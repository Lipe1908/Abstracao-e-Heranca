using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_abstração_e_herança
{
     class Desenvolvedor : Colaborador
    {
        public override void CalcularHorasExtras()
        {
            Console.WriteLine("Digite sua modalidade de trabalho (A-Presencial B-Híbrido C-Remoto): ");
            string modalidade = Console.ReadLine();


            if (modalidade == "A" ) 
            {
                Console.WriteLine("Digite a quantidade de horas extras que você possui:");


                int hExtra = Convert.ToInt32(Console.ReadLine());

               int hExtra2 = hExtra * 100;

                Console.WriteLine("Sua quantidade de horas extras é de:" +  hExtra2);


            }

            else if (modalidade == "B")
            {
                Console.WriteLine("Digite a quantidade de horas extras que você possui:");


                int hExtra = Convert.ToInt32(Console.ReadLine());

                int hExtra2 = hExtra * 50;

                Console.WriteLine("Sua quantidade de horas extras é de:" + hExtra2);


            }

            else if (modalidade == "C") 
            {
                Console.WriteLine("O seu horario é flexivel ou seja vc escolhe suas horas de trabaho portanto não contempla horas extras");


            }

            else
            {
                Console.WriteLine("Você digitou uma opção inválida");
            }
        }
    }
}
