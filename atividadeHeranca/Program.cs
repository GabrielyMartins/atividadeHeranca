
using atividadeHeranca.classes;
using System.Transactions;
using System.Xml;

public class Program
{
    static void Main(string[] args)
    {
        int Nconta = 22;
        string agencia = "Ji-Paraná";

        while (true)
        {

            Console.WriteLine("Digite \n " +
                "1 - Para conta normal, \n " +
                "2 - Para conta estudante e \n" +
                "3 - Para conta empresarial");
            int opcao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o nome do titular");
            string nomeTitular = Console.ReadLine();


            if (opcao == 1)
            {
                Conta c = new Conta(Nconta, agencia, nomeTitular, 0);
                Nconta += 1;
                while (true)
                {
                    Console.WriteLine("1 para depositar e 2 para sacar");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao == 1)
                    {
                        Console.WriteLine("Digite o valor");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        c.Deposito(valor);
                        Console.WriteLine($"Novo saldo {c.SaldoConta}");
                    }
                    else if (opcao == 2)
                    {

                        Console.WriteLine("Digite o valor");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        c.Sacar(valor);
                        Console.WriteLine($"Novo saldo {c.SaldoConta}");
                    }
                    else if (opcao == 3)
                    {
                        Console.Clear();
                        break;
                    }
                }
            }

            else if (opcao == 2)
            {
                Console.WriteLine("Digite o CPF do estudante");
                string cpf = Console.ReadLine();

                Console.WriteLine("Informe a instituição");
                string instituicao = Console.ReadLine();

                ContaEstudante ce = new ContaEstudante(100, cpf, instituicao, Nconta, 0, nomeTitular, agencia);
                Nconta += 1;
                while (true)
                {
                    Console.WriteLine("1 para depositar e 2 para sacar");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao == 1)
                    {
                        Console.WriteLine("Digite o valor");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        ce.Deposito(valor);
                        Console.WriteLine($"Novo saldo {ce.SaldoConta}");
                    }
                    else if (opcao == 2)
                    {

                        Console.WriteLine("Digite o valor");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        ce.Sacar(valor);
                        Console.WriteLine($"Novo saldo {ce.SaldoConta}");
                    }
                    else if (opcao == 3)
                    {
                        Console.Clear();
                        break;
                    }
                }
            }
            else if (opcao == 3)
            {
                ContaEmpresarial cempresa = new ContaEmpresarial(Nconta, agencia, nomeTitular, 0, 10, 1000);
                Nconta += 1;
                while (true)
                {
                    Console.WriteLine("1 para depositar, 2 para sacar e 3 para fazer emprestimo e 4 para sair");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao == 1)
                    {
                        Console.WriteLine("Digite o valor");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        cempresa.Deposito(valor);
                        Console.WriteLine($"Novo saldo {cempresa.SaldoConta}");
                    }
                    else if (opcao == 2)
                    {

                        Console.WriteLine("Digite o valor o valor");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        cempresa.Sacar(valor);
                        Console.WriteLine($"Novo saldo {cempresa.SaldoConta}");
                    }
                    else if (opcao == 3)
                    {
                        Console.WriteLine("Digite o valor do empréstimo");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        cempresa.RealizarEmprestimo(valor);
                        Console.WriteLine($"Novo saldo {cempresa.SaldoConta}");
                    }
                    else if (opcao == 4)
                    {
                        Console.Clear();
                        break;
                    }
                }

            }
            else if (opcao == 4) 
            {
                break;
            }
        }
    }

    
}