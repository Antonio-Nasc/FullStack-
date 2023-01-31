double[] notas = new double[20];
for (int i = 0; i < notas.Length; i++){
    Console.WriteLine("Informe a nota");
    notas[i] = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine("Notas > 7.5");
for (int i = 0; i < notas.Length; i++){
    if(notas[i] > 7.5)
        Console.WriteLine(notas[i]);
}
