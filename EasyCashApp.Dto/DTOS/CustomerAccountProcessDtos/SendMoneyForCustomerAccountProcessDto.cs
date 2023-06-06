using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashApp.Dto.DTOS.CustomerAccountProcessDtos
{
    public class SendMoneyForCustomerAccountProcessDto
    {
        public string ProcessType { get; set; }
        public decimal Amount { get; set; }
        public DateTime ProcessDate { get; set; } // DateTime.UtcNow;

        public int SenderId { get; set; }//Gonderen hesap Id
        public string receiverAccountNumber { get; set; }//Gonderen hesap Id

        public int ReceiverId { get; set; }//Alan hesap Id
    }
}
