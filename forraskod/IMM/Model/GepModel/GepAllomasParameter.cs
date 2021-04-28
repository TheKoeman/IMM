using IMM.Classes;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMM.Model {
    public class GepAllomasParameter {

        private int gapId;
        private int allomasId;
        private string parameterNev;
        private string parameterErtek;
        private string modositasDatuma;
        private string modositotta;

        public int GapId { get => gapId; set => gapId = value; }
        public int AllomasId { get => allomasId; set => allomasId = value; }
        public string ParameterNev { get => parameterNev; set => parameterNev = value; }
        public string ParameterErtek { get => parameterErtek; set => parameterErtek = value; }
        public string ModositasDatuma { get => modositasDatuma; set => modositasDatuma = value; }
        public string Modositotta { get => modositotta; set => modositotta = value; }
        
        public GepAllomasParameter(int id, int aid, string paramnev, string paramertek, string modositasdatum, string modositott) {
            this.GapId = id;
            this.AllomasId = aid;
            this.ParameterNev = paramnev;
            this.ParameterErtek = paramertek;
            this.modositasDatuma = modositasdatum;
            this.Modositotta = modositott;
        }

        public static List<GepAllomasParameter> getAll() {
            List<GepAllomasParameter> _gaParameterLista = new List<GepAllomasParameter>();
            SQLiteConnection sqlc = new SQLiteConnection(Database.Connection1);
            SQLiteCommand sqlcommand = new SQLiteCommand(sqlc);
            SQLiteDataReader dr;
            try {
                sqlc.Open();
                sqlcommand.CommandText = "SELECT * FROM GepAllomasParameterek";
                dr = sqlcommand.ExecuteReader();
                while (dr.Read()) {
                    GepAllomasParameter _gaParameter = new GepAllomasParameter(Convert.ToInt32(dr.GetValue(0)), Convert.ToInt32(dr.GetValue(1)), dr.GetValue(2).ToString(), dr.GetValue(3).ToString(), dr.GetValue(4).ToString(), dr.GetValue(5).ToString());
                    _gaParameterLista.Add(_gaParameter);
                }
                dr.Close();
            } catch (Exception ex) {
                Logger.Log("GépÁllomásParaméter osztály", ex.Message);
            }
            if (sqlc.State == System.Data.ConnectionState.Open) {
                sqlc.Close();
            }
            return _gaParameterLista;
        }
        public static List<GepAllomasParameter> findByAllomasID(int allomasId) {
            List<GepAllomasParameter> parameterek = (from x in getAll()
                                                     where x.AllomasId == allomasId
                                                     select x).ToList();
            return parameterek;
        }
        public static List<GepAllomasParameter> findByID(int id) {
            List<GepAllomasParameter> parameterek = (from x in getAll()
                                                     where x.GapId == id
                                                     select x).ToList();
            return parameterek;
        }

        public static void Hozzaad(GepAllomasParameter _parameter) {
            SQLiteConnection sqlc = new SQLiteConnection(Database.Connection1);
            SQLiteCommand sqlcommand = new SQLiteCommand(sqlc);
            try {
                sqlc.Open();
                sqlcommand.CommandText = "INSERT INTO GepAllomasParameterek (gepallomasid,parameternev,parameterertek,modositasdatuma) VALUES('" + _parameter.AllomasId + "','" + _parameter.ParameterNev + "','" + _parameter.ParameterErtek + "','" + _parameter.ModositasDatuma + "')";
                sqlcommand.ExecuteNonQuery();
            } catch (Exception ex) {
                Logger.Log("Gép Állomás Paraméter hozzáadás osztály hiba", ex.Message);
            }
            if (sqlc.State == System.Data.ConnectionState.Open) {
                sqlc.Close();
            }
        }
        public static void Torol(GepAllomasParameter _parameter) {
            SQLiteConnection sqlc = new SQLiteConnection(Database.Connection1);
            SQLiteCommand sqlcommand = new SQLiteCommand(sqlc);
            try {
                sqlc.Open();
                sqlcommand.CommandText = "DELETE FROM GepAllomasParameterek WHERE gapid='" + _parameter.GapId + "'";
                sqlcommand.ExecuteNonQuery();
            } catch (Exception ex) {
                Logger.Log("Gép Állomás Paraméter törlés osztály hiba", ex.Message);
            }
            if (sqlc.State == System.Data.ConnectionState.Open) {
                sqlc.Close();
            }
        }
        public static void Modosit(GepAllomasParameter _parameter) {
            SQLiteConnection sqlc = new SQLiteConnection(Database.Connection1);
            SQLiteCommand sqlcommand = new SQLiteCommand(sqlc);
            try {
                sqlc.Open();
                sqlcommand.CommandText = "UPDATE GepAllomasParameterek SET parameternev='" + _parameter.ParameterNev + "',parameterertek='" + _parameter.ParameterErtek + "' ,modositasdatuma='" + _parameter.ModositasDatuma + "'WHERE gapid ='" + _parameter.GapId + "'";
                sqlcommand.ExecuteNonQuery();
            } catch (Exception ex) {
                Logger.Log("Gép Állomás Paraméter módosítás osztály hiba", ex.Message);
            }
            if (sqlc.State == System.Data.ConnectionState.Open) {
                sqlc.Close();
            }
        }
    }
}
