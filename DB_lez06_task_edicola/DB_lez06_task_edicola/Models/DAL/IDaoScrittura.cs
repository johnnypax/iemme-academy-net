using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez06_task_edicola.Models.DAL
{
    internal interface IDaoScrittura<T>
    {
        bool Insert(T t);
        bool Update(T t);
        bool Delete(int id);
    }
}
