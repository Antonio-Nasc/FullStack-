using bytebank_ADM.Funcionarios;

Funcionario funcionario = new Funcionario();
funcionario.Nome = "José Nascimento";
funcionario.Cpf = "123456789";
funcionario.Salario = 3500;
Console.WriteLine(funcionario.Nome);
Console.WriteLine(funcionario.Salario);
Console.WriteLine(funcionario.GetBonificacao());

Diretor Jorge = new Diretor();
Jorge.Nome = "Jorge Oliveira";
Jorge.Cpf = "44444444";
Jorge.Salario = 6000;
Console.WriteLine(Jorge.Nome);
Console.WriteLine(Jorge.GetBonificacao());
