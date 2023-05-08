using EasyCashApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashApp.DataAccess.Abstract
{
    public interface ICustomerAccountDal:IGenericDal<CustomerAccount>
    {//Eger CustomerAccount a özel islemler olursa sorgu vs gibi islemlerde buraya yazacagiz
     //aksi alde ekleme silme güncelleme ve listeleme isleminde IGenericDal kullanilacak.
    }
}
