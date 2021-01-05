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
    //class na prácu s DB tabulkou odberatelia
    class Odberatel
    {
        public static DBConnection dBConnection = new DBConnection();



        //Vložiť nový záznam Odberateľa do DB
        public static void UlozOdberatel(string nazovodberatela)
        {
            if (!string.IsNullOrEmpty(nazovodberatela))
            {
                string Query = "('" + nazovodberatela + "')";
                dBConnection.InsertIntoDB("odberatelia (Nazov) ", Query);
            }
            else
            {
                MessageBox.Show("Chyba : Vyplnte všetky voľné políčka");
            }

        }



        // Získanie IDodberatela pomocou názvu odberatela
        public static string GetID(string menoOdberatela)
        {
            
            if (!string.IsNullOrEmpty(menoOdberatela))
            {
                DataTable dt = dBConnection.SelectFromDb("odberatelia", "*", "Nazov = '" + menoOdberatela + "'");
                string idodberatel = Convert.ToString(dt.Rows[0].ItemArray[0]);
                return idodberatel;
            }
            else
            {
                return null;
            }
        }



        //Vybranie zoznamu Názvov z DB a uloženie ich do ComboBoxu
        public static void FillComboBoxNazov (ComboBox comboBox)
        {
            dBConnection.FillComboBox("odberatelia", "Nazov", comboBox);
        }



        //Vybranie zoznamu IDodberatel z DB a uloženie ich do ComboBoxu
        public static void FillComboBoxID(ComboBox comboBox)
        {
            dBConnection.FillComboBox("odberatelia", "Idodberatel", comboBox);
        }




        //Vybrať tabulku odberatelia z DB a uložiť do DataGridView pre zobrazenie dát
        public static void FillDGVAllOdberatelia(DataGridView DGV)
        {
            dBConnection.FillDataGridView("odberatelia", "*", "", DGV);
        }



        //Vybrať určité riadky z tabuľky odberatelia z DB a uložiť do DataGridView pre zobrazenie dát
        public static void FillDGVSelectOdberatelia(DataGridView DGV, string idodberatel, string nazov)
        {
            string condition;
            if (string.IsNullOrEmpty(nazov)) nazov = "Nazov";
            else nazov = "'" + nazov + "'";
            if (string.IsNullOrEmpty(idodberatel)) idodberatel = "Idodberatel";

            condition = " Nazov = " + nazov + " AND Idodberateľ = " + idodberatel ;

            dBConnection.FillDataGridView("odberatelia", " *", condition, DGV);

        }



        // Úprava už existujúceho záznamu v tabulke odberatelia v DB
        public static void UpdateOdberatel(string idodberatela,string nazovodberatela)
        {
            if (!string.IsNullOrEmpty(nazovodberatela))
            {
                string Values = " Nazov = '" + nazovodberatela + "'";
                dBConnection.UpdateDB("odberatelia", Values, " Idodberatel = " + idodberatela);
            }
            else
            {
                MessageBox.Show("Chyba : Vyplnte všetky voľné políčka");
            }

        }
    }
}
