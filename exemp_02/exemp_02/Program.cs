// EXEMPLO DE USING (namespaces) APLICADO A CLASSES E OBJETOS

using exemp_02.Models;
using exemp_02.Services;

// Instanciando um objeto vazio
Produto cargaDeSoja = new Produto(); // Sem using, dá erro!

Console.WriteLine(" O produto é: " + cargaDeSoja.nomeProduto);

// Criando um objeto do tipo ContaBancaria.
ContaBancaria minhaConta = new ContaBancaria(); // Sem using, dá erro!

//minhaConta.saldo = 1000000.00; // ERRO! Saldo é PRIVATE!

//Console.WriteLine(" O saldo da conta é: " + ContaBancaria.saldo); // ERRO, PRIVATE!!

// Criando um objeto do tipo CalculadoraFrete
CalculadoraFrete minhaCalc = new CalculadoraFrete();


minhaCalc.ProcessarFrete(); // Funciona!!



// ------------------------------------


//👉 Em sistemas profissionais:
//❌ Quase nunca você expõe atributos diretamente
//✅ Você usa propriedades



// ------------------------------------

// CLEAN CODE -> CONVENÇÕES DE NOMEAÇÃO (CLEAN CODE E C#)
//O C# tem regras de ouro. Seguir isso é o que faz o seu código
//ser lido por qualquer sênior da Microsoft.

//A) camelCase (Corcova de Camelo):
//Começa com minúscula, e as palavras seguintes com Maiúscula.

//Onde usar: Variáveis locais e parâmetros de métodos.

//✅ pesoCarga, valorUnitario, resultadoDoExame, idadeAluno

//❌ resultado_do_exame (snake_case: Isso é padrão Python, no C# evitamos o underscore).




//B) PascalCase (Todas as iniciais Maiúsculas):

//Onde usar: Classes, Métodos, Interfaces e Propriedades.

//✅ Classe: CalculadoraFrete.

//✅ Método: CalcularTotal().

//✅ Propriedade: public double Salario { get; set; }.



//C) Prefixos Específicos:

//Interfaces: Devem SEMPRE começar com I.

//✅ IFrete, IRepository.

//Atributos Privados (Fields): Costumamos usar um _ no início.

//✅ private double _saldo;


