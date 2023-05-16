using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma cor");
            string cor = Console.ReadLine();

          switch (cor)
            {
                case "vermelho":
                    Console.WriteLine("Sua cor preferida é o Vermelho");
                    break;
                case "azul":
                    Console.WriteLine("Sua cor preferida é o Azul");
                    break;
                case "verde":
                    Console.WriteLine("Sua cor preferida é o Verde");
                    break;
                case "amarelo":
                    Console.WriteLine("Sua cor preferida é o Amarelo");
                    break;
                default:
                    Console.WriteLine("Não encontrei a cor. Tente de novo !");
                    break;
            };


            

            Console.ReadLine();
        }
    }
}
