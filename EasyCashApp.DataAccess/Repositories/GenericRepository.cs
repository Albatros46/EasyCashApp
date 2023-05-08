using EasyCashApp.DataAccess.Abstract;
using EasyCashApp.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashApp.DataAccess.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {//Garbace collector(tanımlanan nesneyi dispose eder.) denilen toplayıcının görevi olan otomatik imha etme görevini devralmak isteriz.
     //Tanımladığımız nesne örneğini dispose etmeyi garantilemek isteriz.
     //Başka bir deyişle ram'den atmak isteriz. Çünkü garbace collector denilen yapı kafasına ne zaman eserse o zaman nesneleri imha eder
    
        // public readonly Context _context; // yukaridaki aciklamadan dolay bu yöntem yerine using var metodiu tercih edilir

        //public GenericRepository(Context context)
        //{
        //    _context = context;
        //}

        public void Delete(T entity)
        {
            //_context.Remove(entity);
            //_context.SaveChanges();
            using var context = new Context();
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

        public T GetById(int id)
        {
            using var context = new Context();
            return  context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            using var context = new Context();
            return context.Set<T>().ToList();
        }

        public void Insert(T entity)
        {
            using var context = new Context();
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            using var context = new Context();
            context.Set<T>().Update(entity);
            context.SaveChanges();
        }
    }
}
