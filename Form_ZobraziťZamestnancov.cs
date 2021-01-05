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
    public partial class Form_ZobraziťZamestnancov : Form
    {
        public Form_ZobraziťZamestnancov()
        {
            InitializeComponent();
        }

        private void button_ZobraziťVšetko_Click(object sender, EventArgs e)
        {
            Zamestnanec.FillDGVAllZamestnanci(dataGridView_Zamestnanec);
        }

        private void Form_ZobraziťZamestnancov_Shown(object sender, EventArgs e)
        {
            Zamestnanec.FillComboBoxMeno(comboBox_MenoZamestannca);
            Zamestnanec.FillComboBoxID(comboBox_IDzamestannca);
            Zamestnanec.FillComboBoxPracovnaPozicia(comboBox_pracovnaPozicia);
            Zamestnanec.FillComboBoxPracovnaPozicia(comboBox_PracovnaPozicia2);
        }


        private void button_UlozitZmeny_Click(object sender, EventArgs e)
        {
            string ID = dataGridView_Zamestnanec.SelectedRows[0].Cells["idzamestnanci"].Value.ToString();
            Zamestnanec.UpdateZamestnanca(ID, textBox_Meno.Text, textBox_Priezvisko.Text, comboBox_PracovnaPozicia2.Text, textBox_HodinovaMzda.Text);
            Zamestnanec.FillDGVSelectZamestnanci(dataGridView_Zamestnanec, comboBox_MenoZamestannca.Text, comboBox_IDzamestannca.Text, comboBox_pracovnaPozicia.Text);

        }

        private void dataGridView_Zamestnanec_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridView_Zamestnanec.SelectedRows.Count > 0)
            {
                textBox_Meno.Text =  dataGridView_Zamestnanec.SelectedRows[0].Cells["Meno"].Value.ToString();
                textBox_Priezvisko.Text = dataGridView_Zamestnanec.SelectedRows[0].Cells["Priezvisko"].Value.ToString();
                comboBox_PracovnaPozicia2.Text = dataGridView_Zamestnanec.SelectedRows[0].Cells["PracovnaPozicia"].Value.ToString();
                textBox_HodinovaMzda.Text = dataGridView_Zamestnanec.SelectedRows[0].Cells["HodinovaMzda"].Value.ToString();
            }
        }

        private void button_ZobraziťVýber_Click(object sender, EventArgs e)
        {
            Zamestnanec.FillDGVSelectZamestnanci(dataGridView_Zamestnanec, comboBox_MenoZamestannca.Text, comboBox_IDzamestannca.Text, comboBox_pracovnaPozicia.Text);
        }
    }
}
