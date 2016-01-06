using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IARS_eBayHTMLBuilder
{
    class ManuFactureCode
    {
        public string sManuFacture { get; set; }
        public string sCode { get; set; }
        public ManuFactureCode(string sManu, string scode)
        {
            sManuFacture = sManu;
            sCode = scode;
        }

        public override string ToString()
        {
            return sManuFacture;
        }
    }
}
