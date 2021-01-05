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
    //class na prácu s DB tabulkou zamestnanci
    public class Zamestnanec
    {
        private static DBConnection dBConnection = new DBConnection();



        //Vložiť nový záznam zamestnanca do DB
        public static void UlozZamestnanca(string meno, string priezvisko, string pracovnapozicia, string hodinovamzda)
        {
            if (!string.IsNullOrEmpty(meno) && !string.IsNullOrEmpty(priezvisko) && !string.IsNullOrEmpty(pracovnapozicia) && !string.IsNullOrEmpty(hodinovamzda))
            {
                string Query = "('" + meno + "','" + priezvisko + "','" + pracovnapozicia + "'," + hodinovamzda + ")";
                dBConnection.InsertIntoDB("zamestnanci  ( Meno, Priezvisko, PracovnaPozicia, HodinovaMzda)", Query);
            }
            else
            {
                MessageBox.Show("Chyba : Vyplnte všetky voľné políčka");
            }

        }



        // Úprava už existujúceho záznamu v tabulke zamestnanci v DB
        public static void UpdateZamestnanca(string ID, string meno, string priezvisko, string pracovnapozicia, string hodinovamzda)
        {
            if (!string.IsNullOrEmpty(meno) && !string.IsNullOrEmpty(priezvisko) && !string.IsNullOrEmpty(pracovnapozicia) && !string.IsNullOrEmpty(hodinovamzda))
            {
                string Values = " Meno = '" + meno + "', Priezvisko = '" + priezvisko + "', PracovnaPozicia = '" + pracovnapozicia + "', HodinovaMzda = " + hodinovamzda;
                dBConnection.UpdateDB("zamestnanci ", Values, "idzamestnanci = " + ID);
            }
            else
            {
                MessageBox.Show("Chyba : Vyplnte všetky voľné políčka");
            }

        }



        // Získanie ID zamestnanca pomocou mena zamestnanca
        public static string GetID(string menoZamestnanec)
        {

            char[] separators = new char[] { ' ' };
            string[] subs = menoZamestnanec.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            if (!string.IsNullOrEmpty(menoZamestnanec))
            {
                DataTable dt = dBConnection.SelectFromDb("zamestnanci", "*", "Meno= '" + subs[0] + "' AND Priezvisko= '" + subs[1] + "'");
                string idzamestnanec = Convert.ToString(dt.Rows[0].ItemArray[0]);
                return idzamestnanec;
            }
            return null;
        }



        // Získanie hodinovej mzdy pomocou mena zamestnanca
        public static double GetHodinaMzda (string menoZamestnanec)
        {
            char[] separators = new char[] { ' ' };
            string[] subs = menoZamestnanec.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            DataTable dt = dBConnection.SelectFromDb("zamestnanci", "*", "Meno= '" + subs[0] + "' AND Priezvisko= '" + subs[1] + "'");

            double hodinovamzda = Convert.ToDouble(dt.Rows[0].ItemArray[4]);

            return hodinovamzda;
        }



        //Vybranie zoznamu celých mien zamestnancov z DB a uloženie ich do ComboBoxu
        public static void FillComboBoxMeno(ComboBox comboBox)
        {
            dBConnection.FillComboBox("zamestnanci", "CONCAT(Meno, ' ' , Priezvisko) AS FullName", comboBox);
        }



        //Vybranie zoznamu ID zamestnancov z DB a uloženie ich do ComboBoxu
        public static void FillComboBoxID(ComboBox comboBox)
        {
            dBConnection.FillComboBox("zamestnanci", "idzamestnanci", comboBox);
        }



        //Vybranie zoznamu už vložených pracovných pozícií z DB a uloženie ich do ComboBoxu
        public static void FillComboBoxPracovnaPozicia(ComboBox comboBox)
        {
            dBConnection.FillComboBox("zamestnanci", "PracovnaPozicia", comboBox);
        }



        //Vybrať tabulku zamestnanci z DB a uložiť do DataGridView pre zobrazenie dát
        public static void FillDGVAllZamestnanci(DataGridView DGV)
        {
            dBConnection.FillDataGridView("zamestnanci","*","",DGV);
        }



        //Vybrať určité riadky z tabuľky zamestnanci z DB a uložiť do DataGridView pre zobrazenie dát
        public static void FillDGVSelectZamestnanci(DataGridView DGV,string meno,string idzamestnanca, string pracovnapozicia)
        {
            string condition;
            string priezvisko = "Priezvisko";
            if (string.IsNullOrEmpty(meno)) meno = "Meno";
            else
            {
                char[] separators = new char[] { ' ' };
                string[] subs = meno.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                meno = "'" + subs[0] + "'";
                priezvisko = "'" + subs[1] + "'";

            }
            if (string.IsNullOrEmpty(idzamestnanca)) idzamestnanca = "idzamestnanci";

            if (string.IsNullOrEmpty(pracovnapozicia)) pracovnapozicia = "PracovnaPozicia";
            else pracovnapozicia = "'" + pracovnapozicia + "'";

            condition = " Meno = " + meno + " AND Priezvisko = " + priezvisko + " AND idzamestnanci = " + idzamestnanca + " AND PracovnaPozicia = " + pracovnapozicia;

            dBConnection.FillDataGridView("zamestnanci", "*", condition, DGV);
        }

    }
}
