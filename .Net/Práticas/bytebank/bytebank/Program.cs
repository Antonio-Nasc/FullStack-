using bytebank.Contas;
using bytebank.Titular;

//ContaCorrente contaDoAndre = new ContaCorrente();
//contaDoAndre.Informar("André Silva");

//contaDoAndre.titular = "André Silva";
//contaDoAndre.conta = "1010-X";
//contaDoAndre.numero_agencia = 15;
//contaDoAndre.saldo = 100;

//Console.WriteLine("Saldo da conta do André é de " + contaDoAndre.saldo);

//ContaCorrente contaDaMaria =new ContaCorrente();
//contaDaMaria.titular = "Maria Souza";
//contaDaMaria.conta = "1010-5";
//contaDaMaria.numero_agencia = 17;
//contaDaMaria.saldo = 350;

//Console.WriteLine("Saldo da conta da Maria é de " + contaDaMaria.saldo);

//contaDoAndre.Transferir(50, contaDaMaria);
//Console.WriteLine("Saldo da conta do André é de " + contaDoAndre.saldo);
//Console.WriteLine("Saldo da conta da Maria é de " + contaDaMaria.saldo);

/*contaDoAndre.Depositar(100);
Console.WriteLine("Saldo da conta do André é de " + contaDoAndre.saldo);

if(contaDoAndre.Sacar(300) == true)
{
    Console.WriteLine("Saldo da conta do André pós-saque é de " + contaDoAndre.saldo);
}
else
{
    Console.WriteLine("Saldo insuficiente.");
}*/

Cliente cliente = new Cliente();
cliente.nome = "José Nascimento";
cliente.cpf = "987654321";
cliente.profissao = "Dev c#";

ContaCorrente conta= new ContaCorrente();
conta.titular = cliente;
conta.conta = "1010-x";
conta.saldo = 100;
conta.numero_agencia = 98;

Console.WriteLine("Cliente: " + conta.titular.nome);
Console.WriteLine("CPF: " + conta.titular.cpf);
Console.WriteLine("Profissão: " + conta.titular.profissao);
Console.WriteLine("------------------------------------------");
Console.WriteLine("Conta: " + conta.conta);
Console.WriteLine("Número da agencia: " + conta.numero_agencia);
Console.WriteLine("Saldo: " + conta.saldo);

