// Sistema acadêmico UNIFEL 1.0 (método)

using System.Globalization;

namespace exemp_10 {
    class Program {

        static int _ultimoGerado = 0; // Vai guardar na memória
        static int opcao = 0;

        static void Main(string[] args) { 
            
            CultureInfo br = new CultureInfo("pt-BR");
            int matricula; // Zerada de propósito, ela vai ser alimentada no método (out)

            while (opcao != 2) {
           
                ExibirBanner();

                GerarMatricula(out matricula);
                Console.WriteLine($"\n\n Aluno Matriculado! \n Matrícula: {matricula:D4} \n");

                Console.Write(" Digite a 1ª nota do aluno: ");
                double n1 = double.Parse(Console.ReadLine()!, br);

                Console.Write(" Digite a 2ª nota do aluno: ");
                double n2 = double.Parse(Console.ReadLine()!, br);

                double media = CalcularMedia(n1, n2);


                ExibirResultadoFinal(matricula, in media);

                
                Console.Write(" Deseja sair (digite 2): ");
                opcao = int.Parse(Console.ReadLine()!, br);
            }


            //Console.WriteLine($"\n Média: {media:F2} | Status: {VerificarStatus(media)} \n");

            // Conferindo valores de variáveis 
            //Console.WriteLine(" Conferindo notas (ORIGINAIS)!\n  NOTA 1: " +
            //    $"{n1:F2} | NOTA 2: {n2:F2}\n\n");

            Console.Write("\n Obrigado por usar o SISTEMA ACADÊMICO UNIFEL 1.0! \n\n");

        }

        static void ExibirBanner() {
           Console.WriteLine("\n ================================= ");
           Console.WriteLine("   SISTEMA ACADÊMICO UNIFEL 1.0   ");
           Console.WriteLine(" ================================= ");
        }

        // Passagem por valor (xérox ou cópia do valor original)
        static double CalcularMedia(double nota1, double nota2) {

            // Destruindo valores dentro do método!
            //nota1 = 0.0;
            //nota2 = 0.0;

            //Console.WriteLine($"\n NOTAS (DENTRO DO MÉTODO): \n NOTA 1 -> {nota1:F2} | NOTA 2 -> {nota2:F2}");
            return (nota1 + nota2) / 2; // Precedência: (), !, &&, ||

        }

        // Arrow Function (Expression-bodied members)
        //static double CalcularMediaNovo(double n1, double n2) => (n1 + n2) / 2;



        //static string VerificarStatus(double media) {

        //    if (media >= 7) {
        //        return " APROVADO!";
        //    }
        //    else if (media >= 5) {
        //        return " RECUPERAÇÃO!";
        //    }
        //    else {
        //        return " REPROVADO!";
        //    }

        //}

        static void GerarMatricula(out int id) {

            // Criando uma matrícula completamente aleatória mas dentro de um intervalo
            //id = new Random().Next(1000, 10000); // Vai até 9999. 10k não será alcançado

            // Para id sequenciais:
            _ultimoGerado++; // _ultimoGerado = _ultimoGerado + 1
            id = _ultimoGerado;
        }

        static void ExibirResultadoFinal(int matricula, in double media) {

            // ERRO, tentar alterar uma variável com "in" (só leitura)
            //media = 10;

            // OPERADOR TERNÁRIO
            string status = media >= 7 ? "APROVADO" : "REPROVADO";

            Console.WriteLine($"\n [RELATÓRIO] \n Matrícula: {matricula:D4} " +
                $"\n Média: {media} \n Status do aluno: {status} \n\n");


        }

    }
}