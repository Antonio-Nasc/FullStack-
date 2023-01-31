using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex_propriedades.Models
{
    public class Pessoa
    {
        private string _nome;
        public string Nome {
             get =>_nome.ToUpper();
            
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        private int _idade;
        public int Idade { 
            get{
                return _idade;
            }

            set {
                if(value <= 0){
                    throw new ArgumentException("Idade não pode ser menor que 1");
                }
                _idade = value;
            }
            
        }

        public void Apresentar(){
            Console.WriteLine($"Nome: {NomeCompleto}, idade: {Idade}");
        }
    }
}