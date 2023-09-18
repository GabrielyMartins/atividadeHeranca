using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace atividadeHeranca.classes
{
    internal class ContaEmpresarial:Conta
    { 
        public double TaxaAnuidade { get; set; }
        public double LimiteEmprestimo { get; set; }
        public double TotalEmprestimo { get; set; }

        public ContaEmpresarial(int numeroConta, string agencia, string titularConta, double saldoConta,
            double taxaAnuidade, double limiteEmprestimo)
           : base(numeroConta, agencia, titularConta, saldoConta)
        {
            this.TaxaAnuidade = taxaAnuidade;
            this.LimiteEmprestimo = limiteEmprestimo;
            TotalEmprestimo = 0;
        }
        public void RealizarEmprestimo(double valor)
        {
            if (valor <= LimiteEmprestimo - TotalEmprestimo)
            {
                SaldoConta += valor;
                TotalEmprestimo += valor;
                Console.WriteLine($"Empréstimo de R$ {valor} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Limite de empréstimo excedido");
            }
            
        }
        public override void Sacar(double valor)
        {
            if (valor <= 5000)
            {
                base.Sacar(valor);
            }
            else
            {
                if (valor + 5 <= SaldoConta)
                {
                    SaldoConta -= (valor + 5);
                    Console.WriteLine($"Saque de R$ {valor} realizado com sucesso (taxa de R$5,00 aplicada.");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente para realizar o saque");
                }
            }
        }

    }
}
