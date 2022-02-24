using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_2s_3_4_5
{
    class Atom
    {
        protected string Name { get; set; }
        protected int CountElectrons { get; set; }
        protected int Mass { get; set; }
        protected Valent Valence { get; set; }

        private static int I = 0;
        private static int II = 0;

        public Atom(string Name = "Имя", int CountElectrons = -1, int Mass = -1, Valent Valence = Valent.DEF)
        {

            if (Valence == Valent.I)
            {
                I++;
            }
            if (Valence == Valent.II)
            {
                II++;
            }

            this.Name = Name;
            this.CountElectrons = CountElectrons;
            this.Mass = Mass;
            this.Valence = Valence;
        }

        public Atom(string Name)
        {
            this.Name = Name;
            this.CountElectrons = -1;
            this.Mass = -1;
            this.Valence = Valent.DEF;
        }

        public void GetInfo()
        {
            Console.WriteLine($"{Name} c {CountElectrons} элементами, массой {Mass} и валентностью {Valence}");
            Console.WriteLine();
        }

    }
}