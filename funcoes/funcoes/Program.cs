using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome?");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual a sua Idade?");
            int idade = Math.Abs(int.Parse(Console.ReadLine()));// usei o Math.Asb para transformar em numero absoluto(sempre positivo)
            Console.WriteLine("Digite o valor do seu salário:");
            float invest = float.Parse(Console.ReadLine());
            

            exibirMsg(nome);//sem retorno
            exibirIdade(idade);//com parametro && com return
            investimento(invest);//com parametro

            Console.WriteLine("E voce terá " + idadeFutura(idade));
            


           
            Console.ReadLine();
        }
        //Função de exibir nome
        static void exibirMsg(string nomeF) //função com restorno vazio (void)
        {
            Console.WriteLine("Olá "+nomeF+"!");
        }

        //Função de resposta a idade
        static void exibirIdade(int idadeF)//quando descrimina parametro, precisa por um valor quando for usar
        {
            if (idadeF > 35)
            {
                Console.WriteLine("Ta ficando Velho!");
            }
            else if (idadeF >= 18)
            {
                Console.WriteLine("Ainda ta novo!");
            }
            else
            {
                Console.WriteLine("Voce ainda não é adulto!");
            }
        }

        static void investimento(float valor)
        {
            valor = (valor / 10) * 60;
            Console.WriteLine("Se voce investier 10% do seu salario, voce terá " + valor + " daqui a 5 anos.");
        }

        //Função com Tipo definido, é obrigado a dar return
        static int idadeFutura(int ida)
        {
            ida = ida + 5;
            return ida;
        }
    }
}
