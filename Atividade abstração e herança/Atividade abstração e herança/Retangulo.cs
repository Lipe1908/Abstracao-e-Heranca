using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_abstração_e_herança
{
     class Retangulo : Formula
    {
        public override void CalcularArea()
        {
            Console.WriteLine("Digite a altura do Retangulo: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a largura do Retangulo");
            double largura = Convert.ToDouble(Console.ReadLine());


            double area = altura * largura;

            Console.WriteLine("A area do seu retangulo é de: " +  area);
        }
    }
}
