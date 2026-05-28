// OPERADORES LÓGICOS, DE PERTENCIMENTO, COMPARAÇÃO retornam uma RESPOSTA LÓGICA
// RESPOSTA LÓGICA = True ou False (V/F)
// E (AND &&), OU (OR ||), NÃO (NOT !)
// ==, >, <, >=, <=, !=, 
// 0 = True, e 1 = False


// CONCEITOS IMPORTANTES
// GUARD CLAUSES (boa prática). Teste o que pode dar errado logo no ínicio.
// FAIL FAST (falhe rápido). Ex: Barrar o despacho do exemp_08!
// Curto-circuito -> Otimização para performance!

// CONJUNÇÃO (E, AND, &&) -> EXCLUSIVO
// E: Só é VERDADEIRO quando AMBAS condições são VERDADEIRAS!

string user = "Admin";
string senha = "123456";

if (user == "admin" && senha == "123456") {
    // Código a ser executado(ex.login aprovado!)
 }




//DISJUNÇÃO(OU, OR, || ->INCLUSIVO

//OU: Só é FALSO quando AMBAS condições são FALSOS!
string dia = "Sábado";

 if (dia == "Sábado" || dia == "Domingo") {
    //Código a executar(ex.imprima que é fim de semana!)
 }


// INVERSÃO DE VALOR LÓGICO (NÃO, NOT, ! -> Negação "lógica"
// NÃO: Inverter o valor booleano (O que é TRUE se torna FALSE e vice-versa).
bool estaLigado = false;

if (!estaLigado) {
    //Código a executar(ex.Ligue o carro!!)
 }



// PRECEDÊNCIA: (), !, &&, ||
// SEMPRE USAR PARÊNTESES EM OPERAÇÕES LÓGICAS COMPLEXAS!
// Controle de acesso a festa da faculdade (18+)
int idade = 18;
bool estaAutorizado = false; // O menino não tem autorização por padrão!
bool estaDeCastigo = false; // O menino tá de castigo por padrão!

if ((idade >= 18 || estaAutorizado) && !estaDeCastigo) { 
    // Acesso autorizado a festa!!
}










//if () { 
//}

