namespace REST_EF_06_Migrazioni.Repos
{
    public interface IRepoScrittura<T>
    {
        bool Create(T entity);
        bool Delete(int id);
        bool Update(T entity);
    }
}
