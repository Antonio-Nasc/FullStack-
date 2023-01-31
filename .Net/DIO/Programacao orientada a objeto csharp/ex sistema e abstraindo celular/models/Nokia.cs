using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex_sistema_e_abstraindo_celular.models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("WhatsApp");
        }
    }
}