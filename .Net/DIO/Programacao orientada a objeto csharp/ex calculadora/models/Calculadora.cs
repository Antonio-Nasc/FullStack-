using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex_calculadora.models
{
    public class Calculadora
    {
        public void somar(int x, int y){
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
         public void subtrair(int x, int y){
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
         public void multiplicar(int x, int y){
            Console.WriteLine($"{x} X {y} = {x * y}");
        }
         public void dividir(int x, int y){
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void potencia(int x, int y){
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {pot}");
        }
        public void Seno(double angulo){
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}º = {Math.Round(seno, 4)}");
        }
         public void Coseno(double angulo){
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Sin(radiano);
            Console.WriteLine($"Coseno de {angulo}º = {Math.Round(coseno)}");
        }
         public void Tangente(double angulo){
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Sin(radiano);
            Console.WriteLine($"Tangente de {angulo}º = {Math.Round(tangente)}");
        }
        public void Raiz(double x){
            double raiz =  Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
           
        }
    }
}