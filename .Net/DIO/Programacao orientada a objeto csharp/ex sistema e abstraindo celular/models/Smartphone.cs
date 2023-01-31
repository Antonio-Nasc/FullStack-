using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex_sistema_e_abstraindo_celular.models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string modelo;
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        private string imei;
        public string Imei
        {
            get { return imei; }
            set { imei = value; }
        }
        private int memoria;
        public int Memoria
        {
            get { return memoria; }
            set { memoria = value; }
        }

        public Smartphone(string numero, string modelo, string imei, int memoria){
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar(){
            Console.WriteLine("Ligando...");
        }
        public void ReceberLigacao(){
            Console.WriteLine("Recebendo ligação...");
        }
        public abstract void InstalarAplicativo(string nomeApp);




    }
}