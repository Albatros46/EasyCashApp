using EasyCashApp.DataAccess.Abstract;
using EasyCashApp.DataAccess.Repositories;
using EasyCashApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashApp.DataAccess.EntityFramework
{
    public class efCustomerAccountProcessDal:GenericRepository<CustomerAccountProcess>,ICustomerAccountProcessDal
    {
    }
}
