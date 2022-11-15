using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class reportmanager : reportinterfaceservice
    {
        reportinterfacedal _reportinterfacedal;

        public reportmanager(reportinterfacedal reportinterfacedal)
        {
            _reportinterfacedal = reportinterfacedal;
        }

        public void TDeletel(Reports t)
        {
            _reportinterfacedal.delete(t);
        }

        public Reports Tgetbyid(int id)
        {
            return _reportinterfacedal.getbyId(id);
        }

        public List<Reports> TGetlist()
        {
            return _reportinterfacedal.getList();
        }

        public void TInsert(Reports t)
        {
            _reportinterfacedal.insert(t);
        }

        public void TUpdate(Reports t)
        {
            _reportinterfacedal.update(t);
        }
    }
}
