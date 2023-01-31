using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex_pessoa.models
{
    public class Aluno : Pessoa
    {
        public Aluno(){
            
        }
        public Aluno(string nome) : base(nome)
        {
            
        }
        public double Nota { get; set; }

        public override void Apresentar(){
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} e nota {Nota}");
        }
        
    }
}