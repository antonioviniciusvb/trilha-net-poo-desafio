using DesafioPOO.Models;

// Implementação: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("+55 099 94125-4125", "m74", "1452678", 258);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("----------");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("+55 011 95555-4444", "PRO 15 max", "7855215", 500);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");





//Console.WriteLine( nokia.Memoria);
