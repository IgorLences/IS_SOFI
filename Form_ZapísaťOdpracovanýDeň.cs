using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Informačný_systém_SOFI.classes;

namespace Informačný_systém_SOFI
{
    public partial class Form_ZapísaťOdpracovanýDeň : Form
    {



        public Form_ZapísaťOdpracovanýDeň()
        {
            InitializeComponent();
        }



        //Vložiť nový záznam odpracovane_dni do DB
        private void button_ZapísaťOdpracovanýDeň_Click(object sender, EventArgs e)
        {
            //Vložiť nový záznam odpracovane_dni do DB
            OdpracovanyDen.UlozOdpracovanyDen(comboBox_Zamestnanci.Text, comboBox_Zakazka.Text, textBox_DatumPrace.Text, textBox_OdpracovanýČas.Text, comboBox_Koeficient.Text);
            // Kontrola či vyčerpaný rozpočet nieje väčší ako zadaný rozpočet 
            Zakazka.KontrolaRozpočtu(Convert.ToString(Zakazka.GetKod(comboBox_Zakazka.Text)));
        }




        private void Form_ZapísaťOdpracovanýDeň_Shown(object sender, EventArgs e)
        {
            //Vybranie zoznamu celých mien zamestnancov z DB a uloženie ich do ComboBoxu
            Zamestnanec.FillComboBoxMeno(comboBox_Zamestnanci);
            // Získanie NazovZakazky pomocou kódu zákazky
            Zakazka.FillComboBoxNazov(comboBox_Zakazka);
        }
    }
}
