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
        public static List<ExpenseModel> LoadExpense()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ExpenseModel>("SELECT Name,Amount,FrequencyInWeeks,IsSplit,Account,IsAutoDebit,Date,Link FROM Expense", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SaveExpense(ExpenseModel expense)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT OR REPLACE INTO Expense(Name,Amount,FrequencyInWeeks,IsSplit,Account,IsAutoDebit,Date,Link) VALUES (@Name,@Amount,@FrequencyInWeeks,@IsSplit,@Account,@IsAutoDebit,@Date,@Link)", expense);
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
