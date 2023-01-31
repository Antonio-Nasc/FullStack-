const string DIAS_31 = "Este mês tem 31 dias!";
const string DIAS_30 = "Este mês tem 30 dias!";
const string DIAS_28 = "Este mês tem 28 dias!";
const string MES_INVALIDO = "Este mês não existe";

Console.WriteLine("Escreva um mês: ");
string mes = Console.ReadLine();
switch (mes.ToUpper()){
    case "JANEIRO":
        Console.WriteLine(DIAS_31);
        break;
    case "FEVEREIRO":
        Console.WriteLine(DIAS_28);
        break;
    case "ABRIL":
        Console.WriteLine(DIAS_30);
        break;
    default:
        Console.WriteLine(MES_INVALIDO);
        break;
}
