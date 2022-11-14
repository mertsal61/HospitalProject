using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class reportmanager : genericservice<Reports>
    {
        genericservice<Reports> _genericservice;

        public reportmanager(genericservice<Reports> genericservice)
        {
            _genericservice = genericservice;
        }

        public void Tadd(Reports t)
        {
            _genericservice.Tadd(t);
        }

        public void Tdel(Reports t)
        {
            
            _genericservice.Tdel(t);
        }

        public Reports Tgetbyid(int id)
        {
            return _genericservice.Tgetbyid(id);
        }

        public List<Reports> Tgetlist()
        {
            return _genericservice.Tgetlist();
        }

        public void Tupdate(Reports t)
        {
            _genericservice.Tupdate(t);
        }
    }
}
