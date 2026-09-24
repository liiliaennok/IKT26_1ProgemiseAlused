namespace IfElseColour
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Teha if ja else konsoolirakendus, kus kontrollitakse stringi abil värvi vastavust

            //Värvide valikuks on: red, blue, green ja white

            //Peab käsitlema juhust, kus vastaja ei sisesta eelpool sisestatud värvi

            Console.WriteLine("Sisestage enda värv");

            string color = Console.ReadLine();

            //see kontrollib, kas on punane värv
            //kui kasutad if ja else, siis esimene kontroll on if
            //ja järgneb else if ning kõige viimane on alati else
            if (color == "punane")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Punane!! :3");
                
            }
            else if (color == "sinine")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Sinine!! :3");
            }
            else if (color == "roheline")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Roheline!! :3");
            }
            else if (color == "valge")
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Valge!! :3");
            }
            else
            {
                Console.WriteLine("seda värvi pole :(");
            }
        }
    }
}
