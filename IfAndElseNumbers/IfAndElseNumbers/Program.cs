namespace IfAndElseNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number");

            //konsoolis sisestame numbri
            //see number salvestatakse string andmetüüpi
            //toimub kontroll, kas sisestatud väärtus on number
            //kasutada if ja else lauseid
            string input = Console.ReadLine();

            //kontrollime, kas sisestatud väärtus on number
            if (int.TryParse(input, out int number))
            {
                Console.WriteLine("sisestasid numbri");
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("ERROR.Numbrit ei sisestatud");
            }
        }
            
    }
}
