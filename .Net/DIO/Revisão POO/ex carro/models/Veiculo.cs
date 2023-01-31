using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex_carro.models
{
    public class Veiculo
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private string cor;
        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        private string anoLancamento;
        public string AnoLancamento
        {
            get { return anoLancamento; }
            set { anoLancamento = value; }
        }

        public void exibirModelo(){
            Console.WriteLine($"O Veículo {Nome} de marca {MarcaVeiculo} tem a cor {Cor} e foi lançado em {AnoLancamento}");
        }
        
        
        
    }
}