using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tentando criar esse algoritmo sozinho
namespace Fibonacci
{
    internal class Class1
    {
        static void Main()
        {
            int numAtual = 1;
            int numAnterior = 0;
            int interacoes = 20;

            for (int i = 1; i<= interacoes; i++)
            {
             int soma = numAtual + numAnterior;
                numAnterior = numAtual;
                numAtual = soma;

                Console.WriteLine("{0} na posição {1}", soma,i);
            }
           
        }
    }
}
