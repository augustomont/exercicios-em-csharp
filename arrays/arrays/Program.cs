using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jeito tradicional de criar uma arrays
            string[] nomes = new string[3] //com limite de tamanho
            {
                "Antonio",
                "Bruna",
                "Augusto"
            };
            nomes[2] = "Carlos";
            int[] idade = new int[] //sem limite de tamanho
            {
                36,
                24,
                15
            };

            Console.WriteLine(nomes[2]);
            Console.WriteLine(idade[2]);


            //Jeito simplificado
            float[] num =
            {
                3.14f,
            2.68f,
            1.33f
            };

            Console.WriteLine(num[2]);


            Console.ReadLine();
        }
    }
}
