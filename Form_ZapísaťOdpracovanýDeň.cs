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

        private void button_VytvoritNovuZakazku_Click(object sender, EventArgs e)
        {
            OdpracovanyDen.UlozOdpracovanyDen(comboBox_Zamestnanci.Text, comboBox_Zakazka.Text, textBox_DatumPrace.Text, textBox_OdpracovanýČas.Text, comboBox_Koeficient.Text);
            Zakazka.KontrolaRozpočtu(Convert.ToString(Zakazka.GetKod(comboBox_Zakazka.Text)));
        }

        private void Form_ZapísaťOdpracovanýDeň_Shown(object sender, EventArgs e)
        {
            Zamestnanec.FillComboBoxMeno(comboBox_Zamestnanci);
            Zakazka.FillComboBoxNazov(comboBox_Zakazka);
        }
    }
}
