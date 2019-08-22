using MHRS.DAL;
using MHRS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS.BLL
{
    public class DetaylarController
    {
        DetaylarManagement _detaylarController;

        public DetaylarController()
        {
            _detaylarController = new DetaylarManagement();

        }

        public List<Poliklinikler> GetPoliklinikByHastane(int id)
        {
            return _detaylarController.GetPoliklinikByHastaneID(id);
        }

        public List<Doktorlar> GetDoktorByPoliklinikID(int id)
        {
            return _detaylarController.GetDoktorByPoliklinikID(id);
        }

        public int GetDetayID(int doktorID)
        {
            return _detaylarController.GetDetayID(doktorID);
        }

        public List<Doktorlar> GetDoktorlarByHastane(int id1, int id2)
        {
            return _detaylarController.GetDoktorlarByHastane(id1, id2);
        }

        public List<Hastaneler> GetHastanelerByPoliklinikID(int id)
        {
            return _detaylarController.GetHastaneByPoliklinikID(id);
        } 
    }
}
