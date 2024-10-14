using System.Collections;

namespace ASP_WEB_03_Clienti.Repositories
{
    public interface IRepoLettura<T>
    {
        T? GetById(int id);
        IEnumerable<T> GetAll();
    }
}
