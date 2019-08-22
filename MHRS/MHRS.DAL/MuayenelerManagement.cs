using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MHRS.Entities;

namespace MHRS.DAL
{
   public class MuayenelerManagement
    {
        SqlConnection conn;
        SqlCommand cmd;

        public MuayenelerManagement()
        {
            conn = new SqlConnection(Properties.Settings.Default.baglanti);
        }

        public int Add(Muayeneler muayene)
        {
            string query = "Insert into Muayeneler values(@GeldiMi,@RandevuId,@MuayeneNot)";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@GeldiMi", muayene.HastaGeldiMi);
            cmd.Parameters.AddWithValue("@RandevuId", muayene.RandevuID);
            cmd.Parameters.AddWithValue("@MuayeneNot", muayene.MuayeneNot);

            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();

            return result;
        }

        public int Delete(int muayeneId)
        {
            string query = "Delete from Muayeneler where MuayeneID=@MuayeneId";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MuayeneId", muayeneId);

            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();

            return result;
        }

        public List<Muayeneler> GetAllExemination()
        {
            List<Muayeneler> ExeminationList = new List<Muayeneler>();
            cmd = new SqlCommand("Select * from Muayeneler", conn);
            //reference tipli bir değişken olan user classı default tipi null o yüzden atama yaptık
            Muayeneler currentExemination = null;

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                //her bir satırda oluşturmak gerekir.
                currentExemination = new Muayeneler();
                //boxing-unboxing yapmadan veriyi isteğimiz formatta okuyup getiriyor.
                currentExemination.MuayeneID = reader.GetInt32(0);
                currentExemination.HastaGeldiMi = reader.GetByte(1);
                currentExemination.RandevuID = reader.GetInt32(2);
                currentExemination.MuayeneNot = reader.GetString(3);
                ExeminationList.Add(currentExemination);
            }
            reader.Close();

            return ExeminationList;
        }

        public Muayeneler GetExeminationByID(int exeId)
        {
            cmd = new SqlCommand("Select * from Muayeneler where MuayeneID=@Id", conn);
            cmd.Parameters.AddWithValue("@Id", exeId);


            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            reader.Read();
            Muayeneler currentExemination = new Muayeneler();

            currentExemination.MuayeneID = exeId;
            currentExemination.HastaGeldiMi = reader.GetByte(1);
            currentExemination.RandevuID = reader.GetInt32(2);
            currentExemination.MuayeneNot = reader.GetString(3);

            reader.Close();

            return currentExemination;

        }
    }
}
