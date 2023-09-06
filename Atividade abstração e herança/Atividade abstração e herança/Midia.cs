using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_abstração_e_herança
{
    public class Midia
    {
        private int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private int preco;
        public int Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public void ImprimirDados()
        {
            Console.WriteLine("Digite o nome de seu cantor favorito: ");
            string cantor = Console.ReadLine();

            Console.WriteLine("Digite o nome de sua música: ");
            string musica = Console.ReadLine();

            Console.WriteLine("Digite seu ano de lançamento: ");
            string ano = Console.ReadLine();

            Console.WriteLine($" {cantor} { musica } {ano} ");

        }
    }
}
