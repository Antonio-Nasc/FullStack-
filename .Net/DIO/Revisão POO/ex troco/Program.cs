Console.WriteLine("Informe o preço do produto: ");
decimal precoProduto = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Informe o valor que você dará para pagar o produto: ");
decimal dinheiroPago = Convert.ToDecimal(Console.ReadLine());

if(dinheiroPago >= precoProduto){
    decimal troco = dinheiroPago - precoProduto;
    Console.WriteLine($"O seu troco é de {troco}");
}
else{
    Console.WriteLine("Compra negada! Dinheiro pago abaixo do preço do produto.");
}
