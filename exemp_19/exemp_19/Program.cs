// Simulação de processamento de etiqueta de logística (de antiga para nova)

//using System.Globalization;

namespace exemp_19 {
    public class Program {
        static void Main(String[] Args)
        {            

            string etiquetaBruta = "   ID#9988-LOGISTICA-SUL   ";
            DateTime? dataUltimaRevisao = null;

            string etiquetaLimpa = etiquetaBruta.Trim(); // "ID#9988-LOGISTICA-SUL"
            string idSomente = etiquetaLimpa.Substring(3,4); // "9988"
            string categoria = etiquetaLimpa.Replace("-","|"); // "ID#9988|LOGISTICA|SUL"

            bool eLogistica = etiquetaLimpa.Contains("LOGISTICA"); // True!
            bool eInternacional = etiquetaLimpa.StartsWith("INT"); // Vai dar false agora!

            // Null Safety + Datas 
            DateTime dataProcessamento = dataUltimaRevisao ?? DateTime.Today;

            DateTime validadeEtiqueta = dataProcessamento.AddMonths(6);

            // Subtração de DateTime sempre gera um TIMESPAN!s
            TimeSpan diasParaVencer = validadeEtiqueta - DateTime.Today;

            // Exibindo dados
            Console.WriteLine($"\n ================================== ");
            Console.WriteLine($" ID Extraído: {idSomente} ");
            Console.WriteLine($" Etiqueta Formatada: {etiquetaLimpa} ");
            Console.WriteLine($" Expedição Logística? {eLogistica} ");
            Console.WriteLine($" Data base da expedição: {dataProcessamento.ToString("dd/MM/yyyy")}");
            Console.WriteLine($" Vence em: {validadeEtiqueta:dd/MM/yy} | (Faltam {diasParaVencer.Days} dias)");
            Console.WriteLine($" ================================== \n\n");

        }
    }
}
