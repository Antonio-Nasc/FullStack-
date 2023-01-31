using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex_carro_exception.models
{
    public class Carro
    {
        private string _Nome;
        public string Nome {
            get => _Nome.ToUpper();
            set{
                if(value == ""){
                    throw new ArgumentException("O nome não pode ficar em vazio!");
                }
                _Nome = value;
            } 
        }
        private string _cor;
        public string Cor {
            get => _cor.ToLower();
            set{
                if(value == ""){
                    throw new ArgumentException("O valor não pode ser vazio!");
                }
                _cor = value;
            }
        }
        
        public void Apresentar(){
            Console.WriteLine($"O veículo {Nome} tem a cor {Cor}");
        }
    }
}