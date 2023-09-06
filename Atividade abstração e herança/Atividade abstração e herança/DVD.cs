using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_abstração_e_herança
{
    class DVD : Midia
    {
        private int filmes;

        public int Filmes
        {
            get { return filmes; }
            set { filmes = value; }
        }

        public void VerFilmes()
            {

            Console.WriteLine("Digite dois filmes que gosta: ");
            string filmes = Console.ReadLine();


            Console.WriteLine("Digite o genero dos filmes: ");
            string genero = Console.ReadLine();

            Console.WriteLine("Digite seu ano de lançamento: ");
            string ano = Console.ReadLine();

            Console.WriteLine($" {filmes} {genero} {ano} ");

        }

    }
}
