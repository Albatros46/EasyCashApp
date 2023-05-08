using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashApp.DataAccess.Abstract
{
    public interface ICustomerAccountProcess:IGenericDal<ICustomerAccountProcess>
    {//Eger CustomerAccountProcess a özel islemler olursa sorgu vs gibi islemlerde buraya yazacagiz
     //aksi alde ekleme silme güncelleme ve listeleme isleminde IGenericDal kullanilacak.
    }
}
