namespace REST_08_Mongo.Repos
{
    public interface IRepoLettura<T>
    {
        T? GetById(string varId);
        IEnumerable<T> GetAll();
    }
}
