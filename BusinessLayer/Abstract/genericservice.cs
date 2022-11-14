using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface genericservice<T>
    {
        void Tadd(T t);
        void Tdel(T t);
        void Tupdate(T t);
        List<T> Tgetlist();
        T Tgetbyid(int id);
    }
}
