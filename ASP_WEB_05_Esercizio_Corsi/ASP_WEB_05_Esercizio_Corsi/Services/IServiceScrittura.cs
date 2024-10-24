namespace ASP_WEB_05_Esercizio_Corsi.Services
{
    public interface IServiceScrittura<T>
    {
        bool Insert(T t);
        bool Update(T t);
        bool Delete(int id);
    }
}
