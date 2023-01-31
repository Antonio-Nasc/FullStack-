string opcao;
double precoInicial;
double precoHora;
Console.WriteLine("Seja bem-vindo ao sistema de estacionamento!");
Console.WriteLine("Digite o preço inicial: ");
precoInicial = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Agora digite o preço por hora: ");
precoHora = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a sua opção: ");
Console.WriteLine("1 - Cadastrar veículo");
Console.WriteLine("2 - Remover veículo");
Console.WriteLine("3 - Listar veículos");
Console.WriteLine("4 - Encerrar");
opcao = Console.ReadLine();
