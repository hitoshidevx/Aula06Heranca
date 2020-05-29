namespace Aula06Heranca
{
    public class CPF : Pessoa
    {
        public string cpf;
        public string rg;

        public bool Validar(){
            if (cpf != ""){
                return false;
            }
            return true;
        }
    }
}