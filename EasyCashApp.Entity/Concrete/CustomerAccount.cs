namespace EasyCashApp.Entity.Concrete
{
    public class CustomerAccount
    {
        public int Id { get; set; }//CustomerAccoungID
        public string CustomerAccountNumber { get; set; }
        public string CustomerCurrency { get; set; }
        public decimal CustomerBalance { get; set; }
        public string BankBrach { get; set; }//Banka subesi

    }
}
