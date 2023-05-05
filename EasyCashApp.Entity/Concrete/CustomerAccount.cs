namespace EasyCashApp.Entity.Concrete
{
    public class CustomerAccount
    {
        public int Id { get; set; }//CustomerAccoungID
        public string CustomerAccountNumber { get; set; }
        public string CustomerCurrency { get; set; }
        public decimal CustomerBalance { get; set; }
        public string BankBrach { get; set; }//Banka subesi
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; } //One To Many 

    }
}
