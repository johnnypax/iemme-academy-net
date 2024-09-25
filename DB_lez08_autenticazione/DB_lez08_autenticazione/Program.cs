using DB_lez08_autenticazione.Models.DAL;

namespace DB_lez08_autenticazione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UtenteDAO.GetInstance().GetByCredenziali("anna_neri", "anna_secure1");
            //UtenteDAO.GetInstance().GetByCredenziali("elisa_russo", "elisa!pass");

            //UtenteDAO.GetInstance().GetByCredenziali("anna_neri' --", "elisa!pass");

            Console.WriteLine("Ciao, inserisci lo username:");
            string? inputUser = Console.ReadLine();
            Console.WriteLine("inserisci la password:");
            string? inputPass = Console.ReadLine();

            if(inputUser is not null && inputPass is not null)
                UtenteDAO.GetInstance().GetByCredenziali(inputUser, inputPass);
        }
    }
}
