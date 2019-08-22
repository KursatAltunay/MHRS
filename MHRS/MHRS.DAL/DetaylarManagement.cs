using MHRS.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS.DAL
{
   public class DetaylarManagement
    {
        SqlConnection conn;
        SqlCommand cmd;

        public DetaylarManagement()
        {
            conn = new SqlConnection(Properties.Settings.Default.baglanti);
        }

        public List<Poliklinikler> GetPoliklinikByHastaneID(int Id)
        {
            List<Poliklinikler> detayList = new List<Poliklinikler>();
            cmd = new SqlCommand("Select distinct p.PoliklinikID as PID,p.PoliklinikAdi as PAD from Poliklinikler as p join Detaylar as  d  on p.PoliklinikID=d.PoliklinikID  where d.HastaneID=@Id order by p.PoliklinikID", conn);
            cmd.Parameters.AddWithValue("@Id", Id);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            while (reader.Read())
            {

                Poliklinikler currentHastane = new Poliklinikler();

                currentHastane.PoliklinikID = reader.GetInt32(0);
                currentHastane.PoliklinikAdi = reader.GetString(1);

                detayList.Add(currentHastane);
            }

            reader.Close();

            return detayList;
        }

        public List<Doktorlar> GetDoktorByPoliklinikID(int Id)
        {
            List<Doktorlar> detayList = new List<Doktorlar>();
            cmd = new SqlCommand("Select distinct dr.DrID,dr.DrAdSoyad from Doktorlar as dr join Detaylar as  d  on dr.DrID=d.DrID  where d.PoliklinikID=@Id order by dr.DrAdSoyad", conn);
            cmd.Parameters.AddWithValue("@Id", Id);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            while (reader.Read())
            {
                Doktorlar currentPoliklinik = new Doktorlar();

                currentPoliklinik.DrID = reader.GetInt32(0);
                currentPoliklinik.DrAdSoyad = reader.GetString(1);

                detayList.Add(currentPoliklinik);
            }

            reader.Close();

            return detayList;
        }

        public int GetDetayID(int doktorID)
        {
            cmd = new SqlCommand("Select DetayID from Detaylar where DrID=@Id", conn);
            cmd.Parameters.AddWithValue("@Id", doktorID);


            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            reader.Read();
            
            int donen = reader.GetInt32(0);

            reader.Close();

            return donen;
        }

        public List<Doktorlar> GetDoktorlarByHastane(int Id1, int Id2)
        {
            List<Doktorlar> detayList = new List<Doktorlar>();
            cmd = new SqlCommand("select distinct dr.DrID,dr.DrAdSoyad from Doktorlar dr join Detaylar d on dr.DrID=d.DrID join Hastaneler h on d.HastaneID=h.HastaneID where h.HastaneID=@Id1 and d.PoliklinikID=@Id2 order by dr.DrAdSoyad", conn);
            cmd.Parameters.AddWithValue("@Id1", Id1);
            cmd.Parameters.AddWithValue("@Id2", Id2); //poli

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            while (reader.Read())
            {
                Doktorlar currentHastane = new Doktorlar();

                currentHastane.DrID = reader.GetInt32(0);
                currentHastane.DrAdSoyad = reader.GetString(1);

                detayList.Add(currentHastane);
            }

            reader.Close();

            return detayList;
        }

        public List<Hastaneler> GetHastaneByPoliklinikID(int Id)
        {
            List<Hastaneler> detayList = new List<Hastaneler>();
            cmd = new SqlCommand("select distinct h.HastaneID,h.HastaneAdi from Hastaneler as h join Detaylar as d on h.HastaneID=d.HastaneID where d.PoliklinikID=@Id order by h.HastaneAdi", conn);
            cmd.Parameters.AddWithValue("@Id", Id);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            while (reader.Read())
            {
                Hastaneler currentPoliklinik = new Hastaneler();

                currentPoliklinik.HastaneID = reader.GetInt32(0);
                currentPoliklinik.HastaneAdi = reader.GetString(1);

                detayList.Add(currentPoliklinik);
            }

            reader.Close();

            return detayList;
        }
    }
}
