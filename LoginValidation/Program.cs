using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus
            //programm küsib kasutajal sisestada parooli
            //programm kontrollib, kas mõlemad, nii kasutajatunnus kui ka parool on õiged
            //kui mõlemad, kasutajatunnus ja parool on õiged, programm kuvab konsoolis "Tere, Tulemast"
            //kui kasutaja tunnus või parool vale siis programm kuvab "sisselogimine ebaõnnestus, proovi uuesti".
            //kt: admin, pr:admin1234
            //kasutajal on kolm katset

            int i = 0;
            while(i < 3)
            {
                Console.WriteLine("sisesta kasutajatunnus");
                string userName = Console.ReadLine();
                Console.WriteLine("sisesta parool");
                string userPassword = Console.ReadLine();
                if(userName == "admin" && userPassword == "admin1234")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    i = i + 1;
                        Console.WriteLine($"Proovi uuesti. {3 - i} katset on jäänud.");
                }

            }

            Console.WriteLine("Kena päeva");

        }
    }
}
