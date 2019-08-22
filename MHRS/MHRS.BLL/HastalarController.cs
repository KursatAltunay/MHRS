using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.DAL;
using MHRS.Entities;
using System.Net.Mail;
using MHRS.DTO;

namespace MHRS.BLL
{
    public class HastalarController
    {
        HastalarManagement _hastalarManagement;

        public HastalarController()
        {
            _hastalarManagement = new HastalarManagement();
        }

        public bool Add(Hastalar hasta)
        {
            CheckValues(hasta);

            bool isExist = CheckMail(hasta.HastaEmail);
            if (isExist)
            {
                throw new Exception("Bu Mail Adresi Sistemde mevcut.");
            }

            CheckTc(hasta.TcNo);
            CheckPassword(hasta.HastaSifre);

            int result = _hastalarManagement.Add(hasta);
            return result > 0;
        }

        void CheckTc(string Tc)
        {
            if (Tc.ToString().Length != 11)
            {
                throw new Exception("Tc kimlik no hatalı");
            }
        }

        void CheckValues(Hastalar hasta)
        {
            if (string.IsNullOrWhiteSpace(hasta.TcNo))
            {
                throw new Exception("TC alanı boş geçilemez");
            }
            else if (string.IsNullOrWhiteSpace(hasta.HastaAdi))
            {
                throw new Exception("Ad Soyad alanı boş geçilemez");
            }
            else if (string.IsNullOrWhiteSpace(hasta.HastaEmail))
            {
                throw new Exception("Email alanı boş geçilemez");
            }
            else if (string.IsNullOrWhiteSpace(hasta.HastaSifre))
            {
                throw new Exception("Parola alanı boş geçilemez");
            }
        }

        void CheckPassword(string pass)
        {
            if (pass.Length < 8)
            {
                throw new Exception("Şifre en az 8 karakter olmalıdır");
            }
            else if (pass.Length > 16)
            {
                throw new Exception("Şifre en fazla 16 karakter olmalıdır");
            }
            
            for (int i = 0; i < pass.Length; i++)
            {
                if (Char.IsSymbol(pass[i]))
                {
                    throw new Exception("Lütfen şifrede özel karakter kullanmayınız");
                }
            }
        }

        bool CheckMail(string mail)
        {
            try
            {
                MailAddress address = new MailAddress(mail);
            }
            catch (Exception)
            {
                throw new Exception("Mail adresi doğru formatta değil");
            }


            List<Hastalar> userList = _hastalarManagement.GetAllPatients();
            foreach (var item in userList)
            {
                if (item.HastaEmail == mail)
                {
                    //methoddan çık demek
                    return true;
                }

            }
            return false;
        }

        public bool Update(Hastalar hasta)
        {
            Hastalar orginalPatient = _hastalarManagement.GetPatientByID(hasta.TcNo);
            orginalPatient.HastaAdi = hasta.HastaAdi;
            orginalPatient.HastaEmail = hasta.HastaEmail;
            orginalPatient.HastaSifre = hasta.HastaSifre;

            //UI tarafında yapılması daha mantıklı

            //if (orginalUser.Email != user.Email)
            //{
            //    throw new Exception("Mail adresi değiştirilemez");
            //}

            int result = _hastalarManagement.Update(orginalPatient);
            return result > 0;
        }

        public bool Delete(Hastalar hasta)
        {
            int result = _hastalarManagement.Delete(hasta.TcNo);
            return result > 0;

        }

        public List<Hastalar> GetUsers()
        {
            return _hastalarManagement.GetAllPatients();
        }

        public Hastalar GetUser(string Tcno)
        {
            return _hastalarManagement.GetPatientByID(Tcno);
        }

        //login işleimde mail ve şifreyle örtüşüyor mu onu kontrol edicez
        public string Login(LoginDTO login)
        {
            List<Hastalar> patients = _hastalarManagement.GetAllPatients();
            foreach (Hastalar item in patients)
            {
                if (item.HastaEmail == login.EMail)
                {
                    if (item.HastaSifre == login.Sifre)
                    {
                        return item.TcNo;
                    }
                    else
                    {
                        return "Şifre Yanlış";
                    }
                }

            }
            return "Mail Yanlış";
        }

    }

}

