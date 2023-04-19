using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_App_Main
{
    public class ExpenseModel
    {
        public int ExpenseID { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public int FrequencyInWeeks { get; set; }
        public bool IsSplit { get; set; }
        public string Account { get; set; }
        public bool IsAutoDebit { get; set; }
        public string Date { get; set; }
        public string Link { get; set; }
    }
}
