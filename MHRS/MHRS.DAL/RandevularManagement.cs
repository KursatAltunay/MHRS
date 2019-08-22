using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.DTO;
using MHRS.Entities;

namespace MHRS.DAL
{
    public class RandevularManagement
    {
        SqlConnection conn;
        SqlCommand cmd;
        LoginDTO login = new LoginDTO();
        public RandevularManagement()
        {
            conn = new SqlConnection(Properties.Settings.Default.baglanti);
        }
        public int Add(Randevular randevu)
        {
            string query = "Insert into Randevular values(@TcNo,@DetayID,@Tarih,@Saat)";

            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@TcNo", randevu.TcNo);
            cmd.Parameters.AddWithValue("@DetayID", randevu.DetayID);
            cmd.Parameters.AddWithValue("@Tarih", randevu.Tarih);
            cmd.Parameters.AddWithValue("@Saat", randevu.Saat);


            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();

            return result;
        }



        public int Update(Randevular randevu)
        {
            string query = "Update Randevular set TcNo=@tcNo, DetayID=@detayId, Tarih=@tarih, Saat=@saat where RandevuID=@randevuId";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@RandevuID", randevu.RandevuID);
            cmd.Parameters.AddWithValue("@TcNo", randevu.TcNo);
            cmd.Parameters.AddWithValue("@DetayID", randevu.DetayID);
            cmd.Parameters.AddWithValue("@Tarih", randevu.Tarih);
            cmd.Parameters.AddWithValue("@Saat", randevu.Saat);

            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();

            return result;

        }

        public int Delete(int randevuId)
        {
            string query = "Delete from Randevular where RandevuID=@randevuId";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@randevuId", randevuId);

            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();

            return result;


        }
        public List<Randevular> GetAllRandevular()
        {
            List<Randevular> randevuList = new List<Randevular>();
            cmd = new SqlCommand("Select * from Randevular", conn);

            Randevular currentRandevu = null;

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            while (reader.Read())
            {

                currentRandevu = new Randevular();
                currentRandevu.RandevuID = reader.GetInt32(0);
                currentRandevu.TcNo = reader.GetString(1);
                currentRandevu.DetayID = reader.GetInt32(2);
                currentRandevu.Tarih = reader.GetDateTime(3);
                currentRandevu.Saat = reader.GetString(4);
                randevuList.Add(currentRandevu);
            }
            reader.Close();

            return randevuList;
        }


        public List<Randevular> GetAllRandevular(DateTime secilenTarih)
        {
            List<Randevular> randevuList = new List<Randevular>();
            cmd = new SqlCommand("Select * from Randevular where Tarih = @Tarih", conn);
            cmd.Parameters.AddWithValue("@Tarih", secilenTarih);

            Randevular currentRandevu = null;

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            while (reader.Read())
            {

                currentRandevu = new Randevular();
                currentRandevu.RandevuID = reader.GetInt32(0);
                currentRandevu.TcNo = reader.GetString(1);
                currentRandevu.DetayID = reader.GetInt32(2);
                currentRandevu.Tarih = reader.GetDateTime(3);
                currentRandevu.Saat = reader.GetString(4);
                randevuList.Add(currentRandevu);
            }
            reader.Close();

            return randevuList;
        }

        public Randevular GetRandevularByID(int randevuId)
        {
            cmd = new SqlCommand("Select * from Randevular where RandevuID=@randevuId", conn);
            cmd.Parameters.AddWithValue("@randevuId", randevuId);

            Randevular currentRandevu = null;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            reader.Read();

            currentRandevu = new Randevular();
            currentRandevu.RandevuID = reader.GetInt32(0);
            currentRandevu.TcNo = reader.GetString(1);
            currentRandevu.DetayID = reader.GetInt32(2);
            currentRandevu.Tarih = reader.GetDateTime(3);
            currentRandevu.Saat = reader.GetString(4);

            reader.Close();

            return currentRandevu;

        }

        public Randevular GetRandevuDetay(int randevuId)
        {
            cmd = new SqlCommand("Select * from Randevular where RandevuID=@randevuId", conn);
            cmd.Parameters.AddWithValue("@randevuId", randevuId);

            Randevular currentRandevu = null;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            reader.Read();

            currentRandevu = new Randevular();
            currentRandevu.RandevuID = reader.GetInt32(0);
            currentRandevu.TcNo = reader.GetString(1);
            currentRandevu.DetayID = reader.GetInt32(2);
            currentRandevu.Tarih = reader.GetDateTime(3);
            currentRandevu.Saat = reader.GetString(4);

            reader.Close();

            return currentRandevu;

        }

        public string HastaAdiBul(string Tc)
        {
            cmd = new SqlCommand("Select HastaAdSoyad from Hastalar as h join Randevular as r on h.TcNo=r.TcNo where r.TcNo=@HastaTc", conn);
            cmd.Parameters.AddWithValue("@HastaTc", Tc);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            reader.Read();

            string ad = reader.GetString(0);

            conn.Close();

            return ad;
        }

        public List<Randevular> GetRandevulars(string email)
        {

            cmd = new SqlCommand("Select r.TcNo,r.Tarih,r.Saat from Randevular r join Hastalar h on r.TcNo=h.TcNo where HastaEmail=@hastaninmaili", conn);
            cmd.Parameters.AddWithValue("@hastaninmaili", email);

            List<Randevular> randevuList = new List<Randevular>();
            Randevular currentRandevu = null;
            conn.Open();


            SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            while (reader.Read())
            {

                currentRandevu = new Randevular();
                currentRandevu.TcNo = reader.GetString(0);
                currentRandevu.Tarih = reader.GetDateTime(1);
                currentRandevu.Saat = reader.GetString(2);
                randevuList.Add(currentRandevu);
            }
            reader.Close();

            return randevuList;

        }

        public int GetDetaydanDoktor(int detayID)
        {
            cmd = new SqlCommand("Select DrID from Detaylar as d join Randevular as r on r.DetayID = d.DetayID where r.DetayID = @detayID", conn);
            cmd.Parameters.AddWithValue("@detayID", detayID);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            reader.Read();
            int ID = reader.GetInt32(0);
            reader.Close();

            return ID;
        }

        public string[,] IslemYapildiMi(DateTime secilenTarih)
        {
            cmd = new SqlCommand("Select distinct Saat,HastaGeldiMi from Randevular as r join Muayeneler as m on r.RandevuID = m.RandevuID where r.Tarih = @Tarih", conn);
            cmd.Parameters.AddWithValue("@Tarih", secilenTarih);

            string[,] sonuc = new string[20,2];
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            int sayac = 0;
            while (reader.Read())
            {
                sonuc[sayac, 0] = reader.GetString(0);
                sonuc[sayac, 1] = reader.GetString(1);
                sayac++;
            }

            conn.Close();

            return sonuc;
        }

        public List<string> GetDoluSaatler(DateTime secilenTarih, int secilenDoktor)
        {
            List<string> doluSaatler = new List<string>();
            cmd = new SqlCommand("Select Saat from Randevular as r join Detaylar as d on r.DetayID = d.DetayID where r.Tarih = @Tarih and d.DrID = @SecilenDoktor", conn);
            cmd.Parameters.AddWithValue("@Tarih", secilenTarih);
            cmd.Parameters.AddWithValue("@SecilenDoktor", secilenDoktor);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                doluSaatler.Add(reader.GetString(0));
            }
            reader.Close();

            return doluSaatler;
        }
    }
}

