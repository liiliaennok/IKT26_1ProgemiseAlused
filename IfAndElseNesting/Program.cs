namespace IfAndElseNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teha üks if ja else nestimine iseseisvalt");
            Console.WriteLine("Teise else if-i sisse panna if and else nestimine");
            //konsool küsib numbrit
            //if võrdub 12
            //else if ja siia sisse omakorda teha if ning else. else if tingimus on, et
            //muutuja on suurem, kui 20
            //else ja seal väljastab konsool teksti: Mingid kahtlased väärtused
            Console.WriteLine("sisesta number");

            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            
            if (number == 12)
            {
                if (number == 12)
                {
                    Console.WriteLine("õige vastus");
                }
                else
                {
                    Console.WriteLine("Vastus oli 12");
                }
            }
            else if (number > 20)

                Console.WriteLine("Mingid kahtlased väärtused");
            {

            }
        }
    }
}
