// Aprovação de Crédito Agrícola

// Problema: Um banco avalia empréstimos baseados
// em produtividade e riscos.

// Passo 1 (Processamento): Receba a área plantada em hectares (double)
// e a produção colhida em toneladas (double).
// Calcule a produtividade (Produção dividida por Área) dentro do método.

// Passo 2 (Lógica): O crédito só é aprovado se:

// A produtividade for maior que 5.0 OU o seguro agrícola (bool)
// estiver ativo.

// E o produtor NÃO possuir dívidas vencidas (bool).

// E a previsão de seca severa (bool) for falsa.

// Tarefa: Crie um método que realize o cálculo e
// a validação multicondicional.


namespace exemp_13 {

    public class Program {

        static void Main(String[] Args) {

            double areaPlantada = 20;
            double producao = 40;
            bool seguro = true;
            bool dividas = false;
            bool previsaoSeca = false;

            bool aprovado = ValidarCreditoAgricola(areaPlantada, producao, 
                seguro, dividas, previsaoSeca);
            Console.WriteLine($"\n   Credito aprovado: {aprovado} \n\n");

        }

      
        static bool ValidarCreditoAgricola(double area, double producao,
            bool temSeguro, bool temDividas, bool previsaoSeca) { 

            double produtividade = producao / area;

            // Lógica multicondicional
            return (produtividade > 5.0 || temSeguro) && !temDividas && !previsaoSeca;
        }

    }

}
