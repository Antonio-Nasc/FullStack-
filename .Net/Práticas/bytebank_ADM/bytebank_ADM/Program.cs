using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

Funcionario Luana = new Funcionario();
Luana.Nome = "José Nascimento";
Luana.Cpf = "123456789";
Luana.Salario = 3500;
Console.WriteLine(Luana.Nome);
Console.WriteLine(Luana.Salario);
Console.WriteLine(Luana.GetBonificacao());

Diretor Jorge = new Diretor();
Jorge.Nome = "Jorge Oliveira";
Jorge.Cpf = "44444444";
Jorge.Salario = 6000;
Console.WriteLine(Jorge.Nome);
Console.WriteLine(Jorge.GetBonificacao());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(Jorge);
gerenciador.Registrar(Luana);

Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);
