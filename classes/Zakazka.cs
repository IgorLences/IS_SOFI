using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Informačný_systém_SOFI.classes;
using MySql.Data.MySqlClient;

namespace Informačný_systém_SOFI.classes
{
    //class na prácu s DB tabulkou zakazky
    class Zakazka
    {
        private static DBConnection dBConnection = new DBConnection();



        //Vložiť nový záznam zakazky do DB
        public static void UlozZakazku(string kodzakazky, string nazovzakazky, string idodberatel, string datumzalozenie, string rozpocetnamontaz, string vycerpanyrozpocet, string koeficient)
        {
            if (!string.IsNullOrEmpty(kodzakazky) && !string.IsNullOrEmpty(nazovzakazky) && !string.IsNullOrEmpty(idodberatel) && !string.IsNullOrEmpty(datumzalozenie) && !string.IsNullOrEmpty(rozpocetnamontaz) && !string.IsNullOrEmpty(vycerpanyrozpocet) && !string.IsNullOrEmpty(koeficient))
            {
                string Query = "(" + kodzakazky + ",'" + nazovzakazky + "','" + idodberatel + "','" + datumzalozenie + "','" + rozpocetnamontaz + "','" + vycerpanyrozpocet + "','" + koeficient + "')";
                dBConnection.InsertIntoDB("zakazky", Query);
            }
            else
            {
                MessageBox.Show("Chyba : Vyplnte všetky voľné políčka");
            }

        }



        // Získanie NazovZakazky pomocou kódu zákazky
        public static string GetNazov(string kodzakazky)
        {
            if (!string.IsNullOrEmpty(kodzakazky))
            {
                DataTable dt = dBConnection.SelectFromDb("zakazky", "NazovZakazky", "KodZakazky= '" + Convert.ToString(kodzakazky) + "'");

                string nazovzakazky = Convert.ToString(dt.Rows[0].ItemArray[0]);

                return nazovzakazky;
            }
            return null;
        }



        // Získanie Kódu zákazky pomocou názvu zákazky
        public static string GetKod(string nazovzakazky)
        {
            if (!string.IsNullOrEmpty(nazovzakazky))
            {
                DataTable dt = dBConnection.SelectFromDb("zakazky", "KodZakazky", "NazovZakazky= '" + nazovzakazky + "'");

                string kodzakazky = Convert.ToString(dt.Rows[0].ItemArray[0]);
                return kodzakazky;
            }
            return null;
        }



        // Výpočet vyčerpaného rozpočtu na zákazke
        public static double GetVycerpanyRozpocet(string kodzakazky)
        {          
            DataTable dt = dBConnection.SelectFromDb("zakazky", "(VycerpanyRozpocet)", "KodZakazky= '" + kodzakazky + "'");

            double vycerpanyrozpocet = Convert.ToDouble(dt.Rows[0].ItemArray[0]);

            return vycerpanyrozpocet;
        }



        // Uloženie vyčerpaného rozpočtu už do existujúcej zákazky
        public static void UpdateVycerpanyRozpocet(double vycerpanyrozpocet, string kodzakazky)
        {
           double vycerpanyrozpocet1 = Zakazka.GetVycerpanyRozpocet(kodzakazky);
            string Query = " VycerpanyRozpocet = " + Convert.ToString(vycerpanyrozpocet1 + vycerpanyrozpocet);
            dBConnection.UpdateDB(" zakazky",Query,"KodZakazky = " + kodzakazky + ";");
            Zakazka.KontrolaRozpočtu(kodzakazky);
        }



        // Získanie rozpočtu zákazky pomocou kódu zákazky
        public static double GetRozpocet(string kodzakazky)
        {
            DataTable dt = dBConnection.SelectFromDb("zakazky", "(RozpocetNaMontaz)", "KodZakazky= '" + kodzakazky + "'");

            double rozpocetnamontaz = Convert.ToDouble(dt.Rows[0].ItemArray[0]);

            return rozpocetnamontaz;
        }



        // Kontrola či vyčerpaný rozpočet nieje väčší ako zadaný rozpočet 
        public static void KontrolaRozpočtu(string kodzakazky)
        {
            double vycerpanyrozpocet = Zakazka.GetVycerpanyRozpocet(kodzakazky);
            double rozpocetnamontaz = Zakazka.GetRozpocet(kodzakazky);
            string nazovzakazky = Zakazka.GetNazov(kodzakazky);

            if (vycerpanyrozpocet >= rozpocetnamontaz)
            {
                MessageBox.Show("Zákazka " + nazovzakazky + " má prekročený rozpočet na montáž");
            }
        }



        //Výpočet nového kódu zákazky(auto increment na strane appky)
        public static int GetNovyKod ()
        {
            DataTable dt = dBConnection.SelectFromDb("zakazky ", "MAX(KodZakazky)", "");

            try
            {
                if (dt.Rows[0].ItemArray[0] == DBNull.Value) return 1;
                int PoslednyKodzDB = Convert.ToInt16(dt.Rows[0].ItemArray[0]) + 1;
                return PoslednyKodzDB;
            }
            catch (System.IndexOutOfRangeException)
            {
                return  1;
            }

        }



