using MHRS.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS.DAL
{
    public class PolikliniklerManagement
    {
        SqlConnection conn;
        SqlCommand cmd;

        public PolikliniklerManagement()
        {
            conn = new SqlConnection(Properties.Settings.Default.baglanti);
        }

        public List<Poliklinikler> GetAllPoliklinikler()
        {
            List<Poliklinikler> userList = new List<Poliklinikler>();
            cmd = new SqlCommand("Select * from Poliklinikler order by PoliklinikAdi", conn);

            Poliklinikler currentPoliklinik = null;

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                currentPoliklinik = new Poliklinikler();

                currentPoliklinik.PoliklinikID = reader.GetInt32(0);
                currentPoliklinik.PoliklinikAdi = reader.GetString(1);

                userList.Add(currentPoliklinik);
            }
            reader.Close();

            return userList;
        }

        public Poliklinikler GetPoliklinikByID(int Id)
        {
            cmd = new SqlCommand("Select * from Poliklinikler where PoliklinikID=@Id", conn);
            cmd.Parameters.AddWithValue("@Id", Id);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            reader.Read();
            Poliklinikler currentPoliklinik = new Poliklinikler();

            currentPoliklinik.PoliklinikID = Id;
            currentPoliklinik.PoliklinikAdi = reader.GetString(1);


            reader.Close();

            return currentPoliklinik;
        }
    }
}
