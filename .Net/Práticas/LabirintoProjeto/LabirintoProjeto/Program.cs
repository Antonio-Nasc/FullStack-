using System.Xml;

string titulo = "Labirinto";
Console.Title = titulo;

string[,] labirinto = new string[4, 5]
{
    {"1","0","0","0","1" },
    {"0","0","1","0","1" },
    {"1","1","1","0","F" },
    {"1","1","1","1","1" }
};

string player = "X";
labirinto[1, 0] = player;

for (int linha = 0; linha < 4; linha++)
{
    for(int coluna = 0; coluna < 5; coluna++)
    {
        Console.Write(labirinto[linha, coluna] + " ");
    }
    Console.WriteLine();
}