        //Vybranie zoznamu názvov zákaziek z DB a uloženie ich do ComboBoxu
        public static void FillComboBoxNazov(ComboBox comboBox)
        {
            dBConnection.FillComboBox("zakazky", "NazovZakazky", comboBox);
        }



        //Vybranie zoznamu kódov zákaziek z DB a uloženie ich do ComboBoxu
        public static void FillComboBoxKodZakazky(ComboBox comboBox)
        {
            dBConnection.FillComboBox("zakazky", "KodZakazky", comboBox);
        }



        //Vybrať tabulku zakazky z DB a uložiť do DataGridView pre zobrazenie dát
        public static void FillDGVAllZakazky(DataGridView DGV)
        {
            dBConnection.FillDataGridView("zakazky", " zakazky.KodZakazky, zakazky.NazovZakazky, odberatelia.Nazov, zakazky.DatumZalozenia, zakazky.RozpocetNaMontaz, zakazky.VycerpanyRozpocet, zakazky.Koeficient ", "", DGV, "odberatelia ON zakazky.IDodberatel=odberatelia.Idodberatel");
        }



        //Vybrať určité riadky z tabuľky odberatelia z DB a uložiť do DataGridView pre zobrazenie dát
        public static void FillDGVSelectZakazky(DataGridView DGV, string Nazov, string kodzakazky, string idodberatela,string koef, string mesiac, string rok)
        {
            string condition;
            if (string.IsNullOrEmpty(Nazov)) Nazov = "zakazky.NazovZakazky";
            else Nazov = "'" + Nazov + "'";

            if (string.IsNullOrEmpty(kodzakazky)) kodzakazky = "zakazky.KodZakazky";

            if (string.IsNullOrEmpty(idodberatela)) idodberatela = "zakazky.IDodberatel";

            if (string.IsNullOrEmpty(koef)) koef = "zakazky.Koeficient";
            else koef = "'" + koef + "'";

            if ((string.IsNullOrEmpty(mesiac)) || (mesiac == "0")) mesiac = "= zakazky.DatumZalozenia";
            else mesiac ="LIKE '%." + mesiac + ".%'" ;

            if (string.IsNullOrEmpty(rok)) rok = "= zakazky.DatumZalozenia";
            else rok = "LIKE '%." + rok + "'";

            condition = " zakazky.NazovZakazky = " + Nazov + " AND zakazky.KodZakazky = " + kodzakazky + " AND zakazky.IDodberatel = " + idodberatela + " AND zakazky.Koeficient = " + koef + " AND zakazky.DatumZalozenia " + mesiac + " AND zakazky.DatumZalozenia " + rok;

            dBConnection.FillDataGridView("zakazky", " zakazky.KodZakazky, zakazky.NazovZakazky, odberatelia.Nazov, zakazky.DatumZalozenia, zakazky.RozpocetNaMontaz, zakazky.VycerpanyRozpocet, zakazky.Koeficient ", condition, DGV, "odberatelia ON zakazky.IDodberatel = odberatelia.Idodberatel");
        }



        // Úprava už existujúceho záznamu v tabulke zákazky v DB
        public static void UpdateZakazku( string kodzakazky, string nazovzakazky, string idodberatel, string datumzalozenie, string rozpocetnamontaz, string vycerpanyrozpocet, string koeficient)
        {
            if (!string.IsNullOrEmpty(nazovzakazky) && !string.IsNullOrEmpty(idodberatel) && !string.IsNullOrEmpty(datumzalozenie) && !string.IsNullOrEmpty(rozpocetnamontaz) && !string.IsNullOrEmpty(vycerpanyrozpocet) && !string.IsNullOrEmpty(koeficient))
            {
                string Values =  " NazovZakazky = '" + nazovzakazky + "', IDodberatel = " + idodberatel + ", DatumZalozenia = '" + datumzalozenie + "', RozpocetNaMontaz = " + rozpocetnamontaz + ", VycerpanyRozpocet = " + vycerpanyrozpocet + ", Koeficient = '" + koeficient + "'";
                dBConnection.UpdateDB("zakazky", Values,"KodZakazky = " + kodzakazky);
            }
            else
            {
                MessageBox.Show("Chyba : Vyplnte všetky voľné políčka");
            }

        }



        // Odstránenie existujúceho záznamu v tabulke zakazky v DB
        public static void DeleteZakazku(string kodzakazky)
        {
            if (!string.IsNullOrEmpty(kodzakazky))
            {
                string Condition = " KodZakazky = '" + kodzakazky + "'";
                dBConnection.DeleteFromDb("zakazky", Condition);
            }
            else
            {
                MessageBox.Show("Chyba : Vyplnte všetky voľné políčka");
            }
        }

    }
}
