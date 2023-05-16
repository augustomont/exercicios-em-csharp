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
        enum Cor { Vermelho = 1, Azul, Verde, Amarelo} //(enum)Cria um novo tipo de dado
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1-Vermelhor\n2-Azul\n3-Verde\n4-Amarelo");
           int opcao = int.Parse(Console.ReadLine());
            Cor corSelecionada = (Cor)opcao;

            Console.WriteLine(corSelecionada); //Usado o indice do enum para exibir o dado

          switch (corSelecionada)
            {
                case Cor.Vermelho:
                    Console.WriteLine("Sua cor preferida é o Vermelho");
                    break;
                case Cor.Azul:
                    Console.WriteLine("Sua cor preferida é o Azul");
                    break;
                case Cor.Verde:
                    Console.WriteLine("Sua cor preferida é o Verde");
                    break;
                case Cor.Amarelo:
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
