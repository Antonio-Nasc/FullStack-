const string APROVADO = "Aprovado!";
const string REPROVADO = "Reprovado!";
const string EM_RECUPERACAO = "Em recuperação";

Console.WriteLine("Digite a nota: ");
decimal nota = Convert.ToDecimal(Console.ReadLine());

if(nota >= 5){
    Console.WriteLine(APROVADO);
}
else if(nota >= 4 && nota < 5){
    Console.WriteLine(EM_RECUPERACAO);
}
else{
    Console.WriteLine(REPROVADO);
}