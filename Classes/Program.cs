using System;
using System.Runtime.CompilerServices;

namespace Classes
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var aluno = new Aluno();
            var professor = new Professor();
            var funcionario = new Funcionario();
            
            aluno.setMatricula("1234ab");
            aluno.setIdade(27);
            aluno.setNome("Daiane");
            
            professor.setMatricula("123456rb");
            professor.setIdade(25);
            professor.setNome("John");
            
            funcionario.setFuncao("Secretária");
            funcionario.setIdade(47);
            funcionario.setNome("Maria");
            
            Console.WriteLine(aluno.getMatricula());
            Console.WriteLine(aluno.getIdade());
            Console.WriteLine(aluno.getNome());
            
            Console.WriteLine(professor.getMatricula());
            Console.WriteLine(professor.getIdade());
            Console.WriteLine(professor.getNome());
            
            Console.WriteLine(funcionario.getFuncao());
            Console.WriteLine(funcionario.getIdade());
            Console.WriteLine(funcionario.getNome());
            
            var pessoa = new Pessoa();
            
            pessoa.setIdade(12);
            pessoa.setNome("Fabiana");
            
            Console.WriteLine(pessoa.getIdade());
            Console.WriteLine(pessoa.getNome());

            pessoa = aluno;
            
            Console.WriteLine(pessoa.getIdade());
            Console.WriteLine(pessoa.getNome());
            
            pessoa = professor;
            
            Console.WriteLine(pessoa.getIdade());
            Console.WriteLine(pessoa.getNome());
            
            pessoa = funcionario;
            
            Console.WriteLine(pessoa.getIdade());
            Console.WriteLine(pessoa.getNome());
        }
    }
}