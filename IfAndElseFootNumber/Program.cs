namespace IfAndElseFootNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                if (number > 29)
                {
                    if (number < 34)
                    {
                        Console.WriteLine("Jalasuurus on vahemikus 30-33");
                    }
                }
                if (number > 34)
                {
                    if (number < 38)
                    {
                        Console.WriteLine("Jalasuurus on vahemikus 34-38");
                    }
                }
                if (number > 38)
                {
                    if (number < 44)
                    {
                        Console.WriteLine("Jalanumber on vahemikus 39-44");
                    }
                }
                if (number >= 45 && number <= 48)
                {
                    Console.WriteLine("Jalanumber on vahemikus 45-48");
                }
                else
                {
                    Console.WriteLine("Number pole vahemikus");
                }
            }
        }
    }
}
