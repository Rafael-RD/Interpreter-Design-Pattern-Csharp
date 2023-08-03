using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreterv2
{
    internal interface IExpression
    {
        string ParaKilometros(double quantidade);
        string ParaMetros(double quantidade);
        string ParaCentimetros(double quantidade);
        string ParaMilimetros(double quantidade);
        string ParaMilhas(double quantidade);
        string ParaPolegadas(double quantidade);
    }
}
