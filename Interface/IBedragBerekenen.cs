using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HypotheekTool.Interface
{
    internal interface IBedragBerekenen
    { 
        void Calculate(int? inkomsten, bool? studieSchuld);
    }
}
