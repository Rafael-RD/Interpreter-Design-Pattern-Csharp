using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreterv2
{
    internal class Context
    {
        public string Pedido { get; private set; }
        public string UnidadeOriginal { get; private set; }
        public string UnidadeDestino { get; private set; }
        public string[] PartesPedido { get; private set; }
        public double Quantidade { get; private set; }
        public string QuantidadeDestino { get; private set; }

        public Context(string pedido)
        {
            Pedido = pedido;
            PartesPedido = Pedido.Split(' ');
            UnidadeOriginal = CaptalizarEPluralizar(PartesPedido[1]);
            UnidadeDestino = CaptalizarEPluralizar(PartesPedido[PartesPedido.Length - 1]);
            Quantidade = double.Parse(PartesPedido[0]);
        }

        public string CaptalizarEPluralizar(string str)
        {
            string result = Char.ToUpper(str[0]) + str.Substring(1).ToLower();
            if (result[result.Length - 1] != 's') result += 's';
            return result;
        }

        public void SetQuantidadeDestino(string str)
        {
            QuantidadeDestino = str;
        }

        public string GetResposta()
        {
            return $"{PartesPedido[0]} {PartesPedido[1]} são {QuantidadeDestino} {PartesPedido[PartesPedido.Length -1]}";
        }
    }
}
