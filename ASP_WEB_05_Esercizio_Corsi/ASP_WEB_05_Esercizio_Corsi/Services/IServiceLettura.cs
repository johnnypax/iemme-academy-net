namespace ASP_WEB_05_Esercizio_Corsi.Services
{
    public interface IServiceLettura<T>
    {
        IEnumerable<T> List();
        T? Details(int id);
    }
}
