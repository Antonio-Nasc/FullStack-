int quantidadeestoque = 10;
int quantidadecompra = 11;
bool possivelVenda = quantidadeestoque >= quantidadecompra;

Console.WriteLine($"É possível realizar a operação? ");

if(possivelVenda){
    Console.WriteLine("Venda realizada.");
}
else{
    Console.WriteLine("Ops! Não temos em estoque a quantidade desejada. :(");
}
