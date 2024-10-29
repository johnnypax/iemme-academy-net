using System.Collections;

namespace REST_EF_06_Migrazioni.Repos
{
    public interface IRepoLettura<T>
    {
        T? GetById(int id);
        IEnumerable<T> GetAll();
    }
}
