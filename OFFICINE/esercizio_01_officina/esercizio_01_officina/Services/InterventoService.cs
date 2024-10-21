using esercizio_01_officina.Models;
using esercizio_01_officina.Repositories;

namespace esercizio_01_officina.Services
{
    public class InterventoService : IService<InterventoDTO>
    {
        private readonly InterventoRepo _repo;
        private readonly ClienteService _cliService;

        public InterventoService(InterventoRepo repo, ClienteService clienteService)
        {
            _repo = repo;
            _cliService = clienteService;
        }

        public InterventoDTO? CercaPerCodice(string codice)
        {
            InterventoDTO? risultato = null;

            Intervento? intervento = _repo.GetByCode(codice);
            if (intervento is not null)
            {
                risultato = new InterventoDTO()
                {
                    Codice = intervento.Codice,
                    Targa = intervento.Targa,
                    Anno = intervento.Anno,
                    DataIngresso = intervento.DataIngresso,
                    Marca = intervento.Marca,
                    Modello = intervento.Modello,
                    Prezzo = intervento.Prezzo,
                    Stato = intervento.Stato,
                    CliRif = _cliService.CercaPerId(intervento.ClienteRIF)
                };
            }

            return risultato;
        }

        public IEnumerable<InterventoDTO> CercaTutti()
        {
            List<InterventoDTO> risultato = new List<InterventoDTO>();

            IEnumerable<Intervento> interventi = _repo.GetAll();
            foreach(Intervento interv  in interventi)
            {
                InterventoDTO temp = new InterventoDTO()
                {
                    Codice = interv.Codice,
                    Targa = interv.Targa,
                    Anno = interv.Anno,
                    DataIngresso = interv.DataIngresso,
                    Marca = interv.Marca,
                    Modello = interv.Modello,
                    Prezzo = interv.Prezzo,
                    Stato = interv.Stato,
                    CliRif = _cliService.CercaPerId(interv.ClienteRIF)
                };

                risultato.Add(temp);
            }

            return risultato;
        }
        public bool Inserisci(InterventoDTO entity)
        {
            bool risultato = false;

            if(entity.CliRif is not null && entity.CliRif.Cod is not null)
            {
                int? riferimentoCli = _cliService.CercaClienteIdPerCodice(entity.CliRif.Cod);
                if (riferimentoCli is not null)
                {
                    Intervento interv = new Intervento()
                    {
                        Anno = entity.Anno,
                        Codice = entity.Codice is not null ? entity.Codice : Guid.NewGuid().ToString().ToUpper(),
                        Targa = entity.Targa,
                        Marca = entity.Marca,
                        Modello = entity.Modello,
                        Prezzo = entity.Prezzo,
                        Stato = entity.Stato,
                        DataIngresso = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
                        ClienteRIF = (int)riferimentoCli
                    };

                    risultato = _repo.Create(interv);
                }
            }                         

            return risultato;
        }

        public bool Aggiorna(InterventoDTO entity)
        {
            throw new NotImplementedException();
        }


        public bool Elimina(string codice)
        {
            throw new NotImplementedException();
        }

    }
}
