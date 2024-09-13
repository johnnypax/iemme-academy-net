using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez04_02_Composizione.classes
{
    internal class Mazzo
    {
        public bool HasFiocco { get; set; } = true;

        public List<Fiore>? Lista { get; set; } = null;

        public void AggiungiFiore(Fiore objFio)
        {
            if(Lista is null)
                Lista = new List<Fiore>();

            Lista.Add(objFio);
        }

        public int ContaFiori()
        {
            if (Lista is null)
                return 0;
            
            return Lista.Count;
        }
    }
}
