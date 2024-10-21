using System.Collections;

namespace esercizio_01_officina.Repositories
{
    public interface IRepoLettura<T>
    {
        T? GetById(int id);
        IEnumerable<T> GetAll();
    }
}
