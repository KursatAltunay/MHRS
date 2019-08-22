using MHRS.DAL;
using MHRS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS.BLL
{
    public class HastanelerController
    {
        HastanelerManagement _hastanelerManagement;

        public HastanelerController()
        {
            _hastanelerManagement = new HastanelerManagement();
        }

        public List<Hastaneler> GetHastanelers()
        {
            return _hastanelerManagement.GetAllHastanes();
        }
        public Hastaneler GetHastane(int hastaneID)
        {
            return _hastanelerManagement.GetHastaneByID(hastaneID);
        }
    }
}
