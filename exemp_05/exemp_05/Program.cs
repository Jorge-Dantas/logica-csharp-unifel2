//Desafio 02: Monitor de Eficiência da Frota (exemp_05)
//Faça um programa que monitore o consumo de combustível
//dos caminhões da frota para identificar possíveis falhas mecânicas.

//Regras de Negócio: Solicite ao usuário a distância total percorrida (km)
//e a quantidade de litros de combustível utilizados.
//Cálculo: Calcule a média de consumo.
//Saída de Dados: Exiba a média com apenas uma casa decimal (ex: 3,5 km / L).
//Condição Especial: Se a média for menor que 3.0 km/L, o programa deve emitir a recomendação:
//Sugestão: Encaminhar veículo para revisão (Consumo excessivo).


// ENTRADA
Console.Write("\n Digite a distância percorrida (KM): ");
double distPercorrida = double.Parse(Console.ReadLine()!); 

Console.Write("\n Quantos litros de combustível foram usados? ");
double combustivelLitros = double.Parse(Console.ReadLine()!);

// PROCESSAMENTO
double mediaConsumo = distPercorrida / combustivelLitros; // Consumo médio

Console.Write($"\n Consumo médio {mediaConsumo:F1} KM/L \n");


// SAÍDA
if (mediaConsumo < 3.0) {
    // média for menor que 3.0 km/L
    Console.WriteLine("\n Encaminhar veículo para revisão (Consumo excessivo).\n\n");
}

