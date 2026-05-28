//Faça um programa que calcule o lucro líquido de uma operação de
//transporte para uma transportadora.

//Regras de Negócio: O sistema deve receber do usuário o valor total do frete e o
//custo do Diesel consumido na viagem e depois calcular o lucro.

//Saída de Dados: Exiba o resultado formatado como moeda (R$).

//Condição Especial: Caso o lucro seja negativo (menor que zero),
//o programa deve exibir o valor como "Prejuízo" e imprimir o alerta:
//"ALERTA: Prejuízo detectado no fechamento desta carga!".

// O TIPO IDEAL DESSE É: DECIMAL!!

using System.Globalization;

namespace exemp_04 {
    class Program {
        static void Main(string[] args) {

            CultureInfo br = new CultureInfo("pt-BR");

            // Entrada
            Console.WriteLine("\n ---- SISTEMA DE FRETE UNIFEL 1.0 ---- ");
            Console.Write("\n Qual foi o valor do frete (R$)? ");
            double valorFrete = double.Parse(Console.ReadLine()!.Replace(".",",")); // 1500.99 ou 1500,99

            Console.Write("\n Qual foi o do Dielsel (R$)? ");
            double custoDiesel = double.Parse(Console.ReadLine()!.Replace(".", ","));


            // Processamento
            double lucroLiquido = valorFrete - custoDiesel;


            // Saída
            if (lucroLiquido > 0) {
                // C é de currency (moeda, monetário)
                Console.WriteLine($"NEGÓCIO LUCRATIVO: {valorFrete.ToString("C",br)} ||\n A operação gerou lucro de: {lucroLiquido.ToString("C", br)}! \n\n");
            }
            else if (lucroLiquido == 0) {
                Console.WriteLine($"NEGÓCIO SEM LUCRO: {valorFrete.ToString("C", br)} ||\n A operação não gerou lucro: {lucroLiquido.ToString("C", br)}! \n\n");
            }
            else { 
            Console.WriteLine($"\n ALERTA: Prejuízo detectado no fechamento desta carga!\n {lucroLiquido.ToString("C", br)} \n\n");
            }
        }
    }
}