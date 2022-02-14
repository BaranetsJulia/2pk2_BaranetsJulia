using System;
using Companys;

namespace pz_2s_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Company comp1 = new Company("Saturn");
            comp1.GetCompanyInfo();
            Company comp2 = new Company("Star", 13428151);
            comp2.GetCompanyInfo();
        }
    }
}

