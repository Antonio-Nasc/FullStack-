int soma = 0;
int numero = 0;
do{
    Console.WriteLine("Informe um número (0 para parar)");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;
}
while(numero != 0);
Console.WriteLine($"A soma dos números digitados é de: {soma}");