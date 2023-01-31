using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex_calculadora.models
{
    public class Calculadora
    {
        public void somar(double x, double y){
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void subtrair(double x, double y){
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void multiplicar(double x, double y){
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
        public void dividir(double x, double y){
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
    }
}