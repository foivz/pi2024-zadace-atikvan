using DBLayer;
using StudentskiRecenziraj.Modeli;
using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiRecenziraj.Repositories
{
    public class RecenzijeRepository
    {
        public static Recenzija GetRecenzija(int id)
        {
            Recenzija recenzija = null;

            string sql = $"SELECT * FROM Recenzija WHERE Id={id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                recenzija = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return recenzija;
                
        }
        public static List<Recenzija> GetRecenzijas()
        {
            List<Recenzija> recenzijas = new List<Recenzija>();
            string sql = "SELECT * FROM Recenzije";
            DB.OpenConnection();


        }

    }
}
