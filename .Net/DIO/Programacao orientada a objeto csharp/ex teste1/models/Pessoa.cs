using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex_variavel_dados.models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }

        public void Apresentar(){
            Console.WriteLine($"Meu nome é {Nome};\n Tenho {Idade};\n Sou do sexo {Sexo}.");
        }
    }
}