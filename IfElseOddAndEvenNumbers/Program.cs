namespace IfElseOddAndEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Konsool küsib numbrit
            //number tuleb ära parsida'

            //if ja else juures toimub kontroll, et
            //kas on paaris või paaritu number
            Console.WriteLine("Sisestage number");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                //% jagab muutujat kahega
                //kui kahe asemele panna 3 siis jagab kolmega
                if (number % 2 == 0)
                {
                    Console.WriteLine("Number on paaris " + number);
                    Paaris();
                    //siia tuleb välja kutsuda meetod,
                    //mis ütleb, et see on paarisarv

                }
                else if (number == 67)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("KUUS SEITSE :3");
                }
                else
                {
                    Console.WriteLine("Number on paaritu " + number);
                    Paaritu();
                    //siia tuleb välja kutsuda meetod
                    //mis ütleb, et see on paarituarv
                }
            }
            string nr = Console.ReadLine();
            int numbrid = int.Parse(nr);

            if (numbrid % 2 == 0)
            {
                Console.WriteLine("Number on paaris!");
            }
            else
            {
                Console.WriteLine("Number on paaritu!");
            }
        }
        static void Paaris()
        {
            Console.WriteLine("Arv on paaris");
        }
        static void Paaritu()
        {
            Console.WriteLine("Arv on paaritu");
        }
    }
}
