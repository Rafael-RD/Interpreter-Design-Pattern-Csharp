using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreterv2.Unidades
{
    internal class Polegadas : IExpression
    {
        public string ParaCentimetros(double quantidade)
        {
            return (quantidade * 2.54).ToString("F4");
        }

        public string ParaKilometros(double quantidade)
        {
            return (quantidade / 39_370.1).ToString("F4");
        }

        public string ParaMetros(double quantidade)
        {
            return (quantidade / 39.370_1).ToString("F4");
        }

        public string ParaMilhas(double quantidade)
        {
            return (quantidade / 63_360).ToString("F4");
        }

        public string ParaMilimetros(double quantidade)
        {
            return (quantidade * 25.4).ToString("F4");
        }

        public string ParaPolegadas(double quantidade)
        {
            return (quantidade).ToString("F4");
        }
    }
}
