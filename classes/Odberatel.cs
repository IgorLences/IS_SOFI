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
    class Odberatel
    {
        public static DBConnection dBConnection = new DBConnection();

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

        public static void FillComboBoxNazov (ComboBox comboBox)
        {
            dBConnection.FillComboBox("odberatelia", "Nazov", comboBox);
        }

        public static void FillComboBoxID(ComboBox comboBox)
        {
            dBConnection.FillComboBox("odberatelia", "Idodberatel", comboBox);
        }

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

        public static void FillDGVAllOdberatelia(DataGridView DGV)
        {
            dBConnection.FillDataGridView("odberatelia", "*", "", DGV);
        }
        public static void FillDGVSelectOdberatelia(DataGridView DGV, string idodberatel, string nazov)
        {
            string condition;
            if (string.IsNullOrEmpty(nazov)) nazov = "Nazov";
            else nazov = "'" + nazov + "'";
            if (string.IsNullOrEmpty(idodberatel)) idodberatel = "Idodberatel";

            condition = " Nazov = " + nazov + " AND Idodberateľ = " + idodberatel ;

            dBConnection.FillDataGridView("odberatelia", " *", condition, DGV);

        }

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
