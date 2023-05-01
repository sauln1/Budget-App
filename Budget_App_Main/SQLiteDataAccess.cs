using Budget_App_Main;
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
                var output = cnn.Query<ExpenseModel>("SELECT * FROM Expense", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SaveExpense(string name, decimal amount, int freq, bool split, string account, bool isauto, string date, decimal monthly)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                if (name == "")
                {
                    name = "''";
                }
                else if (name.Contains("'"))
                {
                    name.Replace("'", "/'");
                }
                if (account == "")
                {
                    account = "''";
                }
                else if (account.Contains("'"))
                {
                    account.Replace("'", "/'");
                }
                cnn.Execute($"INSERT INTO Expense(Name,Amount,FrequencyInWeeks,IsSplit,Account,IsAutoDebit,DayOfMonth,MonthlyBillAmount) VALUES ('{name}',{amount},{freq},'{split}','{account}','{isauto}',{date},{monthly});");            
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
        public static void SavePaycheck(string source, decimal bt, decimal at, string freq, decimal fed, decimal st, decimal med, decimal extra, decimal total)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"INSERT INTO Paycheck (Source, AmountBeforeTax, AmountAfterTax, Frequency, FederalWitholding, StateWitholding, MedicareSS401KWitholding, ExtraWitholding, TotalMonthly) VALUES ('{source}',{bt},{at},'{freq}',{fed},{st},{med},{extra},{total})");
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
