using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeHeranca.classes
{
    internal class ContaEstudante:Conta
    {
        public double LimiteChequeEspecial { get; set; }
        public string Cpf { get; set; }
        public string NomeInstituicao { get; set; }

        public ContaEstudante(int numeroConta, string agencia, string titularConta, double saldoConta, 
            double limiteChequeEspecial, string cpf, string nomeInstituicao)
           : base(numeroConta, agencia, titularConta, saldoConta)
        {
            this.LimiteChequeEspecial = limiteChequeEspecial;
            this.Cpf = cpf;
            this.NomeInstituicao = nomeInstituicao;
        }
        public override void Sacar(double valor)
        {
            if(valor <= SaldoConta + LimiteChequeEspecial) 
            {
                SaldoConta -= valor;
                Console.WriteLine($"Saque de R${valor} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Limite de cheque expecial excedido.");
            }


           
        }
       


    }
}
