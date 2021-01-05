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



        //Vybrať tabulku zamestnanci z DB a uložiť do DataGridView pre zobrazenie dát
        private void button_ZobraziťVšetko_Click(object sender, EventArgs e)
        {
            Zamestnanec.FillDGVAllZamestnanci(dataGridView_Zamestnanec);
        }




        private void Form_ZobraziťZamestnancov_Shown(object sender, EventArgs e)
        {
            //Vybranie zoznamu celých mien zamestnancov z DB a uloženie ich do ComboBoxu
            Zamestnanec.FillComboBoxMeno(comboBox_MenoZamestannca);
            //Vybranie zoznamu ID zamestnancov z DB a uloženie ich do ComboBoxu
            Zamestnanec.FillComboBoxID(comboBox_IDzamestannca);
            //Vybranie zoznamu už vložených pracovných pozícií z DB a uloženie ich do ComboBoxu
            Zamestnanec.FillComboBoxPracovnaPozicia(comboBox_pracovnaPozicia);
            //Vybranie zoznamu už vložených pracovných pozícií z DB a uloženie ich do ComboBoxu
            Zamestnanec.FillComboBoxPracovnaPozicia(comboBox_PracovnaPozicia2);
        }



        //Update vybraného riadku
        private void button_UlozitZmeny_Click(object sender, EventArgs e)
        {
            //uloženie  IDzamestnanca z vybraného riadku
            string ID = dataGridView_Zamestnanec.SelectedRows[0].Cells["idzamestnanci"].Value.ToString();
            // Úprava už existujúceho záznamu v tabulke zamestnanci v DB
            Zamestnanec.UpdateZamestnanca(ID, textBox_Meno.Text, textBox_Priezvisko.Text, comboBox_PracovnaPozicia2.Text, textBox_HodinovaMzda.Text);
            //Vybrať určité riadky z tabuľky zamestnanci z DB a uložiť do DataGridView pre zobrazenie updatenutých dát
            Zamestnanec.FillDGVSelectZamestnanci(dataGridView_Zamestnanec, comboBox_MenoZamestannca.Text, comboBox_IDzamestannca.Text, comboBox_pracovnaPozicia.Text);

        }



        //Načítanie dát z vybraného riadku v DataGridView do texboxov a comboBoxov
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



        //Vybrať určité riadky z tabuľky zamestnanci z DB a uložiť do DataGridView pre zobrazenie dát
        private void button_ZobraziťVýber_Click(object sender, EventArgs e)
        {
            Zamestnanec.FillDGVSelectZamestnanci(dataGridView_Zamestnanec, comboBox_MenoZamestannca.Text, comboBox_IDzamestannca.Text, comboBox_pracovnaPozicia.Text);
        }
    }
}
