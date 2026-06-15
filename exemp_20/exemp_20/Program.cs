// Qual a diferença deles??
// null             -> Ausência de valor (a gaveta nem existe na memória!)
// ""               -> String vazia!!! String cujo tamanho é 0 (Lenght = 0)!!
// "     "          -> String cheia de espaço (lixo de memória)
//string.IsNullOrEmpty();           -> Só valida nulo ou vazio
//string.IsNullOrWhiteSpace();      -> Doutor da validação

using System.Globalization;
using exemp_20.Utils;

namespace exemp_20 {
    public class Program {
        static void Main(String[] Args) {


            Console.Write("\n === SISTEMA DE CADASTRO (MODULARIZADO) v1.0 === \n");

            Console.Write("\n Digite o nome do usuário: ");
            string userInput = Console.ReadLine()!;

            Validacoes.RegistrarUser(userInput);


            // Exercitando o operador ??
            string? apelido = null;
            string userFinal = apelido ?? "Visitante";
            Console.WriteLine($" Bem-vindo, {userFinal} \n\n");

        }

    }
}