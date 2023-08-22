using DesafioPOO.Models;

Iphone iphone = new Iphone("98542", "11", "456852357159", 128);
Nokia nokia = new Nokia("33954897528", "S21", "255842154459", 256);

System.Console.WriteLine("Smartphone Iphone");
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");

System.Console.WriteLine("\n");


System.Console.WriteLine("Smartphone Nokia");
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Bing");



