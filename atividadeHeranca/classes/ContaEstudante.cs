using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeHeranca.classes
{
    internal class ContaEstudante:Conta
    {
        public double limiteChequeEspecial { get; set; }
        public string cpf { get; set; }
        public string nomeInstituicao { get; set; }

        public ContaEstudante(int numeroConta, string agencia, string titularConta, double saldoConta, 
            double limiteChequeEspecial, string cpf, string nomeInstituicao)
           : base(numeroConta, agencia, titularConta, saldoConta)
        {
            this.limiteChequeEspecial = limiteChequeEspecial;
            this.cpf = cpf;
            this.nomeInstituicao = nomeInstituicao;
        }
        public override void Sacar(double valor)
        {
            if(valor <= saldoConta + limiteChequeEspecial) 
            {
                saldoConta -= valor;
                Console.WriteLine($"Saque de R${valor} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Limite de cheque expecial excedido.");
            }


           
        }
       


    }
}
