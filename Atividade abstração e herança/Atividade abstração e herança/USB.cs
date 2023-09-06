using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_abstração_e_herança
{
    class USB : Midia
    {
        private int musicas;
        public int Musicas { get { return musicas; } set { musicas = value; } }

        private string armazenamento;
        public string Armazenamento { get {  return armazenamento; } set {  armazenamento = value; } }

        public void LerMusicas()
        { 
            Console.WriteLine("Digite o nome de 5 músicas com seus respectivos cantores: ");
            string musicas = Console.ReadLine();


            Console.WriteLine($" {musicas} ");
        }
    }
}
