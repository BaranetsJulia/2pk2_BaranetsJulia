using System;
using System.Collections.Generic;
using System.Text;

namespace Companys
{ 
    //Вариант 3
    class Company
    {
        static int AllCount = 0;
        static int Coun2020 = 0;
        private string name
        {
            get { return name; }
            set
            {
                if (value != null) name = value;
            }
        }
        private int okpo
        {
            set
            {
                if (8 == value.ToString().Length) okpo = value;
            }
            get { return okpo; }
        }
        private string dateOfRegistry
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

        public Company(string nname, int okp)
        {
            AllCount++;
            if ((int)Math.Pow(10, 6) <= okp && (int)Math.Pow(10, 8) > okp)
                okpo = okp;
            else
                okpo = rnd.Next((int)Math.Pow(10, 6), (int)Math.Pow(10, 8));

            name = nname;
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

        public void GetCompanyInfo()
        {
            Console.WriteLine("Компания: " + name +
            " владеет okpo: " + okpo +
            "\n Зарегистрированна в " + dateOfRegistry);
        }
    }
}
