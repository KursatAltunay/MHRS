using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.Entities;

namespace MHRS.DAL
{
   public class HastalarManagement
    {
        SqlConnection conn;
        SqlCommand cmd;

        public HastalarManagement()
        {
            conn = new SqlConnection(Properties.Settings.Default.baglanti);
        }

        public int Add(Hastalar hasta)
        {
            string query = "Insert into Hastalar values(@Tc,@AdSoyad,@Email,@Sifre)";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Tc", hasta.TcNo);
            cmd.Parameters.AddWithValue("@AdSoyad", hasta.HastaAdi);
            cmd.Parameters.AddWithValue("@Email", hasta.HastaEmail);
            cmd.Parameters.AddWithValue("@Sifre", hasta.HastaSifre);

            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();

            return result;
        }

        public int Update(Hastalar hasta)
        {
            string query = "Update Hastalar set HastaSifre=@Sifre where TcNo=@Tc";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Tc", hasta.TcNo);
            cmd.Parameters.AddWithValue("@Sifre", hasta.HastaSifre);

            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();

            return result;
        }

        public int Delete(string tcNo)
        {
            string query = "Delete from Hastalar where TcNo=@Tc";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Tc", tcNo);

            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();

            return result;
        }

        public List<Hastalar> GetAllPatients()
        {
            List<Hastalar> userList = new List<Hastalar>();
            cmd = new SqlCommand("Select * from Hastalar", conn);
          
            Hastalar currentPatient = null;

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                currentPatient = new Hastalar();

                currentPatient.TcNo = reader.GetString(0);
                currentPatient.HastaAdi = reader.GetString(1);
                currentPatient.HastaEmail = reader.GetString(2);
                currentPatient.HastaSifre = reader.GetString(3);
                userList.Add(currentPatient);
            }
            reader.Close();

            return userList;
        }

        public Hastalar GetPatientByID(string Tc)
        {
            cmd = new SqlCommand("Select * from Hastalar where TcNo=@Tc", conn);
            cmd.Parameters.AddWithValue("@Tc", Tc);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            reader.Read();
            Hastalar currentPatient = new Hastalar();

            currentPatient.TcNo = Tc;
            currentPatient.HastaAdi = reader.GetString(1);
            currentPatient.HastaEmail = reader.GetString(2);
            currentPatient.HastaSifre = reader.GetString(3);

            reader.Close();

            return currentPatient;
        }
    }
}
