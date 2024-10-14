using ASP_WEB_03_Clienti.Models;
using ASP_WEB_03_Clienti.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace ASP_WEB_03_Clienti.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ClienteService _service;

        public ClienteController(ClienteService service)
        {
            _service = service;
        }

        public IActionResult Lista() {
            IEnumerable<Cliente> elenco = _service.RestituisciTutti();

            return View(elenco); 
        }

        public IActionResult Inserisci() {
            return View();
        }

        public IActionResult Salva(Cliente objCli)
        {
            if (_service.Inserisci(objCli))
                return Redirect("/Cliente/Lista");

            return Redirect("/Cliente/Errore");
        }

        public IActionResult Dettaglio(string varCodice)
        {
            if(string.IsNullOrEmpty(varCodice))
                return Redirect("/Cliente/Errore");

            Cliente? cli = _service.CercaPerCodice(varCodice);
            if(cli is not null)
                return View(cli);

            return Redirect("/Cliente/Errore");
        }

        public IActionResult Errore()
        {
            return View();
        }

        [HttpDelete]
        public IActionResult Elimina(string varCodice)
        {
            if (string.IsNullOrEmpty(varCodice))
                return BadRequest();

            if (_service.EliminaUtente(varCodice))
                return Ok();

            return NotFound();
        }

        public IActionResult Modifica(string varCodice)
        {
            if (string.IsNullOrEmpty(varCodice))
                return Redirect("/Cliente/Errore");

            Cliente? cli = _service.CercaPerCodice(varCodice);
            if (cli is not null)
                return View(cli);

            return Redirect("/Cliente/Errore");
        }

        [HttpPost]
        public IActionResult EffettuaModifica(Cliente objCli)
        {
            if (string.IsNullOrEmpty(objCli.Codice))
                return Redirect("/Cliente/Errore");

            Cliente? cli = _service.CercaPerCodice(objCli.Codice);
            if (cli is not null)
            {
                cli.Nome = objCli.Nome;
                cli.Cognome = objCli.Cognome;
                cli.Telefono = objCli.Telefono;
                cli.Email = objCli.Email;
                cli.Indirizzo = objCli.Indirizzo;

                if(_service.ModificaUtente(cli))
                    return Redirect($"/Cliente/Dettaglio/{objCli.Codice}");
            }

            return Redirect("/Cliente/Errore");
        }
    }
}
