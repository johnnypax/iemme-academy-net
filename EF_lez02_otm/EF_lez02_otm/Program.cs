using EF_lez02_otm.Models;

namespace EF_lez02_otm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Scaffold-DbContext "Server=BOOK-N57JVKH6HJ\SQLEXPRESS;Database=a_lez06_otm_carte;User Id=academy;Password=academy!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

            //Persona osv = new Persona() { Nome = "Osvaldo", Cognome = "Bevilacqua", Email = "osv@bevi.com" };

            //Cartum carUno = new Cartum() { Codice = "CC0099", Negozio = "SMU", PersonaRifNavigation = osv };
            //Cartum carDue = new Cartum() { Codice = "AA6788", Negozio = "Piccol", PersonaRifNavigation = osv };

            //using (var ctx = new ALez06OtmCarteContext())
            //{
            //    try
            //    {
            //        ctx.Personas.Add(osv);
            //        ctx.Carta.Add(carUno);
            //        ctx.Carta.Add(carDue);
            //        ctx.SaveChanges();

            //        Console.WriteLine("STAPPOOOOOOOO");

            //    } catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}

            // ----------------------------------------------------------

            using (var ctx = new ALez06OtmCarteContext())
            {
                //Voglio stampare tutte le carte Coap
                var elCarte = ctx.Carta.ToList();

                foreach (var car in elCarte)
                {
                    car.PersonaRifNavigation = ctx.Personas.Single(p => p.PersonaId == car.PersonaRif);
                    Console.WriteLine(car);
                }
            }

            using (var ctx = new ALez06OtmCarteContext())
            {
                try
                {
                    Persona gio = ctx.Personas.Single(p => p.Email == "gio@pace.com");

                    gio.Carta = ctx.Carta.Where(c => c.PersonaRif == gio.PersonaId).ToList();

                    Console.Write(gio);
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}
