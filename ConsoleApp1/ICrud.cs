using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface ICrud<T>
    {
        List<T> List();
        void Add(T t);
        void Update(T t);
        void Delete(int id);

    }
}
