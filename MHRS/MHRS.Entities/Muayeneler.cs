using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS.Entities
{
    public class Muayeneler
    {
        public int MuayeneID { get; set; }
        public byte HastaGeldiMi { get; set; }
        public int RandevuID { get; set; }
        public string MuayeneNot { get; set; }


    }
}
