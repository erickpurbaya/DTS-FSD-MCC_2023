using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Cash_Flow.Model
{
    public class Purchase
    {
        public int pID;
        public DateTime pDATE;
        public int pTOTAL;
        public string pITEM;
        public int pvID;
        public int pPAID;

        public Purchase(int pID, int pTOTAL, string pITEM, int pvID, int pPAID)
        {
            this.pID = pID;
            this.pDATE = DateTime.Now;
            this.pTOTAL = pTOTAL;
            this.pITEM = pITEM;
            this.pvID = pvID;
            this.pPAID = pPAID;
        }
}
   
}
