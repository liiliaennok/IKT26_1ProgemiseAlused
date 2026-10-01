namespace IfElseColours
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Värvide valikuks on: red, blue, green ja white" + "Sisesta värv"); 


            Console.WriteLine("Sisestage enda värv");
            string color = Console.ReadLine();

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
