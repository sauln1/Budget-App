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

        private void expensedatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check if click is on specific column 
            if (e.ColumnIndex == expensedatagridview.Columns["ExpenseDataGridDeleteButton"].Index)
            {
                var RowID = expensedatagridview.Rows[e.RowIndex].Cells[1].Value.ToString();
                string deleteString = "DELETE FROM Expense WHERE ID = " + RowID;

                SQLiteDataAccess.DeleteExpense(deleteString);
                LoadExpenseList();

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

                MessageBox.Show("Paycheck Deleted");
            }
        }
    }
}