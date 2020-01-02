namespace Classes
{
    public class Funcionario : Pessoa
    {
        private string funcao;
        
        public virtual void setFuncao(string funcao)
        {
            this.funcao = funcao;
        }
        public virtual string getFuncao()
        {
            return this.funcao;
        }
    }
}