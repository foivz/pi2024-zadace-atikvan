using DBLayer;
using StudentskiRecenziraj.Modeli;
using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace StudentskiRecenziraj.Repositories
{
    public class RecenzijeRepository
    {
        public static Recenzija GetRecenzije(int id)
        {
            Recenzija recenzija = null;

            string sql = $"SELECT * FROM Recenzije WHERE Id={id}";
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
        public static List<Recenzija> GetRecenzije()
        {
            string sql = "SELECT * FROM Recenzije";
            DB.OpenConnection();
            List<Recenzija> recenzije = new List<Recenzija>();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                Recenzija recenzija = CreateObject(reader);
                recenzije.Add(recenzija);
            }
            reader.Close();
            DB.CloseConnection();
            return recenzije;
        }
        private static Recenzija CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string naziv = reader["Naziv"].ToString();
            int ocjenaOkus = int.Parse(reader["OcjenaOkus"].ToString());
            int ocjenaKolicina = int.Parse(reader["OcjenaKolicina"].ToString());
            string komentar = reader["Komentar"].ToString();

            var recenzija = new Recenzija
            {
                Id = id,
                Naziv = naziv,
                OcjenaOkus = ocjenaOkus,
                OcjenaKolicina = ocjenaKolicina,
                Komentar = komentar
            };
            return recenzija;

        }


    }
}
