int idade;
Console.WriteLine("Informe sua idade: ");
idade = Convert.ToInt32(Console.ReadLine());

if(idade >= 18){
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Permissão concedida");
}
else{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Sem permissão");
}
