using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Nelinurk
{
    public class Nelnurk
    {
        int laius;
        int korgus;
        string type;

        public Nelnurk() { }

        public Nelnurk(int Korgus, int Laius)
        {
            laius = Laius;
            korgus = Korgus;
        }
        public int Korgus
        {
            set { korgus = value; }
            get { return korgus; }
        }
        public int Laius
        {
            set { laius = value; }
            get { return laius; }
        }
        public string Type
        {
            get
            {
                var type = "";
                if (korgus == laius)
                { type = "square"; }
                return type;

            }
        }

        public void svoistva ()
        {
            Console.WriteLine("Hello, i am a four sided figure!");
            Console.WriteLine("My horizontal side is {0} and my vertical side is {1}",laius,korgus);
        }
    }
}
