using ex_calculadora.models;

Calculadora calc = new Calculadora();

calc.somar(12, 87);
calc.subtrair(2022, 2000);
calc.multiplicar(12, 25);
calc.dividir(10, 3);
calc.potencia(9, 2);
calc.Seno(64);
calc.Coseno(98);
calc.Tangente(17);

int incremento = 12;
Console.WriteLine("Incremento inicial: " + incremento);
incremento++;
Console.WriteLine("O incremento final é: " + incremento);

int decremento = 9;
Console.WriteLine("Incremento inicial: " + decremento);
decremento--;
Console.WriteLine("O decremento final é: " + decremento);

calc.Raiz(64);


