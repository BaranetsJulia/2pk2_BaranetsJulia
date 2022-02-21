using System;
using System.Collections.Generic;
using System.Text;

namespace pz_2s_3
{
    //Вариант 3
    class Company
    {
        static int AllCount = 0;
        static int Coun2020 = 0;
        internal string name
        {
            get { return name; }
            set
            {
                if (value != null) name = value;
            }
        }
        internal int okpo
        {
            set
            {
                if (8 == value.ToString().Length) okpo = value;
            }
            get { return okpo; }
        }
        internal string dateOfRegistry
        {
            get { return dateOfRegistry; }
            set
            {
                var date = DateTime.Parse(value);
                if (
                DateTime.Parse("01.01.1990") <= date
                && DateTime.Parse("01.01.2022") <= date
                ) dateOfRegistry = value;
            }
        }
        private Random rnd = new Random();

        public Company(string kname, int okp)
        {
            AllCount++;
            if ((int)Math.Pow(10, 6) <= okp && (int)Math.Pow(10, 8) > okp)
                okpo = okp;
            else
                okpo = rnd.Next((int)Math.Pow(10, 6), (int)Math.Pow(10, 8));

            name = kname;
            dateOfRegistry = DateTime.Now.ToString();
            if (DateTime.Now.Year >= 2020) Coun2020++;
        }

        public Company(string kname)
        {
            AllCount++;
            name = kname;
            okpo = rnd.Next((int)Math.Pow(10, 6), (int)Math.Pow(10, 8));
            dateOfRegistry = DateTime.Now.ToString();
            if (DateTime.Now.Year >= 2020) Coun2020++;
        }

        public virtual void GetCompanyInfo()
        {
            Console.WriteLine("Компания: " + name +
            " владеет okpo: " + okpo +
            "\n Зарегистрированна в " + dateOfRegistry);
        }
        class OOO : Company
        {
            string Founder;
            public OOO(string kname, int okp, string founder) : base(kname, okp)
            {
                Founder = founder;
            }
            public override void GetCompanyInfo()
            {
                Console.WriteLine("Компания: " + name +
                " владеет okpo: " + okpo +
                "\n Зарегистрированна в " + dateOfRegistry +
                "учередитель " + Founder);
            }
        }
    }
}

