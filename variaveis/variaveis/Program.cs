using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace variaveis
{
    internal class Program
    {
        // float - Numeros decimais. Variações => Double / Decimal
        // int -  numeros inteiros
        // bool - Booleanos
        // string - "string"
        // char - 'a' => é quando armazena apenas um character

        //A-Z => 0-9 => _

        static void Main(string[] args)
        {
            int segundaGuerra = 1939;
            float altura = 1.71f; //float precisa por o f no final do numero
            string nome = "Augusto";
            bool segundaGuerra_aconteceu = true;

            altura = 1.74f;
            nome = "Monteiro";

            Console.WriteLine(segundaGuerra);
            Console.WriteLine(altura);
            Console.WriteLine(nome);
            Console.WriteLine(segundaGuerra_aconteceu);

            // Tamebem é possivel criar uma variavel usando var

            var alturaV = 1.71f;
            var nomeV = "Guto";

            Console.WriteLine(alturaV);
            Console.WriteLine(nomeV);

            // Para variaveis dinamicas, que podem mudar o tipo depois

            dynamic alturaD = 1.71f;
            alturaD = "1.71";

            Console.WriteLine(alturaD);

            Console.ReadLine();
        }
    }
}
