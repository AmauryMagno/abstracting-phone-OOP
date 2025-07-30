using DesafioPOO.Models;

Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789012345", 128);
Iphone iphone = new Iphone("987654321", "Iphone 16", "987654321098765", 256);

Console.WriteLine("Smartphone Nokia:");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstallAplication("Youtube");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstallAplication("Instagram");