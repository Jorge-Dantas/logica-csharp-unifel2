//Simulador de Despacho de Carga Perigosa
//O Cenário: Um caminhão transportando combustível só pode ser
//liberado se passar por uma série de verificações de segurança, peso (5T + tolerância 5%)
//e documentação.

using System.Globalization;

namespace exemp_08 {
    public class Program {


        static void Main(String[] Args) {

            CultureInfo br = new CultureInfo("pt-BR");

            Console.WriteLine();

            // ENTRADA
            Console.Write(" Peso total do veículo (KG): ");
            double pesoCarga = double.Parse(Console.ReadLine()!, br);

            Console.Write(" O motorista tem MOPP? (s/n) "); // "S" ou "N" -> "s" ou "n"
            bool temMOPP = Console.ReadLine()!.ToLower() == "s";

            Console.Write(" O veículo tem aprovação de inspeção técnica? (s/n) ");
            bool temInspecao = Console.ReadLine()!.ToLower() == "s";

            Console.Write(" O motorista está em período de descanso obrigatório? (s/n) ");
            bool estaEmDescanso = Console.ReadLine()!.ToLower() == "s";



            // PROCESSAMENTO e SAÍDA
            if (!temInspecao) {
                Console.WriteLine("\n ❌ [BLOQUEADO]: Veículo reprovado na inspeção técnica! \n");
                return;
            }

            if (estaEmDescanso) {
                Console.WriteLine("\n ❌ [BLOQUEADO]: O motorista deve cumprir o período obrigatório de descanso! \n");
                return;
            }

            if ((pesoCarga <= 5000 || pesoCarga <= 5250) && temMOPP) {

                Console.WriteLine("\n --- ✅  DESPACHO AUTORIZADO! --- ");

                // Alerta secundário (tolerância de 5%)
                if (pesoCarga > 5000) {
                    Console.WriteLine("\n ⚠️ NOTA: Veículo aprovado sob 5% de tolerência!! \n");
                }
            }
            else {
                // Se cair aqui é pq o peso excedeu os 5% OU não tem MOPP
                Console.WriteLine("\n ❌ [DESPACHO NEGADO]:");

                if (!temMOPP) {
                    Console.WriteLine(" ❌ [MOTORISTA sem MOPP] \n");
                }

                if (pesoCarga > 5250) {
                    Console.WriteLine(" ❌ [PESO DA CARGA EXCEDEU O LIMITE TOLERÁVEL (5%)] \n");
                }
            }

            Console.WriteLine("\n PROGRAMA FINALIZADO! 😉🫡\n\n");

        }

    }
}