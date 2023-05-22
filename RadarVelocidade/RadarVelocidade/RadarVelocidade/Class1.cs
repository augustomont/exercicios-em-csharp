using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadarVelocidade
{
    public class Class1
    {
        public const decimal limite = 100;
        public static void Main()
        {
            MostrarVelocidade(100, "KPD-5734");
            Console.WriteLine(CalcularPercentual(170));
        }

        public static decimal CalcularPercentual(decimal VelocidadeVeiculo)
        {
            decimal percentual = ((VelocidadeVeiculo / limite) -1) *100;
            return percentual;
        }

        public static void MostrarVelocidade(int velocidade, string placa)
        {
            Console.WriteLine("{1} - {0}hm/h", velocidade,placa);
        }
    }
}
