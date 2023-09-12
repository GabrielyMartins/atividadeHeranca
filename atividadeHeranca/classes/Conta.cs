using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeHeranca.classes
{
    internal class Conta
    {
        public int numeroConta { get; set; }
        public string agencia { get; set; }
        public string titularConta { get; set;}
        public double saldoConta { get; set; }

        public Conta(int numeroConta, string agencia, string titularConta, double saldoConta)
        {
            this.numeroConta = numeroConta;
            this.agencia = agencia;
            this.titularConta = titularConta;
            this.saldoConta = saldoConta;
        }

        public virtual void Sacar(double valor)
        {
            if (valor <= saldoConta)
            {
                saldoConta -= valor;
                Console.WriteLine($"Saque de R${valor} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar saque");
            }
            
        }
        public void Deposito(double valor) 
        {
            saldoConta += valor;
            Console.WriteLine($"Depósito de {valor} realizado com sucesso.");
        }
    }
}
