
// STRINGS SÃO ITERÁVEIS
string nome = "  Jorge Alex Dantas ";

// Uso do in para buscar itens dentro de uma String
// Laço, ou estrutura de repetição
foreach (char letra in nome) {
    Console.Write(letra);
}
Console.Write($"\n -----------------------------------\n");


// TryParse (exemplo) + if + validação
Console.Write($"\n\n Digite sua idade: ");
string txt = Console.ReadLine()!;
if (int.TryParse(txt, out int idade) && idade >= 0 && idade <= 17)
{
    // Algum código.. "Você é de menor!"
    Console.Write($"\n\n Você é de menor!! \n Idade: {idade} \n\n");
}
else if (idade > 17)
{
    Console.Write($"\n\n Você é maior de idade! \n Idade: {idade} \n\n");
}
else if (idade < 0)
{
    Console.Write($"\n\n Você digitou uma idade negativa, tente novamente! \n\n");
}
else {
    Console.Write($"\n\n Você digitou uma entrada inválida. Digite um número inteiro positivo! \n\n");
}

// Aprendendo mais sobre string!
string? numeroCasa = string.Empty; // Nullable!
string.IsNullOrEmpty(numeroCasa); // Verifica se é nula ou vazia
string.IsNullOrWhiteSpace(numeroCasa); // Verifica se é nula ou se tem espaço "branco"
