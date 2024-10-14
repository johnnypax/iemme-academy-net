namespace ASP_WEB_03_Clienti.Repositories
{
    public interface IRepoScrittura<T>
    {
        bool Create(T entity);
        bool Delete(int id);
        bool Update(T entity);
    }
}
