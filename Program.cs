using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("---------------- Smartphone Nokia ----------------");
Smartphone nokia = new Nokia(numero: "(xx)xxxxx-xxxx", modelo: "Modelo EGM-150", imei:"789456123", memoria: 160);
nokia.Ligar();
nokia.InstalarAplicativo("Instagran");

Console.WriteLine("\n");

Console.WriteLine("---------------- Smartphone Nokia ----------------");
Smartphone iphone = new Iphone(numero: "(xx)xxxxx-xxxx", modelo: "Modelo KFW-130", imei:"123456789", memoria: 180);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");
