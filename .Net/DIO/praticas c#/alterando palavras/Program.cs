using System.Text;

string frase = "Brasil x Sérvia na quinta-feira";
Console.WriteLine(frase.Replace("Sérvia", "Argentina"));


Program p = new Program();
string Frase = "O Palmeiras não tem mundial";

Console.WriteLine(p.Alterar(Frase));


private string Alterar(string Frase){
    if(Frase.Trim().Length > 0){
        int Total = Frase.Length;
        int Count = 0;

        var StringBuilder = new StringBuilder();

        while(Count < Total){
            if(StringBuilder[Count] == "o"){
                StringBuilder[Count] = '&';
            }
            Count++;
        }

        Frase = StringBuilder.ToString();
        return Frase;
    }
    else{
        return null;
    }
}