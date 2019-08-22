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
    public class DoktorlarController
    {
        DoktorlarManagement _doktorlarManagement;

        public DoktorlarController()
        {
            _doktorlarManagement = new DoktorlarManagement();
        }
       
        public List<Doktorlar> GetDoctors()
        {
            return _doktorlarManagement.GetAllDoctors();
        }

        public Doktorlar GetDoctor(int docID)
        {
            return _doktorlarManagement.GetDoctorByID(docID);
        }

        public string Login(LoginDTO login)
        {
            List<Doktorlar> doctors = _doktorlarManagement.GetAllDoctors();
            foreach (Doktorlar item in doctors)
            {
                if (item.DrAdSoyad == login.EMail)
                {
                    if (item.DrSifre == login.Sifre)
                    {
                        return item.DrID.ToString();
                    }
                    else
                    {
                        return "Şifre Yanlış";
                    }
                }

            }
            return "Doktor Adı Yanlış";
        }
    }
}
