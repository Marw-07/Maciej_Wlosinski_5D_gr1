using System;
using System.Collections.Generic;
using System.Text;

namespace Testowa
{
    public class Przelicznik
    {
        public double KilometryNaMetry(double kilometry)
        {
            return kilometry * 1000;
        }

        public double MetryNaCentymetry(double metry)
        {
            return metry * 100;
        }

        public double GodzinyNaMinuty(double godziny)
        {
            return godziny * 60;
        }
    }
}