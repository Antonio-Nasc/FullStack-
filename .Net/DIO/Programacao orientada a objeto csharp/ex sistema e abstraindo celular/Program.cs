using ex_sistema_e_abstraindo_celular.models;
Console.WriteLine("SmartPhone Nokia: ");
Smartphone Nokia = new Nokia(numero: "31324", modelo: "Modelo 1", imei: "323131", memoria: 64);
Nokia.Ligar();
Nokia.InstalarAplicativo("");

Console.WriteLine("\n");

Console.WriteLine("SmartPhone Iphone: ");
Smartphone Iphone = new Iphone(numero: "1412", modelo: "Modelo 2", imei: "131", memoria: 128);
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("");

