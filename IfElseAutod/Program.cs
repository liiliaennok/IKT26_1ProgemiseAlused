namespace IfElseAutod
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //kasutada if ja else 
            //kirjuta automark
            //valikus on BMW, Audi, Porsche, Fiat ja Skoda
            //Kui valitakse Skoda, siis seal sees on uuesti küsimus, et
            //mis mudelit soovid valida. Mudeli valikus on Kodiaq ja Octavia

            Console.WriteLine("Sisestage oma automark");
            string input = Console.ReadLine();
            if (input == "BMW")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Valisite BMW!");
            }
            else if (input == "Audi")
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Valisite Audi!");
            }
            else if (input == "Porsche")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Valisite Porsche!");
            }
            else if (input == "Fiat")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Valisite Fiat!");
            }
            else if (input == "Skoda")
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Valisite Skoda!");
                Console.WriteLine("---------------");
                Console.WriteLine("Palun valige mudel. Valikud Kodiaq ja Octavia");
                string skoda = Console.ReadLine();
                if (skoda == "Kodiaq")
                {
                    Console.WriteLine("Valisite Skoda Kodiaq!");
                }
                else if (skoda == "Octavia")
                {
                    Console.WriteLine("Valisite Skoda Octavia!");
                }
            }
        }
    }
}
