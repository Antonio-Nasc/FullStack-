using ex_conta_corrente.models;

ContaCorrente c1 = new ContaCorrente(123, 200);
c1.ExibirSaldo();
c1.Sacar(300);
c1.ExibirSaldo();
