using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia");
Smartphone nokia = new Nokia("666", "Tijolão", "333", 32);
nokia.Ligar();
nokia.InstalarAplicativo("outlook");

Console.WriteLine("Iphone");
Smartphone iphone = new Iphone("0", "X", "999", 32);
iphone.Ligar();
iphone.InstalarAplicativo("instagram");