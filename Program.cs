using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone iphone = new Iphone("99111-1111", "Iphone 11", "123456789", 128);
Console.WriteLine(iphone.ToString());
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");
Console.WriteLine();
Console.WriteLine("==============================================");
Console.WriteLine();
Nokia nokia = new Nokia("99222-2222", "Nokia X-11", "987654321", 64);
Console.WriteLine(nokia.ToString());
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("TIK-TOK");
Console.WriteLine("==============================================");