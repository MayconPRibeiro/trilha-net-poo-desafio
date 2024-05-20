using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// IMPLEMENTADO COM SUCESSO

Console.WriteLine("Teste Nokia:");
Smartphone smartNokia = new Nokia("11988888888", "Nokia Indestrutível", "123456789", 64);
smartNokia.Ligar();
smartNokia.ReceberLigacao();
smartNokia.InstalarAplicativo("Whatsapp");


Console.WriteLine("\nTeste Iphone:");
Smartphone smartIphone = new Iphone("1199999999", "Iphone 6s", "987654321", 128);
smartIphone.Ligar();
smartIphone.ReceberLigacao();
smartIphone.InstalarAplicativo("Telegram");