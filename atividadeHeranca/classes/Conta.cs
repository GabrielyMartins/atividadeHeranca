using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeHeranca.classes
{
    internal class Conta
    {
        public int NumeroConta { get; set; }
        public string Agencia { get; set; }
        public string TitularConta { get; set;}
        public double SaldoConta { get; set; }

        public Conta(int numeroConta, string agencia, string titularConta, double saldoConta)
        {
            this.NumeroConta = numeroConta;
            this.Agencia = agencia;
            this.TitularConta = titularConta;
            this.SaldoConta = saldoConta;
        }

        public virtual void Sacar(double valor)
        {
            if (valor <= SaldoConta)
            {
                SaldoConta -= valor;
                Console.WriteLine($"Saque de R$ {valor} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar saque");
            }
            
        }
        public void Deposito(double valor) 
        {
            if (valor >= 0)
            {
                SaldoConta += valor;
                Console.WriteLine($"Depósito de {valor} realizado com sucesso."); 
            }

            
        }
    }
}
