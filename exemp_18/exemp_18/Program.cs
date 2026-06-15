// Cálculo de prazos de logística (tempo no C#)

using System.Globalization;

namespace exemp_18 {
    public class Program {
        static void Main(String[] Args) {

            CultureInfo br = new CultureInfo("pt-BR");

            DateTime dataSaida = DateTime.Now; // Instante exato do agora (relógio do sistema)!
            DateTime dataEntregaPrevista = dataSaida.AddDays(3).AddHours(5); // Adiciona 3 dias e 5 horas e salva
            TimeSpan duracaoViagem = dataEntregaPrevista - dataSaida;

            // PT-BR: dd/mm/aaaa
            // EN-US: yyyy/mm/dd
            // ano = years!
            // mês = month!
            // dia = day
            // Formatação: dia / mês / ano hora:minuto)
            Console.WriteLine($"\n Carga liberada em: {dataSaida.ToString("dd/MM/yyyy HH:mm")}! \n");

            Console.WriteLine($"\n Previsão de entrega: {dataEntregaPrevista.ToString("D",br)}! \n");

            Console.WriteLine($"\n Tempo estimado é: {duracaoViagem.Days} " +
                $"dias e {duracaoViagem.Hours} horas! ");

            // Validação de atraso da entrega
            bool atrasado = DateTime.Now > dataEntregaPrevista;
            string status = atrasado ? "CRÍTICO: Carga Atrasada" : "Carga dentro do prazo";

            Console.WriteLine($"\n STATUS DA ENTREGA: {status} \n\n");

        }
    }
}