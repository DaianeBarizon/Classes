namespace Classes
{
    public class Aluno : Pessoa
    {
        private string matricula;
        
        public virtual void setMatricula(string matricula)
        {
            this.matricula = matricula;
        }
        public virtual string getMatricula()
        {
            return this.matricula;
        }
    }
}