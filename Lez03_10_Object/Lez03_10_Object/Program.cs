using Lez03_10_Object.classes;

namespace Lez03_10_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Persona persona = new Persona()
            //{
            //    Nominativo = "Giovanni Pace"
            //};
            // Console.WriteLine(persona.ToString());

            Studente stu = new Studente()
            {
                Nominativo = "Valeria Verdi",
                Matricola = "AB12345"
            };

            Console.WriteLine(stu.ToString());
        }
    }
}
