namespace ASP_WEB_05_Esercizio_Corsi.Repos
{
    public interface IRepo<T>
    {
        T? Get(int id);
        IEnumerable<T> GetAll();
        bool Create(T t);
        bool Update(T t);
        bool Delete(int id);
    }
}
