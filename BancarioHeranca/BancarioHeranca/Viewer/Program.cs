using System;
using BancarioHeranca.Model; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancarioHeranca 
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente cc = new ContaCorrente(4000, 1, 2, 5000);

            ContaPoupanca cp = new ContaPoupanca(3000, 2, 4000);

            int op = 0, op2 = 0;

            double Valor = 0;  
            do
            {
                Console.WriteLine("1- Conta Corrente\n2- Conta Poupança\n0- SAIR");
                op = int.Parse(Console.ReadLine());
                
                switch (op)
                {
                    case 0:
                        Environment.Exit(1); 
                        break;
                        
                    case 1:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("1- Depositar\n2- Sacar\n3- Transferir\n4- Consultar Saldo\n5- Juros do Cheque Especial\n0- Voltar");
                            op2 = int.Parse(Console.ReadLine());
                            Console.Clear();

                            switch (op2)
                            {
                                
                                case 0:
                                    
                                    break;

                                case 1:
                                    Console.WriteLine("Digite o Valor do Depósito: ");
                                    Valor = double.Parse(Console.ReadLine());
                                    cc.Depositar(Valor);
                                    Console.WriteLine("\nO Valor Depositado foi: " + Valor);
                                    break; 
                                    
                                case 2:
                                    Console.WriteLine("Digite o valor do Saque: ");
                                    Valor = double.Parse(Console.ReadLine());
                                    cc.Sacar(Valor);
                                    Console.WriteLine("\nO Valor Sacado foi: " + Valor);

                                    break;

                                case 3:
                                    Conta conta = new Conta();

                                    Console.WriteLine("Qual conta será enviado? ");
                                    conta.setNumero(int.Parse(Console.ReadLine()));

                                    Console.WriteLine("\nDigite o Valor da Transferência");
                                    Valor = double.Parse(Console.ReadLine());

                                    cc.Transferir(Valor, conta);
                                    Console.WriteLine("\nO Valor Transferido foi: " + Valor);

                                    break;

                                case 4:
                                    Console.WriteLine(cc.ConsultarSaldo());
                                    break;

                                case 5:
                                    Console.WriteLine("Digite a Taxa de Juros: ");
                                    double taxa = double.Parse(Console.ReadLine());
                                    Console.WriteLine(cc.CalcularJuros(taxa));
                                    break;
                                    


                            }
                            Console.ReadKey();  
                        }
                        while (op2 != 0);

                        break;
                        
                    case 2:
                        do
                            
                        {
                            Console.Clear();
                            Console.WriteLine("1- Depositar\n2- Sacar\n3- Transferir\n4- Consultar Saldo\n5- Rendimento\n0- Voltar");
                            op2 = int.Parse(Console.ReadLine());
                            Console.Clear();

                            switch (op2)
                            {
                                
                                case 0:

                                    break;

                                case 1:
                                    Console.WriteLine("Digite o Valor do Depósito: ");
                                    Valor = double.Parse(Console.ReadLine());
                                    cp.Depositar(Valor);
                                    Console.WriteLine("\nO Valor Depositado foi: " + Valor);
                                    break;

                                case 2:
                                    Console.WriteLine("Digite o valor do Saque: ");
                                    Valor = double.Parse(Console.ReadLine());
                                    cp.Sacar(Valor);
                                    Console.WriteLine("O Valor Sacado foi: " + Valor);

                                    break;

                                case 3:
                                    Conta conta = new Conta();

                                    Console.WriteLine("Qual conta será enviado? ");
                                    conta.setNumero(int.Parse(Console.ReadLine()));

                                    Console.WriteLine("Digite o Valor da Transferência");
                                    Valor = double.Parse(Console.ReadLine());

                                    cp.Transferir(Valor, conta);
                                    Console.WriteLine("O Valor Transferido foi: " + Valor);

                                    break;

                                case 4:
                                    Console.WriteLine(cp.ConsultarSaldo());
                                    break;

                                case 5:
                                    Console.WriteLine("Rendimento: ");
                                    double taxa = double.Parse(Console.ReadLine());
                                    cp.CalcularRendimento(taxa);  
                                    break;
                                    

                            }
                            Console.ReadKey();
                        }
                        while (op2 != 0);

                        break;
                        

                }

            }
            while (op != 0);

        }
    }
}
