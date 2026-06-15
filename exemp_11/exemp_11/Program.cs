//Faça um programa que simule o motor de processamento de uma conta bancária digital.
//O sistema deve gerenciar o saldo do cliente através de métodos
//especializados que garantam a integridade dos dados.

//Entradas: O usuário deve informar o Saldo Inicial da conta.

//Métodos Obrigatórios: AplicarTaxa(saldo): Deve descontar R$ 10,00 fixos do saldo.
//OBS: O saldo original precisa ser alterado na memória, use a ferramenta apropriada.

//GerarProtocolo(protocolo): Deve gerar um número de protocolo aleatório (entre 1 e 100.000).
//Use a ferramenta apropriada para devolver esse valor ao programa principal.

//ExibirSaldo(saldo): Deve imprimir o saldo formatado como moeda (R$).
//Use a ferramenta que garante que esse método seja apenas para leitura
//e não altere o valor original por acidente.

//Saída de Dados:

//Exiba o número do protocolo gerado. Exiba o saldo final após a aplicação da taxa.

using System.Globalization;

namespace exemp_11 {
    class Program {

        static void Main(string[] args) {

            CultureInfo br = new CultureInfo("pt-BR");

            int protocolo; // Será preenchido pelo out

            Console.WriteLine("\n ================================= ");
            Console.Write(" ======== UNIFEL BANK 1.0 ======== ");
            Console.WriteLine("\n ================================= \n");


            Console.Write(" Informe o saldo inicial da conta (R$): ");
            double saldo = double.Parse(Console.ReadLine()!, br);

            GerarProtocolo(out protocolo);

            AplicarTaxa(ref saldo);

            ExibirRelatorio(protocolo, in saldo);

        }


        static void GerarProtocolo(out int protoc) { 
            protoc = new Random().Next(1000, 10000);
        }

        static void AplicarTaxa(ref double saldo) {
            const double TAXA = 10.00;

            //saldo = saldo - TAXA;
            saldo -= TAXA;
        }

        static void ExibirRelatorio(int numProtocolo, in double saldo) {

            string saudeFinanceira = saldo >= 500 ? "SAUDÁVEL" : "DELICADA";

            Console.WriteLine("\n ================================= ");

            Console.WriteLine($"\n  PROTOCOLO: {numProtocolo} ");
            Console.WriteLine($"  SALDO ATUAL: {saldo.ToString("C", new CultureInfo("pt-BR"))}");
            Console.WriteLine($"  SAÚDE DA CONTA: {saudeFinanceira}");

            Console.WriteLine("\n ================================= \n\n");

        }

    }
}