//Protocolo de Embarque Internacional

//Problema: Um sistema alfandegário precisa validar a liberação de passageiros.

//Requisitos Base: O passageiro deve possuir passaporte válido (bool)
//E visto aprovado (bool).
//
//Caso não possua um dos dois, ele ainda pode passar se for cidadão nativo (bool).


//Regra de Segurança: Mesmo atendendo aos requisitos base,
// o embarque é abortado se o passageiro estiver na lista de restrição da
// Interpol (bool) OU se o certificado de vacina (bool) for falso.



//Tarefa: Monte uma única expressão de if utilizando parênteses
//para isolar os "Requisitos Base" das "Regras de Segurança".

namespace exemp_14 {

    public class Program {

        static void Main(String[] Args) {

            Console.WriteLine("\n   =============================================== ");
            Console.WriteLine("   =====  PROTOCOLO DE CONTROLE DE EMBARQUE  ===== ");
            Console.WriteLine("   =============================================== \n");

            Console.Write("   O passageiro é cidadão nativo (S/N) ?? ");
            bool cidadaoNativo = Console.ReadLine()!.Trim().ToLower() == "s";

            Console.Write("   O passaporte está válido (S/N) ?? ");
            bool passaporteValido = Console.ReadLine()!.Trim().ToLower() == "s";

            Console.Write("   Tem visto aprovado (S/N) ?? ");
            bool vistoAprovado = Console.ReadLine()!.Trim().ToLower() == "s";

            Console.Write("   O nome está na lista da Interpol (S/N) ?? ");
            bool listaRestrição = Console.ReadLine()!.Trim().ToLower() == "s";

            Console.Write("   O certificado de vacina está válido (S/N) ?? ");
            bool certificadoVacina = Console.ReadLine()!.Trim().ToLower() == "s";


            Console.WriteLine("\n\n   ================================================ ");
            Console.WriteLine("   =====  PROCESSANDO LIBERAÇÃO ALFANDEGÁRIA  ===== ");
            Console.WriteLine("   ================================================ \n");

            ValidarEmbarque(cidadaoNativo, passaporteValido,
                vistoAprovado, listaRestrição, certificadoVacina);

        }


        static void ValidarEmbarque(bool nativo, bool passaporte,
            bool visto, bool restricaoInterpol, bool vacina) {

            if ((passaporte && visto || nativo) && (!restricaoInterpol || vacina)) {
                Console.Write("   EMBARQUE AUTORIZADO! \n\n\n");
            }
            else {
                Console.Write("   EMBARQUE NEGADO POR RESTRIÇÕES DOCUMENTAIS OU DE SEGURANÇA! \n\n\n");

            }

        }



    }




}