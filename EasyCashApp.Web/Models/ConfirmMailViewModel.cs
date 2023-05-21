namespace EasyCashApp.Web.Models
{
    public class ConfirmMailViewModel
    {
        public string  Mail { get; set; }//kod gonderilen maili karsilamak icin kullancagiz 
        public int ConfirmCode { get; set; }
    }
}
