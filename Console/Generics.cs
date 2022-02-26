using System.Collections.Generic;
using System;
using System.Linq;

namespace Console
{
    public class Generics
    {
    }

    public class Alunos
    {
        public Alunos()
        {

        }
        public Alunos(int matricula, string nome, int turma)
        {
            Matricula = matricula;
            Nome = nome;
            Turma = turma;
        }

        public int Matricula { get; private set; }
        public string Nome { get; private set; }
        public int Turma { get; private set; }

        public static List<Alunos> ListaDeAlunos()
        {
            var conjuntoAlunos = new List<Alunos>();

            Alunos aluno = new Alunos(1, "Miguel", 1);
            conjuntoAlunos.Add(aluno);

            aluno = new Alunos(2, "Leonardo", 1);
            conjuntoAlunos.Add(aluno);

            aluno = new Alunos(3, "Rodrigo", 1);
            conjuntoAlunos.Add(aluno);

            aluno = new Alunos(4, "Lucas", 2);
            conjuntoAlunos.Add(aluno);

            aluno = new Alunos(5, "Wendell", 2);
            conjuntoAlunos.Add(aluno);

            aluno = new Alunos(6, "Vitor", 2);
            conjuntoAlunos.Add(aluno);

            aluno = new Alunos(7, "Eric", 3);
            conjuntoAlunos.Add(aluno);

            aluno = new Alunos(8, "Geraldo", 3);
            conjuntoAlunos.Add(aluno);

            aluno = new Alunos(9, "Fernando", 3);
            conjuntoAlunos.Add(aluno);

            aluno = new Alunos(10, "Sergio", 3);
            conjuntoAlunos.Add(aluno);

            return conjuntoAlunos;
        }

        public Alunos PesquisaAluno(List<Alunos> listaDeAlunos, int search)
        {
            try
            {
                var alunoPesquisado = (from aluno in listaDeAlunos
                                       where aluno.Matricula == search
                                       select aluno).FirstOrDefault();
                return (Alunos)alunoPesquisado;
            }
            catch (Exception e)
            {

                System.Console.WriteLine("Insira um ID valido! " + e.Message);
                return null;
            }
        }
    }
}
