using EasyCashApp.Business.Abstract;
using EasyCashApp.DataAccess.Concrete;
using EasyCashApp.Dto.DTOS.CustomerAccountProcessDtos;
using EasyCashApp.Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EasyCashApp.Web.Controllers
{
    public class SendMoneyController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ICustomerAccountProcessService _customerAccountProcessService;

        public SendMoneyController(UserManager<AppUser> userManager, ICustomerAccountProcessService customerAccountProcessService)
        {
            _userManager = userManager;
            _customerAccountProcessService = customerAccountProcessService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(SendMoneyForCustomerAccountProcessDto sendMoneyForCustomerAccountProcessDto)
        {
            var context = new Context();
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var receiverAccountNumberID = context.CustomerAccounts.Where(
               x => x.CustomerAccountNumber == sendMoneyForCustomerAccountProcessDto.receiverAccountNumber).Select(y => y.Id).FirstOrDefault();

            sendMoneyForCustomerAccountProcessDto.SenderId = user.Id;
            sendMoneyForCustomerAccountProcessDto.ProcessDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            sendMoneyForCustomerAccountProcessDto.ProcessType = "Havale";
            sendMoneyForCustomerAccountProcessDto.ReceiverId= receiverAccountNumberID;

           // _customerAccountProcessService.TInsert();

            return RedirectToAction("Index","Home");
        }
    }
}
