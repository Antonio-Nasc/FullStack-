Console.WriteLine("Informe a primeira nota do aluno");
decimal nota1 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Informe a segunda nota do aluno");
decimal nota2 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Informe a terceira nota do aluno");
decimal nota3 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Informe a quarta nota do aluno");
decimal nota4 = Convert.ToDecimal(Console.ReadLine());

decimal mediaFinal = (nota1 + nota2 + nota3 + nota4) / 4;

if(mediaFinal >= 6){
    Console.WriteLine("Aprovado");
} else{
    Console.WriteLine("Reprovado");
}

