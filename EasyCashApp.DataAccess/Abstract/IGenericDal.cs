using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashApp.DataAccess.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T entity); //T t
        void Delete(T entity); //T t
        void Update(T entity); //T t
        T GetById(int id);
        List<T> GetList(); 
    }
}
