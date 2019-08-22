using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.Entities;

namespace MHRS.DAL
{
    public class RecetelerManagement
    {
        SqlConnection conn;
        SqlCommand cmd;

        public RecetelerManagement()
        {
            conn = new SqlConnection(Properties.Settings.Default.baglanti);
        }

        public int Add(Receteler recete)
        {
            string query = "Insert into Receteler values(@Ilac1,@Ilac2,@Ilac3,@Ilac4,@Tc)";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Ilac1", recete.Ilac1);
            cmd.Parameters.AddWithValue("@Ilac2", recete.Ilac2);
            cmd.Parameters.AddWithValue("@Ilac3", recete.Ilac3);
            cmd.Parameters.AddWithValue("@Ilac4", recete.Ilac4);
            cmd.Parameters.AddWithValue("@Tc", recete.TcNo);

            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();

            return result;
        }

        public int Update(Receteler recete)
        {
            string query = "Update Receteler set Ilac1=@Ilac1,Ilac2=@Ilac2,Ilac3=@Ilac3,Ilac4=@Ilac4 where ReceteID=@Id";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Ilac1", recete.Ilac1);
            cmd.Parameters.AddWithValue("@Ilac2", recete.Ilac2);
            cmd.Parameters.AddWithValue("@Ilac3", recete.Ilac3);
            cmd.Parameters.AddWithValue("@Ilac4", recete.Ilac4);
            cmd.Parameters.AddWithValue("@Id", recete.ReceteID);

            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();

            return result;
        }

        public int Delete(int receteId)
        {
            string query = "Delete from Receteler where ReceteID=@receteId";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@receteId", receteId);

            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();

            return result;
        }

        public List<Receteler> GetAllPatientRecipe(string tcNo)
        {
            List<Receteler> recipeList = new List<Receteler>();
            cmd = new SqlCommand("Select * from Receteler where TcNo=@Tc", conn);
            cmd.Parameters.AddWithValue("@Tc", tcNo);
            //reference tipli bir değişken olan user classı default tipi null o yüzden atama yaptık
            Receteler currentRecipe = null;

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                //her bir satırda oluşturmak gerekir.
                currentRecipe = new Receteler();
                //boxing-unboxing yapmadan veriyi isteğimiz formatta okuyup getiriyor.
                currentRecipe.ReceteID = reader.GetInt32(0);
                currentRecipe.Ilac1 = reader.GetString(1);
                currentRecipe.Ilac2 = reader.GetString(2);
                currentRecipe.Ilac3 = reader.GetString(3);
                currentRecipe.Ilac4 = reader.GetString(4);
                recipeList.Add(currentRecipe);
            }
            reader.Close();

            return recipeList;
        }

        public Receteler GetRecipeByID(int receteId)
        {
            cmd = new SqlCommand("Select Ilac1,Ilac2,Ilac3,Ilac4 from Receteler where ReceteID=@ReceteId", conn);
            cmd.Parameters.AddWithValue("@ReceteId", receteId);


            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            //döngü yapmadık çünkü tek değer gelecek
            reader.Read();
            Receteler currentRecipe = new Receteler();
            //boxing-unboxing yapmadan veriyi isteğimiz formatta okuyup getiriyor.
            currentRecipe.ReceteID = receteId;//reader.GetGuid(0);
            currentRecipe.Ilac1 = reader.GetString(0);
            currentRecipe.Ilac2 = reader.GetString(1);
            currentRecipe.Ilac3 = reader.GetString(2);
            currentRecipe.Ilac4 = reader.GetString(3);

            reader.Close();

            return currentRecipe;

        }
    }
}
