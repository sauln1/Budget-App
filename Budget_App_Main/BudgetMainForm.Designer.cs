
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
            this.TabBudget = new System.Windows.Forms.TabPage();
            this.totalpaycheckexpensestext = new System.Windows.Forms.Label();
            this.totalannualexpensestext = new System.Windows.Forms.Label();
            this.fluidpaycheckincometext = new System.Windows.Forms.Label();
            this.fluidannualincometext = new System.Windows.Forms.Label();
            this.netpaycheckincometext = new System.Windows.Forms.Label();
            this.netannualincometext = new System.Windows.Forms.Label();
            this.grosspaycheckincometext = new System.Windows.Forms.Label();
            this.grossannualincometext = new System.Windows.Forms.Label();
            this.totalpaycheckexpenseslabel = new System.Windows.Forms.Label();
            this.totalannualexpenseslabel = new System.Windows.Forms.Label();
            this.fluidpaycheckincomelabel = new System.Windows.Forms.Label();
            this.fluidannualincomelabel = new System.Windows.Forms.Label();
            this.netpaycheckincomelabel = new System.Windows.Forms.Label();
            this.netannualincomelabel = new System.Windows.Forms.Label();
            this.grosspaycheckincomelabel = new System.Windows.Forms.Label();
            this.grossannualincomelabel = new System.Windows.Forms.Label();
            this.TabPaycheck = new System.Windows.Forms.TabPage();
            this.extrawithinput = new System.Windows.Forms.NumericUpDown();
            this.totalmedwithinput = new System.Windows.Forms.NumericUpDown();
            this.totalstatewithinput = new System.Windows.Forms.NumericUpDown();
            this.totalfedwithinput = new System.Windows.Forms.NumericUpDown();
            this.paycheckamountatinput = new System.Windows.Forms.NumericUpDown();
            this.paycheckamoutbtinput = new System.Windows.Forms.NumericUpDown();
            this.paycheckfrequencyinput = new System.Windows.Forms.ComboBox();
            this.addpaycheckbutton = new System.Windows.Forms.Button();
            this.paychecksourceinput = new System.Windows.Forms.TextBox();
            this.extrawitholding = new System.Windows.Forms.Label();
            this.totalotherwitholding = new System.Windows.Forms.Label();
            this.totalstatewitholding = new System.Windows.Forms.Label();
            this.totalfederalwitholding = new System.Windows.Forms.Label();
            this.paychecklabel = new System.Windows.Forms.Label();
            this.paycheckdatagridview = new System.Windows.Forms.DataGridView();
            this.PaycheckDataGridDeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.paycheckfrequency = new System.Windows.Forms.Label();
            this.paycheckamountaftertax = new System.Windows.Forms.Label();
            this.paycheckamountbeforetax = new System.Windows.Forms.Label();
            this.paychecksource = new System.Windows.Forms.Label();
            this.TabExpense = new System.Windows.Forms.TabPage();
            this.adddateinput = new System.Windows.Forms.NumericUpDown();
            this.addfrequencyinput = new System.Windows.Forms.NumericUpDown();
            this.addamountinput = new System.Windows.Forms.NumericUpDown();
            this.addautono = new System.Windows.Forms.CheckBox();
            this.addautoyes = new System.Windows.Forms.CheckBox();
            this.addsplitno = new System.Windows.Forms.CheckBox();
            this.addsplityes = new System.Windows.Forms.CheckBox();
            this.addexpensebutton = new System.Windows.Forms.Button();
            this.addaccountinput = new System.Windows.Forms.TextBox();
            this.addnameinput = new System.Windows.Forms.TextBox();
            this.adddate = new System.Windows.Forms.Label();
            this.addautodebit = new System.Windows.Forms.Label();
            this.addaccount = new System.Windows.Forms.Label();
            this.addsplit = new System.Windows.Forms.Label();
            this.addfrequencyinweeks = new System.Windows.Forms.Label();
            this.addamount = new System.Windows.Forms.Label();
            this.addname = new System.Windows.Forms.Label();
            this.expenselistlabel = new System.Windows.Forms.Label();
            this.expensedatagridview = new System.Windows.Forms.DataGridView();
            this.ExpenseDataGridDeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl1.SuspendLayout();
            this.TabBudget.SuspendLayout();
            this.TabPaycheck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extrawithinput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalmedwithinput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalstatewithinput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalfedwithinput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paycheckamountatinput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paycheckamoutbtinput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paycheckdatagridview)).BeginInit();
            this.TabExpense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adddateinput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addfrequencyinput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addamountinput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensedatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabBudget);
            this.tabControl1.Controls.Add(this.TabPaycheck);
            this.tabControl1.Controls.Add(this.TabExpense);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(555, 616);
            this.tabControl1.TabIndex = 1;
            // 
            // TabBudget
            // 
            this.TabBudget.Controls.Add(this.totalpaycheckexpensestext);
            this.TabBudget.Controls.Add(this.totalannualexpensestext);
            this.TabBudget.Controls.Add(this.fluidpaycheckincometext);
            this.TabBudget.Controls.Add(this.fluidannualincometext);
            this.TabBudget.Controls.Add(this.netpaycheckincometext);
            this.TabBudget.Controls.Add(this.netannualincometext);
            this.TabBudget.Controls.Add(this.grosspaycheckincometext);
            this.TabBudget.Controls.Add(this.grossannualincometext);
            this.TabBudget.Controls.Add(this.totalpaycheckexpenseslabel);
            this.TabBudget.Controls.Add(this.totalannualexpenseslabel);
            this.TabBudget.Controls.Add(this.fluidpaycheckincomelabel);
            this.TabBudget.Controls.Add(this.fluidannualincomelabel);
            this.TabBudget.Controls.Add(this.netpaycheckincomelabel);
            this.TabBudget.Controls.Add(this.netannualincomelabel);
            this.TabBudget.Controls.Add(this.grosspaycheckincomelabel);
            this.TabBudget.Controls.Add(this.grossannualincomelabel);
            this.TabBudget.Location = new System.Drawing.Point(4, 22);
            this.TabBudget.Name = "TabBudget";
            this.TabBudget.Size = new System.Drawing.Size(547, 590);
            this.TabBudget.TabIndex = 0;
            this.TabBudget.Text = "Budget View";
            this.TabBudget.UseVisualStyleBackColor = true;
            // 
            // totalpaycheckexpensestext
            // 
            this.totalpaycheckexpensestext.AutoEllipsis = true;
            this.totalpaycheckexpensestext.AutoSize = true;
            this.totalpaycheckexpensestext.BackColor = System.Drawing.Color.LightGreen;
            this.totalpaycheckexpensestext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalpaycheckexpensestext.Location = new System.Drawing.Point(253, 550);
            this.totalpaycheckexpensestext.MinimumSize = new System.Drawing.Size(130, 2);
            this.totalpaycheckexpensestext.Name = "totalpaycheckexpensestext";
            this.totalpaycheckexpensestext.Size = new System.Drawing.Size(130, 15);
            this.totalpaycheckexpensestext.TabIndex = 15;
            this.totalpaycheckexpensestext.Text = "0";
            // 
            // totalannualexpensestext
            // 
            this.totalannualexpensestext.AutoEllipsis = true;
            this.totalannualexpensestext.AutoSize = true;
            this.totalannualexpensestext.BackColor = System.Drawing.Color.LightGreen;
            this.totalannualexpensestext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalannualexpensestext.Location = new System.Drawing.Point(253, 475);
            this.totalannualexpensestext.MinimumSize = new System.Drawing.Size(130, 2);
            this.totalannualexpensestext.Name = "totalannualexpensestext";
            this.totalannualexpensestext.Size = new System.Drawing.Size(130, 15);
            this.totalannualexpensestext.TabIndex = 14;
            this.totalannualexpensestext.Text = "0";
            // 
            // fluidpaycheckincometext
            // 
            this.fluidpaycheckincometext.AutoEllipsis = true;
            this.fluidpaycheckincometext.AutoSize = true;
            this.fluidpaycheckincometext.BackColor = System.Drawing.Color.Bisque;
            this.fluidpaycheckincometext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fluidpaycheckincometext.Location = new System.Drawing.Point(253, 400);
            this.fluidpaycheckincometext.MinimumSize = new System.Drawing.Size(130, 2);
            this.fluidpaycheckincometext.Name = "fluidpaycheckincometext";
            this.fluidpaycheckincometext.Size = new System.Drawing.Size(130, 15);
            this.fluidpaycheckincometext.TabIndex = 13;
            this.fluidpaycheckincometext.Text = "0";
            // 
            // fluidannualincometext
            // 
            this.fluidannualincometext.AutoEllipsis = true;
            this.fluidannualincometext.AutoSize = true;
            this.fluidannualincometext.BackColor = System.Drawing.Color.Bisque;
            this.fluidannualincometext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fluidannualincometext.Location = new System.Drawing.Point(253, 325);
            this.fluidannualincometext.MinimumSize = new System.Drawing.Size(130, 2);
            this.fluidannualincometext.Name = "fluidannualincometext";
            this.fluidannualincometext.Size = new System.Drawing.Size(130, 15);
            this.fluidannualincometext.TabIndex = 12;
            this.fluidannualincometext.Text = "0";
            // 
            // netpaycheckincometext
            // 
            this.netpaycheckincometext.AutoEllipsis = true;
            this.netpaycheckincometext.AutoSize = true;
            this.netpaycheckincometext.BackColor = System.Drawing.Color.Bisque;
            this.netpaycheckincometext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.netpaycheckincometext.Location = new System.Drawing.Point(253, 250);
            this.netpaycheckincometext.MinimumSize = new System.Drawing.Size(130, 2);
            this.netpaycheckincometext.Name = "netpaycheckincometext";
            this.netpaycheckincometext.Size = new System.Drawing.Size(130, 15);
            this.netpaycheckincometext.TabIndex = 11;
            this.netpaycheckincometext.Text = "0";
            // 
            // netannualincometext
            // 
            this.netannualincometext.AutoEllipsis = true;
            this.netannualincometext.AutoSize = true;
            this.netannualincometext.BackColor = System.Drawing.Color.Bisque;
            this.netannualincometext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.netannualincometext.Location = new System.Drawing.Point(253, 175);
            this.netannualincometext.MinimumSize = new System.Drawing.Size(130, 2);
            this.netannualincometext.Name = "netannualincometext";
            this.netannualincometext.Size = new System.Drawing.Size(130, 15);
            this.netannualincometext.TabIndex = 10;
            this.netannualincometext.Text = "0";
            // 
            // grosspaycheckincometext
            // 
            this.grosspaycheckincometext.AutoEllipsis = true;
            this.grosspaycheckincometext.AutoSize = true;
            this.grosspaycheckincometext.BackColor = System.Drawing.Color.Bisque;
            this.grosspaycheckincometext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grosspaycheckincometext.Location = new System.Drawing.Point(253, 100);
            this.grosspaycheckincometext.MinimumSize = new System.Drawing.Size(130, 2);
            this.grosspaycheckincometext.Name = "grosspaycheckincometext";
            this.grosspaycheckincometext.Size = new System.Drawing.Size(130, 15);
            this.grosspaycheckincometext.TabIndex = 9;
            this.grosspaycheckincometext.Text = "0";
            // 
            // grossannualincometext
            // 
            this.grossannualincometext.AutoEllipsis = true;
            this.grossannualincometext.AutoSize = true;
            this.grossannualincometext.BackColor = System.Drawing.Color.Bisque;
            this.grossannualincometext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grossannualincometext.Location = new System.Drawing.Point(253, 25);
            this.grossannualincometext.MinimumSize = new System.Drawing.Size(130, 2);
            this.grossannualincometext.Name = "grossannualincometext";
            this.grossannualincometext.Size = new System.Drawing.Size(130, 15);
            this.grossannualincometext.TabIndex = 8;
            this.grossannualincometext.Text = "0";
            // 
            // totalpaycheckexpenseslabel
            // 
            this.totalpaycheckexpenseslabel.AutoSize = true;
            this.totalpaycheckexpenseslabel.Location = new System.Drawing.Point(30, 550);
            this.totalpaycheckexpenseslabel.Name = "totalpaycheckexpenseslabel";
            this.totalpaycheckexpenseslabel.Size = new System.Drawing.Size(120, 13);
            this.totalpaycheckexpenseslabel.TabIndex = 7;
            this.totalpaycheckexpenseslabel.Text = "Total Monthly Expenses";
            // 
            // totalannualexpenseslabel
            // 
            this.totalannualexpenseslabel.AutoSize = true;
            this.totalannualexpenseslabel.Location = new System.Drawing.Point(30, 475);
            this.totalannualexpenseslabel.Name = "totalannualexpenseslabel";
            this.totalannualexpenseslabel.Size = new System.Drawing.Size(116, 13);
            this.totalannualexpenseslabel.TabIndex = 6;
            this.totalannualexpenseslabel.Text = "Total Annual Expenses";
            // 
            // fluidpaycheckincomelabel
            // 
            this.fluidpaycheckincomelabel.AutoSize = true;
            this.fluidpaycheckincomelabel.Location = new System.Drawing.Point(30, 400);
            this.fluidpaycheckincomelabel.Name = "fluidpaycheckincomelabel";
            this.fluidpaycheckincomelabel.Size = new System.Drawing.Size(118, 13);
            this.fluidpaycheckincomelabel.TabIndex = 5;
            this.fluidpaycheckincomelabel.Text = "Fluid Paycheck Income";
            // 
            // fluidannualincomelabel
            // 
            this.fluidannualincomelabel.AutoSize = true;
            this.fluidannualincomelabel.Location = new System.Drawing.Point(30, 325);
            this.fluidannualincomelabel.Name = "fluidannualincomelabel";
            this.fluidannualincomelabel.Size = new System.Drawing.Size(103, 13);
            this.fluidannualincomelabel.TabIndex = 4;
            this.fluidannualincomelabel.Text = "Fluid Annual Income";
            // 
            // netpaycheckincomelabel
            // 
            this.netpaycheckincomelabel.AutoSize = true;
            this.netpaycheckincomelabel.Location = new System.Drawing.Point(30, 250);
            this.netpaycheckincomelabel.Name = "netpaycheckincomelabel";
            this.netpaycheckincomelabel.Size = new System.Drawing.Size(113, 13);
            this.netpaycheckincomelabel.TabIndex = 3;
            this.netpaycheckincomelabel.Text = "Net Paycheck Income";
            // 
            // netannualincomelabel
            // 
            this.netannualincomelabel.AutoSize = true;
            this.netannualincomelabel.Location = new System.Drawing.Point(30, 175);
            this.netannualincomelabel.Name = "netannualincomelabel";
            this.netannualincomelabel.Size = new System.Drawing.Size(98, 13);
            this.netannualincomelabel.TabIndex = 2;
            this.netannualincomelabel.Text = "Net Annual Income";
            // 
            // grosspaycheckincomelabel
            // 
            this.grosspaycheckincomelabel.AutoSize = true;
            this.grosspaycheckincomelabel.Location = new System.Drawing.Point(30, 100);
            this.grosspaycheckincomelabel.Name = "grosspaycheckincomelabel";
            this.grosspaycheckincomelabel.Size = new System.Drawing.Size(123, 13);
            this.grosspaycheckincomelabel.TabIndex = 1;
            this.grosspaycheckincomelabel.Text = "Gross Paycheck Income";
            // 
            // grossannualincomelabel
            // 
            this.grossannualincomelabel.AutoSize = true;
            this.grossannualincomelabel.Location = new System.Drawing.Point(30, 25);
            this.grossannualincomelabel.Name = "grossannualincomelabel";
            this.grossannualincomelabel.Size = new System.Drawing.Size(108, 13);
            this.grossannualincomelabel.TabIndex = 0;
            this.grossannualincomelabel.Text = "Gross Annual Income";
            // 
            // TabPaycheck
            // 
            this.TabPaycheck.Controls.Add(this.extrawithinput);
            this.TabPaycheck.Controls.Add(this.totalmedwithinput);
            this.TabPaycheck.Controls.Add(this.totalstatewithinput);
            this.TabPaycheck.Controls.Add(this.totalfedwithinput);
            this.TabPaycheck.Controls.Add(this.paycheckamountatinput);
            this.TabPaycheck.Controls.Add(this.paycheckamoutbtinput);
            this.TabPaycheck.Controls.Add(this.paycheckfrequencyinput);
            this.TabPaycheck.Controls.Add(this.addpaycheckbutton);
            this.TabPaycheck.Controls.Add(this.paychecksourceinput);
            this.TabPaycheck.Controls.Add(this.extrawitholding);
            this.TabPaycheck.Controls.Add(this.totalotherwitholding);
            this.TabPaycheck.Controls.Add(this.totalstatewitholding);
            this.TabPaycheck.Controls.Add(this.totalfederalwitholding);
            this.TabPaycheck.Controls.Add(this.paychecklabel);
            this.TabPaycheck.Controls.Add(this.paycheckdatagridview);
            this.TabPaycheck.Controls.Add(this.paycheckfrequency);
            this.TabPaycheck.Controls.Add(this.paycheckamountaftertax);
            this.TabPaycheck.Controls.Add(this.paycheckamountbeforetax);
            this.TabPaycheck.Controls.Add(this.paychecksource);
            this.TabPaycheck.Location = new System.Drawing.Point(4, 22);
            this.TabPaycheck.Name = "TabPaycheck";
            this.TabPaycheck.Size = new System.Drawing.Size(547, 590);
            this.TabPaycheck.TabIndex = 2;
            this.TabPaycheck.Text = "Add Paycheck";
            this.TabPaycheck.UseVisualStyleBackColor = true;
            // 
            // extrawithinput
            // 
            this.extrawithinput.DecimalPlaces = 2;
            this.extrawithinput.Location = new System.Drawing.Point(359, 267);
            this.extrawithinput.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.extrawithinput.Name = "extrawithinput";
            this.extrawithinput.Size = new System.Drawing.Size(146, 20);
            this.extrawithinput.TabIndex = 8;
            // 
            // totalmedwithinput
            // 
            this.totalmedwithinput.DecimalPlaces = 2;
            this.totalmedwithinput.Location = new System.Drawing.Point(359, 192);
            this.totalmedwithinput.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.totalmedwithinput.Name = "totalmedwithinput";
            this.totalmedwithinput.Size = new System.Drawing.Size(146, 20);
            this.totalmedwithinput.TabIndex = 7;
            // 
            // totalstatewithinput
            // 
            this.totalstatewithinput.DecimalPlaces = 2;
            this.totalstatewithinput.Location = new System.Drawing.Point(359, 117);
            this.totalstatewithinput.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.totalstatewithinput.Name = "totalstatewithinput";
            this.totalstatewithinput.Size = new System.Drawing.Size(146, 20);
            this.totalstatewithinput.TabIndex = 6;
            // 
            // totalfedwithinput
            // 
            this.totalfedwithinput.DecimalPlaces = 2;
            this.totalfedwithinput.Location = new System.Drawing.Point(359, 42);
            this.totalfedwithinput.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.totalfedwithinput.Name = "totalfedwithinput";
            this.totalfedwithinput.Size = new System.Drawing.Size(146, 20);
            this.totalfedwithinput.TabIndex = 5;
            // 
            // paycheckamountatinput
            // 
            this.paycheckamountatinput.DecimalPlaces = 2;
            this.paycheckamountatinput.Location = new System.Drawing.Point(33, 192);
            this.paycheckamountatinput.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.paycheckamountatinput.Name = "paycheckamountatinput";
            this.paycheckamountatinput.Size = new System.Drawing.Size(146, 20);
            this.paycheckamountatinput.TabIndex = 3;
            // 
            // paycheckamoutbtinput
            // 
            this.paycheckamoutbtinput.DecimalPlaces = 2;
            this.paycheckamoutbtinput.Location = new System.Drawing.Point(33, 117);
            this.paycheckamoutbtinput.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.paycheckamoutbtinput.Name = "paycheckamoutbtinput";
            this.paycheckamoutbtinput.Size = new System.Drawing.Size(146, 20);
            this.paycheckamoutbtinput.TabIndex = 2;
            // 
            // paycheckfrequencyinput
            // 
            this.paycheckfrequencyinput.DisplayMember = "Text";
            this.paycheckfrequencyinput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paycheckfrequencyinput.FormattingEnabled = true;
            this.paycheckfrequencyinput.Location = new System.Drawing.Point(33, 266);
            this.paycheckfrequencyinput.Name = "paycheckfrequencyinput";
            this.paycheckfrequencyinput.Size = new System.Drawing.Size(146, 21);
            this.paycheckfrequencyinput.TabIndex = 4;
            this.paycheckfrequencyinput.ValueMember = "ID";
            // 
            // addpaycheckbutton
            // 
            this.addpaycheckbutton.Location = new System.Drawing.Point(396, 299);
            this.addpaycheckbutton.Name = "addpaycheckbutton";
            this.addpaycheckbutton.Size = new System.Drawing.Size(103, 23);
            this.addpaycheckbutton.TabIndex = 9;
            this.addpaycheckbutton.Text = "Save Paycheck";
            this.addpaycheckbutton.UseVisualStyleBackColor = true;
            this.addpaycheckbutton.Click += new System.EventHandler(this.addpaycheckbutton_Click);
            // 
            // paychecksourceinput
            // 
            this.paychecksourceinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paychecksourceinput.Location = new System.Drawing.Point(33, 41);
            this.paychecksourceinput.Name = "paychecksourceinput";
            this.paychecksourceinput.Size = new System.Drawing.Size(146, 20);
            this.paychecksourceinput.TabIndex = 1;
            // 
            // extrawitholding
            // 
            this.extrawitholding.AutoSize = true;
            this.extrawitholding.Location = new System.Drawing.Point(421, 250);
            this.extrawitholding.Name = "extrawitholding";
            this.extrawitholding.Size = new System.Drawing.Size(84, 13);
            this.extrawitholding.TabIndex = 16;
            this.extrawitholding.Text = "Extra Witholding";
            // 
            // totalotherwitholding
            // 
            this.totalotherwitholding.AutoSize = true;
            this.totalotherwitholding.Location = new System.Drawing.Point(330, 175);
            this.totalotherwitholding.Name = "totalotherwitholding";
            this.totalotherwitholding.Size = new System.Drawing.Size(175, 13);
            this.totalotherwitholding.TabIndex = 15;
            this.totalotherwitholding.Text = "Total Medical, SS, 401K Witholding";
            // 
            // totalstatewitholding
            // 
            this.totalstatewitholding.AutoSize = true;
            this.totalstatewitholding.Location = new System.Drawing.Point(393, 100);
            this.totalstatewitholding.Name = "totalstatewitholding";
            this.totalstatewitholding.Size = new System.Drawing.Size(112, 13);
            this.totalstatewitholding.TabIndex = 14;
            this.totalstatewitholding.Text = "Total State Witholding";
            // 
            // totalfederalwitholding
            // 
            this.totalfederalwitholding.AutoSize = true;
            this.totalfederalwitholding.Location = new System.Drawing.Point(383, 25);
            this.totalfederalwitholding.Name = "totalfederalwitholding";
            this.totalfederalwitholding.Size = new System.Drawing.Size(122, 13);
            this.totalfederalwitholding.TabIndex = 13;
            this.totalfederalwitholding.Text = "Total Federal Witholding";
            // 
            // paychecklabel
            // 
            this.paychecklabel.AutoSize = true;
            this.paychecklabel.Location = new System.Drawing.Point(30, 309);
            this.paychecklabel.Name = "paychecklabel";
            this.paychecklabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.paychecklabel.Size = new System.Drawing.Size(55, 13);
            this.paychecklabel.TabIndex = 8;
            this.paychecklabel.Text = "Paycheck";
            // 
            // paycheckdatagridview
            // 
            this.paycheckdatagridview.AllowUserToAddRows = false;
            this.paycheckdatagridview.AllowUserToDeleteRows = false;
            this.paycheckdatagridview.AllowUserToResizeColumns = false;
            this.paycheckdatagridview.AllowUserToResizeRows = false;
            this.paycheckdatagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.paycheckdatagridview.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.paycheckdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paycheckdatagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaycheckDataGridDeleteButton});
            this.paycheckdatagridview.GridColor = System.Drawing.Color.Bisque;
            this.paycheckdatagridview.Location = new System.Drawing.Point(30, 325);
            this.paycheckdatagridview.MultiSelect = false;
            this.paycheckdatagridview.Name = "paycheckdatagridview";
            this.paycheckdatagridview.ReadOnly = true;
            this.paycheckdatagridview.RowHeadersVisible = false;
            this.paycheckdatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.paycheckdatagridview.ShowEditingIcon = false;
            this.paycheckdatagridview.Size = new System.Drawing.Size(475, 250);
            this.paycheckdatagridview.TabIndex = 12;
            this.paycheckdatagridview.Click += new System.EventHandler(this.AddExpenseButton_Click);
            paycheckdatagridview.CellClick += paycheckdatagridview_CellContentClick;

            // 
            // PaycheckDataGridDeleteButton
            // 
            this.PaycheckDataGridDeleteButton.HeaderText = "Delete";
            this.PaycheckDataGridDeleteButton.Name = "PaycheckDataGridDeleteButton";
            this.PaycheckDataGridDeleteButton.ReadOnly = true;
            this.PaycheckDataGridDeleteButton.Text = "Delete";
            this.PaycheckDataGridDeleteButton.UseColumnTextForButtonValue = true;
            // 
            // paycheckfrequency
            // 
            this.paycheckfrequency.AutoSize = true;
            this.paycheckfrequency.Location = new System.Drawing.Point(30, 250);
            this.paycheckfrequency.Name = "paycheckfrequency";
            this.paycheckfrequency.Size = new System.Drawing.Size(108, 13);
            this.paycheckfrequency.TabIndex = 11;
            this.paycheckfrequency.Text = "Paycheck Frequency";
            // 
            // paycheckamountaftertax
            // 
            this.paycheckamountaftertax.AutoSize = true;
            this.paycheckamountaftertax.Location = new System.Drawing.Point(30, 175);
            this.paycheckamountaftertax.Name = "paycheckamountaftertax";
            this.paycheckamountaftertax.Size = new System.Drawing.Size(140, 13);
            this.paycheckamountaftertax.TabIndex = 10;
            this.paycheckamountaftertax.Text = "Paycheck Amount After Tax";
            // 
            // paycheckamountbeforetax
            // 
            this.paycheckamountbeforetax.AutoSize = true;
            this.paycheckamountbeforetax.Location = new System.Drawing.Point(30, 100);
            this.paycheckamountbeforetax.Name = "paycheckamountbeforetax";
            this.paycheckamountbeforetax.Size = new System.Drawing.Size(149, 13);
            this.paycheckamountbeforetax.TabIndex = 9;
            this.paycheckamountbeforetax.Text = "Paycheck Amount Before Tax";
            // 
            // paychecksource
            // 
            this.paychecksource.AutoSize = true;
            this.paychecksource.Location = new System.Drawing.Point(30, 25);
            this.paychecksource.Name = "paychecksource";
            this.paychecksource.Size = new System.Drawing.Size(92, 13);
            this.paychecksource.TabIndex = 8;
            this.paychecksource.Text = "Paycheck Source";
            // 
            // TabExpense
            // 
            this.TabExpense.Controls.Add(this.adddateinput);
            this.TabExpense.Controls.Add(this.addfrequencyinput);
            this.TabExpense.Controls.Add(this.addamountinput);
            this.TabExpense.Controls.Add(this.addautono);
            this.TabExpense.Controls.Add(this.addautoyes);
            this.TabExpense.Controls.Add(this.addsplitno);
            this.TabExpense.Controls.Add(this.addsplityes);
            this.TabExpense.Controls.Add(this.addexpensebutton);
            this.TabExpense.Controls.Add(this.addaccountinput);
            this.TabExpense.Controls.Add(this.addnameinput);
            this.TabExpense.Controls.Add(this.adddate);
            this.TabExpense.Controls.Add(this.addautodebit);
            this.TabExpense.Controls.Add(this.addaccount);
            this.TabExpense.Controls.Add(this.addsplit);
            this.TabExpense.Controls.Add(this.addfrequencyinweeks);
            this.TabExpense.Controls.Add(this.addamount);
            this.TabExpense.Controls.Add(this.addname);
            this.TabExpense.Location = new System.Drawing.Point(4, 22);
            this.TabExpense.Name = "TabExpense";
            this.TabExpense.Size = new System.Drawing.Size(547, 590);
            this.TabExpense.TabIndex = 1;
            this.TabExpense.Text = "Add Expense";
            this.TabExpense.UseVisualStyleBackColor = true;
            // 
            // adddateinput
            // 
            this.adddateinput.Location = new System.Drawing.Point(202, 475);
            this.adddateinput.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.adddateinput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.adddateinput.Name = "adddateinput";
            this.adddateinput.Size = new System.Drawing.Size(192, 20);
            this.adddateinput.TabIndex = 14;
            this.adddateinput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addfrequencyinput
            // 
            this.addfrequencyinput.Location = new System.Drawing.Point(202, 168);
            this.addfrequencyinput.Maximum = new decimal(new int[] {
            52,
            0,
            0,
            0});
            this.addfrequencyinput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.addfrequencyinput.Name = "addfrequencyinput";
            this.addfrequencyinput.Size = new System.Drawing.Size(192, 20);
            this.addfrequencyinput.TabIndex = 13;
            this.addfrequencyinput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addamountinput
            // 
            this.addamountinput.DecimalPlaces = 2;
            this.addamountinput.Location = new System.Drawing.Point(202, 93);
            this.addamountinput.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.addamountinput.Name = "addamountinput";
            this.addamountinput.Size = new System.Drawing.Size(192, 20);
            this.addamountinput.TabIndex = 2;
            // 
            // addautono
            // 
            this.addautono.AutoSize = true;
            this.addautono.Location = new System.Drawing.Point(298, 400);
            this.addautono.Name = "addautono";
            this.addautono.Size = new System.Drawing.Size(96, 17);
            this.addautono.TabIndex = 8;
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
            this.addautoyes.TabIndex = 7;
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
            this.addsplitno.TabIndex = 5;
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
            this.addsplityes.TabIndex = 4;
            this.addsplityes.Text = "Split";
            this.addsplityes.UseVisualStyleBackColor = true;
            this.addsplityes.CheckedChanged += new System.EventHandler(this.addsplityes_CheckedChanged);
            // 
            // addexpensebutton
            // 
            this.addexpensebutton.Location = new System.Drawing.Point(213, 553);
            this.addexpensebutton.Name = "addexpensebutton";
            this.addexpensebutton.Size = new System.Drawing.Size(112, 23);
            this.addexpensebutton.TabIndex = 11;
            this.addexpensebutton.Text = "Save Expense";
            this.addexpensebutton.UseVisualStyleBackColor = true;
            this.addexpensebutton.Click += new System.EventHandler(this.AddExpenseButton_Click);
            // 
            // addaccountinput
            // 
            this.addaccountinput.Location = new System.Drawing.Point(202, 325);
            this.addaccountinput.Name = "addaccountinput";
            this.addaccountinput.Size = new System.Drawing.Size(192, 20);
            this.addaccountinput.TabIndex = 6;
            // 
            // addnameinput
            // 
            this.addnameinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addnameinput.Location = new System.Drawing.Point(202, 20);
            this.addnameinput.Name = "addnameinput";
            this.addnameinput.Size = new System.Drawing.Size(192, 20);
            this.addnameinput.TabIndex = 1;
            // 
            // adddate
            // 
            this.adddate.AutoSize = true;
            this.adddate.Location = new System.Drawing.Point(30, 475);
            this.adddate.Name = "adddate";
            this.adddate.Size = new System.Drawing.Size(133, 13);
            this.adddate.TabIndex = 7;
            this.adddate.Text = "Expense Day of the Month";
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
            this.expensedatagridview.AllowUserToResizeColumns = false;
            this.expensedatagridview.AllowUserToResizeRows = false;
            this.expensedatagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.expensedatagridview.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.expensedatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expensedatagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExpenseDataGridDeleteButton});
            this.expensedatagridview.GridColor = System.Drawing.Color.LightGreen;
            this.expensedatagridview.Location = new System.Drawing.Point(557, 38);
            this.expensedatagridview.MultiSelect = false;
            this.expensedatagridview.Name = "expensedatagridview";
            this.expensedatagridview.ReadOnly = true;
            this.expensedatagridview.RowHeadersVisible = false;
            this.expensedatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.expensedatagridview.ShowEditingIcon = false;
            this.expensedatagridview.Size = new System.Drawing.Size(1040, 571);
            this.expensedatagridview.TabIndex = 7;
            expensedatagridview.CellClick += expensedatagridview_CellContentClick;
            
            // 
            // ExpenseDataGridDeleteButton
            // 
            this.ExpenseDataGridDeleteButton.HeaderText = "Delete";
            this.ExpenseDataGridDeleteButton.Name = "ExpenseDataGridDeleteButton";
            this.ExpenseDataGridDeleteButton.ReadOnly = true;
            this.ExpenseDataGridDeleteButton.Text = "Delete";
            this.ExpenseDataGridDeleteButton.UseColumnTextForButtonValue = true;
            // 
            // BudgetMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1605, 621);
            this.Controls.Add(this.expensedatagridview);
            this.Controls.Add(this.expenselistlabel);
            this.Controls.Add(this.tabControl1);
            this.Name = "BudgetMainForm";
            this.Text = "Budget";
            this.tabControl1.ResumeLayout(false);
            this.TabBudget.ResumeLayout(false);
            this.TabBudget.PerformLayout();
            this.TabPaycheck.ResumeLayout(false);
            this.TabPaycheck.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extrawithinput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalmedwithinput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalstatewithinput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalfedwithinput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paycheckamountatinput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paycheckamoutbtinput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paycheckdatagridview)).EndInit();
            this.TabExpense.ResumeLayout(false);
            this.TabExpense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adddateinput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addfrequencyinput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addamountinput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensedatagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabBudget;
        private System.Windows.Forms.TabPage TabExpense;
        private System.Windows.Forms.Label expenselistlabel;
        private System.Windows.Forms.Label addautodebit;
        private System.Windows.Forms.Label addaccount;
        private System.Windows.Forms.Label addsplit;
        private System.Windows.Forms.Label addfrequencyinweeks;
        private System.Windows.Forms.Label addamount;
        private System.Windows.Forms.Label addname;
        private System.Windows.Forms.Label adddate;
        private System.Windows.Forms.TextBox addaccountinput;
        private System.Windows.Forms.TextBox addnameinput;
        private System.Windows.Forms.Button addexpensebutton;
        private System.Windows.Forms.DataGridView expensedatagridview;
        private System.Windows.Forms.CheckBox addsplitno;
        private System.Windows.Forms.CheckBox addsplityes;
        private System.Windows.Forms.CheckBox addautono;
        private System.Windows.Forms.CheckBox addautoyes;
        private Label netannualincomelabel;
        private Label grosspaycheckincomelabel;
        private Label grossannualincomelabel;
        private DataGridViewButtonColumn ExpenseDataGridDeleteButton;
        private Label totalpaycheckexpenseslabel;
        private Label totalannualexpenseslabel;
        private Label fluidpaycheckincomelabel;
        private Label fluidannualincomelabel;
        private Label netpaycheckincomelabel;
        private Label grossannualincometext;
        private Label grosspaycheckincometext;
        private Label totalpaycheckexpensestext;
        private Label totalannualexpensestext;
        private Label fluidpaycheckincometext;
        private Label fluidannualincometext;
        private Label netpaycheckincometext;
        private Label netannualincometext;
        private TabPage TabPaycheck;
        private Label paycheckfrequency;
        private Label paycheckamountaftertax;
        private Label paycheckamountbeforetax;
        private Label paychecksource;
        private DataGridView paycheckdatagridview;
        private Label paychecklabel;
        private Label extrawitholding;
        private Label totalotherwitholding;
        private Label totalstatewitholding;
        private Label totalfederalwitholding;
        private TextBox paychecksourceinput;
        private Button addpaycheckbutton;
        private DataGridViewButtonColumn PaycheckDataGridDeleteButton;
        public ComboBox paycheckfrequencyinput;
        private NumericUpDown paycheckamountatinput;
        private NumericUpDown paycheckamoutbtinput;
        private NumericUpDown totalfedwithinput;
        private NumericUpDown totalstatewithinput;
        private NumericUpDown totalmedwithinput;
        private NumericUpDown extrawithinput;
        private NumericUpDown addamountinput;
        private NumericUpDown addfrequencyinput;
        private NumericUpDown adddateinput;
    }
}

