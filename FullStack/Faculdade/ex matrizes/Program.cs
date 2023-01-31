int[][] quant = new int[4][];
int soma = 0;
for (int i = 0; i < 4; i++){
    for (int j = 0; j < 5; j++){
        Console.WriteLine("Informe o valor do " + (i + 1) + "º trimestre e " + (j + 1) + "º região. ");
        quant[i][j] = Convert.ToInt32(Console.ReadLine());
    }
}

for (int i = 0; i < 4;i++){
    for (int j = 0; j < 5; j++)
        soma = soma + quant[i][j];
}
Console.WriteLine("O total de quantidade vendidas é: " + soma);
