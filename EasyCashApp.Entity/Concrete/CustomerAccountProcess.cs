namespace EasyCashApp.Entity.Concrete
{
    public class CustomerAccountProcess
    {
        public int Id { get; set; }//CustomerAccountProcessId
        public string ProcessType { get; set; }
        public decimal Amount { get; set; }
        public DateTime ProcessDate { get; set; } // DateTime.UtcNow;

        public int? SenderId { get; set; }//Gonderen hesap Id
        public CustomerAccount SenderCustomer { get; set; }

        public int? ReceiverId { get; set; }//Alan hesap Id
        public CustomerAccount ReceiverCustomer { get; set; }
    }
    /*
     ID-Islem Türü(Gelen Para, Giden Para(havale ve odemeler))-Miktar-Tarih- Alici- Gönderici
     */
}
