int[] idade = new int[10];
for (int i = 0; i < idade.Length; i++){
    Console.WriteLine("Informe a idade: ");
    idade[i] = Convert.ToInt32(Console.ReadLine());
}
Array.Sort(idade);
foreach(int j in idade){
    Console.WriteLine(j);
}
