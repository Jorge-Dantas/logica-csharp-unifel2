using exemp_02.Models;

namespace exemp_02.Models {
    public class Produto {

        public string nomeProduto = "Carga de Soja";

    }
}


//public (Público): O atendente do balcão. Todo cliente vê e interage.
//private (Privado): O cofre do gerente. Só quem está dentro daquela classe tem a chave.
//protected: Só a própria classe + seus filhos acessam. 
//internal: Só membos do mesmo projeto acessam. 
//Menos usados:
//protected internal:	Projeto OU herança
//private protected:	Projeto E herança