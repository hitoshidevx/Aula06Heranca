namespace Aula06Heranca
{
    public class CNPJ : Pessoa
    {
        public string cnpj;

        public bool Validar(){
            if (cnpj != ""){
                return false;
            }
            return true;
        }
    }
}