
using System;
using sistema_bancario.Models;



Console.WriteLine("Bem-vindo ao Sistema Bancário!");

Console.WriteLine("Digite o tipo de serviço que deseja: ");

Usuario u = new (); // Criação de um usuário com saldo inicial de 0



bool menu = true;
while(menu)
{
    Console.WriteLine("[1] - Abertura de Conta");
    Console.WriteLine("[2] - Depósito");
    Console.WriteLine("[3] - Consulta de Saldo");
    Console.WriteLine("[4] - Saque"); 
    Console.WriteLine("[5] - Transferência");
    Console.WriteLine("[6] - Extrato Bancário");
    Console.WriteLine("[0] - Sair");
    
     

    if (int.TryParse(Console.ReadLine(), out int opcao))
    {
        switch (opcao)
        {
            case 1:

                u.AbrirConta();

                Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                Console.Clear();
                break;
           
            case 2:

                u.Depositar(0); // Chama o método Depositar, que já contém a lógica de entrada de valor

                
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                Console.Clear();
                break;
            
            case 3:

                u.ConsultarSaldo(); // Chama o método ConsultarSaldo, que já contém a lógica de exibição do saldo
                

                Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                Console.Clear();
                break;
           
            case 4:

                u.Sacar(0); // Chama o método Sacar, que já contém a lógica de entrada de valor

                Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                Console.Clear();
                break;
           
            case 5:
                
                u.Transferencia(0); // Chama o método Transferencia, que já contém a lógica de entrada de valor

                Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                Console.Clear();
                break;

            case 6:

                u.MostrarExtrato(); // Chama o método GerarExtrato, que já contém a lógica de exibição do extrato
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();  
                Console.Clear();
                break;
                

          
            case 0:
                Console.WriteLine("Você escolheu Sair. Obrigado por usar nossos serviços!");
                menu = false;
                break;

            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }
    }
    else
    {
        Console.WriteLine("opcão inválida.");
    }
}
