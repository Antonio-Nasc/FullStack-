using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pessoa_idade.models
{
    public class Pessoa
    {
         private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private DateTime data;
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        
        private double altura;
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        
        public void imprimirDados(){
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Data de nascimento: " + data);
            Console.WriteLine("Altura: " + altura);

        }

        public int CalcularIdade(){
            return DateTime.Today.Year - data.Year;
        }
    }
}