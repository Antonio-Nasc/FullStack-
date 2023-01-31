using ex_pessoa.models;

Aluno a1 = new Aluno("Pedro");
Console.WriteLine("Informe a idade do aluno");
a1.Idade = Convert.ToInt32(Console.ReadLine());
a1.Nota = 7.3;
a1.Apresentar();

Professor p1 = new Professor("Marta");
p1.Idade = 18;
p1.Salario = 5152.11M;
p1.Apresentar();