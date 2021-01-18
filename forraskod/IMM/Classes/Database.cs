using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using IMM.Properties;
using System.Collections;
using System.Data.SqlClient;
using IMM.Model;
using IMM.Model.GyartasModel;
using IMM.Model.RaktarModel;

namespace IMM.Classes
{
    class Database {
        private string conString = Properties.Settings.Default.dbConn;
        private SQLiteConnection con;
        private SQLiteCommand sqlc;
        public Database() {
            if (conString != null) {
                con = new SQLiteConnection(conString);
                sqlc = new SQLiteCommand(con);
                con.Open();
            }
        }
        #region GETALL
        #region Termék Modul
        public List<Termek> getAllTermek() {
            List<Termek> termekek = new List<Termek>();
            SQLiteDataReader dr;
            try {
                sqlc.CommandText = "SELECT * FROM Termekek";
                dr = sqlc.ExecuteReader();
                while (dr.Read()) {
                    Termek jelenlegiTermek = new Termek(Convert.ToInt32(dr.GetValue(0)), dr.GetValue(1).ToString(), dr.GetValue(2).ToString(), dr.GetValue(3).ToString(), Convert.ToInt32(dr.GetValue(4)), Convert.ToInt32(dr.GetValue(5)),Convert.ToInt32(dr.GetValue(6)), Convert.ToInt32(dr.GetValue(7)), Convert.ToInt32(dr.GetValue(8)), Convert.ToInt32(dr.GetValue(9)), Convert.ToInt32(dr.GetValue(10)));

                    termekek.Add(jelenlegiTermek);
                }
                dr.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Termékek kiolvasása SQL hiba!");
                Logger.Log("Database", ex.Message);
            }

            return termekek;

        }
        public List<Kategoria> getAllKategoria() {
            List<Kategoria> kategoriak = new List<Kategoria>();
            SQLiteDataReader dr;
            try {
                sqlc.CommandText = "SELECT * FROM Kategoriak";
                dr = sqlc.ExecuteReader();
                while (dr.Read()) {
                    Kategoria jelenlegiKategoria = new Kategoria(Convert.ToInt32(dr.GetValue(0)), dr.GetValue(1).ToString());
                    kategoriak.Add(jelenlegiKategoria);
                }
                dr.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Kategóriák kiolvasása SQL hiba!");
                Logger.Log("Database", ex.Message);
            }
            return kategoriak;
        }
        public List<Lokacio> getAllLokacio() {
            List<Lokacio> lokaciok = new List<Lokacio>();
            SQLiteDataReader dr;
            try {
                sqlc.CommandText = "SELECT * FROM Lokaciok";
                dr = sqlc.ExecuteReader();
                while (dr.Read()) {
                    Lokacio jelenlegiLokacio = new Lokacio(Convert.ToInt32(dr.GetValue(0)), dr.GetValue(1).ToString());

                    lokaciok.Add(jelenlegiLokacio);
                }
                dr.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Lokációk kiolvasása SQL hiba!");
                Logger.Log("Database", ex.Message);
            }
            return lokaciok;
        }
        #endregion
        #region Felhasználó modul
        public List<User> getAllUser() {
            List<User> felhasznalok = new List<User>();
            SQLiteDataReader dr;
            try {
                sqlc.CommandText = "SELECT * FROM Felhasznalok";
                dr = sqlc.ExecuteReader();
                while (dr.Read()) {
                    User jelenlegiUser = new User(Convert.ToInt32(dr.GetValue(0)), dr.GetValue(1).ToString(), dr.GetValue(2).ToString(), dr.GetValue(3).ToString(), dr.GetValue(4).ToString(), dr.GetValue(5).ToString(), Convert.ToInt32(dr.GetValue(6)));
                    felhasznalok.Add(jelenlegiUser);
                }
                dr.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Felhasználók kiolvasása SQL hiba!");
                Logger.Log("Database", ex.Message);
            }
            return felhasznalok;
        }
        #endregion
        #region Gép Modul
        public List<Gep> getAllGep() {
            List<Gep> gepek = new List<Gep>();
            SQLiteDataReader dr;
            try {
                sqlc.CommandText = "SELECT * FROM Gepek";
                dr = sqlc.ExecuteReader();
                while (dr.Read()) {
                    Gep jelenlegiGep = new Gep(Convert.ToInt32(dr.GetValue(0)), dr.GetValue(1).ToString());
                    gepek.Add(jelenlegiGep);
                }
                dr.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Gépek kiolvasása SQL hiba!");
                Logger.Log("Database", ex.Message);
            }

            return gepek;

        }
        public List<GepKategoria> getAllGepKategoria() {
            List<GepKategoria> gkat = new List<GepKategoria>();
            SQLiteDataReader dr;
            try {
                sqlc.CommandText = "SELECT * FROM GepKategoriak";
                dr = sqlc.ExecuteReader();
                while (dr.Read()) {
                    GepKategoria jelenlegiGKat = new GepKategoria(Convert.ToInt32(dr.GetValue(0)), Convert.ToInt32(dr.GetValue(1)), Convert.ToInt32(dr.GetValue(2)));
                    gkat.Add(jelenlegiGKat);
                }
                dr.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Gép kategóriák kiolvasása SQL hiba!");
                Logger.Log("Database", ex.Message);
            }

            return gkat;


        }
        public List<GepAllomas> getAllGepAllomas() {
            List<GepAllomas> allomasok = new List<GepAllomas>();
            SQLiteDataReader dr;
            try {
                sqlc.CommandText = "SELECT * FROM GepAllomasok";
                dr = sqlc.ExecuteReader();
                while (dr.Read()) {
                    GepAllomas jelenlegiAllomas = new GepAllomas(Convert.ToInt32(dr.GetValue(0)), Convert.ToInt32(dr.GetValue(1)), Convert.ToInt32(dr.GetValue(2)),dr.GetValue(3).ToString());

                    allomasok.Add(jelenlegiAllomas);
                }
                dr.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Gép állomások kiolvasása SQL hiba!");
                Logger.Log("Database", ex.Message);
            }
            return allomasok;
        }
        public List<GepAllomasParameter> getAllGepAllomasParameter() {
            List<GepAllomasParameter> parameterek = new List<GepAllomasParameter>();
            SQLiteDataReader dr;
            try {
                sqlc.CommandText = "SELECT * FROM GepAllomasParameterek";
                dr = sqlc.ExecuteReader();
                while (dr.Read()) {
                    GepAllomasParameter jelenlegiParameter = new GepAllomasParameter(Convert.ToInt32(dr.GetValue(0)), Convert.ToInt32(dr.GetValue(1)), dr.GetValue(2).ToString(),dr.GetValue(3).ToString(),dr.GetValue(4).ToString(),dr.GetValue(5).ToString());

                    parameterek.Add(jelenlegiParameter);
                }
                dr.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Gép állomás paraméterek kiolvasása SQL hiba!");
                Logger.Log("Database", ex.Message);
            }
            return parameterek;
        }
        public List<GepAdatok> getAllGepAdat() {
            List<GepAdatok> adatok = new List<GepAdatok>();
            SQLiteDataReader dr;
            try {
                sqlc.CommandText = "SELECT * FROM GepAdatok";
                dr = sqlc.ExecuteReader();
                while (dr.Read()) {
                    GepAdatok jelenlegiAdat = new GepAdatok(Convert.ToInt32(dr.GetValue(0)), Convert.ToInt32(dr.GetValue(1)), Convert.ToInt32(dr.GetValue(2)),dr.GetValue(3).ToString(), dr.GetValue(4).ToString(),dr.GetValue(5).ToString(), dr.GetValue(6).ToString());

                    adatok.Add(jelenlegiAdat);
                }
                dr.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "GépAdatok kiolvasása SQL hiba!");
                Logger.Log("Database", ex.Message);
            }
            return adatok;
        }
        #endregion
        #region Gyártás modul
        public List<Munkarend> getAllMunkarend() {
            List<Munkarend> munkarendek = new List<Munkarend>();
            SQLiteDataReader dr;
            try {
                sqlc.CommandText = "SELECT * FROM Munkarendek";
                dr = sqlc.ExecuteReader();
                while (dr.Read()) {
                    Munkarend jelenlegiMunkarend = new Munkarend(Convert.ToInt32(dr.GetValue(0)), dr.GetValue(1).ToString(), dr.GetValue(2).ToString(), dr.GetValue(3).ToString(), dr.GetValue(4).ToString(), dr.GetValue(5).ToString());
                    munkarendek.Add(jelenlegiMunkarend);
                }
                dr.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Munkarendek kiolvasása SQL hiba!");
                Logger.Log("Database", ex.Message);
            }

            return munkarendek;
        }
        public List<MunkarendTermekek> getAllMunkarendTermekek() {
            List<MunkarendTermekek> munkarendTermekek = new List<MunkarendTermekek>();
            SQLiteDataReader dr;
            try {
                sqlc.CommandText = "SELECT * FROM MunkarendTermekek";
                dr = sqlc.ExecuteReader();
                while (dr.Read()) {
                    MunkarendTermekek jelenlegiMunkarendTermekek = new MunkarendTermekek(Convert.ToInt32(dr.GetValue(0)), Convert.ToInt32(dr.GetValue(1)), Convert.ToInt32(dr.GetValue(2)), Convert.ToInt32(dr.GetValue(3)),dr.GetValue(4).ToString());
                    munkarendTermekek.Add(jelenlegiMunkarendTermekek);
                }
                dr.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Munkarend termékek kiolvasása SQL hiba!");
                Logger.Log("Database", ex.Message);
            }

            return munkarendTermekek;
        }
        public List<MunkarendStatusz> getAllMunkarendStatuszok() {
            List<MunkarendStatusz> munkarendStatuszok = new List<MunkarendStatusz>();
            SQLiteDataReader dr;
            try {
                sqlc.CommandText = "SELECT * FROM MunkarendStatuszok";
                dr = sqlc.ExecuteReader();
                while (dr.Read()) {
                    MunkarendStatusz jelenlegiMunkarendStatusz = new MunkarendStatusz(Convert.ToInt32(dr.GetValue(0)), dr.GetValue(1).ToString(), dr.GetValue(2).ToString(), Convert.ToInt32(dr.GetValue(3)));
                    munkarendStatuszok.Add(jelenlegiMunkarendStatusz);
                }
                dr.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Munkarend státuszok kiolvasása SQL hiba!");
                Logger.Log("Database", ex.Message);
            }

            return munkarendStatuszok;
        }
        #endregion
        #region Raktár modul
        public List<Raktar> getAllRaktar() {
            List<Raktar> raktarak = new List<Raktar>();
            SQLiteDataReader dr;
            try {
                sqlc.CommandText = "SELECT * FROM Raktarak";
                dr = sqlc.ExecuteReader();
                while (dr.Read()) {
                    Raktar jelenlegiRaktar = new Raktar(Convert.ToInt32(dr.GetValue(0)), dr.GetValue(1).ToString());
                    raktarak.Add(jelenlegiRaktar);
                }
                dr.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Raktárak kiolvasása SQL hiba!");
                Logger.Log("Database", ex.Message);
            }
            return raktarak;
        }
        #endregion
        #endregion
        #region FINDBY
        #region Termék Modul
        public List<Termek> termekFindById(int id) {
            List<Termek> actual = new List<Termek>();
            actual = (from x in getAllTermek()
                     where x.ID == id
                     select x).ToList();
            return actual;
        }
        public List<Kategoria> kategoriaFindByName(string name) {
            List<Kategoria> actualKategoria = new List<Kategoria>();
            actualKategoria = (from x in getAllKategoria()
                               where x.KategoriaNev == name
                               select x).ToList();
            return actualKategoria;
        }
        #endregion
        #region Gép Modul
        public List<Gep> gepFindById(int id) {
            List<Gep> actualGep = new List<Gep>();
            actualGep = (from x in getAllGep()
                         where x.Id == id
                         select x).ToList();
            return actualGep;
        }
        public List<GepKategoria> gepKatFindByIds(int gepid, int katid) {
            List<GepKategoria> gepkatList = (from x in getAllGepKategoria()
                                             where x.GepId == gepid & x.KategoriaId == katid
                                             select x).ToList();
            return gepkatList;
        }
        public List<GepAllomas> gepAllomasFindByGepId(int gepid) {
            List<GepAllomas> allomasok = (from x in getAllGepAllomas()
                                          where x.GepId == gepid
                                          select x).ToList();
            return allomasok;
        }
        public List<GepAllomas> gepAllomasFindByAllomasSzam(int allomas,int gepid) {
            List<GepAllomas> allomasLista = (from x in getAllGepAllomas()
                                             where x.AllomasSzam == allomas && x.GepId==gepid
                                             select x).ToList();
            return allomasLista;
        }
        public List<GepAllomas> gepAllomasFindByGepIdAllomasNev(int gepid, string allomasnev) {
            List<GepAllomas> allomas = (from x in gepAllomasFindByGepId(gepid)
                                        where x.AllomasNev == allomasnev
                                        select x).ToList();
            return allomas;
        }
        public List<GepAllomas> gepAllomasFindByID(int gaid) {
            List<GepAllomas> allomas = (from x in getAllGepAllomas()
                                        where x.GaId == gaid
                                        select x).ToList();
            return allomas;
        }
        public List<GepAllomasParameter> gepAllomasParameterFindByAllomasId(int allomasId) {
            List<GepAllomasParameter> parameterek = (from x in getAllGepAllomasParameter()
                                                     where x.AllomasId == allomasId
                                                     select x).ToList();
            return parameterek;
        }
        public List<GepAllomasParameter> gepAllomasParameterFindByID(int id) {
            List<GepAllomasParameter> parameterek = (from x in getAllGepAllomasParameter()
                                                     where x.GapId == id
                                                     select x).ToList();
            return parameterek;
        }
        public List<GepAdatok> gepAdatokByGepId(int gepid) {
            List<GepAdatok> adatok = (from x in getAllGepAdat()
                                      where x.Gepid == gepid
                                      select x).ToList();
            return adatok;
        }
        #endregion
        #region Gyártás modul
        public List<Munkarend> munkarendFindByID(int id) {
            List<Munkarend> jelenlegiLista = (from x in getAllMunkarend()
                                              where x.MrId == id
                                              select x).ToList();
            return jelenlegiLista;
        }
        public List<Munkarend> munkarendFindByAzonosito(string azon) {
            List<Munkarend> jelenlegiLista = (from x in getAllMunkarend()
                                              where x.MrAzonosito == azon
                                              select x).ToList();
            return jelenlegiLista;
        }
        #endregion
        #endregion
        #region UPDATE/INSERT/DELETE
        #region Termék Modul
        public void termekModositas(Termek _termek) {
            try {
                sqlc.CommandText = "UPDATE Termekek SET termekNev='"+ _termek.TermekNev+"',termekNev2='"+ _termek.TermekNev2 + "',cikkszam='"+ _termek.Cikkszam + "',kategoria='"+ _termek.Kategoria+ "',csomagolasidarabszam='"+_termek.CsomagolasiDarabszam+"',minimumgyarthato='"+_termek.MinimumGyarthato+"',felkesztermek='"+_termek.Felkesztermek+"',beepuloanyag='"+_termek.BeepuloAnyag+"',aktiv='"+_termek.Aktiv+"',raktar='"+_termek.Raktar+"' where id='" + _termek.ID + "'";
                sqlc.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Termek módosítása SQL hiba!");
                Logger.Log("Database", ex.Message);
            }
        }
        public void termekHozzaad(Termek _termek) {
            try {
                sqlc.CommandText = "INSERT INTO Termekek (termekNev,termekNev2,cikkszam,kategoria,raktar) VALUES('" + _termek.TermekNev + "','" + _termek.TermekNev2 + "','" + _termek.Cikkszam + "','"+ _termek.Kategoria+"','"+_termek.Raktar+"')";
                sqlc.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Termék hozzáadása SQL hiba!");
                Logger.Log("Database", ex.Message);
            }
        }    
        public void gepKategoriahozAdd(int gepid, int katid) {
            try {
                sqlc.CommandText = "INSERT INTO GepKategoriak (gepid,kategoriaid) VALUES('" + gepid + "','" + katid + "')";
                sqlc.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Kategória hozzáadása SQL hiba!");
                Logger.Log("Database", ex.Message);
            }
        }
        public void gepKategoriabolDel(int gepid, int katid) {
            try {
                sqlc.CommandText = "DELETE FROM GepKategoriak WHERE gepid='"+gepid+"' and kategoriaid='"+katid+"'";
                sqlc.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Kategória törlése SQL hiba!");
                Logger.Log("Database", ex.Message);
            }
        }
        public void kategoriaModositas(Kategoria _kategoria) {
            try {
                sqlc.CommandText = "UPDATE Kategoriak SET kategoriaNev='" + _kategoria.KategoriaNev + "' WHERE id='"+_kategoria.Id+"'";
                sqlc.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Kategória módosítás SQL hiba!");
                Logger.Log("Database", ex.Message);
            }
        }
        #endregion
        #region Gép Modul
        public void gepModositas(Gep _gep) {
            try {
                sqlc.CommandText = "UPDATE Gepek SET gepnev='" +_gep.GepNev+"' where id='"+_gep.Id+"'";
                sqlc.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Gép módosítás SQL hiba!");
                Logger.Log("Database", ex.Message);
            }
        }
        public void gepAdatokModositas(GepAdatok _gepAdatok) {
            try {
                sqlc.CommandText = "UPDATE GepAdatok SET geplokacio='"+_gepAdatok.Lokacio+"',gepmarka='"+_gepAdatok.Gepmarka+"',ciklusido='"+_gepAdatok.Ciklusido + "',karbantartaskezdes='"+_gepAdatok.Karbidatum+"',karbantartasismetlodes='"+_gepAdatok.Ismetlodes+"' WHERE id='"+_gepAdatok.GaId+"'";
                sqlc.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Gép adatok módosítás SQL hiba!");
                Logger.Log("Database", ex.Message);
            }
        }
        public void gepAdatokAdd(GepAdatok _gepAdatok) {
            try {
                sqlc.CommandText = "INSERT INTO GepAdatok (gepid,geplokacio,gepmarka,ciklusido,karbantartaskezdes,karbantartasismetlodes) VALUES('" + _gepAdatok.Gepid + "','" + _gepAdatok.Lokacio + "','" + _gepAdatok.Gepmarka + "','"+_gepAdatok.Ciklusido + "','"+ _gepAdatok .Karbidatum+ "','"+ _gepAdatok .Ismetlodes+ "')";
                sqlc.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Gép Adatok hozzáadása SQL hiba!");
                Logger.Log("Database", ex.Message);
            }
        }
        public void gepAdd(Gep _gep) {
            try {
                sqlc.CommandText = "INSERT INTO Gepek (id,gepnev,aktiv)VALUES('"+_gep.Id+"','" + _gep.GepNev + "','1')";
                sqlc.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Gép módosítás SQL hiba!");
                Logger.Log("Database", ex.Message);
            }
        }
        public void gepAllomasAdd(int gepid, int allomas, string nev) {
            try {
                sqlc.CommandText = "INSERT INTO GepAllomasok (gepid,allomasszam,allomasnev) VALUES('" + gepid + "','" + allomas + "','" + nev + "')";
                sqlc.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Állomás hozzáadása SQL hiba");
                Logger.Log("Database", ex.Message);
            }
        }
        public void gepAllomasSzamDel(GepAllomas _allomas) {
            try {
                
                sqlc.CommandText = "DELETE FROM GepAllomasok WHERE allomasszam='" + _allomas.AllomasSzam + "' AND gepid='" + _allomas.GepId + "'";
                sqlc.ExecuteNonQuery();
                sqlc.CommandText = "DELETE FROM GepAllomasParameterek WHERE gepallomasid='" + _allomas.GaId + "'";
                sqlc.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Állomás törlése SQL hiba");
                Logger.Log("Database", ex.Message);
            }
            
        }
        public void gepAllomasModositas(GepAllomas _allomas) {
            try {
                sqlc.CommandText = "UPDATE GepAllomasok SET allomasszam='"+_allomas.AllomasSzam+"',allomasnev='"+_allomas.AllomasNev+"' WHERE gaid ='"+_allomas.GaId+"'";
                sqlc.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Állomás módosítás SQL hiba!");
                Logger.Log("Database", ex.Message);
            }
        }
        public void gepAllomasParameterAdd(GepAllomasParameter _parameter) {
            try {
                sqlc.CommandText = "INSERT INTO GepAllomasParameterek (gepallomasid,parameternev,parameterertek,modositasdatuma) VALUES('" + _parameter.AllomasId + "','" + _parameter.ParameterNev + "','" + _parameter.ParameterErtek + "','"+_parameter.ModositasDatuma+"')";
                sqlc.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Paraméter hozzáadása SQL hiba");
                Logger.Log("Database", ex.Message);
            }
        }
        public void gepAllomasParameterDel(GepAllomasParameter _parameter) {
            try {

                sqlc.CommandText = "DELETE FROM GepAllomasParameterek WHERE gapid='" + _parameter.GapId +"'";
                sqlc.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Állomás paraméter törlés SQL hiba!");
                Logger.Log("Database", ex.Message);
            }
        }
        public void gepAllomasParameterModositas(GepAllomasParameter _parameter) {
            try {
                sqlc.CommandText = "UPDATE GepAllomasParameterek SET parameternev='" +_parameter.ParameterNev + "',parameterertek='" + _parameter.ParameterErtek + "' ,modositasdatuma='"+_parameter.ModositasDatuma+"'WHERE gapid ='" + _parameter.GapId + "'";
                sqlc.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Állomás paraméter módosítás SQL hiba!");
                Logger.Log("Database", ex.Message);
            }
        }
        #endregion
        #region Gyártás modul
        public void munkarendAdd(Munkarend _mr) {
            try {
                sqlc.CommandText = "INSERT INTO Munkarendek (mrazonosito,mrmegnevezes,mrdatum,letrehozta)VALUES('"+_mr.MrAzonosito+"','"+_mr.MrMegnevezes+"','"+_mr.MrDatum+"','"+_mr.Letrehozta+"')";
                sqlc.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Munkarend hozzáadása SQL hiba!");
                Logger.Log("Database", ex.Message);
            }
        }
        public void munkarendTermekAdd(MunkarendTermekek _mt) {
            try {
                sqlc.CommandText = "INSERT INTO MunkarendTermekek (mrid,termekid,szuksegesdarabszam,statusz)VALUES('" + _mt.MrID + "','" + _mt.TermekID + "','"+termekFindById(_mt.TermekID).First().MinimumGyarthato+ "','"+ _mt.Statusz+ "')";
                sqlc.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Munkarend Termék hozzáadása SQL hiba!");
                Logger.Log("Database", ex.Message);
            }
        }
        public void munkarendTermekDel(MunkarendTermekek _mt) {
            try {
                if (statuszCheck(_mt)) {
                    sqlc.CommandText = "DELETE FROM MunkarendTermekek WHERE mrtid='" + _mt.MrtID + "'";
                    sqlc.ExecuteNonQuery();
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "MunkarendTermék Törlés SQL hiba");
                Logger.Log("Database", ex.Message);
            }
        }
        bool statuszCheck(MunkarendTermekek _mt) {
            if (_mt.Statusz == (from x in getAllMunkarendStatuszok() where x.Sorszam == 1 select x).First().Megnevezes) {
                return true;
            } else {
                return false;
            }
        }
        public void munkarendTermekUpdate(MunkarendTermekek _mt) {
            try {
                if (statuszCheck(_mt)) {
                    sqlc.CommandText = "UPDATE MunkarendTermekek SET szuksegesdarabszam='" + _mt.SzuksegesDarabszam + "' WHERE mrtid='"+_mt.MrtID+"'";
                    sqlc.ExecuteNonQuery();
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "MunkarendTermék Módosítás SQL hiba");
                Logger.Log("Database", ex.Message);
            }
        }

        #endregion
        #region Raktar modul
        public void raktarAdd(Raktar _rak) {
            try {
                sqlc.CommandText = "INSERT INTO Raktarak (rmegnevezes) VALUES ('" + _rak.RaktarMegnevezes + "')";
                sqlc.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Raktár hozzáadás SQL hiba!");
                Logger.Log("Database", ex.Message);
            }
        }
        #endregion
        #endregion





    }
}
