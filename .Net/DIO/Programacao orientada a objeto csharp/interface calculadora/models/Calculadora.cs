using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using interface_calculadora.interfaces;

namespace interface_calculadora.models
{
    public class Calculadora : ICalculadora
    {

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}