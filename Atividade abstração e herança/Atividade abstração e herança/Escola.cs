using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_abstração_e_herança
{
    abstract class Escola
    {
        public abstract void CalcularMedia();
    
        public void DescobrirNome()
        {
            Console.WriteLine("Digite o nome da sua escola: ");
            string escola = Console.ReadLine().ToUpper();

            Console.WriteLine("Digite o nome da sua cidade: ");
            string cidade = Console.ReadLine();

            Console.WriteLine("Digite o nome do seu estado: ");
            string estado = Console.ReadLine();

            if (escola == "SESISENAI")
            {
                Console.WriteLine("Aluno Sesi Senai");
            }
            else
            {
                Console.WriteLine("Nao estuda na escola Senai/Sesi, estuda: " + escola);
                Console.WriteLine("Mora na cidade de: " + cidade);
            }
        }
    }
}
