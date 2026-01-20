using Lab1;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Proizvod p = new Proizvod("Televizija",299 , 14);
            p.IspisiInformacije();

            Console.WriteLine();

            PametniTelefon tel = new PametniTelefon("Honor 200 PRO","Honor",2024,"Android");

            tel.IspisiInformacije();
            tel.InstalirajAplikaciju("Njuškalo");
        }
    }
}
