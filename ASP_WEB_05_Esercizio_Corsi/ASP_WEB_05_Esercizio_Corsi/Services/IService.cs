namespace ASP_WEB_05_Esercizio_Corsi.Services
{
    public interface IService<T>
    {
        IEnumerable<T> List();
        T? Details(int id);
        bool Insert(T t);
        bool Update(T t);
        bool Delete(int id);
    }
}
