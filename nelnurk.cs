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
        int per;
        int plosh;
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
        public int Per
        {
            get
            {
                per = (laius + korgus) * 2;
                return per;
            }
        }
        public int Plosh
        {
            get
            {
                plosh = laius * korgus;
                return plosh;
            }
        }
        public string Type
        {
            get
            {
                var type = "";
                if (korgus == laius)
                { type = "square"; }
                else if (korgus<laius && korgus>laius) // ne rabotaet /ispravit
                { type = "rectangle"; }
                return type;

            }
        }

        public void svoistva ()
        {
            Console.WriteLine("Hello, i am a four sided figure!");
            Console.WriteLine("My horizontal side is {0} and my vertical side is {1}",laius,korgus);
            Console.WriteLine("I am a {0}", Type);
            Console.WriteLine("My perimetr is {0}", Per);
            Console.WriteLine("My ploshad is {0}", Plosh);
        }
    }
}
