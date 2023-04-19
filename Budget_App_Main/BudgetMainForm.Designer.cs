
using System.Windows.Forms;

namespace Budget_App_Main
{
    partial class BudgetMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.addautono = new System.Windows.Forms.CheckBox();
            this.addautoyes = new System.Windows.Forms.CheckBox();
            this.addsplitno = new System.Windows.Forms.CheckBox();
            this.addsplityes = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.adddateinput = new System.Windows.Forms.DateTimePicker();
            this.addfrequencyinput = new System.Windows.Forms.TextBox();
            this.addamountinput = new System.Windows.Forms.TextBox();
            this.addlinkinput = new System.Windows.Forms.TextBox();
            this.addaccountinput = new System.Windows.Forms.TextBox();
            this.addnameinput = new System.Windows.Forms.TextBox();
            this.addlink = new System.Windows.Forms.Label();
            this.adddate = new System.Windows.Forms.Label();
            this.addautodebit = new System.Windows.Forms.Label();
            this.addaccount = new System.Windows.Forms.Label();
            this.addsplit = new System.Windows.Forms.Label();
            this.addfrequencyinweeks = new System.Windows.Forms.Label();
            this.addamount = new System.Windows.Forms.Label();
            this.addname = new System.Windows.Forms.Label();
            this.expenselistlabel = new System.Windows.Forms.Label();
            this.expensedatagridview = new System.Windows.Forms.DataGridView();
            this.dataGridViewDeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cleartablebutton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expensedatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(555, 616);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(547, 590);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Budget View";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.addautono);
            this.tabPage4.Controls.Add(this.addautoyes);
            this.tabPage4.Controls.Add(this.addsplitno);
            this.tabPage4.Controls.Add(this.addsplityes);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.adddateinput);
            this.tabPage4.Controls.Add(this.addfrequencyinput);
            this.tabPage4.Controls.Add(this.addamountinput);
            this.tabPage4.Controls.Add(this.addlinkinput);
            this.tabPage4.Controls.Add(this.addaccountinput);
            this.tabPage4.Controls.Add(this.addnameinput);
            this.tabPage4.Controls.Add(this.addlink);
            this.tabPage4.Controls.Add(this.adddate);
            this.tabPage4.Controls.Add(this.addautodebit);
            this.tabPage4.Controls.Add(this.addaccount);
            this.tabPage4.Controls.Add(this.addsplit);
            this.tabPage4.Controls.Add(this.addfrequencyinweeks);
            this.tabPage4.Controls.Add(this.addamount);
            this.tabPage4.Controls.Add(this.addname);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(547, 590);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Add Expense";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // addautono
            // 
            this.addautono.AutoSize = true;
            this.addautono.Location = new System.Drawing.Point(298, 400);
            this.addautono.Name = "addautono";
            this.addautono.Size = new System.Drawing.Size(96, 17);
            this.addautono.TabIndex = 23;
            this.addautono.Text = "Not Auto Debit";
            this.addautono.UseVisualStyleBackColor = true;
            this.addautono.CheckedChanged += new System.EventHandler(this.addautono_CheckedChanged);
            // 
            // addautoyes
            // 
            this.addautoyes.AutoSize = true;
            this.addautoyes.Location = new System.Drawing.Point(202, 400);
            this.addautoyes.Name = "addautoyes";
            this.addautoyes.Size = new System.Drawing.Size(76, 17);
            this.addautoyes.TabIndex = 22;
            this.addautoyes.Text = "Auto Debit";
            this.addautoyes.UseVisualStyleBackColor = true;
            this.addautoyes.CheckedChanged += new System.EventHandler(this.addautoyes_CheckedChanged);
            // 
            // addsplitno
            // 
            this.addsplitno.AutoSize = true;
            this.addsplitno.Location = new System.Drawing.Point(314, 250);
            this.addsplitno.Name = "addsplitno";
            this.addsplitno.Size = new System.Drawing.Size(66, 17);
            this.addsplitno.TabIndex = 21;
            this.addsplitno.Text = "Not Split";
            this.addsplitno.UseVisualStyleBackColor = true;
            this.addsplitno.CheckedChanged += new System.EventHandler(this.addsplitno_CheckedChanged);
            // 
            // addsplityes
            // 
            this.addsplityes.AutoSize = true;
            this.addsplityes.Location = new System.Drawing.Point(202, 250);
            this.addsplityes.Name = "addsplityes";
            this.addsplityes.Size = new System.Drawing.Size(46, 17);
            this.addsplityes.TabIndex = 20;
            this.addsplityes.Text = "Split";
            this.addsplityes.UseVisualStyleBackColor = true;
            this.addsplityes.CheckedChanged += new System.EventHandler(this.addsplityes_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 541);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Save Expense";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddExpenseButton_Click);
            // 
            // adddateinput
            // 
            this.adddateinput.Location = new System.Drawing.Point(202, 475);
            this.adddateinput.Name = "adddateinput";
            this.adddateinput.Size = new System.Drawing.Size(192, 20);
            this.adddateinput.TabIndex = 18;
            // 
            // addfrequencyinput
            // 
            this.addfrequencyinput.Location = new System.Drawing.Point(202, 175);
            this.addfrequencyinput.Name = "addfrequencyinput";
            this.addfrequencyinput.Size = new System.Drawing.Size(192, 20);
            this.addfrequencyinput.TabIndex = 13;
            // 
            // addamountinput
            // 
            this.addamountinput.Location = new System.Drawing.Point(202, 100);
            this.addamountinput.Name = "addamountinput";
            this.addamountinput.Size = new System.Drawing.Size(192, 20);
            this.addamountinput.TabIndex = 12;
            // 
            // addlinkinput
            // 
            this.addlinkinput.Location = new System.Drawing.Point(202, 543);
            this.addlinkinput.Name = "addlinkinput";
            this.addlinkinput.Size = new System.Drawing.Size(192, 20);
            this.addlinkinput.TabIndex = 11;
            // 
            // addaccountinput
            // 
            this.addaccountinput.Location = new System.Drawing.Point(202, 325);
            this.addaccountinput.Name = "addaccountinput";
            this.addaccountinput.Size = new System.Drawing.Size(192, 20);
            this.addaccountinput.TabIndex = 10;
            // 
            // addnameinput
            // 
            this.addnameinput.Location = new System.Drawing.Point(202, 20);
            this.addnameinput.Name = "addnameinput";
            this.addnameinput.Size = new System.Drawing.Size(192, 20);
            this.addnameinput.TabIndex = 9;
            // 
            // addlink
            // 
            this.addlink.AutoSize = true;
            this.addlink.Location = new System.Drawing.Point(30, 550);
            this.addlink.Name = "addlink";
            this.addlink.Size = new System.Drawing.Size(71, 13);
            this.addlink.TabIndex = 8;
            this.addlink.Text = "Expense Link";
            // 
            // adddate
            // 
            this.adddate.AutoSize = true;
            this.adddate.Location = new System.Drawing.Point(30, 475);
            this.adddate.Name = "adddate";
            this.adddate.Size = new System.Drawing.Size(74, 13);
            this.adddate.TabIndex = 7;
            this.adddate.Text = "Expense Date";
            // 
            // addautodebit
            // 
            this.addautodebit.AutoSize = true;
            this.addautodebit.Location = new System.Drawing.Point(30, 400);
            this.addautodebit.Name = "addautodebit";
            this.addautodebit.Size = new System.Drawing.Size(118, 13);
            this.addautodebit.TabIndex = 6;
            this.addautodebit.Text = "Is Expense Auto Debit?";
            // 
            // addaccount
            // 
            this.addaccount.AutoSize = true;
            this.addaccount.Location = new System.Drawing.Point(30, 325);
            this.addaccount.Name = "addaccount";
            this.addaccount.Size = new System.Drawing.Size(91, 13);
            this.addaccount.TabIndex = 5;
            this.addaccount.Text = "Expense Account";
            // 
            // addsplit
            // 
            this.addsplit.AutoSize = true;
            this.addsplit.Location = new System.Drawing.Point(30, 250);
            this.addsplit.Name = "addsplit";
            this.addsplit.Size = new System.Drawing.Size(88, 13);
            this.addsplit.TabIndex = 4;
            this.addsplit.Text = "Is Expense Split?";
            // 
            // addfrequencyinweeks
            // 
            this.addfrequencyinweeks.AutoSize = true;
            this.addfrequencyinweeks.Location = new System.Drawing.Point(30, 175);
            this.addfrequencyinweeks.Name = "addfrequencyinweeks";
            this.addfrequencyinweeks.Size = new System.Drawing.Size(149, 13);
            this.addfrequencyinweeks.TabIndex = 3;
            this.addfrequencyinweeks.Text = "Expense Frequency in Weeks";
            // 
            // addamount
            // 
            this.addamount.AutoSize = true;
            this.addamount.Location = new System.Drawing.Point(30, 100);
            this.addamount.Name = "addamount";
            this.addamount.Size = new System.Drawing.Size(87, 13);
            this.addamount.TabIndex = 2;
            this.addamount.Text = "Expense Amount";
            // 
            // addname
            // 
            this.addname.AutoSize = true;
            this.addname.Location = new System.Drawing.Point(30, 25);
            this.addname.Name = "addname";
            this.addname.Size = new System.Drawing.Size(79, 13);
            this.addname.TabIndex = 1;
            this.addname.Text = "Expense Name";
            // 
            // expenselistlabel
            // 
            this.expenselistlabel.AutoSize = true;
            this.expenselistlabel.Location = new System.Drawing.Point(561, 22);
            this.expenselistlabel.Name = "expenselistlabel";
            this.expenselistlabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.expenselistlabel.Size = new System.Drawing.Size(67, 13);
            this.expenselistlabel.TabIndex = 2;
            this.expenselistlabel.Text = "Expense List";
            // 
            // expensedatagridview
            // 
            this.expensedatagridview.AllowUserToAddRows = false;
            this.expensedatagridview.AllowUserToDeleteRows = false;
            this.expensedatagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.expensedatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expensedatagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewDeleteButton});
            this.expensedatagridview.Location = new System.Drawing.Point(561, 38);
            this.expensedatagridview.MultiSelect = false;
            this.expensedatagridview.Name = "expensedatagridview";
            this.expensedatagridview.ReadOnly = true;
            this.expensedatagridview.ShowEditingIcon = false;
            this.expensedatagridview.Size = new System.Drawing.Size(1040, 571);
            this.expensedatagridview.TabIndex = 7;
            // 
            // dataGridViewDeleteButton
            // 
            this.dataGridViewDeleteButton.HeaderText = "Delete";
            this.dataGridViewDeleteButton.Name = "dataGridViewDeleteButton";
            this.dataGridViewDeleteButton.ReadOnly = true;
            this.dataGridViewDeleteButton.Text = "Delete";
            this.dataGridViewDeleteButton.UseColumnTextForButtonValue = true;
            this.dataGridViewDeleteButton.Width = 44;
            // 
            // cleartablebutton
            // 
            this.cleartablebutton.Location = new System.Drawing.Point(1437, 13);
            this.cleartablebutton.Name = "cleartablebutton";
            this.cleartablebutton.Size = new System.Drawing.Size(75, 23);
            this.cleartablebutton.TabIndex = 8;
            this.cleartablebutton.Text = "Clear Table";
            this.cleartablebutton.UseVisualStyleBackColor = true;
            this.cleartablebutton.Click += new System.EventHandler(this.cleartablebutton_Click);
            // 
            // BudgetMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1605, 621);
            this.Controls.Add(this.cleartablebutton);
            this.Controls.Add(this.expensedatagridview);
            this.Controls.Add(this.expenselistlabel);
            this.Controls.Add(this.tabControl1);
            this.Name = "BudgetMainForm";
            this.Text = "Budget";
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expensedatagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label expenselistlabel;
        private System.Windows.Forms.Label addautodebit;
        private System.Windows.Forms.Label addaccount;
        private System.Windows.Forms.Label addsplit;
        private System.Windows.Forms.Label addfrequencyinweeks;
        private System.Windows.Forms.Label addamount;
        private System.Windows.Forms.Label addname;
        private System.Windows.Forms.Label adddate;
        private System.Windows.Forms.Label addlink;
        private System.Windows.Forms.TextBox addaccountinput;
        private System.Windows.Forms.TextBox addnameinput;
        private System.Windows.Forms.TextBox addlinkinput;
        private System.Windows.Forms.TextBox addfrequencyinput;
        private System.Windows.Forms.TextBox addamountinput;
        private System.Windows.Forms.DateTimePicker adddateinput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView expensedatagridview;
        private System.Windows.Forms.CheckBox addsplitno;
        private System.Windows.Forms.CheckBox addsplityes;
        private System.Windows.Forms.CheckBox addautono;
        private System.Windows.Forms.CheckBox addautoyes;
        private DataGridViewButtonColumn dataGridViewDeleteButton;
        private Button cleartablebutton;
    }
}

