
DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);
DateTime dia = DateTime.Now;
Console.WriteLine(dia.ToString("dd/MM/yyyy"));
DateTime hora = DateTime.Now;
Console.WriteLine(hora.ToString("HH:mm"));




string apresentacao = "Olá, seja bem-vindo!";
int quantidade = 3;
double altura = 1.81;
decimal valor = 10.32M;
bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variável quantidade é: " + quantidade);
Console.WriteLine("Valor da variável altura é: " + altura.ToString("0.00"));
Console.WriteLine("Valor da variável valor é: " + valor);
Console.WriteLine("Valor da variável condição é: " + condicao);


