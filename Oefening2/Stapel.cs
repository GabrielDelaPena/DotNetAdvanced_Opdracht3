using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    internal class Stapel<T>
    {
        List<T> stapel = new List<T>();

        public void Toevoegen(T o)
        {
            stapel.Add(o);
        }
        public T Verwijderen(T o)
        {
            if (stapel.Count <= 0)
            {
                throw new Exception("Stapel is leeg.");
            }
            stapel.Remove(o);
            return o;
        }
        public void Leegmaken()
        {
            stapel.Clear();
        }

        public override string ToString()
        {
            string text = "";
            foreach (T o in stapel)
            {
                text += o.ToString() + ", ";
            }
            return text;
        }

        public bool IsAanwezig(T o)
        {
            if (stapel.Contains(o))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Stapel<T> Copy()
        {
            return (Stapel<T>)this.MemberwiseClone();
        }

    }
}
