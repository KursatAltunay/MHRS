using MHRS.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS.DAL
{
    public class HastanelerManagement
    {
        SqlConnection conn;
        SqlCommand cmd;

        public HastanelerManagement()
        {
            conn = new SqlConnection(Properties.Settings.Default.baglanti);
        }

        public List<Hastaneler> GetAllHastanes()
        {
            List<Hastaneler> userList = new List<Hastaneler>();
            cmd = new SqlCommand("Select * from Hastaneler order by HastaneAdi", conn);

            Hastaneler currentHastane = null;

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                currentHastane = new Hastaneler();

                currentHastane.HastaneID = reader.GetInt32(0);
                currentHastane.HastaneAdi = reader.GetString(1);

                userList.Add(currentHastane);
            }
            reader.Close();

            return userList;
        }


        public Hastaneler GetHastaneByID(int Id)
        {
            cmd = new SqlCommand("Select * from Hastaneler where HastaneID=@Id", conn);
            cmd.Parameters.AddWithValue("@Id", Id);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            reader.Read();
            Hastaneler currentHastane = new Hastaneler();

            currentHastane.HastaneID = Id;
            currentHastane.HastaneAdi = reader.GetString(1);


            reader.Close();

            return currentHastane;
        }
    }
}
