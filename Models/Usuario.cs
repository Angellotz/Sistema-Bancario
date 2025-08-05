using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_bancario.Models
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public decimal Saldo = 0;

        private List<Transacao> extrato = new List<Transacao>();



        public void Depositar(decimal valor) //feito
        {
            Console.WriteLine("por favor insira o valor do depósito: ");


            if (decimal.TryParse(Console.ReadLine(), out decimal valorDeposito) && valorDeposito > 0)
            {
                Saldo += valorDeposito; // Atualiza o saldo
                extrato.Add(new Transacao
                {
                    Data = DateTime.Now,
                    Tipo = "Depósito",
                    Valor = valorDeposito
                });
                Console.WriteLine($"Depósito de {valorDeposito:C} realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Valor inválido. O depósito deve ser um número positivo.");
            }
        }


        public void Transferencia(decimal valor)
        {
            Console.WriteLine("Você escolheu Transferência.");

            Console.WriteLine("Digite o CPF do destinatário: ");
            string cpfDestinatario = Console.ReadLine()!;

            Console.WriteLine("Digite o valor da transferência: ");

            if (decimal.TryParse(Console.ReadLine(), out decimal valorTransferencia) && valorTransferencia > 0 && valorTransferencia <= Saldo)
            {
                Saldo -= valorTransferencia; // Atualiza o saldo
                extrato.Add(new Transacao
                {
                    Data = DateTime.Now,
                    Tipo = "Transferência",
                    Valor = valorTransferencia
                });
                Console.WriteLine($"Transferência de {valorTransferencia:C} para o CPF {cpfDestinatario} realizada com sucesso!");
            }
            else
            {
                Console.WriteLine("Valor inválido. A transferência deve ser um número positivo e não pode exceder o saldo.");
            }

        }

        public void Sacar(decimal valor) // feito
        {

            Console.WriteLine("Digite o Valor a ser sacado: ");

            if (decimal.TryParse(Console.ReadLine(), out decimal valorSaque) && valorSaque > 0 && valorSaque <= Saldo)
            {
                Saldo -= valorSaque; // Atualiza o saldo

                extrato.Add(new Transacao
                {
                    Data = DateTime.Now,
                    Tipo = "Saque",
                    Valor = valorSaque
                });

                Console.WriteLine($"Saque de {valorSaque:C} realizado com sucesso!");
            }

            else
            {

                Console.WriteLine("Saldo insuficiente ou valor inválido.");

            }


        }

        public void AbrirConta() // feito
        {
            Console.WriteLine("Você escolheu Abertura de Conta.");
            Console.WriteLine("Por favor, insira os seguintes dados para abertura de conta:");

            Console.WriteLine("Nome: ");
            Nome = Console.ReadLine()!;
            Console.WriteLine("CPF: ");
            CPF = Console.ReadLine()!;

            Console.WriteLine($"\nSeja bem-vindo ao banco Supra {Nome}! Sua conta foi aberta com sucesso!.");

        }

        public decimal ConsultarSaldo() // feito
        {
            Console.WriteLine("Consulta de Saldo.");

            Console.WriteLine($"Seu saldo atual é de: {Saldo:C}");

            return Saldo;
        }
        public void MostrarExtrato()
        {
          Console.WriteLine("\n--- EXTRATO BANCÁRIO ---");

            if (extrato.Count == 0)
            {
                Console.WriteLine("Nenhuma transação registrada.");
            }
            else
            {
                foreach (var transacao in extrato)
                {
                    Console.WriteLine(transacao);
                }

            }

          Console.WriteLine($"Saldo atual: {Saldo:C}");
          Console.WriteLine("-------------------------\n");
        }
        

    }
        
    
}