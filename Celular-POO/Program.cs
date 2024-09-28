﻿using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia =  new Nokia(numero: "123456", modelo: "Modelo 1", imei: "1234", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone =  new Iphone(numero: "144856", modelo: "Modelo 2", imei: "1848", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");