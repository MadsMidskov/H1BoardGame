﻿using System;
using System.Runtime.CompilerServices;

namespace H1Brætspil
{
    class PlayGame
    {
        public static void Main(string[] args)
        {

            //hvor meget man skal spille til, så den første der rammer måltallet vinder
            int MålTal = 150;

            //bool DuVandt = false;
            Console.WriteLine("Hvad er dit navn?");


            Console.WriteLine("Hvad vil du hedde spiller 1?");
            //Laver et nyt objekt i klassen Player der hedder Player1 
            Player Player1 = new Player();
            Console.WriteLine("Hej " + Player1.name);

            Console.WriteLine("Hvad vil du hedde spiller 2?");
            //Laver et nyt objekt i klassen Player der hedder Player2
            Player Player2 = new Player();
            Console.WriteLine("Hej " + Player2.name);

            //man kan lave en ny terning som man ser inde i while løkken
            Random rnd = new Random();

            //string til at skrive ud at Player1 vinder
            string P1Win = " Tillykke {Player1.name}! Du vandt!";

            //string til at skrive ud at Player2 vinder
            string P2Win = " Tillykke {Player2.name}! Du vandt!";

            //string til at skrive ud hvis de står lige
            string Tie = "I stod lige! Prøv igen for at se hvem der vinder!";

            //Player1 og Player2 skal begge starte på 0
            int P1Plads = 0;
            int P2Plads = 0;

            //hvis DinPlads er mindre en 150 som er målet skal den slå med terningen og lægge TerningsKast til spillernes plads
            while (P1Plads < MålTal && P2Plads < MålTal)
            {
                int P1TerningKast = rnd.Next(1, 7);
                int P2TerningKast = rnd.Next(1, 7);

                P1Plads = P1Plads + P1TerningKast;

                P2Plads = P2Plads + P2TerningKast;


                //hvis din plads er over målet og din plads er større modstanderns har du vundet
                if (P1Plads >= MålTal && P2Plads < MålTal)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(P1Win);
                    Console.WriteLine(Player1.name + " din plads er " + P1Plads + " du slog " + P1TerningKast);
                    Console.WriteLine(Player2.name + " din plads er " + P2Plads + " du slog " + P2TerningKast);

                }
                //Hvis P1Plads er mindre end MålTal og P2Plads er større end eller lig med MålTal 
                else if (P1Plads < MålTal && P2Plads >= MålTal)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(P2Win);
                    Console.WriteLine(Player1.name + " din plads er " + P1Plads + " du slog " + P1TerningKast);
                    Console.WriteLine(Player2.name + " din plads er " + P2Plads + " du slog " + P2TerningKast);

                }
                //Hvis P1Plads og P2Plads er større eller lig med MålPlads står de lige
                else if (P1Plads >= MålTal && P2Plads >= MålTal)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(Tie);
                    Console.WriteLine(Player1.name + " din plads er " + P1Plads + " du slog " + P1TerningKast);
                    Console.WriteLine(Player2.name + " din plads er " + P2Plads + " du slog " + P2TerningKast);

                }
                //Hvis der ikke er nogen der har vundet eller står lige skriver den ud hvor langt man er nået og hvad man senest slog med sin terning
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(Player1.name + " din plads er " + P1Plads + " du slog " + P1TerningKast);
                    Console.WriteLine(Player2.name + " din plads er " + P2Plads + " du slog " + P2TerningKast);
                    Console.WriteLine();
                    Console.WriteLine("Tryk på en knap for at slå med en terning for jer begge!");
                    Console.ReadKey();
                }
            }
        }
    }
}
