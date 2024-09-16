using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez05_02_CorrezioneEsercizioDue.classes
{
    internal class GestoreStudente
    {
        private List<Studente> Elenco { get; set; } = new List<Studente>();

        /// <summary>
        /// Metodo di aggiunta di un oggetto studente
        /// </summary>
        /// <param name="studente">Oggetto studente</param>
        public void AggiungiStudente(Studente studente)
        {
            Elenco.Add(studente);
            Console.WriteLine("Studente aggiunto con successo");
        }

        /// <summary>
        /// Metodo di stampa degli studenti
        /// </summary>
        public void StampaStudenti()
        {
            foreach(Studente studente in Elenco)
            {
                Console.WriteLine(studente);
            }
        }

        /// <summary>
        /// Funzione di modifica di uno studente.
        /// Per la modifica, sono necessari Nome e Cognome
        /// </summary>
        /// <param name="vechioStu"></param>
        /// <param name="nuovoStu"></param>
        public void ModificaStudente(Studente vecchioStu, Studente nuovoStu)
        {
            foreach(Studente stu in Elenco)
            {
                if (vecchioStu.Nome is not null && 
                    vecchioStu.Nome.Equals(stu.Nome) && 
                    vecchioStu.Cognome is not null && 
                    vecchioStu.Cognome.Equals(stu.Cognome))
                {
                    stu.Nome = nuovoStu.Nome;
                    stu.Cognome = nuovoStu.Cognome;
                    stu.Voto = nuovoStu.Voto;
                }
            }
        }

        public void IntervalloVoti(double maggioreDi, double minoreDi)
        {
            List<Studente> elencoTemp = new List<Studente>();

            foreach(Studente stu in Elenco)
            {
                if(stu.Voto >= maggioreDi && stu.Voto <= minoreDi)
                {
                    elencoTemp.Add(stu);
                }
            }

            foreach(Studente tmp in elencoTemp)
            {
                Console.WriteLine(tmp);
            }
        }

        //TODO: Remove...
    }
}
