//Sistema de Decolagem de Drone Agrícola

//Problema: O computador de bordo de um drone só autoriza
//a decolagem se o ambiente estiver estável.

//Dados: Velocidade do vento em km/h (double), umidade do ar em % (double),
//carga da bateria em % (int) e detecção de obstáculo (bool).

//Processamento Composto: A decolagem é segura se:

//O vento estiver entre 5 e 20 km/h (inclusive os extremos).

//A umidade for maior que 60% E a bateria for maior que 25%.

//Lógica de Interrupção: O drone NÃO pode decolar se houver obstáculo
//detectado OU se o vento for maior que 30 km/h.

//Tarefa: Crie um método que retorne true (Decolar)
//apenas se as condições de segurança forem
//atendidas E a interrupção não estiver ativa.


namespace exemp_15 {

    public class Program {

        static void Main(String[] Args) {

            Console.WriteLine("\n   ======================================================== ");
            Console.WriteLine("   =====  ASSISTENTE DE EMBARQUE DE DRONE UNIFEL 1.0  ===== ");
            Console.WriteLine("   ======================================================== \n");

            Console.Write("   Qual a velocidade do vento ?? ");
            double velocidadeVento = double.Parse(Console.ReadLine()!);

            Console.Write("   Qual o nível de umidade do ar (%) ?? ");
            double umidade = double.Parse(Console.ReadLine()!);

            Console.Write("   Qual o nível de bateria atual do drone ?? ");
            int nivelBateria = int.Parse(Console.ReadLine()!);

            Console.Write("   Há obstáculos detectados no ar (S/N) ?? ");
            bool temObstaculo = Console.ReadLine()!.Trim().ToLower() == "s";

            bool decolar = VerificaDecolagem(velocidadeVento, umidade, nivelBateria, temObstaculo);

            Console.Write($"\n\n DRONE PODE DECOLAR:  {decolar} \n\n");

        }

        static bool VerificaDecolagem(double vento, double umidade,
            int bateria, bool obstaculo){

            bool condicaoAmbiente = (vento >= 5 && vento <= 20) 
                && (umidade > 60 && bateria > 25);

            bool interrupcao = obstaculo || vento > 30;

            return condicaoAmbiente && !interrupcao;
        }



    }
}