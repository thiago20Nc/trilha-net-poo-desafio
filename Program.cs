using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone   
//IMPLEMENTADO! 

Console.WriteLine("\nSmartphone iPhone:");
Iphone iphone = new Iphone(numero:"123456789", modelo:"IPHONE 11", imei: "1111111", memória: 128);
iphone.Ligar(); 
Console.WriteLine("Informações sobre o Smartphone iPhone:");
Console.WriteLine($"Número: {iphone.Numero}"); 
Console.WriteLine($"Modelo: {iphone.GetModelo()}"); 
Console.WriteLine($"Imei: {iphone.GetIMEI()}"); 
Console.WriteLine($"Memória: {iphone.GetMemoria()}GB");
iphone.InstalarAplicativo("Instagran"); 
iphone.ReceberLigacao(); 

//------------------------------------------------------------------------------------------------------------------------------- 

Console.WriteLine("\nSmartphone Nokia:");
Nokia nokia = new Nokia(numero:"987654321", modelo:"Nokia G11", imei: "2222222", memória: 64);
nokia.Ligar(); 
Console.WriteLine("Informações sobre o Smartphone Nokia:");
Console.WriteLine($"Número: {nokia.Numero}"); 
Console.WriteLine($"Modelo: {nokia.GetModelo()}"); 
Console.WriteLine($"Imei: {nokia.GetIMEI()}"); 
Console.WriteLine($"Memória: {nokia.GetMemoria()}GB");
nokia.InstalarAplicativo("Facebook");
nokia.ReceberLigacao(); 
 

