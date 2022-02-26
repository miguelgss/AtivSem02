using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            Alunos alunos = new Alunos();

            //foreach (Alunos aluno in Alunos.ListaDeAlunos())
            //{
            //    System.Console.WriteLine(aluno.Nome);
            //}


            // Atividade 1
            alunos = alunos.PesquisaAluno(Alunos.ListaDeAlunos(), 5);
            System.Console.WriteLine(alunos.Matricula.ToString() + " " + alunos.Nome + " " + alunos.Turma);

            System.Console.ReadKey();

            // Atividade 2
        }
    }
}
