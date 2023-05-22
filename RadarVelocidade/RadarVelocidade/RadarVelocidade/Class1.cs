using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadarVelocidade
{
    /* Mostrar placa e Velocidade
     * Calcular o percentual acima da velocidade limite
     * Multas diferentes acima de 10, 20 e 50 porcento.
     */

    public class Class1
    {
        //Constantes fora da função principal Main()
        public const decimal limite = 100;

        //Função principal que é executada no console
        public static void Main()
        {
            decimal aleatorio = new Random().Next(90, 160); //Algoritimo para gerar numeros aleatorios dentro de um intervalo

            decimal Velocidade = aleatorio;
            decimal percentual = CalcularPercentual(Velocidade);
            decimal ValorMulta = 100;
            decimal MultaExtra = ValorMulta + (percentual * 5);
            
                MostrarVelocidade(Velocidade, "KPD-5734");
                AlertaPercentual(percentual);

            if (percentual >9)
            {
                //Caso passe acima de 10% do limite de velocidade
                if (percentual >= 10 && percentual < 20)
                {
                    GerarMulta(ValorMulta);
                }
                else if (percentual < 50)//Caso passe acima de 20%
                {
                    GerarMulta(MultaExtra);
                }
                else if (percentual > 50)
                {
                    GerarMulta(MultaExtra);
                    Console.WriteLine("Sua carteira foi suspensa e você perdeu o direito de Dirigir");
                }
            }
            else
            {
                Console.WriteLine("Dirija com atenção!");
            }
        }

        //Dividindo cada etapa em funções menores, que alimentam a funçao principal Main()
        public static decimal CalcularPercentual(decimal VelocidadeVeiculo)
        {
            decimal percentual = ((VelocidadeVeiculo / limite) -1) *100;
            //If para eliminar os numeros negativos
            if(percentual < 0)
            {
                percentual = 0;
            }
            return percentual;
        }

        public static void MostrarVelocidade(decimal velocidade, string placa)
        {
            Console.WriteLine("{1} - {0}hm/h", velocidade,placa);
        }

        public static void GerarMulta(decimal ValorMulta)
        {
            Console.WriteLine("Você foi multado em {0}", ValorMulta);
        }

        public static void AlertaPercentual(decimal percentual)
        {
            Console.WriteLine("Você Passou {0}% acima da velocidade", percentual);
        }
    }
}
