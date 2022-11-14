using DataAccessLayer.Abstract;
using DataAccessLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class genericrepo<T> : genrepinterfacedal<T> where T : class
    {
        public void delete(T t)
        {
            using var contex = new HospitalProject();
            contex.Remove(t);
            contex.SaveChanges();
        }

        public T getbyId(int id)
        {
            using var contex = new HospitalProject();
            return contex.Set<T>().Find(id);
        }

        public List<T> getList()
        {
            using var contex = new HospitalProject();
            return contex.Set<T>().ToList();
        }

        public void insert(T t)
        {
            using var contex = new HospitalProject();
            contex.Add(t);
            contex.SaveChanges();
        }

        public void update(T t)
        {
            using var contex = new HospitalProject();
            contex.Update(t);
            contex.SaveChanges();
        }
    }
}
