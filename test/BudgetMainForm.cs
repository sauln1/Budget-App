using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Windows.Forms;
using test;

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
            p.Date = adddate.Text.ToString();
            p.Link = addlink.Text;

            SQLiteDataAccess.SaveExpense(p);

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
            adddate.Text = "";
            addlinkinput.Text = "";
        }
    }
}
