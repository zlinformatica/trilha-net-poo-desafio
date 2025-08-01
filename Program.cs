using DesafioPOO.Models;
using Microsoft.Win32.SafeHandles;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia(numero: "975345022", modelo: "Nokia NK22", imei: "356789123456789", memoria: 64);
Console.WriteLine($"Smartphone Modelo: {nokia.Modelo}, Número: {nokia.Numero}, IMEI: {nokia.IMEI}");

nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Smartphone iphone = new Iphone(numero: "975762383", modelo: "Iphone IP45", imei: "490154203237518", memoria: 128);
Console.WriteLine($"Smartphone Modelo: {iphone.Modelo}, Número: {iphone.Numero}, IMEI: {iphone.IMEI}");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
