List<string> lista = new List<string>();
lista.Add("BA");
lista.Add("SP");
lista.Add("SE");

Console.WriteLine(lista[0]);

int cont = 0;
foreach(string item in lista){
    Console.WriteLine($"{cont} - {item}");
    cont++;
}
