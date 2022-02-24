using System;

namespace pz_2s_3_4_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Atom atom1 = new Atom("Atom1");
            Atom atom2 = new Atom("Atom2", 123, 1234, Valent.II);
            Atom atom3 = new Atom("Atom3", 123, 6457427, Valent.II);
            Atom atom4 = new Atom("Atom4", 73564, 5234, Valent.I);
            Atom atom5 = new Atom("Atom5", 1365823, 123, Valent.I);

            RadioactiveAtom rd1 = new RadioactiveAtom(100, "Atom6", 56436453, 6578, Valent.I);
            RadioactiveAtom rd2 = new RadioactiveAtom(100, "Atom7", 958, 357, Valent.II);
            RadioactiveAtom rd3 = new RadioactiveAtom(100, "Atom8", 37856, 24, Valent.I);



            atom1.GetInfo();
            atom2.GetInfo();
            atom3.GetInfo();
            atom4.GetInfo();
            atom5.GetInfo();

            rd1.GetInfo();
            rd2.GetInfo();
            rd3.GetInfo();

        }
    }
}
