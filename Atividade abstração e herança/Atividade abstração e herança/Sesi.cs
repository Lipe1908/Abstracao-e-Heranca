using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_abstração_e_herança
{
 
        internal class Sesi : Escola
        {
            public override void CalcularMedia()
            {
                Console.WriteLine("Digite a primeira nota: ");
                double nota = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a segunda nota: ");
                double nota2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a terceira nota: ");
                double nota3 = Convert.ToDouble(Console.ReadLine());

                double media = nota + nota2 + nota3 / 3;

                if (media >= 7)
                {
                    Console.WriteLine("Aluno aprovado");
                }
                else if (media <= 5)
                {
                    Console.WriteLine("Aluno em recuperação");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado");
                }
            }
        }

    }

