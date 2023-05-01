namespace EasyCashApp.Entity.Concrete
{
    public class CustomerAccountProcess
    {
        public int Id { get; set; }//CustomerAccountProcessId
        public string ProcessType { get; set; }
        public decimal Amount { get; set; }
        public DateTime ProcessDate { get; set; } = DateTime.UtcNow;
    }
}
