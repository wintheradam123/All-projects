using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArray
{
    class Opgaver
    {
        internal static string[] måneder = { "Januar", "Februar", "Marts", "April", "Maj", 
            "Juni", "Juli", "August", "September", "Oktober", "November", "December" };
        
        
        internal static void opg81()
        {
            //Arrayet står ovenfor, udenfor metoden.
            Console.WriteLine("Opgave 8.1\n");
            foreach (var item in måneder)
            {
                Console.WriteLine(item);        //Udskriver hvert item fra vores array
            }
        }

        internal static void opg82()
        {
            Console.WriteLine("Opgave 8.2\n");
            foreach (var item in måneder)
            {
                int IndexOfa = item.IndexOf("a");       //Laver en ny variabel med IndexOf som tjekker om der er et lille a
                int IndexOfA = item.IndexOf("A");       //Tjekker om der er et stort A

                if (IndexOfa != -1)     //Hvis vores tidligere oprettede variabel har et a gør den det nedenstående
                {
                    Console.WriteLine(item);
                }
                if (IndexOfA != -1)     //Hvis vores tidligere oprettede variabel har et A gør den det nedenstående
                {
                    Console.WriteLine(item);
                }

            }
        }

        internal static void opg83()
        {
            Console.WriteLine("Opgave 8.3\n");
            Array.Sort(måneder, StringComparer.InvariantCulture);   //Sorterer arrayet alfabetisk
            foreach (var item in måneder)
            {

                if (item.Length>4)      //Tjekker om vores item er over 4 tegn
                {
                    Console.WriteLine(item);        //Udskriver vores item
                }
            }
        }

        internal static void opg84()
        {
            Console.WriteLine("Opgave 8.4\n");
            Array.Resize(ref måneder, måneder.Length + 1);  //Vi tilføjer en plads til vores array
            måneder[måneder.Length - 1] = "Bichat";         //Tilføjer i dette tilfælde Bichat til den sidste plads i vores array.

            foreach (var item in måneder)
            {
                Console.WriteLine(item);                    //Vi udskriver vores array
            }
        }
    }
}
