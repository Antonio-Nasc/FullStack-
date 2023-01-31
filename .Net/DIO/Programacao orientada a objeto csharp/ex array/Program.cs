int[] arrayInteiro = new int[3];
arrayInteiro[0] = 12;
arrayInteiro[1] = 7;
arrayInteiro[2] = 52;

Array.Resize(ref arrayInteiro, arrayInteiro.Length + 2);

Console.WriteLine("Percorrendo o Array com o FOR");

for( int contador = 0; contador < arrayInteiro.Length; contador++) {
    Console.WriteLine($"Posição Nº {contador} - {arrayInteiro[contador]}");
}

string[] carros = {"Polo", "fox"};

Console.WriteLine(carros[1]);

for(int cont = 0; cont < carros.Length; cont++){
    Console.WriteLine($"Nº {cont} - {carros[cont]}");
}

Console.WriteLine("Percorrendo o Array com o FOREACH");

int contadorForeach = 0;
foreach(int valor in arrayInteiro){
    Console.WriteLine($"Nº {contadorForeach} - {valor}");
    contadorForeach++;
}

foreach(string result in carros){
    Console.WriteLine(result);
}
