//DECOMPOSIÇÃO E ALGORITMOS:
//'Sistema de Multas por Excesso de Velocidade', você quebra em:

//Qual a velocidade do carro?
//Qual o limite da via?
//Calcular a diferença.
//Aplicar o multiplicador da multa.

// Se vel. = 120 (acima): multa gravíssima
// Se vel. = 80 (acima): multa grave
// Se vel. = 60 (acima): multa leve

// ENTRADA: Velocidade, 
// PROC.: Cálculos de diferença e multas,
// SAÍDA: Resultad final do programa (multado ou não multado)


namespace exemp_03 {
    public class Program {

        static void Main(String[] Args) {

            // ENTRADA
            Console.Write("\n Digite o limite da via (km/h): ");
            double limiteVia = double.Parse(Console.ReadLine()!);

            Console.Write("\n Digite a velocidade (km/h): ");
            double velocidadeVeiculo = double.Parse(Console.ReadLine()!); // Operador de coalescência nula!

            

            double excesso = velocidadeVeiculo - limiteVia;

            // PROC. e SAÍDA
            // SE(IF): Estrutura condicional!
            // Executa se A CONDIÇÃO FOR TRUE
            if (limiteVia >= 120)
            {
                if (velocidadeVeiculo > limiteVia)
                {
                    Console.WriteLine($"\n MULTADO! Você ultrapasou o limite da via em {excesso} km/h");
                    Console.WriteLine($"\n Sua velocidade foi de: {velocidadeVeiculo} km/h! \n [MULTA GRAVÍSSIMA]!! \n\n");

                }
                else
                {
                    Console.WriteLine("\n Velocidade dentro do permitido. Siga com segurança! \n\n");
                }
            }
            else if (limiteVia >= 80)
            {
                if (velocidadeVeiculo > limiteVia)
                {
                    Console.WriteLine($"\n MULTADO! Você ultrapasou o limite da via em {excesso} km/h");
                    Console.WriteLine($"\n Sua velocidade foi de: {velocidadeVeiculo} km/h! \n [MULTA GRAVE]!! \n\n");

                }
                else
                {
                    Console.WriteLine("\n Velocidade dentro do permitido. Siga com segurança! \n\n");
                }
            }
            else if (limiteVia >= 60)
            {
                if (velocidadeVeiculo > limiteVia)
                {
                    Console.WriteLine($"\n MULTADO! Você ultrapasou o limite da via em {excesso} km/h");
                    Console.WriteLine($"\n Sua velocidade foi de: {velocidadeVeiculo} km/h! \n [MULTA LEVE]!! \n\n");

                }
                else
                {
                    Console.WriteLine("\n Velocidade dentro do permitido. Siga com segurança! \n\n");
                }
            }
            // Para qualquer limite da via que seja menor que 60, ele vai passar (permitido)!!
            else {
                Console.WriteLine("\n OK! Vel dentro do permitido. Siga com segurança! \n\n");
            }

        }   

    }
}

