using pessoa_idade.models;

Pessoa p1 = new Pessoa();

p1.Nome = "Jorge";
p1.Data = new DateTime(2000, 05, 06);
p1.Altura = 1.81;

p1.imprimirDados();

int idade = p1.CalcularIdade();

Console.WriteLine("Idade: " + idade);

Console.ReadKey();
