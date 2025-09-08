using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia meuNokia = new Nokia("4144544", "A-90", "10987545", 1200);
meuNokia.Ligar();
meuNokia.InstalarAplicativo("Whatsapp");
meuNokia.ReceberLigacao(meuNokia.Numero);

Console.WriteLine(@"
-----------------------
");
Iphone meuIphone = new Iphone("8855-3255", "20-Plus", "0000000", 44000);
meuIphone.Ligar();
meuIphone.InstalarAplicativo("Instagram");
meuIphone.ReceberLigacao(meuIphone.Numero);

Console.WriteLine(@"
-----------------------
");