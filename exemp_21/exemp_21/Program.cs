namespace exemp_21 {
    public class Program {
        static void Main(String[] Args) {

            // Aula de incremento!!
            Console.WriteLine("\n  Aula de incremento! \n\n");

            int numero = 5;
            Console.WriteLine($"  " +
                $"i = {numero}");          // 5

            Console.WriteLine($"  numero++ = {numero++}");      // 6 (Emanuel) -> (5).

            Console.WriteLine($"  numero = {numero}");          // 6 (Emanuel) -> (6).

            Console.WriteLine($"  ++numero = {++numero}");      // 7 (Emanuel) -> (7)


            //i + 2; // ERRO!
            //i+4;    // ERRO!

            numero += 2; // => numero = numero + 2;
            numero += 4;  // => numero = numero + 4;


            //variavel++ => USA O VALOR DA VARIÁVEL ANTES, E INCREMENTA DEPOIS!!
            //++variavel => INCREMENTA ANTES, E USA O VALOR DEPOIS!!



            // WHILE TRADICIONAL!!
            //int tentativas = 10; // CONTADOR!!

            //Console.WriteLine("\n");

            //while (tentativas < 4) {
            //    // Código que vai rodar enquanto o while for verdadeiro
            //    Console.WriteLine($"\n Tentativa número {tentativas} ");
            //    tentativas++; // INCREMENTANDO O CONTADOR A CADA ITERAÇÃO
            //}


            // DO.. WHILE !!
            //string resposta = "";
            //do {
            //    Console.Write($"\n Deseja continuar?? (S/N) "); // "S" ou "s"
            //    resposta = Console.ReadLine()!.ToUpper();
            //} while (resposta != "N" && resposta != "n");


            Console.WriteLine("\n \n");


            // FOR
            //for (inicio; fim; incremento) { 
            //}
            for (int i = 1 ; i <= 10; i++) {
                Console.WriteLine($" 5 x {i} = {5 * i} ");
            }

            Console.WriteLine("\n \n");


            // Foreach
            string nomeCurso = " Lógica de programação com C# Unifel 2026.5 \n";
            foreach (char letra in nomeCurso) {
                Console.Write(letra);
            }

            Console.WriteLine("\n \n");


        }
    }
}