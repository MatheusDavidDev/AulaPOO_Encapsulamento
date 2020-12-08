namespace Aula.classes
{
    public class MasterCard : Cartao
    {
        //Atributos
        private int parcelas;

        // Get e Set

        public int Parcelas{
            //get pega a informacao 
            get{ return parcelas;}//pegar dados

            //Coloca dados
            set{ parcelas = value;}// Inserir dados
            
            // get;
            // set;
        }

        //Metodos

        public string CompraComDesconto(){

            return"";
        }
    }
}