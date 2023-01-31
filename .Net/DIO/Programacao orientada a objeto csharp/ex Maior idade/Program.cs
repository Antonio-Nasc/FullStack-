using ex_Maior_idade.models;

Pessoa p1 = new Pessoa();
Console.WriteLine("Informe seu nome");
p1.Nome = Console.ReadLine();
Console.WriteLine("Informe sua idade");
p1.Idade = Convert.ToInt32(Console.ReadLine());


Pessoa p2 = new Pessoa();
Console.WriteLine("Informe seu nome");
p2.Nome = Console.ReadLine();
Console.WriteLine("Informe sua idade");
p2.Idade = Convert.ToInt32(Console.ReadLine());


Pessoa p3 = new Pessoa();
Console.WriteLine("Informe seu nome");
p3.Nome = Console.ReadLine();
Console.WriteLine("Informe sua idade");
p3.Idade = Convert.ToInt32(Console.ReadLine());

if((p1.Idade > p2.Idade) && (p1.Idade > p3.Idade)){
    p1.ExibirDados();
}
else if((p2.Idade > p1.Idade) && (p2.Idade > p3.Idade)){
    p2.ExibirDados();
}
else if((p3.Idade > p1.Idade) && (p3.Idade > p2.Idade)){
    p3.ExibirDados();
} else{
    Console.WriteLine("Todas as idades são iguais");
}



