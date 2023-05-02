namespace Budget_App_Main
{
    public class PaycheckModel
    {
        public int ID { get; set; }
        public string Source { get; set; }
        public decimal AmountBeforeTax { get; set; }
        public decimal AmountAfterTax { get; set; }
        public string Frequency { get; set; }
        public decimal FederalWitholding { get; set; }
        public decimal StateWitholding { get; set; }
        public decimal OtherWitholding { get; set; }
        public decimal ExtraWitholding { get; set; }
    }
}
