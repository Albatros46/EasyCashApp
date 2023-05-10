using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashApp.Business.Abstract
{
    public interface IGenericService<T> where T:class
    {//DataAccess katmanindan ayri oldugunu gostermek icin basina T ekledim.
        void TInsert(T entity); //T t
        void TDelete(T entity); //T t
        void Update(T entity); //T t
        T TGetById(int id);
        List<T> TGetList();
    }
}
