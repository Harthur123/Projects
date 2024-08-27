using MySolution.Commons.valueobjects;
using NetDevPack.Domain;

namespace MySolution.Domain.models
{
    public class ContaBancaria : Entity, IAggregateRoot
    {

        public string NumeroConta { get; }
        public string NomeUsuario { get; set; }
        private decimal Saldo { get; set; }

        


        public ContaBancaria(string numeroConta, string nomeUsuario, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            NomeUsuario = nomeUsuario;
            Saldo = saldoInicial;
        
        }

        public void Depositar(decimal valor)
        {
            if(valor > 0) {
                Saldo += valor;
                Console.WriteLine("Deposito de {valor:C}$ efetuado com sucesso");
            } else {
                Console.WriteLine("Não é possível efetuar o deposito. Valor invalido...");
            }
        }

        public void Sacar(decimal valor)
        {
            if(valor <= Saldo && valor > 0 ) {
                Saldo -= valor;
                Console.WriteLine("O Saque com valor {valor:C} foi efetuado com sucesso");
            } else {
                Console.WriteLine("Não foi possível efetuar o saque, digite outro valor");
            }
            
        }

        public void MostrarSaldo()
        {
            Console.WriteLine($"Saldo atual: {Saldo:C}");
        }
        


    }
    
}

   