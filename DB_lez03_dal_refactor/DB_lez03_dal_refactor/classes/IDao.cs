using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez03_dal_refactor.classes
{
    internal interface IDao<T>
    {
        List<T> FindAll();
        T? FindById(int id);
        bool Insert(T obj);
        bool Update(T obj);
        bool Delete(int id);
    }
}
