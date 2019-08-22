using MHRS.DAL;
using MHRS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS.BLL
{
   public class PolikliniklerController
    {
        PolikliniklerManagement _polikliniklerManagement;

        public PolikliniklerController()
        {
            _polikliniklerManagement = new PolikliniklerManagement();
        }

        public List<Poliklinikler> GetPoliklinikler()
        {
            return _polikliniklerManagement.GetAllPoliklinikler();
        }
        public Poliklinikler GetPoliklinik(int poliklinikID)
        {
            return _polikliniklerManagement.GetPoliklinikByID(poliklinikID);
        }
    }
}
