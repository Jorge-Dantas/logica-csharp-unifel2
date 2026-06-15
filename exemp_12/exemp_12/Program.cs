//Triagem de Segurança em Usina

//Problema: Uma usina exige três requisitos simultâneos para
// entrada em uma área de alta radiação.

//Entrada: Uma credencial ativa (bool), um nível de acesso (int)
//    e o tempo de exposição atual em minutos (int).

//Regra de Negócio: O acesso só é permitido se a credencial
//    estiver ativa E o nível de acesso for maior ou igual a 5. 

//    Além disso, o acesso é terminantemente proibido se o tempo
//    de exposição for maior que 100 minutos.

//Tarefa: Implemente um método que receba esses dados.
//    Utilize uma expressão lógica com operadores para validar a entrada.

//Saída: Exiba "ACESSO AUTORIZADO" (em caso de True)
//    ou "ACESSO NEGADO: VIOLAÇÃO DE SEGURANÇA" (em caso de False).
public class Program {
    static void Main(String[] Args) {

        ProcessarAcessoUsina(true, 5, 150); // Simulando a entrada do app!

    }

    static void ProcessarAcessoUsina(bool credencialAtiva, int nivelAcesso, int tempoMinutos) {

        // Se credencial(ok) e n. acesso >= 5 E tempoMin <= 100
        if ((credencialAtiva && nivelAcesso >= 5) && !(tempoMinutos > 100)) {
            Console.WriteLine("\n\n   ACESSO AUTORIZADO ! \n");
        }
        else {
            Console.WriteLine("\n\n   ACESSO NEGADO: VIOLAÇÃO DE SEGURANÇA!! \n");
        }
    }
}
