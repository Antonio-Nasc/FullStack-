using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex_classe.Models
{
    public class Pessoa
    {
        //Atributo
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
        //Método
        public void Apresentar(){
            Console.WriteLine($"Olá, meu nome é {Nome}, sou do sexo {Sexo} e eu tenho {Idade} anos");

            //"\n" quebra linha
            // Console.WriteLine($"Olá, meu nome é {Nome}, \n sou do sexo {Sexo} e \n eu tenho {Idade} anos");
        }
    }
}