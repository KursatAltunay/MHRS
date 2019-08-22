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
   
    public class RandevularController
    {
        LoginDTO login = new LoginDTO();
        RandevularManagement _randevularmanagement;
        public RandevularController()
        {
            _randevularmanagement = new RandevularManagement();
        }

        public bool Add(Randevular randevu)
        {
            CheckValues(randevu);
            int result = _randevularmanagement.Add(randevu);
            return result > 0;
        }
        public bool Update(Randevular randevu)
        {
            Randevular orginalRandevu = _randevularmanagement.GetRandevularByID(randevu.RandevuID);
            orginalRandevu.TcNo = randevu.TcNo;
            orginalRandevu.Tarih = randevu.Tarih;
            orginalRandevu.Saat = randevu.Saat;
            orginalRandevu.DetayID = randevu.DetayID;

            int result = _randevularmanagement.Update(orginalRandevu);
            return result > 0;
        }
        public bool Delete(int randevuId)
        {
            int result = _randevularmanagement.Delete(randevuId);
            return result > 0;

        }
        void CheckValues(Randevular randevu)
        {
            if (string.IsNullOrWhiteSpace(Convert.ToString(randevu.TcNo)))
            {
                throw new Exception("TcNo boş geçilemez");
            }
            else if (string.IsNullOrWhiteSpace(Convert.ToString(randevu.Tarih)))
            {
                throw new Exception("Tarih alanı boş geçilemez");
            }
            else if (string.IsNullOrWhiteSpace(Convert.ToString(randevu.Saat)))
            {
                throw new Exception("Saat boş geçilemez");
            }

        }
        
        public List<Randevular> GetRandevularsByTC(string email)
        {
            return _randevularmanagement.GetRandevulars(email);
        }
        public List<Randevular> GetAllRandevular()
        {
            return _randevularmanagement.GetAllRandevular();
        }


        public List<Randevular> GetAllRandevular(DateTime secilenTarih)
        {
            return _randevularmanagement.GetAllRandevular(secilenTarih);
        }

        public List<Randevular> GetRandevularByHastalar(int randevuId, DateTime secilenTarih)
        {
            List<Randevular> randevular = new List<Randevular>();
            foreach (Randevular item in _randevularmanagement.GetAllRandevular(secilenTarih))
            {
                if (item.RandevuID == randevuId)
                {
                    randevular.Add(item);
                }
            }
            return randevular;
        }

        public string HastaAdiBul(string Tc)
        {
            return _randevularmanagement.HastaAdiBul(Tc);
        }

        public List<Randevular> GetRandevularByHastalar(int randevuId)
        {
            List<Randevular> randevular = new List<Randevular>();
            foreach (Randevular item in _randevularmanagement.GetAllRandevular())
            {
                if (item.RandevuID == randevuId)
                {
                    randevular.Add(item);
                }
            }
            return randevular;
        }

        public List<string> GetDoluSaatler(DateTime secilenTarih, int secilenDoktor)
        {
            return _randevularmanagement.GetDoluSaatler(secilenTarih, secilenDoktor);
        }

        public string[,] IslemYapildiMi(DateTime secilenTarih)
        {
            return _randevularmanagement.IslemYapildiMi(secilenTarih);
        }

        public int GetDetaydanDoktor(int detayID)
        {
            return _randevularmanagement.GetDetaydanDoktor(detayID);
        }
    }
}
