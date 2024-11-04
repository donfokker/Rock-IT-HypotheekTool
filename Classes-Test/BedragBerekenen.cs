using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HypotheekTool.Interface;

namespace HypotheekTool.Classes
{
    internal class BedragBerekenen : IBedragBerekenen
    {
        public void Calculate(int? inkomsten, bool? studieSchuld)
        {
            int? leenBedrag;
            if (studieSchuld == true)
            {
                leenBedrag = inkomsten * 3;
                Console.WriteLine($"Maximaal leen bedrag = {leenBedrag}");
            }
            else
            {
                leenBedrag = inkomsten * 4;
                Console.WriteLine($"Maximaal leen bedrag = {leenBedrag}");
            }
        }
    }
}
