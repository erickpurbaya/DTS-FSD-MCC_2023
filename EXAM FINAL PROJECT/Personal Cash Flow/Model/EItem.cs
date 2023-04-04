using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Cash_Flow.Model
{
    public class Item
    {
        public int iID;
        public string iNAME;
        public int iPRICE;
        public int iTOTAL;
        public string iTYPE;
        public int iVENDOR;
        public int iHALAL;

        public Item(int iID, string iNAME, int iPRICE, int iTOTAL, string iTYPE, int iVENDOR, int iHALAL) { 
            this.iID = iID;
            this.iNAME = iNAME; 
            this.iPRICE = iPRICE;
            this.iTOTAL = iTOTAL; 
            this.iTYPE = iTYPE;
            this.iVENDOR = iVENDOR;
            this.iHALAL = iHALAL;
        }
    }
}
