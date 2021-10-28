using System;
using System.Globalization;
namespace Cadastro_Conta_Bancaria {
    class Program {
        static void Main(string[] args) {

            Conta_Bancaria conta;

            Console.Write("Informe o numero da sua conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Nome do titular da conta: ");
            string titular = Console.ReadLine();

            Console.WriteLine("Havera deposito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            Console.WriteLine();

            if (resp == 's' || resp == 'S') {
                Console.Write("Entre com o valor do deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta_Bancaria(numero, titular, depositoInicial);
            }
            else {
                conta = new Conta_Bancaria(numero, titular);
            }

            Console.Write("Entre um valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre uma valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta);
        }
    }
}
