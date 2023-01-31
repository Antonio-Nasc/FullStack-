using interface_calculadora.interfaces;
using interface_calculadora.models;

ICalculadora c = new Calculadora();
Console.WriteLine(c.Multiplicar(12, 22));
