using MHRS.DAL;
using MHRS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS.BLL
{
    public class MuayenelerController
    {
        MuayenelerManagement _muayenelerManagement;

        public MuayenelerController()
        {
            _muayenelerManagement = new MuayenelerManagement();
        }

        public bool Add(Muayeneler muayene)
        {
            int result = _muayenelerManagement.Add(muayene);
            return result > 0;
        }

        public bool Delete(Muayeneler muayene)
        {
            int result = _muayenelerManagement.Delete(muayene.MuayeneID);
            return result > 0;
        }
    }
}
