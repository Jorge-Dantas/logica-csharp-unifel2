using System;

namespace exemp_20.Utils{
    public class Validacoes {
       
        public static bool ValidarCampoObrigatorio(string entrada) {
            return string.IsNullOrWhiteSpace(entrada);
        }

        public static bool ValidarApenasVazio(string entrada)
        {
            return string.IsNullOrEmpty(entrada); // "" -> Length = 0
        }


        public static void RegistrarUser(string nome) {

            if (ValidarCampoObrigatorio(nome) || ValidarApenasVazio(nome)) {
                Console.WriteLine("\n ERRO CRÍTICO: O nome foi inválido ou está nulo!! ");
                return;
            }

            string nomeLimpo = nome.Trim().ToUpper();
            Console.WriteLine($" Usuário {nomeLimpo} registrado no sistema com sucesso!! \n");
        }


    }
}






//01.No C#, ao executar o método nome.ToUpper(),
//o que acontece com a variável original na memória?
//A) A variável original é alterada para letras maiúsculas no Heap.
//B) O Garbage Collector apaga a string e a reescreve no mesmo endereço.
//C) Uma nova string é criada no Heap, strings são imutáveis.
//D) Nada acontece, a menos que a string seja Nulable.






//02. Qual é o resultado de
// DateTime.Today - DateTime.Today.AddDays(-2)?

//A) Um objeto DateTime representando anteontem.
//B) Um erro de compilação, pois não se subtrai datas.
//C) Um objeto TimeSpan representando o valor de 2 dias.
//D) Um valor inteiro representando 48 horas.












//03. O operador de coalescência nula (??) serve para:
//A) Comparar se dois objetos no Heap são idênticos.
//B) Atribuir um valor padrão caso a variável à esquerda seja nula.
//C) Converter uma string para int de forma segura.
//D) Limpar os espaços em branco de uma string nula.










//04. Analise o código:

//string campo = "   ";.
//
//Qual será o retorno de string.IsNullOrEmpty(campo) e
//string.IsNullOrWhiteSpace(campo), respectivamente?
//A) True e True
//B) False e True
//C) True e False
//D) False e False











//05. Por que o método int.TryParse é considerado mais seguro que o int.Parse?

//A) Porque ele converte o número para decimal automaticamente.
//B) Porque ele retorna 0 se o usuário digitar letras, sem interromper o programa.
//C) Porque ele retorna um booleano e evita o travamento (crash) do
//sistema em caso de erro de entrada.
//D) Porque ele limpa os espaços da string antes de tentar converter.








//06. Em um servidor localizado em outra região,
// qual comando deve ser usado para garantir que
// o horário registrado seja independente do fuso horário local do hardware?
//A) DateTime.Now
//B) DateTime.Today
//C) DateTime.UtcNow
//D) DateTime.LocalTime








//07. O que acontece se você tentar usar nome.Trim()
//em uma variável que está com valor null?
//A) O programa retorna uma string vazia.
//B) Ocorre um erro de NullReferenceException e o programa trava.
//C) O Garbage Collector limpa a variável automaticamente.
//D) O C# ignora o comando e segue para a próxima linha.








//08. Qual método de busca é usado para verificar
//se uma etiqueta começa com um prefixo específico, como "ID#"?
//A) Contains()
//B) Substring()
//C) StartsWith()
//D) Replace()










//09. Se
// TimeSpan intervalo = dataFinal - dataInicial;,
//
//como acessamos apenas a quantidade total de dias inteiros desse intervalo?
//A) intervalo.TotalTime
//B) intervalo.Days
//C) intervalo.GetDays()
//D) intervalo.ToDays()











//10. O que faz o método
// Substring(5, 2) na string "UNIFEL_2026"?
//A) Pega o texto do índice 5 até o índice 2.
//B) Começa no índice 5 e pega os próximos 2 caracteres.
//C) Remove os 5 primeiros e os 2 últimos caracteres.
//D) Retorna apenas "_2".











//PARTE 2: QUESTÕES ABERTAS(DESAFIO LÓGICO)
//11.Explique por que o uso do Trim() é
//vital antes de realizar uma comparação de login em um sistema de segurança.










//12. Qual a diferença prática entre DateTime.Now e DateTime.Today?













//13. No método int.TryParse(input, out int resultado),
//para que serve o parâmetro out?









//14. Imagine uma variável string? apelido = null;.
//Como você escreveria uma linha usando
//o operador ?? para que a tela exiba "Usuário" caso o apelido não exista (esteja nullo)?








//15. Descreva o que acontece na memória (Stack/Heap)
//quando realizamos muitas manipulações de string em um curto espaço de tempo.
//Ex: string nome = "Jorge";
//nome = "UNIFEL"
//nome = "Turma de C# 2026.3";
//nome = "Anônimo";
//nome = "Monique";

