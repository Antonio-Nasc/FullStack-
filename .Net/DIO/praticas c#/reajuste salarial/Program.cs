double salario;
Console.WriteLine("Informe seu salário:");
salario = Convert.ToDouble(Console.ReadLine());

if(salario < 1700){
    Console.ForegroundColor = ConsoleColor.Yellow;
    salario += 300;
}
else{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    salario += 200;
}
Console.WriteLine($"Novo salário é {salario}");
