using MHRS.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS.DAL
{
    public class DoktorlarManagement
    {
        SqlConnection conn;
        SqlCommand cmd;

        public DoktorlarManagement()
        {
            conn = new SqlConnection(Properties.Settings.Default.baglanti);
        }

        public List<Doktorlar> GetAllDoctors()
        {
            List<Doktorlar> userList = new List<Doktorlar>();
            cmd = new SqlCommand("Select * from Doktorlar", conn);

            Doktorlar currentDoctor = null;

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                currentDoctor = new Doktorlar();

                currentDoctor.DrID = reader.GetInt32(0);
                currentDoctor.DrAdSoyad = reader.GetString(1);
                currentDoctor.DrSifre = reader.GetString(2);
                userList.Add(currentDoctor);
            }
            reader.Close();

            return userList;
        }

        public Doktorlar GetDoctorByID(int Id)
        {
            cmd = new SqlCommand("Select * from Doktorlar where DrID=@Id", conn);
            cmd.Parameters.AddWithValue("@Id", Id);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            reader.Read();
            Doktorlar currentDoctor = new Doktorlar();

            currentDoctor.DrID = Id;
            currentDoctor.DrAdSoyad = reader.GetString(1);
            currentDoctor.DrSifre = reader.GetString(2);

            reader.Close();

            return currentDoctor;
        }
    }
}
