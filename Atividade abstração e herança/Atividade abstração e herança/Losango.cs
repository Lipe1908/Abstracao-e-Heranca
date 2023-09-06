using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_abstração_e_herança
{
    class Losango : Formula
    {
        public override void CalcularArea()
        {
            Console.WriteLine("Digite a altura do losango: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a largura do Losango");
            double largura = Convert.ToDouble(Console.ReadLine());


            double area = (altura * largura) / 2;

            Console.WriteLine("A area do seu Lonsango é de: " +  area);
        }
    }
}
