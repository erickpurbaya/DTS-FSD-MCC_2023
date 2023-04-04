using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Cash_Flow
{
    public class Vendor
    {
        public int vID;
        public string vNAME;
        public string vORIGIN;
        public string vTYPE;
        public int vVERIFIED;

        public Vendor(int vID, string vNAME, string vORIGIN, string vTYPE, int vVERIFIED)
        {
            this.vID = vID;
            this.vNAME = vNAME;
            this.vORIGIN = vORIGIN;
            this.vTYPE = vTYPE;
            this.vVERIFIED = vVERIFIED;
        }
    }
}


