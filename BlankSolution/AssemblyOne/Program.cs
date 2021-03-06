﻿using System;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Developer developer = new Developer();

            String val = employee.companyNamePublic;
            //String val1 = employee.companyName; unaccessible cause private by default

            employee.GetCompanyNamePublic();
            developer.GetCompanyNamePublic();

            //employee.GetCompanyNameProtected(); unaccessible as seen only in type
            //developer.GetCompanyNameProtected(); unaccessible as seen only in type

            employee.GetAgeInternal();
            developer.GetAgeInternal();

            employee.GetCompanyNameProtectedInternal();
            developer.GetCompanyNameProtectedInternal();

            //employee.GetCompanyNamePrivate(); unaccessible
            //developer.GetCompanyNamePrivate(); unaccessible

            //employee.GetCompanyNamePrivateProtected(); unaccessible
            //developer.GetCompanyNamePrivateProtected(); unaccessible
        }
    }
}
