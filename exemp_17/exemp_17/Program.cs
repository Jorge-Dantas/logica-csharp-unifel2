//Validação de cadastro unificado

namespace exemp_17 {

    public class Program {

        static void Main(String[] Args) {

            Console.Write("\n Digite seu nome completo: ");
            string nomeInput = Console.ReadLine()!;
            string nomeFinal = string.IsNullOrEmpty(nomeInput) ? "Visitante" : nomeInput.Trim();


            Console.Write("\n Digite sua idade: ");
            string idadeInput = Console.ReadLine()!;
            // TryParse -> Conversão segura
            if (int.TryParse(idadeInput, out int idadeConvertida)) {

                Console.WriteLine($"\n NOME REGISTRADO: {nomeFinal} ");
                Console.WriteLine($" IDADE: {idadeConvertida} \n\n");

            }
            else {
                Console.WriteLine("\n ERRO: Idade inválida! Tente novamente!! \n\n");
            }

        }
    }
}