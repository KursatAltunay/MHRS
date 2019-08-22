using MHRS.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS.DAL
{
   public class EczanelerManagement
    {
        SqlConnection conn;
        SqlCommand cmd;

        public EczanelerManagement()
        {
            conn = new SqlConnection(Properties.Settings.Default.baglanti);
        }
        public List<Eczaneler> GetAllEczaneler()
        {
            List<Eczaneler> ezcaneList = new List<Eczaneler>();
            cmd = new SqlCommand("Select * from Eczaneler", conn);

            Eczaneler currentEczane = null;

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                currentEczane = new Eczaneler();

                currentEczane.EczaneID = reader.GetInt32(0);
                currentEczane.EczaneAdı = reader.GetString(1);
                currentEczane.EczaneSifre = reader.GetString(2);
                ezcaneList.Add(currentEczane);
            }
            reader.Close();

            return ezcaneList;
        }

        public Eczaneler GetEczaneByID(int Id)
        {
            cmd = new SqlCommand("Select * from Ezcaneler where EczaneID=@Id", conn);
            cmd.Parameters.AddWithValue("@Id", Id);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            reader.Read();
            Eczaneler currentEczane = new Eczaneler();

            currentEczane.EczaneID = Id;
            currentEczane.EczaneAdı = reader.GetString(1);
            currentEczane.EczaneSifre = reader.GetString(2);

            reader.Close();

            return currentEczane;
        }
    }
}

