Console.WriteLine("Informe seu peso");
double peso = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe sua altura");
double altura = Convert.ToDouble(Console.ReadLine());
double alturaResultado = Math.Pow(altura, 2);
double imc = peso / alturaResultado;


if(imc < 18.5){
    Console.WriteLine("Magreza");
}
else if(imc >= 18.5 && imc < 25.0){
    Console.WriteLine("Normal");
}
else if(imc >= 25.0 && imc < 30.0){
    Console.WriteLine("Sobrepeso");
}
else if(imc >= 30.0 && imc < 40.0){
    Console.WriteLine("Obesidade");
}
else{
    Console.WriteLine("Obesidade grave");
}
