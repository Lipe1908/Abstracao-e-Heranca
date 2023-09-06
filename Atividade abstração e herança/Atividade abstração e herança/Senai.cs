using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_abstração_e_herança
{
    internal class Senai : Escola
    {
        public override void CalcularMedia()
        {
            Console.WriteLine("Digite as 4 notas do aluno de 0 a 100");

            Console.WriteLine("Digite a 1 nota");
            double nota = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a 2 nota");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a 3 nota");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a 4 nota");
            double nota4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a frequencia do aluno");
            double frequencia = Convert.ToDouble(Console.ReadLine());

            double media = nota + nota2 + nota3 + nota4;

            if (frequencia >= 90 && media >= 70)
            {
                Console.WriteLine("Parabens, voce foi aprovado no curso tecnico senai");
            }
            else if (frequencia >= 90 && nota < 70)
            {
                Console.WriteLine("Voce precisa fazer trabalho de recuperaçao");
            }
            else if (frequencia < 90 && nota >= 70)
            {
                Console.WriteLine("Aluno reprovado por falta");
            }
            else
            {
                Console.WriteLine("Aluno reprovado");
            }

        }
    
    }
}
