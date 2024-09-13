using Lez04_04_statici.classes;

namespace Lez04_04_statici
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Studente.getContatore());

            Studente uno = new Studente();
            Studente due = new Studente();

            //Studente.Contatore = -852;            //Non possibile perché private

            Console.WriteLine(Studente.getContatore());
        }
    }
}
