using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex_pessoa.models
{
    public  class Professor : Pessoa
    {
        public Professor(){

        }
        public Professor(string nome) : base(nome)
        {
            
        }
        public decimal Salario { get; set; }

        //Método selado
        public sealed override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} e meu salário é de {Salario}");
        }
    }
}