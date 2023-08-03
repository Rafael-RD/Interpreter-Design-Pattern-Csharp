using Interpreterv2.Unidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Interpreterv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Digite o seu pedido de conversão");
                string pedido = Console.ReadLine();

                try
                {
                    Context c1 = new Context(pedido);

                    Type typeDynamicObj = Type.GetType($"Interpreterv2.Unidades.{c1.UnidadeOriginal}");
                    ConstructorInfo constructorDynamicObj = typeDynamicObj.GetConstructor(Type.EmptyTypes);

                    dynamic dynamicObj = constructorDynamicObj.Invoke(new object[] { });

                    MethodInfo dynamicMethod = typeDynamicObj.GetMethod($"Para{c1.UnidadeDestino}");
                    dynamic quantidadeDestino = dynamicMethod.Invoke(dynamicObj, new object[] { c1.Quantidade });

                    c1.SetQuantidadeDestino(quantidadeDestino);

                    Console.WriteLine($"{c1.GetResposta()}\n");
                }

                catch (Exception ex) { }
            }
        }
    }
}
