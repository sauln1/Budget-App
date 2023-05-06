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
            calculateValuesBudgetPage();
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
            string amountParameter;
            int frequencyinweeksParameter;
            string splitParameter;
            string accountParameter;
            string autoParameter;
            int dayofmonthParameter;
            string monthlybillamountParameter;
            if (addnameinput.Text.Contains(@"'"))
            {
                nameParameter = addnameinput.Text.Replace(@"'", @"''");
            }
            else
            {
                nameParameter = addnameinput.Text;
            }
            amountParameter = Convert.ToString(Math.Round(addamountinput.Value,2));
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
                monthlybillamountParameter = Convert.ToString(Math.Round(Convert.ToDecimal(addamountinput.Value) * 4,2));
            }
            else if (addfrequencyinput.Value == 2)
            {
                monthlybillamountParameter = Convert.ToString(Math.Round(Convert.ToDecimal(addamountinput.Value) * 2,2));
            }
            else if (addfrequencyinput.Value == 3)
            {
                monthlybillamountParameter = Convert.ToString(Math.Round(Convert.ToDecimal(Convert.ToDouble(addamountinput.Value) * 1.5),2));
            }
            else if (addfrequencyinput.Value == 4)
            {
                monthlybillamountParameter = Convert.ToString(Math.Round(addamountinput.Value,2));
            }
            else
            {
                monthlybillamountParameter = Convert.ToString(Math.Round(Convert.ToDecimal(Convert.ToDecimal(addamountinput.Value) / Convert.ToInt32(addfrequencyinput.Value))*4,2));
            };

            if (splitParameter == "true")
            {
                SQLiteDataAccess.SaveExpense(
                    nameParameter,
                    amountParameter,
                    frequencyinweeksParameter,
                    splitParameter,
                    accountParameter,
                    autoParameter,
                    dayofmonthParameter,
                    Convert.ToString(Math.Round(Convert.ToDecimal(monthlybillamountParameter) / 2, 2))
                );
            }
            else
            {
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
            }

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
            string amountbeforetaxParameter;
            string amountaftertaxParameter;
            string frequencyParameter;
            string federalwitholdingParameter;
            string statewitholdingParameter;
            string otherwitholdingParameter;
            string extrawitholdingParameter;
            string totalmonthlyParameter;

            if (paychecksourceinput.Text.Contains(@"'"))
            {
                sourceParameter = paychecksourceinput.Text.Replace(@"'", @"''");
            }
            else
            {
                sourceParameter = paychecksourceinput.Text;
            }
            amountbeforetaxParameter = Convert.ToString(Math.Round(paycheckamoutbtinput.Value,2));
            amountaftertaxParameter = Convert.ToString(Math.Round(paycheckamountatinput.Value,2));
            frequencyParameter = paycheckfrequencyinput.Text;
            federalwitholdingParameter = Convert.ToString(Math.Round(totalfedwithinput.Value,2));
            statewitholdingParameter = Convert.ToString(Math.Round(totalstatewithinput.Value,2));
            otherwitholdingParameter = Convert.ToString(Math.Round(totalmedwithinput.Value,2));
            extrawitholdingParameter = Convert.ToString(Math.Round(extrawithinput.Value, 2));
            if(paycheckfrequencyinput.Text == "Weekly")
            {
                totalmonthlyParameter = Convert.ToString(paycheckamountatinput.Value * 4);
            }
            else if (paycheckfrequencyinput.Text == "Every 2 Weeks")
            {
                totalmonthlyParameter = Convert.ToString(paycheckamountatinput.Value * 2);
            }
            else
            {
                totalmonthlyParameter = Convert.ToString(paycheckamountatinput.Value);
            }

            SQLiteDataAccess.SavePaycheck(
                sourceParameter,
                amountbeforetaxParameter,
                amountaftertaxParameter,
                frequencyParameter,
                federalwitholdingParameter,
                statewitholdingParameter,
                otherwitholdingParameter,
                extrawitholdingParameter,
                totalmonthlyParameter
            );

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
            //GrossAnnualIncome
            decimal grossannualincomeParameter = 0;
            for(int i = 0; i < paycheckdatagridview.Rows.Count; i++)
            {
                if(Convert.ToString(paycheckdatagridview.Rows[i].Cells[5].Value) == "Weekly")
                {
                    grossannualincomeParameter += (Convert.ToDecimal(paycheckdatagridview.Rows[i].Cells[3].Value) * 52);
                }
                else if(Convert.ToString(paycheckdatagridview.Rows[i].Cells[5].Value) == "Every 2 Weeks")
                {
                    grossannualincomeParameter += (Convert.ToDecimal(paycheckdatagridview.Rows[i].Cells[3].Value) * 26);
                }
                else
                {
                    grossannualincomeParameter += (Convert.ToDecimal(paycheckdatagridview.Rows[i].Cells[3].Value) * 12);
                }
            }
            grossannualincometext.Text = Convert.ToString(Math.Round(grossannualincomeParameter,2));

            //GrossMonthlyIncome
            decimal grossmonthlyincometextParamenter = 0;
            for (int i = 0; i < paycheckdatagridview.Rows.Count; i++)
            {
                if (Convert.ToString(paycheckdatagridview.Rows[i].Cells[5].Value) == "Weekly")
                {
                    grossmonthlyincometextParamenter += (Convert.ToDecimal(paycheckdatagridview.Rows[i].Cells[3].Value) * 4);
                }
                else if (Convert.ToString(paycheckdatagridview.Rows[i].Cells[5].Value) == "Every 2 Weeks")
                {
                    grossmonthlyincometextParamenter += (Convert.ToDecimal(paycheckdatagridview.Rows[i].Cells[3].Value) * 2);
                }
                else
                {
                    grossmonthlyincometextParamenter += (Convert.ToDecimal(paycheckdatagridview.Rows[i].Cells[3].Value));
                }
            }
            grossmonthlyincometexttext.Text = Convert.ToString(Math.Round(grossmonthlyincometextParamenter,2));

            //NetAnnualIncome
            decimal netannualincomeParameter = 0;
            for (int i = 0; i < paycheckdatagridview.Rows.Count; i++)
            {
                if (Convert.ToString(paycheckdatagridview.Rows[i].Cells[5].Value) == "Weekly")
                {
                    netannualincomeParameter += (Convert.ToDecimal(paycheckdatagridview.Rows[i].Cells[4].Value) * 52);
                }
                else if (Convert.ToString(paycheckdatagridview.Rows[i].Cells[5].Value) == "Every 2 Weeks")
                {
                    netannualincomeParameter += (Convert.ToDecimal(paycheckdatagridview.Rows[i].Cells[4].Value) * 26);
                }
                else
                {
                    netannualincomeParameter += (Convert.ToDecimal(paycheckdatagridview.Rows[i].Cells[4].Value) * 12);
                }
            }
            netannualincometext.Text = Convert.ToString(Math.Round(netannualincomeParameter,2));

            //NetMonthlyIncome
            decimal netmonthlyincometextParamenter = 0;
            for (int i = 0; i < paycheckdatagridview.Rows.Count; i++)
            {
                if (Convert.ToString(paycheckdatagridview.Rows[i].Cells[5].Value) == "Weekly")
                {
                    netmonthlyincometextParamenter += (Convert.ToDecimal(paycheckdatagridview.Rows[i].Cells[4].Value) * 4);
                }
                else if (Convert.ToString(paycheckdatagridview.Rows[i].Cells[5].Value) == "Every 2 Weeks")
                {
                    netmonthlyincometextParamenter += (Convert.ToDecimal(paycheckdatagridview.Rows[i].Cells[4].Value) * 2);
                }
                else
                {
                    netmonthlyincometextParamenter += (Convert.ToDecimal(paycheckdatagridview.Rows[i].Cells[4].Value));
                }
            }
            netmonthlyincometext.Text = Convert.ToString(Math.Round(netmonthlyincometextParamenter,2));

            // TotalAnnualExpenses
            decimal totalannualexpenseParameter = 0;
            for (int i = 0; i < expensedatagridview.Rows.Count; i++)
            {
                totalannualexpenseParameter += (Convert.ToDecimal(expensedatagridview.Rows[i].Cells[9].Value)*12);
            }
            totalannualexpensestext.Text = Convert.ToString(Math.Round(totalannualexpenseParameter,2));

            // TotalMonthlyExpeses
            decimal totalmonthlyexpenseParameter = 0;
            for (int i = 0; i < expensedatagridview.Rows.Count; i++)
            {
                totalmonthlyexpenseParameter += (Convert.ToDecimal(expensedatagridview.Rows[i].Cells[9].Value));
            }
            totalmonthlyexpensestext.Text = Convert.ToString(Math.Round(totalmonthlyexpenseParameter,2));

            // FluidAnnualIncome
            decimal fluidannualincomeParameter = (netannualincomeParameter - (totalmonthlyexpenseParameter*12));
            fluidannualincometext.Text = Convert.ToString(Math.Round(fluidannualincomeParameter,2));

            // FluidPaycheckIncome
            decimal PaycheckIncome = 0;
            decimal ExpensePerPaycheck = 0;
            decimal PaycheckFluidIncome = 0;
            for (int i = 0; i < paycheckdatagridview.Rows.Count; i++)
            {
                if (Convert.ToString(paycheckdatagridview.Rows[i].Cells[5].Value) == "Weekly")
                {
                    for (int j = 0; j < expensedatagridview.Rows.Count; j++)
                    {
                        ExpensePerPaycheck += (Convert.ToDecimal(expensedatagridview.Rows[j].Cells[9].Value)) / 4;
                    }
                    PaycheckIncome += (Convert.ToDecimal(paycheckdatagridview.Rows[i].Cells[4].Value));
                    PaycheckFluidIncome += PaycheckIncome - ExpensePerPaycheck;
                }
                else if (Convert.ToString(paycheckdatagridview.Rows[i].Cells[5].Value) == "Every 2 Weeks")
                {
                    for (int j = 0; j < expensedatagridview.Rows.Count; j++)
                    {
                        ExpensePerPaycheck += (Convert.ToDecimal(expensedatagridview.Rows[j].Cells[9].Value)) / 2;
                    }
                    PaycheckIncome += (Convert.ToDecimal(paycheckdatagridview.Rows[i].Cells[4].Value));
                    PaycheckFluidIncome += PaycheckIncome - ExpensePerPaycheck;
                }
                else
                {
                    for (int j = 0; j < expensedatagridview.Rows.Count; j++)
                    {
                        ExpensePerPaycheck += (Convert.ToDecimal(expensedatagridview.Rows[j].Cells[9].Value));
                    }
                    PaycheckIncome += (Convert.ToDecimal(paycheckdatagridview.Rows[i].Cells[4].Value));
                    PaycheckFluidIncome += PaycheckIncome - ExpensePerPaycheck;
                }
                fluidpaycheckincometext.Text = Convert.ToString(Math.Round(PaycheckFluidIncome,2));
            }
            //TotalOwedToMe
            decimal TotalOwedToMeParameter = 0;
            for (int i = 0; i < expensedatagridview.Rows.Count; i++)
            {
                if(Convert.ToBoolean(expensedatagridview.Rows[i].Cells[5].Value) == true)
                {
                    TotalOwedToMeParameter += Convert.ToDecimal(expensedatagridview.Rows[i].Cells[9].Value) / 2;
                }
                monthlytotalowedtometext.Text = Convert.ToString(Math.Round(TotalOwedToMeParameter,2));
            }
        }
    }
}