Console.WriteLine("Informe 3 valores inteiros: ");
int valor1 = Convert.ToInt32(Console.ReadLine());
int valor2 = Convert.ToInt32(Console.ReadLine());
int valor3 = Convert.ToInt32(Console.ReadLine());

if(valor1 > valor2 && valor1 > valor3){
    Console.WriteLine($"O {valor1} é o maior valor");
} else if(valor2 > valor1 && valor2 > valor3){
    Console.WriteLine($"O {valor2} é o maior valor");
}else{
    Console.WriteLine($"O {valor3} é o maior valor");
}

if(valor1 < valor2 && valor1 < valor3){
    Console.WriteLine($"O {valor1} é o menor valor");
} else if(valor2 < valor1 && valor2 < valor3){
    Console.WriteLine($"O {valor2} é o menor valor");
}else{
    Console.WriteLine($"O {valor3} é o menor valor");
}