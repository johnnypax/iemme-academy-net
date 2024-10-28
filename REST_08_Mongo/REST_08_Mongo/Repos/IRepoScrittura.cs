namespace REST_08_Mongo.Repos
{
    public interface IRepoScrittura<T>
    {
        bool Create(T entity);
        bool Delete(string varId);
        bool Update(T entity);
    }
}
