using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez06_task_edicola.Models.DAL
{
    internal interface IDaoLettura<T>
    {
        List<T> GetAll();               //CANONICO cRud
        T GetById(int id);              //CANONICO cRud
        T GetByCodice(string cod);
    }
}
