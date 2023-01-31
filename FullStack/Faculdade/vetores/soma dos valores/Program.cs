int[] valores = new int[5];
int soma = 0;
double media = 0;
Console.WriteLine("Informe os 5 valores desejados");
for (int i = 0; i < valores.Length; i++){
    valores[i] = Convert.ToInt32(Console.ReadLine());
    soma = soma + valores[i];
   


}
 media = soma / 5;
Console.WriteLine(soma);
Console.WriteLine(media);

for (int i = 0; i > 5; i++){
    if(media < valores[i]){
        Console.WriteLine(valores[i]);
    }
}



