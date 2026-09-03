namespace intro //See on projekti nimetus
{
    internal class Program // see on klassi nimetus
    {
        //meetodit ei saa panna namespace'i, kuna see on klassi sees
        static void Main(string[] args) // see on peamine meetod, mis käivitatakse programmi käivitamisel
        {
            Console.WriteLine("Hello, World!"); // konsooli väljund mis prindib "Hello, world!" ekraanile
            //kui tahad topelt rida teha, siis vajuta Ctrl + shift + D
            //kui tahad kusttada rida, siis vajuta Ctrl + X
        }

        //breakpointi saab panna koodirea vasakule poolele,
        //kus hall ruut. kui programm jõuab
        //selle koodirea juurde, peatub see ja võimaldab teil
        //uurida muutujate väärtusi ja programmi olekut.
    }
}
