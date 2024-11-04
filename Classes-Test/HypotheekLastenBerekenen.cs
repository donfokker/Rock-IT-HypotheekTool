using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HypotheekTool.Interface;

namespace HypotheekTool.Classes
{
    internal class HypotheekLastenBerekenen : IHypotheekLasten
    {
        public void Calculate(int? inkomsten, int? aantalJaar)
        {
            int leenBedrag;
            double? precentage = null;
            double? maandelijkseRenteLasten = null;

            GetData:
            int? maandelijkseHypotheekLasten = inkomsten / 12 / 5;
            Console.WriteLine("Wat is het leen bedrag?");
            string leenBedragString = Console.ReadLine();
            if (int.TryParse(leenBedragString, out int leenBedragToInt))
            {
                leenBedrag = leenBedragToInt;
            }
            else
            {
                Console.WriteLine("\nInput wordt niet toegestaan probeer opnieuw...");
                goto GetData;
            }

            switch (aantalJaar)
            {
                case 1:
                    precentage = 2;
                    break;
                case 5:
                    precentage = 3;
                    break;
                case 10:
                    precentage = 3.5;
                    break;
                case 20:
                    precentage = 4.5;
                    break;
                case 30:
                    precentage = 5;
                    break;
            }

            maandelijkseRenteLasten = maandelijkseHypotheekLasten / 100 * precentage;
            Console.WriteLine($"Maandelijkse hypotheek lasten van u zijn {maandelijkseHypotheekLasten}");
            Console.WriteLine($"Maandelijkse rente lasten van u zijn {maandelijkseRenteLasten}");

            double? totaal = maandelijkseHypotheekLasten + maandelijkseRenteLasten;
            Console.WriteLine($"Totale maandelijkse kosten per maand is {totaal}");
        }
    }
}
