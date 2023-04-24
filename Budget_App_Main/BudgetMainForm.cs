using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;

//https://www.youtube.com/watch?v=ayp3tHEkRc0
namespace Budget_App_Main
{
    public partial class BudgetMainForm : Form
    {
        List<ExpenseModel> expense = new List<ExpenseModel>();
        List<PaycheckModel> paycheck = new List<PaycheckModel>();
        public BudgetMainForm()
        {
            InitializeComponent();
            LoadExpenseList();
            LoadPaycheckList();
            InitComboItem();
        }
        private void LoadExpenseList()
        {
            //This will load expense list into the ExpenseModel list
            expense.Clear();
            expense = SQLiteDataAccess.LoadExpense();
            WireUpExpenseList();
        }
        private void LoadPaycheckList()
        {
            paycheck.Clear();
            paycheck = SQLiteDataAccess.LoadPaycheck();
            WireUpPaycheckList();
        }
        private void WireUpExpenseList()
        {
            //This will set the expense display values to the data source values
            var expensebindingList = new BindingList<ExpenseModel>(expense);
            var source = new BindingSource(expensebindingList, null);
            expensedatagridview.DataSource = source;

            addnameinput.Text = "";
            addamountinput.Text = "0.00";
            addfrequencyinput.Text = "";
            addsplityes.Checked = true;
            addsplitno.Checked = false;
            addaccountinput.Text = "";
            addautoyes.Checked = true;
            addautono.Checked = false;
            adddateinput.Text = "";
        }
        private void WireUpPaycheckList()
        {
            //This will set the expense display values to the data source values
            var paycheckbindingList = new BindingList<PaycheckModel>(paycheck);
            var source = new BindingSource(paycheckbindingList, null);
            paycheckdatagridview.DataSource = source;

            paychecksourceinput.Text = "";
            paycheckamoutbtinput.Text = "0.00";
            paycheckamountatinput.Text = "0.00";
            paycheckfrequencyinput.Text = "";
            totalfedwithinput.Text = "0.00";
            totalstatewithinput.Text = "0.00";
            totalmedwithinput.Text = "0.00";
            extrawithinput.Text = "0.00";
        }
        private void AddExpenseButton_Click(object sender, EventArgs e)
        {
            //This will add the contents of the datagrid line to the database

            ExpenseModel p = new ExpenseModel();

            p.Name = addnameinput.Text;
            p.Amount = addamountinput.Value;
            p.FrequencyInWeeks = Int16.Parse(addfrequencyinput.Text);
            if (addsplityes.Checked)
            {
                p.IsSplit = true;
            }
            else
            {
                p.IsSplit = false;
            }
            p.Account = addaccountinput.Text;
            if (addautoyes.Checked)
            {
                p.IsAutoDebit = true;
            }
            else
            {
                p.IsAutoDebit = false;
            }
            p.Date = adddateinput.Text.ToString();

            bool issplitParameter = false;
            if (addsplityes.Checked)
            {
                issplitParameter = true;
            }
            else
            {
                issplitParameter = false;
            }
            bool isautoParameter = false;
            if (addautoyes.Checked)
            {
                isautoParameter = true;
            }
            else
            {
                isautoParameter = false;
            }
            string monthlybillamountParameter = "";
            if (p.FrequencyInWeeks == 1)
            {
                monthlybillamountParameter = Convert.ToString(Convert.ToDecimal(addamountinput) * 4);
            }
            else if (p.FrequencyInWeeks == 2)
            {
                monthlybillamountParameter = Convert.ToString(Convert.ToDecimal(addamountinput) * 2);
            }
            else if (p.FrequencyInWeeks == 3)
            {
                monthlybillamountParameter = Convert.ToString(Convert.ToDouble(addamountinput) * 1.5);
            }
            else if (p.FrequencyInWeeks == 4)
            {
                monthlybillamountParameter = Convert.ToString(addamountinput);
            }
            else
            {
                monthlybillamountParameter = Convert.ToString(Convert.ToDouble(addamountinput) / Convert.ToInt32(addfrequencyinput));
            };
            
            SQLiteDataAccess.SaveExpense(addnameinput.Text,addamountinput.Value,Convert.ToInt32(addfrequencyinput.Value), issplitParameter,addaccountinput.Text, isautoParameter, adddateinput.Text, Convert.ToDecimal(monthlybillamountParameter));

            expense.Add(p);
            LoadExpenseList();
            calculateValuesBudgetPage();

            addnameinput.Text = "";
            addamountinput.Text = "0.00";
            addfrequencyinput.Text = "";
            addsplityes.Checked = true;
            addsplitno.Checked = false;
            addaccountinput.Text = "";
            addautoyes.Checked = true;
            addautono.Checked = false;
            adddateinput.Text = "";
        }
        private void addpaycheckbutton_Click(object sender, EventArgs e)
        {
            PaycheckModel p = new PaycheckModel();

            p.Source = paychecksourceinput.Text;
            p.Amount_Before_Tax = paycheckamoutbtinput.Value;
            p.Amount_After_Tax = paycheckamountatinput.Value;
            p.Frequency = paycheckfrequencyinput.Text;
            p.Federal_Witholding = totalfedwithinput.Value;
            p.State_Witholding = totalstatewithinput.Value;
            p.Med_SS_401K_Witholding = totalmedwithinput.Value;
            p.Extra_Witholding = extrawithinput.Value;

            decimal TotalMonthly = 0;
            if(p.Frequency == "Weekly")
            {
                TotalMonthly += paycheckamountatinput.Value * 4;
            }
            else if(p.Frequency == "Every 2 Weeks")
            {
                TotalMonthly += paycheckamountatinput.Value * 2;
            }
            else if (p.Frequency == "Monthly")
            {
                TotalMonthly += paycheckamountatinput.Value;
            };

            SQLiteDataAccess.SavePaycheck(paychecksourceinput.Text, paycheckamoutbtinput.Value, paycheckamountatinput.Value, paycheckfrequencyinput.Text, totalfedwithinput.Value, totalstatewithinput.Value, totalmedwithinput.Value, extrawithinput.Value, TotalMonthly);

            paycheck.Add(p);
            LoadPaycheckList();
            calculateValuesBudgetPage();

            paychecksourceinput.Text = "";
            paycheckamoutbtinput.Text = "0.00";
            paycheckamountatinput.Text = "0.00";
            paycheckfrequencyinput.Text = "";
            totalfedwithinput.Text = "0.00";
            totalstatewithinput.Text = "0.00";
            totalmedwithinput.Text = "0.00";
            extrawithinput.Text = "0.00";
        }
        private void addsplityes_CheckedChanged(object sender, EventArgs e)
        {
            addsplitno.Checked = !addsplityes.Checked;
        }

