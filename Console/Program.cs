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
            // Atividade 1
            Alunos alunos = new Alunos();

            alunos = alunos.PesquisaAluno(Alunos.ListaDeAlunos(), 5);
            System.Console.WriteLine(alunos.Matricula.ToString() + " " + alunos.Nome + " " + alunos.Turma);

            // Atividade 2
            Banco1 banco1 = new Banco1();
            Banco2 banco2 = new Banco2();

            TransferenciasBancarias TransBanco = new TransferenciasBancarias(banco1, banco2);

            TransBanco.Transferir(banco1,banco2);

            System.Console.ReadKey();
        }
    }
}
