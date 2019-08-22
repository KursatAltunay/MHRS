using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS.Entities
{
    public class Randevular
    {
       
        public int RandevuID { get; set; }

        public string TcNo { get; set; }

        public int DetayID { get; set; }
        public DateTime Tarih { get; set; }
        public string Saat { get; set; }
    }
}
