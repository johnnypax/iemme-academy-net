using esercizio_01_officina.Models;
using esercizio_01_officina.Repositories;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace esercizio_01_officina.Services
{
    public class InterventoService : IService<InterventoDTO>
    {
        private readonly InterventoRepo _repo;
        private readonly ClienteService _cliService;
        public InterventoService(InterventoRepo repo, ClienteService cliSer)
        {
            _repo = repo;
            _cliService = cliSer;
        }

        public bool Aggiorna(InterventoDTO entity)
        {
            throw new NotImplementedException();
        }

        public InterventoDTO? CercaPerCodice(string codice)
        {
            InterventoDTO? risultato = null;

            Intervento? interv = _repo.GetByCodice(codice);
            if (interv is not null)
            {
                risultato = new InterventoDTO()
                {
                    Tar = interv.Targa,
                    Mar = interv.Marca,
                    Sta = interv.Stato,
                    Cod = interv.Codice,
                    Mod = interv.Modello,
                    Pre = interv.Prezzo,
                    Dat = interv.DataIngresso,
                    Ann = interv.Anno,
                    Cli = _cliService.CercaPerId(interv.ClienteRIF)
                };
            }

            return risultato;
        }

        public IEnumerable<InterventoDTO> CercaTutti()
        {
            throw new NotImplementedException();
        }

        public bool Elimina(string codice)
        {
            throw new NotImplementedException();
        }

        public bool Inserisci(InterventoDTO entity)
        {
            if (entity.Cli is null || entity.Cli.Cod is null)
                return false;

            int? cliId = _cliService.RestituisciIdCliente(entity.Cli.Cod);
            if (!cliId.HasValue)
                return false;

            Intervento interv = new Intervento()
            {
                Targa = entity.Tar,
                Marca = entity.Mar,
                Stato = entity.Sta,
                Codice = entity.Cod is not null ? entity.Cod : Guid.NewGuid().ToString().ToUpper(),
                Modello = entity.Mod,
                Prezzo = entity.Pre,
                DataIngresso = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
                Anno = entity.Ann,
                ClienteRIF = (int)cliId
            };

            return _repo.Create(interv);

        }

        public IEnumerable<InterventoDTO>? ElencoInterventiPerCliente(string codCli)
        {
            List<InterventoDTO> risultato = new List<InterventoDTO>();

            int? idCli = _cliService.RestituisciIdCliente(codCli);
            if (!idCli.HasValue)
                return null;

            IEnumerable<Intervento> elenco = _repo.GetByClienteRif((int)idCli);
            foreach (Intervento interv in elenco)
            {

                InterventoDTO temp = new InterventoDTO()
                {
                    Tar = interv.Targa,
                    Mar = interv.Marca,
                    Sta = interv.Stato,
                    Cod = interv.Codice,
                    Mod = interv.Modello,
                    Pre = interv.Prezzo,
                    Dat = interv.DataIngresso,
                    Ann = interv.Anno,
                    Cli = _cliService.CercaPerId(interv.ClienteRIF)
                };

                risultato.Add(temp);
            }

            return risultato;

            throw new NotImplementedException();
        }
    }

}