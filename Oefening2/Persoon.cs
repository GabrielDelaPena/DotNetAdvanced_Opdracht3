using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    public class Persoon
    {
        public string naam { get; set; }

        public Persoon(string naam)
        {
            this.naam = naam;
        }

        public override string ToString()
        {
            return naam;
        }
    }
}
