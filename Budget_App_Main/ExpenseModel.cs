namespace Budget_App_Main
{
    public class ExpenseModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public int FrequencyInWeeks { get; set; }
        public bool IsSplit { get; set; }
        public string Account { get; set; }
        public bool AutoDebit { get; set; }
        public int DayOfMonth { get; set; }
        public string MonthlyBillAmount { get; set; }
        public string TotalAfterBills { get; set; }
    }
}
