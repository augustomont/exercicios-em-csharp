using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inserindoDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Salvar o nome do Usuario
            Console.WriteLine("escreva seu nome abaixo");
            string nome = Console.ReadLine();

            //Fazer Calculos com os dados que ele inserir
            Console.WriteLine(nome +" digite um numero");
            float num = float.Parse(Console.ReadLine());
            Console.WriteLine(nome + " digite outro numero");
            float num2 = float.Parse(Console.ReadLine());
            
            float res = num + num2;

           if(res%2 == 0)
            {
            Console.WriteLine(nome + " A soma dos numeros " +num + " e " +num2+" é: " + res + "\n" + res + " é um numero par");

            }
            else
            {
                Console.WriteLine(nome + " A soma dos numeros " + num + " e " + num2 + " é: " + res + "\n" + res + " é um numero impar");
            }

            Console.WriteLine(nome + " Qaul a sua idade?");
            int idade = int.Parse(Console.ReadLine());

            if(idade < 18)
            {
                Console.WriteLine(nome + " você é uma Criancinha ainda");
            } else if (idade >=18 && idade < 30)
            {
                Console.WriteLine("Ainda ta novo " + nome);
            }
            else
            {
                Console.WriteLine(nome + " você esta ficando velho");
            }



            Console.ReadLine();
        }
    }
}
