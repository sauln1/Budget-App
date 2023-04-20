namespace Budget_App_Main
{
    public class PaycheckModel
    {
        public int ID { get; set; }
        public string Source { get; set; }
        public decimal Amount_Before_Tax { get; set; }
        public decimal Amount_After_Tax { get; set; }
        public string Frequency { get; set; }
        public decimal Federal_Witholding { get; set; }
        public decimal State_Witholding { get; set; }
        public decimal Med_SS_401K_Witholding { get; set; }
        public decimal Extra_Witholding { get; set; }
    }
}
