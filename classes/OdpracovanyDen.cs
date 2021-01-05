using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Informačný_systém_SOFI.classes;

namespace Informačný_systém_SOFI.classes
{
    class OdpracovanyDen
    {
       public static DBConnection dBConnection = new DBConnection();



        public static void  UlozOdpracovanyDen (string menozamestnanec, string menozakazka, string datumprace, string odpracovanycas, string koeficient)
        {
            if (!string.IsNullOrEmpty(menozamestnanec) && !string.IsNullOrEmpty(menozakazka) && !string.IsNullOrEmpty(datumprace) && !string.IsNullOrEmpty(odpracovanycas) && !string.IsNullOrEmpty(koeficient))
            {
                string kodzakazky = Zakazka.GetKod(menozakazka);
                string idzamestnanec = Zamestnanec.GetID(menozamestnanec);
                double cenaPrace = OdpracovanyDen.VypCenuPrace(menozamestnanec, Convert.ToDouble(odpracovanycas), koeficient);


                string Query = "(" + idzamestnanec + "," + kodzakazky + ",'" + datumprace + "'," + odpracovanycas + ",'" + koeficient + "'," + Convert.ToString(cenaPrace) + ")";
                dBConnection.InsertIntoDB("odpracovane_dni (IDZamestnanec, KodZakazka, Datum, OdpracovanyCas, Koeficient, CenaPrace)", Query);

                Zakazka.UpdateVycerpanyRozpocet(cenaPrace, Convert.ToString(kodzakazky));
            }
            else
            {
                MessageBox.Show("Chyba : Vyplnte všetky voľné políčka");
            }
        }


        public static void UpdateOdpracovanyDen(string idodpracovanyden, string menozamestnanec, string menozakazka, string datumprace, string odpracovanycas, string koeficient)
        {
            if (!string.IsNullOrEmpty(menozamestnanec) && !string.IsNullOrEmpty(menozakazka) && !string.IsNullOrEmpty(datumprace) && !string.IsNullOrEmpty(odpracovanycas) && !string.IsNullOrEmpty(koeficient))
            {
                string kodzakazky = Zakazka.GetKod(menozakazka);
                string idzamestnanec = Zamestnanec.GetID(menozamestnanec);
                double cenaPrace = OdpracovanyDen.VypCenuPrace(menozamestnanec, Convert.ToDouble(odpracovanycas), koeficient);


                string Values = " IDZamestnanec = " + idzamestnanec + ", KodZakazka = " + kodzakazky + ", Datum ='" + datumprace + "', OdpracovanyCas = " + odpracovanycas + ", Koeficient ='" + koeficient + "', CenaPrace = " + Convert.ToString(cenaPrace) ;
                dBConnection.UpdateDB("odpracovane_dni", Values, " IDOdpracovaneDni = " + idodpracovanyden);
                Zakazka.UpdateVycerpanyRozpocet(cenaPrace, Convert.ToString(kodzakazky));
            }
            else
            {
                MessageBox.Show("Chyba : Vyplnte všetky voľné políčka");
            }
        }


        public static double VypCenuPrace (string menozamestnanca,double odpracovanycas ,string sKoeficient)
        {
            double hodinovamzda = Zamestnanec.GetHodinaMzda(menozamestnanca);
            double koef = Koeficient.KoefToDouble(sKoeficient);
            double cenaPrace = koef * odpracovanycas * hodinovamzda;

            return cenaPrace;
        }




        public static void FillComboBoxIDodpracovaneDni(ComboBox comboBox)
        {
            dBConnection.FillComboBox("odpracovane_dni", "IDOdpracovaneDni", comboBox);
        }


        public static void FillDGVAllOdpracovaneDni(DataGridView DGV)
        {
            dBConnection.FillDataGridView("odpracovane_dni", "odpracovane_dni.IDOdpracovaneDni, CONCAT(zamestnanci.Meno, ' ', zamestnanci.Priezvisko) AS FullName, zakazky.NazovZakazky , odpracovane_dni.Datum, odpracovane_dni.OdpracovanyCas, odpracovane_dni.Koeficient, odpracovane_dni.CenaPrace ", "", DGV,"zamestnanci ON odpracovane_dni.IDZamestnanec = zamestnanci.idzamestnanci", "zakazky ON odpracovane_dni.KodZakazka = zakazky.KodZakazky");
        }



        public static void FillDGVSelectOdpracovanedni(DataGridView DGV,string idodpracovanedni, string idzamestnanec, string kodzakazka, string koef, string mesiac, string rok)
        {
            string condition;
            if (string.IsNullOrEmpty(idodpracovanedni)) idodpracovanedni = "odpracovane_dni.IDOdpracovaneDni";

            if (string.IsNullOrEmpty(idzamestnanec)) idzamestnanec = "odpracovane_dni.IDZamestnanec";

            if (string.IsNullOrEmpty(kodzakazka)) kodzakazka = "odpracovane_dni.KodZakazka";

            if (string.IsNullOrEmpty(koef)) koef = "odpracovane_dni.Koeficient";
            else koef = "'" + koef + "'";

            if ((string.IsNullOrEmpty(mesiac)) || (mesiac == "0")) mesiac = "= odpracovane_dni.Datum";
            else mesiac = "LIKE '%." + mesiac + ".%'";

            if (string.IsNullOrEmpty(rok)) rok = "= odpracovane_dni.Datum";
            else rok = "LIKE '%." + rok + "'";

            condition = "IDOdpracovaneDni = " + idodpracovanedni + " AND odpracovane_dni.IDZamestnanec = " + idzamestnanec + " AND odpracovane_dni.KodZakazka = " + kodzakazka + " AND odpracovane_dni.Koeficient = " + koef + " AND odpracovane_dni.Datum " + mesiac + " AND odpracovane_dni.Datum " + rok;

            dBConnection.FillDataGridView("odpracovane_dni", "odpracovane_dni.IDOdpracovaneDni, CONCAT(zamestnanci.Meno, ' ', zamestnanci.Priezvisko) AS FullName, zakazky.NazovZakazky , odpracovane_dni.Datum, odpracovane_dni.OdpracovanyCas, odpracovane_dni.Koeficient, odpracovane_dni.CenaPrace ", condition, DGV, "zamestnanci ON odpracovane_dni.IDZamestnanec = zamestnanci.idzamestnanci", "zakazky ON odpracovane_dni.KodZakazka = zakazky.KodZakazky");
        }
    }
}
