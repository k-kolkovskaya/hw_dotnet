using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    public class Employee
    {
        const string companyName = "Microsoft";
        public string companyNamePublic = "Apple";

        public string GetCompanyNamePublic()
        {
            return companyNamePublic;
        }
        protected string GetCompanyName()
        {
            return companyNamePublic;
        }

        internal int GetAgeInternal()
        {
            Console.WriteLine("Enter your age, please");
            int age = Convert.ToInt32(Console.ReadLine());
            return age;
        }

        protected internal string GetCompanyNameProtectedInternal()
        {
            return companyName;
        }

        private string GetCompanyNamePrivate()
        {
            return companyNamePublic;
        }

        private protected string GetCompanyNamePrivateProtected()
        {
            return companyNamePublic;
        }

    }
}
