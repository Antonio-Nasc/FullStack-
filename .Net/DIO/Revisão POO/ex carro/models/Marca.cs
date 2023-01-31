using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex_carro.models
{
    public class Marca : Veiculo
    {
        private string marcaVeiculo;
        public string MarcaVeiculo
        {
            get { return marcaVeiculo; }
            set { MarcaVeiculo = value; }
        }
        


    }
}