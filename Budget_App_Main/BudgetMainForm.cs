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
            //Add to the Database
            string nameParameter;
            decimal amountParameter;
            int frequencyinweeksParameter;
            string splitParameter;
            string accountParameter;
            string autoParameter;
            int dayofmonthParameter;
            decimal monthlybillamountParameter;
            if (addnameinput.Text.Contains(@"'"))
            {
                nameParameter = addnameinput.Text.Replace(@"'", @"''");
            }
            else
            {
                nameParameter = addnameinput.Text;
            }
            amountParameter = Convert.ToDecimal(addamountinput.Value);
            frequencyinweeksParameter = Convert.ToInt32(addfrequencyinput.Value);
            if (addsplityes.Checked)
            {
                splitParameter = "true";
            }
            else
            {
                splitParameter = "false";
            }
            if (addaccountinput.Text.Contains(@"'"))
            {
                accountParameter = addaccountinput.Text.Replace(@"'", @"''");
            }
            else
            {
                accountParameter = addaccountinput.Text;
            }
            if (addautoyes.Checked)
            {
                autoParameter = "true";
            }
            else
            {
                autoParameter = "false";
            }
            dayofmonthParameter = Convert.ToInt32(adddateinput.Value);
            if (addfrequencyinput.Value == 1)
            {
                monthlybillamountParameter = Convert.ToDecimal(addamountinput.Value) * 4;
            }
            else if (addfrequencyinput.Value == 2)
            {
                monthlybillamountParameter = Convert.ToDecimal(addamountinput.Value) * 2;
            }
            else if (addfrequencyinput.Value == 3)
            {
                monthlybillamountParameter = Convert.ToDecimal(Convert.ToDouble(addamountinput.Value) * 1.5);
            }
            else if (addfrequencyinput.Value == 4)
            {
                monthlybillamountParameter = addamountinput.Value;
            }
            else
            {
                monthlybillamountParameter = Convert.ToDecimal(addamountinput.Value) / Convert.ToInt32(addfrequencyinput.Value);
            };
            
            SQLiteDataAccess.SaveExpense(
                nameParameter,
                amountParameter,
                frequencyinweeksParameter,
                splitParameter,
                accountParameter,
                autoParameter,
                dayofmonthParameter,
                monthlybillamountParameter
            );

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
            string sourceParameter;
            decimal amountbeforetaxParameter;
            decimal amountaftertaxParameter;
            string frequencyParameter;
            decimal federalwitholdingParameter;
            decimal statewitholdingParameter;
            decimal otherwitholdingParameter;
            decimal extrawitholdingParameter;
            decimal totalmonthlyParameter;

            if (paychecksourceinput.Text.Contains(@"'"))
            {
                sourceParameter = paychecksourceinput.Text.Replace(@"'", @"''");
            }
            else
            {
                sourceParameter = paychecksourceinput.Text;
            }
            amountbeforetaxParameter = paycheckamoutbtinput.Value;
            amountaftertaxParameter = paycheckamountatinput.Value;
            frequencyParameter = paycheckfrequencyinput.Text;
            federalwitholdingParameter = totalfedwithinput.Value;
            statewitholdingParameter = totalstatewithinput.Value;
            otherwitholdingParameter = totalmedwithinput.Value;
            extrawitholdingParameter = extrawithinput.Value;
            if(paycheckfrequencyinput.Text == "Weekly")
            {
                totalmonthlyParameter = paycheckamountatinput.Value * 4;
            }
            else if (paycheckfrequencyinput.Text == "Every 2 Weeks")
            {
                totalmonthlyParameter = paycheckamountatinput.Value * 2;
            }
            else
            {
                totalmonthlyParameter = paycheckamountatinput.Value;
            }

            SQLiteDataAccess.SavePaycheck(sourceParameter, amountbeforetaxParameter, amountaftertaxParameter, frequencyParameter, federalwitholdingParameter, statewitholdingParameter, otherwitholdingParameter, extrawitholdingParameter, totalmonthlyParameter);

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

        }
    }
}