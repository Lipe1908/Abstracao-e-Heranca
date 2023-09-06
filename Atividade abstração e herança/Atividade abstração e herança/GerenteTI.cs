using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_abstração_e_herança
{
   class GerenteTI : Colaborador
    {
        public override void CalcularHorasExtras()
        {
            Console.WriteLine("Digite a quantidade de horas extras que você possui:");


            int hExtra = Convert.ToInt32(Console.ReadLine());

            if (hExtra > 100) 
            {
               int hExtra2 = hExtra / 2;

                int hExtra3 = hExtra2 * 200 + 500;

                int descanso = hExtra2 / 8;

                Console.WriteLine("Você receberá um total de horas extras de " + hExtra3 + " e descansará " + descanso); 
            }

            else
            {
                int hExtra2 = hExtra * 400;

                Console.WriteLine("VocÊ receberá um total de " + hExtra2 + " horas extras");
            }
        }
    }
}
