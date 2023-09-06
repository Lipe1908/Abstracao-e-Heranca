using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_abstração_e_herança
{
     class Bancario : Colaborador
    {
        public override void CalcularHorasExtras()
        {
            Console.WriteLine("Digite a quantidade de horas extras que você possui no mês:");

            int hExtra = Convert.ToInt32(Console.ReadLine());

            int hExtra2 = hExtra * 250;

            if (hExtra2 > 500)
            {
                double imposto = hExtra2 * 1.10;

                Console.WriteLine("O valor que receberá por suas horas extras é de:" + imposto);


            }

            else if (hExtra2 > 1000)
            {
                double imposto = hExtra2 * 1.15;

                Console.WriteLine("O valor que receberá por suas horas extras é de:" + imposto);


            }

            else {
                Console.WriteLine("O valor que receberá por suas horas extras é de:" + hExtra2);
                    }
        }
    }
}
