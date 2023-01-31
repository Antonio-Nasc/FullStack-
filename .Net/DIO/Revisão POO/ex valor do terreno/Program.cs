Console.WriteLine("Informe a dimensão da frente");
decimal dimensaoFrente = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Informe a dimensão do fundo");
decimal dimensaoFundo = Convert.ToDecimal(Console.ReadLine());

decimal area = dimensaoFrente * dimensaoFundo;
Console.WriteLine($"A área desse terreno é de {area}m²");
decimal metroQuadrado = 7592m;

decimal precoTerreno = area * metroQuadrado;
Console.WriteLine($"O valor do terreno é de {precoTerreno}");
