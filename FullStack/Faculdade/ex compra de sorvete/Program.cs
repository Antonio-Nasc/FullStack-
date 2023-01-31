Console.WriteLine("Olá, seja bem-vindo a nossa sorveteria!");
Console.WriteLine("No nosso cardápio existem dois sabores, para sabor chocolate Digite o número 1 e para morango Digite o número 2");

int sabor;
sabor = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Agora informe quantas bolas de sorvete o senhor deseja.");
int qntDeBolas;
qntDeBolas = Convert.ToInt32(Console.ReadLine());

if((sabor == 1) && (qntDeBolas <= 3)){
    Console.WriteLine("Desconto de 5%");
}
else if((sabor == 1) && (qntDeBolas > 3)){
    Console.WriteLine("Desconto de 10%");
}
else if((sabor == 2) && (qntDeBolas > 0)){
    Console.WriteLine("Sorvete sem desconto");
} else{
    Console.WriteLine("Sabor ou quantidade de bolas não detectadas");
}



