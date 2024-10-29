namespace REST_EF_06_Migrazioni.Services
{
    public interface IServices<T>
    {
        T? CercaPerCodice(string codice);
        IEnumerable<T> CercaTutti();
        bool Inserisci(T entity);
        bool Aggiorna(T entity);
        bool Elimina(string codice);
    }
}
