using MHRS.DAL;
using MHRS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS.BLL
{
    
    public class RecetelerController
    {
        RecetelerManagement _recetelerManagement;

        public RecetelerController()
        {
            _recetelerManagement = new RecetelerManagement();
        }

        public bool Add(Receteler recete)
        {
            CheckValues(recete);

            int result = _recetelerManagement.Add(recete);
            return result > 0;
        }

        void CheckValues(Receteler recete)
        {
            if (string.IsNullOrWhiteSpace(recete.Ilac1))
            {
                throw new Exception("En az 1 ilaç girilmelidir");
            }
            else if (string.IsNullOrWhiteSpace(recete.TcNo))
            {
                throw new Exception("Tc alanı boş geçilemez");
            }            
        }

        public bool Delete(Receteler recete)
        {
            int result = _recetelerManagement.Delete(recete.ReceteID);
            return result > 0;
        }

        public Receteler GetRecipe(int receteId)
        {
            return _recetelerManagement.GetRecipeByID(receteId);
        }

        public List<Receteler> GetRecipes(string Tc)
        {
            return _recetelerManagement.GetAllPatientRecipe(Tc);
        }
    }
}
