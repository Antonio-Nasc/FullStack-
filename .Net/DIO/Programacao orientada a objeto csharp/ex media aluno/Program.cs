int av1 = 8;
int av2 = 8;
int av3 = 8; 
int av4 = 7;
double media = (av1 + av2 + av3 + av4) / 4;
Console.WriteLine(media);

if(media >= 7){
    Console.WriteLine("Parabéns! Você está aprovado.");
} else if(media >= 5 && media < 7){
    Console.WriteLine("Você está de recuperação.");
} else{
    Console.WriteLine("Você reprovou.");
}
