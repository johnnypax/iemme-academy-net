using ASP_WEB_03_Clienti.Models;
using ASP_WEB_03_Clienti.Repositories;

namespace ASP_WEB_03_Clienti.Service
{
    public class ClienteService
    {
        private readonly ClienteRepo _repo; 

        public ClienteService(ClienteRepo repo)
        {
            _repo = repo;
        }

        public IEnumerable<Cliente> RestituisciTutti()
        {
            return _repo.GetAll();
        }

        public bool Inserisci(Cliente cli)
        {
            cli.Codice = Guid.NewGuid().ToString(); 

            return _repo.Create(cli);
        }

        public Cliente? CercaPerCodice(string varCod)
        {
            return _repo.GetByCodice(varCod);
        }

        public bool EliminaUtente(string varCod)
        {
            bool risultato = false;

            Cliente? cli = _repo.GetByCodice(varCod);
            if (cli is not null)
                risultato = _repo.Delete(cli.ClienteID);

            return risultato;
        }

        public bool ModificaUtente(Cliente cli) {
            return _repo.Update(cli);
        }
    }
}
