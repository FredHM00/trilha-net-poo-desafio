using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testando o Nokia:");
        Smartphone nokia = new Nokia("123456789", "Modelo Nokia", "111222333444555", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine("\nTestando o iPhone:");
        Smartphone iphone = new Iphone("987654321", "Modelo iPhone", "555444333222111", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
