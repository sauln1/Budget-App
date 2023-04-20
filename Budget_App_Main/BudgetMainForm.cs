using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        }
        private void WireUpPaycheckList()
        {
            //This will set the expense display values to the data source values
            var paycheckbindingList = new BindingList<PaycheckModel>(paycheck);
            var source = new BindingSource(paycheckbindingList, null);
            paycheckdatagridview.DataSource = source;
        }
        private void AddExpenseButton_Click(object sender, EventArgs e)
        {
            //This will add the contents of the datagrid line to the database

            ExpenseModel p = new ExpenseModel();

            p.Name = addnameinput.Text;
            p.Amount = Decimal.Parse(addamountinput.Text);
            p.FrequencyInWeeks = Int16.Parse(addfrequencyinput.Text);
            if (addsplityes.Checked)
            {
                p.IsSplit = true;
            }
            else
            {
                p.IsSplit = false;
            }
            p.Account = addaccount.Text;
            if (addautoyes.Checked)
            {
                p.IsAutoDebit = true;
            }
            else
            {
                p.IsAutoDebit = false;
            }
            p.Date = adddateinput.Text.ToString();
            p.Link = addlinkinput.Text;

            string insertString = "INSERT INTO Expense(Name,Amount,FrequencyInWeeks,IsSplit,Account,IsAutoDebit,Date,Link) VALUES (" +
                "'" + p.Name + "'," +
                p.Amount + "," +
                p.FrequencyInWeeks + "," +
                "'" + p.IsSplit + "'," +
                "'" + p.Account + "'," +
                "'" + p.IsAutoDebit + "'," +
                "'" + p.Date + "'," +
                "'" + p.Link + "')";
            SQLiteDataAccess.SaveExpense(insertString);

            expense.Add(p);
            WireUpExpenseList();
            calculateValuesBudgetPage();

            MessageBox.Show("Expense Added");

            addnameinput.Text = "";
            addamountinput.Text = "";
            addfrequencyinput.Text = "";
            addsplityes.Checked = true;
            addsplitno.Checked = false;
            addaccountinput.Text = "";
            addautoyes.Checked = true;
            addautono.Checked = false;
            adddateinput.Text = "";
            addlinkinput.Text = "";
        }
        private void addpaycheckbutton_Click(object sender, EventArgs e)
        {
            PaycheckModel p = new PaycheckModel();

            p.Source = paychecksourceinput.Text;
            p.Amount_Before_Tax = Decimal.Parse(paycheckamoutbtinput.Text);
            p.Amount_After_Tax = Decimal.Parse(paycheckamountatinput.Text);
            p.Frequency = paycheckfrequencyinput.Text;
            p.Federal_Witholding = Decimal.Parse(totalfedwithinput.Text);
            p.State_Witholding = Decimal.Parse(totalstatewithinput.Text);
            p.Med_SS_401K_Witholding = Decimal.Parse(totalmedwithinput.Text);
            p.Extra_Witholding = Decimal.Parse(extrawithinput.Text);

            string insertString = "INSERT INTO Paycheck(Source,Amount_Before_Tax,Amount_After_Tax,Frequency,Federal_Witholding,State_Witholding,Med_SS_401K_Witholding,Extra_Witholding) VALUES (" +
            "'" + p.Source + "'," +
            p.Amount_Before_Tax + "," +
            p.Amount_After_Tax + "," +
            "'" + p.Frequency + "'," +
            p.Federal_Witholding + "," +
            p.State_Witholding + "," +
            p.Med_SS_401K_Witholding + "," +
            p.Extra_Witholding + ")";
            SQLiteDataAccess.SavePaycheck(insertString);

            paycheck.Add(p);
            WireUpPaycheckList();
            calculateValuesBudgetPage();

            MessageBox.Show("Paycheck Added");

            paychecksourceinput.Text = "";
            paycheckamoutbtinput.Text = "";
            paycheckamountatinput.Text = "";
            paycheckfrequencyinput.Text = "";
            totalfedwithinput.Text = "";
            totalstatewithinput.Text = "";
            totalmedwithinput.Text = "";
            extrawithinput.Text = "";
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
                string deleteString = "DELETE FROM Expense WHERE ID = " + RowID;

                SQLiteDataAccess.DeleteExpense(deleteString);
                LoadExpenseList();
                calculateValuesBudgetPage();

                MessageBox.Show("Expense Deleted");
            }
        }
        private void paycheckdatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check if click is on specific column 
            if (e.ColumnIndex == paycheckdatagridview.Columns["PaycheckDataGridDeleteButton"].Index)
            {
                var RowID = paycheckdatagridview.Rows[e.RowIndex].Cells[1].Value.ToString();
                string deleteString = "DELETE FROM Paycheck WHERE ID = " + RowID;

                SQLiteDataAccess.DeletePaycheck(deleteString);
                LoadPaycheckList();
                calculateValuesBudgetPage();

                MessageBox.Show("Paycheck Deleted");
            }
        }
        private void calculateValuesBudgetPage()
        {
            //This function acts as a 'Load' for the main page and is called after any changes are made to paychecks or expenses and also on app load.
            //All values are calculated as 'monthly' originally.
            decimal total_expense_amount = 0;
            decimal total_expense_split = 0;
            decimal total_paycheck_before = 0;
            decimal total_paycheck_after = 0;
            decimal paycheck_freq = 1;

            //Calculate all expense amounts and if they are split and their frequency into one sum 
            for(int i = 0; i < expensedatagridview.Rows.Count; i++)
            {
                var isSplit = expensedatagridview.Rows[i].Cells[5].Value;
                if (isSplit.ToString() == "True")
                {
                    total_expense_split = 2;
                }
                else
                {
                    total_expense_split = 1;
                }
                //(Each Expense / Frequency in Weeks)/1 or 2 If the cost is Split
                total_expense_amount += ((Convert.ToDecimal(expensedatagridview.Rows[i].Cells[3].Value) / 
                    Convert.ToInt32(expensedatagridview.Rows[i].Cells[4].Value)) / total_expense_split);
            }
            //Sum all paycheck amounts before tax compared to frequency values
            for(int i = 0; i < paycheckdatagridview.Rows.Count; i++)
            {
                if (Convert.ToString(paycheckdatagridview.Rows[i].Cells[5].Value) == "Weekly")
                {
                    paycheck_freq = 4;
                }
                else if (Convert.ToString(paycheckdatagridview.Rows[i].Cells[5].Value) == "Every 2 Weeks")
                {
                    paycheck_freq = 2;
                }
                else if (Convert.ToString(paycheckdatagridview.Rows[i].Cells[5].Value) == "Monthly")
                {
                    paycheck_freq = 1;
                }

                total_paycheck_before += (Convert.ToDecimal(paycheckdatagridview.Rows[i].Cells[3].Value) *
                    paycheck_freq);
            }

            //Sum all paycheck amounts before tax compared to frequency values
            for (int i = 0; i < paycheckdatagridview.Rows.Count; i++)
            {
                if (Convert.ToString(paycheckdatagridview.Rows[i].Cells[5].Value) == "Weekly")
                {
                    paycheck_freq = 4;
                }
                else if (Convert.ToString(paycheckdatagridview.Rows[i].Cells[5].Value) == "Every 2 Weeks")
                {
                    paycheck_freq = 2;
                }
                else if (Convert.ToString(paycheckdatagridview.Rows[i].Cells[5].Value) == "Monthly")
                {
                    paycheck_freq = 1;
                }

                total_paycheck_after += (Convert.ToDecimal(paycheckdatagridview.Rows[i].Cells[4].Value) *
                    paycheck_freq);
            }

            //Display values
            grossannualincometext.Text = Convert.ToString(total_paycheck_before * 12);
            grosspaycheckincometext.Text = Convert.ToString(total_paycheck_before / paycheck_freq);
            netannualincometext.Text = Convert.ToString(total_paycheck_after * 12);
            netpaycheckincometext.Text = Convert.ToString(total_paycheck_after / paycheck_freq);
            fluidannualincometext.Text = Convert.ToString((total_paycheck_after * 12) - (total_expense_amount * 12));
            fluidpaycheckincometext.Text = Convert.ToString((total_paycheck_after / paycheck_freq)- (total_expense_amount / paycheck_freq));
            totalannualexpensestext.Text = Convert.ToString(total_expense_amount * 12);
            totalpaycheckexpensestext.Text = Convert.ToString(total_expense_amount / paycheck_freq);
        }
    }
}