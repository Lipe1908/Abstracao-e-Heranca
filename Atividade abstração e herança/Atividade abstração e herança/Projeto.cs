using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_abstração_e_herança
{
     class Projeto : Estudante
    {
        string DataDoProjeto { get; set; }  

        public void EscolherProfissao()
        {
            Console.WriteLine("Qual profissão gostaria de escolher:");
            string profissao = Console.ReadLine();

            Console.WriteLine("Qual faculdade gostaria de cursar:");
            string faculdade = Console.ReadLine();

            Console.WriteLine("Cite 3 coisas que gostaria de estar fazendo daqui 5 anos:");
            string ambicoes = Console.ReadLine();

            Console.WriteLine("Quais são as suas expectativas quando finalizar o ensino médio?");
            string expectativas = Console.ReadLine();

            Console.WriteLine("Cite 3 características de quais são os seus projetos para o futuro?");
            string caracteristicas = Console.ReadLine();

            Console.WriteLine($"Seu nome é {Nome} Sua idade é {Idade} Sua cidade {Cidade} Seu estado {Estado} Qual profissão gostaria de escolher: {profissao}  Qual faculdade gostaria de cursar: {faculdade} Cite 3 coisas que gostaria de estar fazendo daqui 5 anos: {ambicoes} Quais são as suas expectativas quando finalizar o ensino médio? {expectativas} Cite 3 características de quais são os seus projetos para o futuro? {caracteristicas} ");


        }
    }
}
