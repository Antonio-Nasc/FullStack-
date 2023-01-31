// int num1 = 12;
// int num2 = 8;
// int calc = num1 + num2;

// //calc *= 2;
// calc /= 2;
// Console.WriteLine(calc);

// Console.WriteLine("Informe seu nome: ");
// string nome = Console.ReadLine();
// Console.WriteLine("Informe seu sobrenome: ");
// string sobrenome = Console.ReadLine();
// Console.WriteLine($"Seu nome completo é: {nome} {sobrenome}");

// int inteiro = 9;
// string a = inteiro.ToString();

// string b = "3";
// int v = Convert.ToInt32(b);


string a = "3-";
int b = 0;
int.TryParse(a, out b);
Console.WriteLine(b);
Console.WriteLine("Conversão com sucesso");