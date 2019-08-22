using MHRS.DAL;
using MHRS.DTO;
using MHRS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS.BLL
{
    
   public class EczanelerController
    {
        EczanelerManagement _eczanelerManagement;

        public EczanelerController()
        {
            _eczanelerManagement = new EczanelerManagement();
        }

        public List<Eczaneler> GetAllEczaneler()
        {
            return _eczanelerManagement.GetAllEczaneler();
        }

        public Eczaneler GetEczane(int eczID)
        {
            return _eczanelerManagement.GetEczaneByID(eczID);
        }

        public string Login(LoginDTO login)
        {
            List<Eczaneler> eczaneler = _eczanelerManagement.GetAllEczaneler();
            foreach (Eczaneler item in eczaneler)
            {
                if (item.EczaneAdı == login.EMail)
                {
                    if (item.EczaneSifre == login.Sifre)
                    {
                        return item.EczaneID.ToString();
                    }
                    else
                    {
                        return "Şifre Yanlış";
                    }
                }

            }
            return "Eczane Adı Yanlış";
        }
    }

}

