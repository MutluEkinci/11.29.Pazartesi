using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DbBase<T> : ApplicationBase, ICrud<T>,IReport
    {
        public void Add(T t)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> List()
        {
            throw new NotImplementedException();
        }

        public void Update(T t)
        {
            throw new NotImplementedException();
        }

        public void WriteToJson()
        {
            throw new NotImplementedException();
        }

        public void WriteToXml()
        {
            throw new NotImplementedException();
        }
    }
}
