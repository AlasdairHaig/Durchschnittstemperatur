using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Durchschnittstemperatur
{
    class Program
    {

        static void Main(string[] args)
        {

            int maxTemp = 0;
            int minTemp = 0;
            int durchscnittsTemp = 0;

            //Fragen nach die Temperaturen und holen die Temperaturen ab
            Console.WriteLine("Diese Anwendung erreicht die Durchschnittstemperatur.");
            Console.WriteLine("Geben Sie bitte die maximale Temperatur: ");
            prüfenTemp();
            maxTemp = prüfenZahl;
            Console.WriteLine("Geben Sie bitte die mindeste Temperatur: ");
            prüfenTemp();
            minTemp = prüfenZahl;


            //Errechnen die Durchschnittstemperatur
            durchscnittsTemp = (maxTemp + minTemp) / 2;

            //Zeigen die Durchschnittstemperatur an
            Console.WriteLine("Die Durchschnittstemperatur ist " + durchscnittsTemp + "°");
            Console.ReadLine();
        }
        public static void prüfenTemp()
        {

            prüfenZahl = Convert.ToInt32(Console.ReadLine());
            while (prüfenZahl > 200 || prüfenZahl < -200)
            {
                Console.WriteLine("Bitte geben Sie eine realistische Zahl");
                prüfenZahl = Convert.ToInt32(Console.ReadLine());
            }
        }


        public static int prüfenZahl { get; set; }
    }
}
