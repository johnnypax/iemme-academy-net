using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez04_libreria.classes.DAL
{
    internal interface IDao<T>
    {
        List<T> GetAll();
        T? GetById(int id);
        bool Insert(T obj);
        bool Update(T obj);
        bool Delete(int id);
    }
}
