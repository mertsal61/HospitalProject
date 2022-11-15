using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface genericservice<T>
    {
        void TInsert(T t);
        void TDeletel(T t);
        void TUpdate(T t);
        List<T> TGetlist();
        T Tgetbyid(int id);
    }
}
