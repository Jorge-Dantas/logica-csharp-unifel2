// Sistema que simula o processamento de 10 pedidos
// Pedido com valor zerado deve ser IGNORADO
// Tentativas de fraude devem ser BLOQUEADAS, o sistema deve PARAR!

namespace exemp_22 {
    public class Program {
        static void Main(String[] Args) {


            for (int i = 1; i <= 10; i++) {

                // Supondo que o pedido 3 tem valor zerado...
                if (i == 3) {
                    Console.WriteLine($" -> Pedido Nº{i}: Valor zerado (pulando)... \n");
                    continue; // PULA APENAS ESSA RODADA (i == 3)
                }

                // Supondo que o pedido 7 teve suspeita de FRAUDE
                if (i == 7) {
                    Console.WriteLine($" -> Pedido Nº{i}: FRAUDE DETECTADA, BLOQUEANDO SISTEMA... \n");
                    break; // SAI DO LOOP INTEIRO
                }

                Console.WriteLine($"\n Processando pedido Nº{i} .. Sucesso!! \n");

            }

            Console.WriteLine("\n Lote de pedidos processado com sucesso!! \n\n");


        }
    }
}
