using Microsoft.VisualBasic;
using MySolution.Commons.valueobjects;
using NetDevPack.Domain;

namespace MySolution.Domain.models
{

        public class Banco : Entity, IAggregateRoot
        {
            public static void main(String[] args) {

                var conta  = new ContaBancaria("17569347", "Adailson Souza", 450.75m);

                while (true)
            {
                
                Console.WriteLine("\n--- Banco Vale ---");
                Console.Write("Escolha uma opção: ");
                Console.WriteLine("1. Consultar Saldo");
                Console.WriteLine("2. Depositar");
                Console.WriteLine("3. Sacar");
                Console.WriteLine("4. Sair");
                
                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        conta.MostrarSaldo();
                        break;

                    case "2":
                        Console.Write("Digite o valor do depósito: ");
                        var deposito = Convert.ToDecimal(Console.ReadLine());
                        conta.Depositar(deposito);
                        break;

                    case "3":
                        Console.Write("Digite o valor do saque: ");
                        var saque = Convert.ToDecimal(Console.ReadLine());
                        conta.Sacar(saque);
                        break;

                    case "4":
                        Console.WriteLine("Saindo do sistema...");
                        return;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }

            }
        }

















}




