/*Console.WriteLine("Informe as 4 notas por vez");
double nota1 = Convert.ToDouble(Console.ReadLine());
double nota2 = Convert.ToDouble(Console.ReadLine());
double nota3 = Convert.ToDouble(Console.ReadLine());
double nota4 = Convert.ToDouble(Console.ReadLine());
double media = (nota1 + nota2 + nota3 + nota4) / 4;

if(media >= 7){
    Console.WriteLine("Parabéns! Você foi aprovado.");
} else if(media >= 5 && media < 7){
    Console.WriteLine("Você está de recuperação");
} else{
    Console.WriteLine("Você reprovou.");
}*/


/*int[] lista = new int[4] { 12, 21, 42, 32 };

foreach(int num in lista){
    Console.WriteLine(num);
}*/

List<string> cidades = new List<string> { "Aracaju", "Rio de Janeiro" };
cidades.Add("Itabaiana");
cidades.Remove("Aracaju");
foreach(string cidade in cidades){
    Console.WriteLine(cidade);
}