        private void addsplitno_CheckedChanged(object sender, EventArgs e)
        {
            addsplityes.Checked = !addsplitno.Checked;
        }

        private void addautoyes_CheckedChanged(object sender, EventArgs e)
        {
            addautono.Checked = !addautoyes.Checked;
        }

        private void addautono_CheckedChanged(object sender, EventArgs e)
        {
            addautoyes.Checked = !addautono.Checked;
        }
        public class PaycheckFreqComboItem
        {
            public int ID { get; set; }
            public string Text { get; set; }
        }
        private void InitComboItem()
        {
            List<PaycheckFreqComboItem> comboOptions = new List<PaycheckFreqComboItem>();
            comboOptions.Add(new PaycheckFreqComboItem() { ID = 1, Text = "Weekly" });
            comboOptions.Add(new PaycheckFreqComboItem() { ID = 2, Text = "Every 2 Weeks" });
            comboOptions.Add(new PaycheckFreqComboItem() { ID = 3, Text = "Monthly" });

            paycheckfrequencyinput.DataSource = comboOptions;
            paycheckfrequencyinput.DisplayMember = "Text";
            paycheckfrequencyinput.ValueMember = "ID";
        }
        
        private void expensedatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check if click is on specific column 
            if (e.ColumnIndex == expensedatagridview.Columns["ExpenseDataGridDeleteButton"].Index)
            {
                var RowID = expensedatagridview.Rows[e.RowIndex].Cells[1].Value.ToString();

                SQLiteDataAccess.DeleteExpense(Convert.ToInt32(RowID));
                LoadExpenseList();
                calculateValuesBudgetPage();
            }
        }
        private void paycheckdatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check if click is on specific column 
            if (e.ColumnIndex == paycheckdatagridview.Columns["PaycheckDataGridDeleteButton"].Index)
            {
                var RowID = paycheckdatagridview.Rows[e.RowIndex].Cells[1].Value.ToString();

                SQLiteDataAccess.DeletePaycheck(Convert.ToInt32(RowID));
                LoadPaycheckList();
                calculateValuesBudgetPage();
            }
        }
        private void calculateValuesBudgetPage()
        {
            //This function acts as a 'Load' for the main page and is called after any changes are made to paychecks or expenses and also on app load.
            //All values are calculated as 'monthly' originally.

            //GAI = PaycheckBT * 26
            decimal grossannualincomecalc = 0;
            for (int i = 0; i < paycheckdatagridview.Rows.Count; ++i)
            {
                grossannualincomecalc += Convert.ToDecimal(paycheckdatagridview.Rows[i].Cells[3].Value);
            }
            grossannualincometext.Text = Convert.ToString(grossannualincomecalc * 26);

            //GPI = PaycheckBT
            decimal grosspaycheckincomecalc = 0;
            for (int i = 0; i < paycheckdatagridview.Rows.Count; ++i)
            {
                grosspaycheckincomecalc += Convert.ToDecimal(paycheckdatagridview.Rows[i].Cells[3].Value);
            }
            grosspaycheckincometext.Text = Convert.ToString(grosspaycheckincomecalc);

            //NAI = PaycheckAT * 26
            decimal netannualincomecalc = 0;
            for (int i = 0; i < paycheckdatagridview.Rows.Count; ++i)
            {
                netannualincomecalc += Convert.ToDecimal(paycheckdatagridview.Rows[i].Cells[4].Value);
            }
            netannualincometext.Text = Convert.ToString(netannualincomecalc * 26);

            //NPI = PaycheckAT
            decimal netpaycheckincomecalc = 0;
            for (int i = 0; i < paycheckdatagridview.Rows.Count; ++i)
            {
                netpaycheckincomecalc += Convert.ToDecimal(paycheckdatagridview.Rows[i].Cells[4].Value);
            }
            netpaycheckincometext.Text = Convert.ToString(netpaycheckincomecalc);

            //TAE = Total Monthly Expenses * 26
            decimal totalannualexpenses = 0;
            for (int i = 0; i < expensedatagridview.Rows.Count; ++i)
            {
                totalannualexpenses += Convert.ToDecimal(paycheckdatagridview.Rows[i].Cells[9].Value);
            }
            totalannualexpensestext.Text = Convert.ToString(totalannualexpenses * 12);

            //TPE = Total Monthly Expenses / 2
            decimal totalmonthlyexpenses = 0;
            for (int i = 0; i < expensedatagridview.Rows.Count; ++i)
            {
                totalmonthlyexpenses += Convert.ToDecimal(paycheckdatagridview.Rows[i].Cells[9].Value);
            }
            totalpaycheckexpensestext.Text = Convert.ToString(totalmonthlyexpenses);

            //FAI = (Total Annual Net - Total Annual Expenses)
            fluidannualincometext.Text = Convert.ToString(Convert.ToDecimal(netannualincometext.Text) - Convert.ToDecimal(totalannualexpensestext.Text));

            //FMI = Total Paycheck Net - (Total Monthly Expenses)
        }
    }
}