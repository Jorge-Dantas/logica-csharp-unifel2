
// EX. DE USO DE NAMESPACE NO MUNDO REAL
// nampespace Comercial{
//  public class CadastrarUsuario {

//  }
// }

// nampespace Marketing{
//  public class CadastrarUsuario {

//  }
// }

// Moderno, não precisa declarar classe e etc, C# faz por você!
//Console.WriteLine("Hello, World!");


// Modo antigo (na mão, aprende fazendo):
namespace exemp_01 {
    public class Program {
        static void Main(String[] Args) {

            // TIPOS DE VALOR (Nomes das variáveis moram na STACK, valores no HEAP)
            sbyte escala = -10;              // 1 byte
            byte nivelEnergia = 255;         // 1 byte
            short estoqueMinimo = 30000;     // 2 bytes
            int populacaoCidade = 2000000;   // 4 bytes
            long estrelasGalaxia = 1000000000000L; // 8 bytes (Sufixo L obrigatório)

            float aceleracao = 9.8f;         // 4 bytes (Sufixo f obrigatório)
            double latitude = -23.5505;      // 8 bytes (Padrão para decimais)
            decimal saldoBancario = 1500.50m;// 16 bytes (Sufixo m obrigatório para dinheiro)

            bool estaLigado = false;          // 1 byte
            char inicial = 'J';              // 2 bytes (Aspas simples '')

            // TIPOS DE REFERÊNCIA (Texto no Heap, Endereço na Stack)
            string nomeCurso = "Lógica C# UNIFEL"; // Aspas duplas ""





            //Sem inicializar (não faça isso)
            double pesoCarga;
            // Colocando valor depois de criada
            pesoCarga = 100.50;

            // Criando e inicializando variáveis
            string aluno = "Lais";
            bool estaAtivo = true;

            //Classe.Metodo(abacate, números, listas)
            // string = texto/letras
            Console.WriteLine("\n Segunda aula de C#! \n\n");

            // CONCATENAÇÃO (+)
            // Isso daria erro se a variável não tivesse inicializada
            Console.WriteLine("\n CONCATENÇÃO\n O peso da carga é: " + pesoCarga + " \n\n");

            // INTERPOLAÇÃO DE STRING
            Console.WriteLine($"\n INTERPOLAÇÃO\n O peso da carga é: {pesoCarga} \n\n");


            Console.WriteLine($"\n NOME DO ALUNO: {aluno}\n" +
                $" ALUNO ATIVO? {estaAtivo} \n\n");


            // TIPOS SIMPLES (INT, BOOL, FLOAT, DOUBLE) não podem ser NULOS por padrão
            //float mediaAluno = null;  -> ERRO
            Console.WriteLine(" -----------------");
            int? numeroCasa = null;
            Console.WriteLine($"\n Número da casa: {numeroCasa} \n\n"); // Mostra "nada" (null)

            Console.WriteLine("\n\n ----------------- ");
            Console.WriteLine($"\n A IMPRECISÃO DO DOUBLE (PONTO FLUTUANTE)!! \n ");

            Console.Write(" 0.1 + 0.2 É IGUAL A 0.3??? ");
            Console.WriteLine(0.1 + 0.2 == 0.3); // FALSE

            double numA = 0.1 + 0.2;
            double numB = 0.3;

            Console.WriteLine("\n ----------------- ");
            Console.WriteLine($"\n\n VARIÁVEL numA: {numA} \n");
            Console.WriteLine($" VARIÁVEL numB: {numB} ");


            Console.WriteLine("\n ----------------- ");
            int a = 5, b = 2;
            Console.Write(" DIVISÃO 5 / 2: ");
            Console.WriteLine(a / b); // RESULTADO: 2!
            Console.WriteLine("\n\n");


            Console.WriteLine("\n ----------------- ");
            Console.WriteLine($" VARIÁVEIS IMUTÁVEIS (CONSTANTES) \n");

            const double PI = 3.14;

            //PI = 5.54; -> ERRO, NÃO SE PODE MUDAR UMA CONSTANTE!





        }
    
    }
}

