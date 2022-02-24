using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_2s_3_4_5
{
    class RadioactiveAtom : Atom
    {

        private int PeriodPoluraspada = 0;

        public RadioactiveAtom(int PeriodPoluraspada, string Name = "Имя", int CountElectrons = -1, int Mass = -1, Valent Valence = Valent.DEF)
            : base(Name, CountElectrons, Mass, Valence)
        {
            this.PeriodPoluraspada = PeriodPoluraspada;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Радиоактивный {Name} c {CountElectrons} элементами, массой {Mass} и валентностью {Valence}");
            Console.WriteLine();
        }

    }
}

