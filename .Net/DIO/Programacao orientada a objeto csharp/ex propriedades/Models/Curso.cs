using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex_propriedades.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        //void retorna vazio
        public void AdicionarAluno(Pessoa aluno){
            Alunos.Add(aluno);
        }
        //int, bool, string etc precisa retornar algo
        public int ObterQuantidadeDeAlunosMatriculados(){
            int quantidade = Alunos.Count;
            return quantidade;
        }
        public bool RemoverAluno(Pessoa aluno){
            return Alunos.Remove(aluno);
            //return true;
        }
        
    }
}