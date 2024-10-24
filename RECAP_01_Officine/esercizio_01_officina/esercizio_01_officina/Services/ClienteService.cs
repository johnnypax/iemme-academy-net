using esercizio_01_officina.Models;
using esercizio_01_officina.Repositories;

namespace esercizio_01_officina.Services
{
    public class ClienteService : IService<ClienteDTO>
    {
        private readonly ClienteRepo _repo;

        public ClienteService(ClienteRepo repo)
        {
            _repo = repo;
        }

        public ClienteDTO? CercaPerCodice(string codice)
        {
            ClienteDTO? risultato = null;

            Cliente? cli = _repo.GetByCodice(codice);
            if (cli is not null)
            {
                risultato = new ClienteDTO()
                {
                    Cod = cli.Codice,
                    Nom = cli.Nome,
                    Cog = cli.Cognome,
                    Ind = cli.Indirizzo,
                    Tel = cli.Telefono,
                    Ema = cli.Email
                };
            }

            return risultato;
        }

        public ClienteDTO? CercaPerId(int id)
        {
            ClienteDTO? risultato = null;

            Cliente? cli = _repo.GetById(id);
            if (cli is not null)
            {
                risultato = new ClienteDTO()
                {
                    Cod = cli.Codice,
                    Nom = cli.Nome,
                    Cog = cli.Cognome,
                    Ind = cli.Indirizzo,
                    Tel = cli.Telefono,
                    Ema = cli.Email
                };
            }

            return risultato;
        }

        public int? CercaClienteIdPerCodice(string cod)
        {
            int? risultato = null;

            Cliente? cliente = _repo.GetByCodice(cod);
            if (cliente is not null)
            {
                risultato = cliente.ClienteID;
            }

            return risultato;
        }

        public IEnumerable<ClienteDTO> CercaTutti()
        {
            ICollection<ClienteDTO> risultato = new List<ClienteDTO>();

            IEnumerable<Cliente> clienti = _repo.GetAll();
            foreach (Cliente cliente in clienti)
            {
                ClienteDTO temp = new ClienteDTO()
                {
                    Cod = cliente.Codice,
                    Nom = cliente.Nome,
                    Cog = cliente.Cognome,
                    Ind = cliente.Indirizzo,
                    Tel = cliente.Telefono,
                    Ema = cliente.Email
                };

                risultato.Add(temp);
            }

            return risultato;
        }

        public bool Inserisci(ClienteDTO entity)
        {
            Cliente cli = new Cliente()
            {
                Codice = entity.Cod is not null ? entity.Cod : Guid.NewGuid().ToString().ToUpper(),
                Nome = entity.Nom,
                Cognome = entity.Cog,
                Indirizzo = entity.Ind,
                Telefono = entity.Tel,
                Email = entity.Ema
            };


            return _repo.Create(cli);
        }

        public bool Aggiorna(ClienteDTO entity)
        {
            bool risultato = false;

            if(entity.Cod is not null)
            {
                Cliente? cli = _repo.GetByCodice(entity.Cod);

                if(cli is not null && entity.Nom is not null && entity.Cog is not null)
                {
                    cli.Nome = entity.Nom is not null ? entity.Nom : cli.Nome;
                    cli.Cognome = entity.Cog is not null ? entity.Cog : cli.Cognome;
                    cli.Indirizzo = entity.Ind is not null ? entity.Ind : cli.Indirizzo;
                    cli.Telefono = entity.Tel is not null ? entity.Tel : cli.Telefono;
                    cli.Email = entity.Ema is not null ? entity.Ema : cli.Email;

                    risultato = _repo.Update(cli);
                };
            }

            return risultato;
        }


        public bool Elimina(string codice)
        {
            bool risultato = false;

            Cliente? cli = _repo.GetByCodice(codice);
            if (cli is not null)
            {
                risultato = _repo.Delete(cli.ClienteID);
            }

            return risultato;
        }

        
    }
}
