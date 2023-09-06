using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_abstração_e_herança
{
     class ContaBancaria
    {

        public string nConta;
        public string nAgencia;
        public string nomeBanco;

        private double saldo;

        public double Saldo
        {
            get
            {
                return this.saldo;
            }
            set
            {
                this.saldo = value;
            }
        }

        public void Sacar(double valorSaq)
        {
            if (valorSaq > Saldo)
            {
                Console.WriteLine("Você não possui saldo suficiente na sua conta bancária");
                Console.ReadKey();
            }
            else if (valorSaq < Saldo || valorSaq == Saldo)
            {
                double calcularValorSaldo = Saldo - valorSaq;
                Console.WriteLine("O valor do saque efetuado foi de " + valorSaq);
                Console.WriteLine("Então o valor de seu novo saldo ficou " + calcularValorSaldo);
                Console.ReadKey();
            }
        }
        public void Depositar(double valorDep)
        {
            this.saldo = valorDep;
        }
    }
}

