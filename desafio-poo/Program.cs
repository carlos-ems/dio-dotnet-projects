using DesafioPOO.Models;

// Realizar os testes com as classes Nokia e Iphone

// Teste para a classe Nokia
Nokia nokia1 = new Nokia("119509092200", "Nokia Lumia", "12345678910", 32);

Console.WriteLine("---- Teste da classe Nokia ----");
nokia1.Ligar();
nokia1.ReceberLigacao();
nokia1.InstalarAplicativo("Instagram");
Console.WriteLine("------------------------------\n");

Iphone iphone1 = new Iphone("11948211016", "iPhone 16", "11121314150", 128);

Console.WriteLine("---- Teste da classe Iphone ----");
iphone1.Ligar();
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("X (ex Twitter)");
Console.WriteLine("------------------------------");