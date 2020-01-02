namespace Classes
{
    public class Professor : Pessoa
    {
        private string matricula;
        private string materia;
        
        public virtual void setMatricula(string matricula)
        {
            this.matricula = matricula;
        }
        public virtual string getMatricula()
        {
            return this.matricula;
        }
        public virtual void setMateria(string materia)
        {
            this.materia = materia;
        }
        public virtual string getMateria()
        {
            return this.materia;
        }
    }
}