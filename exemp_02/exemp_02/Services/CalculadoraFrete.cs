namespace exemp_02.Services {
    public class CalculadoraFrete {

        public void ProcessarFrete() {
            Console.WriteLine("\n Processando o frete... \n");
            VerificarCombustivel(); // Um método pode chamar outro!
            Console.WriteLine("\n Frete processado com sucesso! \n");
        }

        private void VerificarCombustivel() {
            Console.WriteLine("\n Calculando gasto com Diesel (privado) ... \n");
        }

    }
}
