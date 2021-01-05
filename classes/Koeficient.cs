using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informačný_systém_SOFI.classes
{
    class Koeficient
    {
        // Prevod koeficinetu na číselnú hodnotu
        public static double KoefToDouble(string sKoef)
        {
            double dKoef = 0;
            switch (sKoef)
            {
                case "EU1":
                    {
                        dKoef = 1.5;
                    }
                    break;

                case "EU2":
                    {
                        dKoef = 2;
                    }
                    break;

                case "SK":
                    {
                        dKoef = 1;
                    }
                    break;

                default:
                    {
                        dKoef = 1;
                    }
                    break;
            }
            return dKoef;
        }
    }
}
