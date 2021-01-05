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
    public partial class Form_ZobraziťZákazky : Form
    {



        public Form_ZobraziťZákazky()
        {
            InitializeComponent();
        }



        //Vybrať tabulku zakazky z DB a uložiť do DataGridView pre zobrazenie dát
        private void button_ZobraziťVšetkyZakazky_Click(object sender, EventArgs e)
        {
            Zakazka.FillDGVAllZakazky(dataGridView_Zákazka);
        }



        //Vybrať určité riadky z tabuľky odberatelia z DB a uložiť do DataGridView pre zobrazenie dát
        private void button_Zobraziť_Click(object sender, EventArgs e)
        {
            Zakazka.FillDGVSelectZakazky(dataGridView_Zákazka, comboBox_NazovZakazky.Text, comboBox_Kodzakazky.Text,Odberatel.GetID(comboBox_Odberatel.Text), comboBox_Koeficient.Text,Convert.ToString(comboBox_mesiac.SelectedIndex), comboBox_Rok.Text);
        }




        private void Form_ZobraziťZákazky_Shown(object sender, EventArgs e)
        {
            comboBox_mesiac.SelectedIndex = 0;
            //Vybranie zoznamu kódov zákaziek z DB a uloženie ich do ComboBoxu
            Zakazka.FillComboBoxKodZakazky(comboBox_Kodzakazky);
            //Vybranie zoznamu názvov zákaziek z DB a uloženie ich do ComboBoxu
            Zakazka.FillComboBoxNazov(comboBox_NazovZakazky);
            //Vybranie zoznamu Názvov z DB a uloženie ich do ComboBoxu
            Odberatel.FillComboBoxNazov(comboBox_Odberatel);
            //Vybranie zoznamu Názvov z DB a uloženie ich do ComboBoxu
            Odberatel.FillComboBoxNazov(comboBox_Odberatelia);
        }



        //Update vybraného riadku
        private void button_UpdateZakazku_Click(object sender, EventArgs e)
        {
            //uloženie  KodZakazky z vybraného riadku
            string KodZakazky = dataGridView_Zákazka.SelectedRows[0].Cells["KodZakazky"].Value.ToString();
            // Úprava vybraného riadku v tabulke odberatelia v DB
            Zakazka.UpdateZakazku( KodZakazky, textBox_NazovZakazky.Text, Odberatel.GetID(comboBox_Odberatelia.Text), textBox_DatumZalozenia.Text, textBox_RozpocetNaMontaz.Text, textBox_VycerpanyRozpocet.Text, comboBox_Koeficient2.Text);
            //Vybrať určité riadky z tabuľky odberatelia z DB a uložiť do DataGridView pre zobrazenie updatenutých dát
            Zakazka.FillDGVSelectZakazky(dataGridView_Zákazka, comboBox_NazovZakazky.Text, comboBox_Kodzakazky.Text, Odberatel.GetID(comboBox_Odberatel.Text), comboBox_Koeficient.Text, Convert.ToString(comboBox_mesiac.SelectedIndex), comboBox_Rok.Text);
        }



        //Načítanie dát z vybraného riadku v DataGridView do texboxov a comboBoxov
        private void dataGridView_Zákazka_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridView_Zákazka.SelectedRows.Count > 0)
            {
                textBox_NazovZakazky.Text = dataGridView_Zákazka.SelectedRows[0].Cells["NazovZakazky"].Value.ToString();
                textBox_DatumZalozenia.Text = dataGridView_Zákazka.SelectedRows[0].Cells["DatumZalozenia"].Value.ToString();
                textBox_RozpocetNaMontaz.Text = dataGridView_Zákazka.SelectedRows[0].Cells["RozpocetNaMontaz"].Value.ToString();
                textBox_VycerpanyRozpocet.Text = dataGridView_Zákazka.SelectedRows[0].Cells["VycerpanyRozpocet"].Value.ToString();
                comboBox_Koeficient2.Text = dataGridView_Zákazka.SelectedRows[0].Cells["Koeficient"].Value.ToString();
                comboBox_Odberatelia.Text = dataGridView_Zákazka.SelectedRows[0].Cells["Nazov"].Value.ToString();               
            }
        }



        private void button_Odstrániť_Click(object sender, EventArgs e)
        {
            //uloženie  KodZakazky z vybraného riadku
            string KodZakazky = dataGridView_Zákazka.SelectedRows[0].Cells["KodZakazky"].Value.ToString();
            // Odstránenie existujúceho záznamu v tabulke zakazky v DB
            Zakazka.DeleteZakazku(KodZakazky);
            //Vybrať určité riadky z tabuľky odberatelia z DB a uložiť do DataGridView pre zobrazenie dát
            Zakazka.FillDGVSelectZakazky(dataGridView_Zákazka, comboBox_NazovZakazky.Text, comboBox_Kodzakazky.Text, Odberatel.GetID(comboBox_Odberatel.Text), comboBox_Koeficient.Text, Convert.ToString(comboBox_mesiac.SelectedIndex), comboBox_Rok.Text);
        }
    }
}
