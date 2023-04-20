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

        public BudgetMainForm()
        {
            InitializeComponent();
            LoadExpenseList();
        }
        private void LoadExpenseList()
        {
            //This will load expense list into the ExpenseModel list
            expense = SQLiteDataAccess.LoadExpense();
            WireUpExpenseList();
        }
        private void WireUpExpenseList()
        {
            //This will set the expense display values to the data source values
            var bindingList = new BindingList<ExpenseModel>(expense);
            var source = new BindingSource(bindingList, null);
            expensedatagridview.DataSource = source;
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

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check if click is on specific column 
            if (e.ColumnIndex == expensedatagridview.Columns["DataGridDeleteButton"].Index)
            {
                var RowID = expensedatagridview.Rows[e.RowIndex].Cells[1].Value.ToString();
                string deleteString = "DELETE FROM Expense WHERE ID = " + RowID;

                SQLiteDataAccess.DeleteExpense(deleteString);
                LoadExpenseList();
            }
        }
    }
}