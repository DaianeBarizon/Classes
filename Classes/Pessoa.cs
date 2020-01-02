using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Pessoa
    {
        private string nome;
        private int idade;

        public virtual void setNome(string nome)
        {
            this.nome = nome;
        }
        public virtual string getNome()
        {
            return this.nome;
        }
        public virtual void setIdade(int idade)
        {
            this.idade = idade;
        }
        public virtual int getIdade()
        {
            return this.idade;
        }
    }
}