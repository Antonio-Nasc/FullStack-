using bytebank;

ContaCorrente contaDoAndre = new ContaCorrente();

contaDoAndre.titular = "André Silva";
contaDoAndre.conta = "1010-X";
contaDoAndre.numero_agencia = 15;
contaDoAndre.saldo = 100;

Console.WriteLine("Titular: " + contaDoAndre.titular);
