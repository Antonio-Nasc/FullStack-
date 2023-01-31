int[] numeros = new int[] { 1, 2, 3, 4 };
int num = numeros[0];
Console.WriteLine(num);

List<int> _numeros = new List<int>();
List<int> qtdNum = new List<int>() { 1, 2, 3, 4 };

int count = qtdNum.Count;
qtdNum.Add(6);
qtdNum.Remove(2);
int numer = qtdNum.ElementAt(0);
qtdNum.Clear();

foreach(int cont in qtdNum){
    Console.WriteLine(cont);
}