// Representar um relatório de venda:
// 3 vendedores
// Cada vendedor tem 2 metas de produtos
namespace exemp_22 {
    public class Program {
        static void Main(String[] Args) {

            // Matriz (linhas x colunas)
            
            // Vendedor (linhas)!
            for (int vendedor = 1; vendedor <= 3; vendedor++) {

                Console.WriteLine($"\n\n Vendedor #{vendedor}:");
                
                // Produto (colunas)
                for (int produto = 1; produto <= 2; produto++) {
                    Console.WriteLine($" -> Verificando metas do produto #{produto}:");
                }

            }


        }
    }
}