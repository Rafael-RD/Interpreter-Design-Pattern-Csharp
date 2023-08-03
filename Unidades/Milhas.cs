using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreterv2.Unidades
{
    internal class Milhas : IExpression
    {
        public string ParaCentimetros(double quantidade)
        {
            return (quantidade * 160_934).ToString("F4");
        }

        public string ParaKilometros(double quantidade)
        {
            return (quantidade * 1.609_34).ToString("F4");
        }

        public string ParaMetros(double quantidade)
        {
            return (quantidade * 1_609.34).ToString("F4");
        }

        public string ParaMilhas(double quantidade)
        {
            return (quantidade).ToString("F4");
        }

        public string ParaMilimetros(double quantidade)
        {
            return (quantidade * 1_609_340).ToString("F4");
        }

        public string ParaPolegadas(double quantidade)
        {
            return (quantidade * 63_360).ToString("F4");
        }
    }
}
