using Budget_App_Main;
using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

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
        public static void SaveExpense(string insertString)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute(insertString);            
            }
        }
        public static void DeleteExpense(string deleteString)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute(deleteString);
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
        public static void SavePaycheck(string insertString)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute(insertString);
            }
        }
        public static void DeletePaycheck(string deleteString)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute(deleteString);
            }
        }


    }
}
