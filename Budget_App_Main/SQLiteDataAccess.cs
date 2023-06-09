﻿using Budget_App_Main;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace Budget_App_Main
{
    public class SQLiteDataAccess
    {
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
        public static List<ExpenseModel> LoadExpense()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ExpenseModel>("SELECT ID,Name,Amount,FrequencyInWeeks,IsSplit,Account,AutoDebit,DayOfMonth,MonthlyBillAmount FROM Expense", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SaveExpense(string name, string amount, int freq, string split, string account, string isauto, decimal dayofmonth, string monthly)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"INSERT INTO Expense(Name,Amount,FrequencyInWeeks,IsSplit,Account,AutoDebit,DayOfMonth,MonthlyBillAmount) VALUES ('{name}',{amount},{freq},'{split}','{account}','{isauto}',{dayofmonth},{monthly});");            
            }
        }
        public static void DeleteExpense(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"DELETE FROM Expense WHERE ID = {id}");
            }
        }

        public static List<PaycheckModel> LoadPaycheck()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PaycheckModel>("SELECT * FROM Paycheck", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SavePaycheck(string source, string bt, string at, string freq, string fed, string st, string other, string extra, string total)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"INSERT INTO Paycheck (Source, AmountBeforeTax, AmountAfterTax, Frequency, FederalWitholding, StateWitholding, OtherWitholding, ExtraWitholding, TotalMonthly) VALUES ('{source}',{bt},{at},'{freq}',{fed},{st},{other},{extra},{total})");
            }
        }
        public static void DeletePaycheck(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute(Convert.ToString($"DELETE FROM Paycheck WHERE ID = {id}"));
            }
        }
    }
}
