//Inteligência em Balança Rodoviária
//Faça um programa que simule a lógica de uma balança inteligente em uma rodovia,
//considerando a margem de tolerância legal.

//Regras de Negócio: O sistema deve receber o peso atual da carga (kg)
//e o limite de peso permitido para aquela via.

//Cálculo de Tolerância: Calcule o limite crítico somando 5% ao limite permitido.

//Saída de Dados (Lógica):

//Se o peso for menor ou igual ao limite: Exiba "Peso dentro do limite permitido".

//Se o peso for maior que o limite, mas menor ou igual à tolerância (5%):
//Exiba "ADVERTÊNCIA: Peso acima do limite, mas dentro da tolerância".

//Se o peso for maior que a tolerância:
//Exiba "BLOQUEADO: Excesso de peso detectado! Realize o transbordo".


using System.Globalization;

namespace exemp_06 {
    public class Program {

        static void Main(String[] Args) {

            // ENTRADA
            Console.Write("\n Qual o limite de peso da via (KG)? ");
            double limiteKg = double.Parse(Console.ReadLine()!);

            Console.Write("\n Digite o peso da carga (KG): ");
            double pesoCarga = double.Parse(Console.ReadLine()!);

            // PROCESSAMENTO
            double limiteTolerancia = limiteKg * 1.05; // 0.05 = 5%

            // SAÍDA
            if (pesoCarga <= limiteKg) {
                Console.WriteLine("\n [AUTORIZADO]: Peso dentro do limite permitido ✅ \n\n");
            }
            else if (pesoCarga <= limiteTolerancia) {
                Console.WriteLine("\n ⚠️ ADVERTÊNCIA: Peso acima do limite, mas dentro da tolerância de 5% \n\n");
            }
            else {
                Console.WriteLine("\n ❌ BLOQUEADO: Excesso de peso detectado! Realize o transbordo \n\n");
            }
        }


    }
}