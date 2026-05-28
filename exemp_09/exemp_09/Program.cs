//Central de Inteligência Logística

//Faça um programa que funcione como um painel de controle para um gestor de frota.
//O programa deve exibir um menu inicial e realizar cálculos baseados na escolha do usuário.

//Regras de Negócio: O programa deve exibir o seguinte menu:
//1 - Calcular Autonomia Crítica
//2 - Simular Pedágio com Desconto de Frota
//3 - Sair

//Lógica das Opções:

//Se escolher 1(Autonomia): Receba a capacidade do tanque (L) e o consumo médio (km/L).
//Calcule a Autonomia Total.

//Regra Composta: Se a autonomia for menor que 200km, exiba
//"PERIGO: Rota impraticável! Abastecimento obrigatório".

//Se estiver entre 200km e 600km, exiba "ATENÇÃO: Rota de médio risco".
//Se for maior que 600km, exiba "SEGURO: Autonomia está excelente".



//Se escolher 2 (Pedágio): Receba o valor base do pedágio e a quantidade de eixos do caminhão.
//Calcule o Custo Bruto.

//Regra de Desconto: Se o Custo Bruto for maior que R$ 150,00, aplique 10% de desconto.

//Caso contrário, não há desconto.

//Exiba o valor final que será debitado da Tag de pedágio.

//Se escolher 3: Exiba "Saindo do sistema...".

//Caso digite qualquer outro número ou letra: Exiba "Opção Inválida!".

using System.Globalization;

namespace exemp_09 {
    public class Program {

        static void Main(String[] Args) {

            CultureInfo br = new CultureInfo("pt-BR");

            Console.WriteLine("\n 1 - Calcular Autonomia Crítica ");
            Console.WriteLine(" 2 - Simular Pedágio com Desconto de Frota ");
            Console.WriteLine(" 3 - Sair");
            Console.Write("\n Escolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine()!);

            if (opcao == 1) {

                Console.Write(" Digite a capacidade total do tanque (L): ");
                double capacidade = double.Parse(Console.ReadLine()!);

                Console.Write(" Digite o consumo médio (Km/L): ");
                double consumoMedio = double.Parse(Console.ReadLine()!);

                double autonomiaTotal = capacidade * consumoMedio;
                Console.Write($" Autonomia total estimada: {autonomiaTotal} \n");

                if (autonomiaTotal < 200) {
                    Console.WriteLine(" 🚩PERIGO: Rota impraticável! Abastecimento obrigatório ");
                }
                else if (autonomiaTotal <= 600) {
                    Console.WriteLine(" ⚠️ATENÇÃO: Rota de médio risco ");
                }
                else {
                    Console.WriteLine(" ✅ SEGURO: Autonomia está excelente ");
                }

            }


            else if (opcao == 2) {
                Console.Write(" Valor base do pedágio (R$): ");
                double valorBase = double.Parse(Console.ReadLine()!, br);

                Console.Write(" Quantidade de eixos do veículo: ");
                int eixos = int.Parse(Console.ReadLine()!, br);

                double custoBruto = valorBase * eixos;
                double valorFinal = custoBruto * 0.90; // Fica com 90%, i.e., 10% desconto!


                if (custoBruto > 150.00) {
                    Console.WriteLine($"\n Valor Original (Sem Desconto): {custoBruto.ToString("C", br)} \n");
                    Console.WriteLine($"\n Desconto Aplicado ✅ Valor final: {valorFinal.ToString("C", br)} \n");
                }
                else {
                    Console.WriteLine($"\n Valor final: {valorFinal.ToString("C", br)} (sem desconto) \n");
                }
            }




            else if (opcao == 3) {
                Console.WriteLine("\n Encerrando o sistema... Boa viagem!! \n");
                return; // Totalmente opcional
            }
            else {
                Console.WriteLine("\n Opção Inválida! Reinicie o programa\n");
            }


        }

    }
}


