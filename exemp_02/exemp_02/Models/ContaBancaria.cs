using System.Numerics;

namespace exemp_02.Models {
    class ContaBancaria { // OMITIDO: Ela é internal

        private decimal saldo = 1000.00m; // PRIVATE!!!

        public void Depositar(decimal valor) {
            //saldo = saldo + valor;
            saldo += valor; // Mesma coisa que a linha acima!
        }


    }
}

//ONDE PODEMOS USAR MODIFICADORES??
//Classes
//Métodos
//Atributos (variáveis)
//Propriedades
//Construtores
//Interfaces
//Structs