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
    public partial class Form_ZobraziťOdpracovanéDni : Form
    {



        public Form_ZobraziťOdpracovanéDni()
        {
            InitializeComponent();
        }



        //Vybrať tabulku odpracovane_dni z DB a uložiť do DataGridView pre zobrazenie dát
        private void button_ZobraziťVšetkyOdpravoneDni_Click(object sender, EventArgs e)
        {
            OdpracovanyDen.FillDGVAllOdpracovaneDni(dataGridView_OdpracovanyDen);
        }



        //Vybrať určité riadky z tabuľky odpracovane_dni z DB a uložiť do DataGridView pre zobrazenie dát
        private void button_Zobraziť_Click(object sender, EventArgs e)
        {
            OdpracovanyDen.FillDGVSelectOdpracovanedni( dataGridView_OdpracovanyDen, comboBox_IDodpracovanyDen.Text, Zamestnanec.GetID(comboBox_Zamestnanec.Text), Zakazka.GetKod(comboBox_Zakazka.Text), comboBox_Koeficient.Text, Convert.ToString(comboBox_mesiac.SelectedIndex), comboBox_Rok.Text);
        }



        private void Form_ZobraziťOdpracovanéDni_Shown(object sender, EventArgs e)
        {
            comboBox_mesiac.SelectedIndex = 0;
            //Vybranie zoznamu IDOdpracovaneDni z DB a uloženie ich do ComboBoxu
            OdpracovanyDen.FillComboBoxIDodpracovaneDni(comboBox_IDodpracovanyDen);
            //Vybranie zoznamu celých mien zamestnancov z DB a uloženie ich do ComboBoxu
            Zamestnanec.FillComboBoxMeno(comboBox_Zamestnanec);
            //Vybranie zoznamu názvov zákaziek z DB a uloženie ich do ComboBoxu
            Zakazka.FillComboBoxNazov(comboBox_Zakazka);
            //Vybranie zoznamu celých mien zamestnancov z DB a uloženie ich do ComboBoxu
            Zamestnanec.FillComboBoxMeno(comboBox_Zamestnanec2);
            //Vybranie zoznamu názvov zákaziek z DB a uloženie ich do ComboBoxu
            Zakazka.FillComboBoxNazov(comboBox_Zakazka2);

        }



        //Update vybraného riadku
        private void button_UpdateOdpracovaneDni_Click(object sender, EventArgs e)
        {
            //uloženie  KodZakazky z vybraného riadku
            string idodpracovanyden = dataGridView_OdpracovanyDen.SelectedRows[0].Cells["IDOdpracovaneDni"].Value.ToString();
            // Úprava už existujúceho záznamu v tabulke odpracovane_dni v DB
            OdpracovanyDen.UpdateOdpracovanyDen(idodpracovanyden, comboBox_Zamestnanec2.Text, comboBox_Zakazka2.Text, textBox_DatumPrace.Text, textBox_OdpracovanýČas.Text, comboBox_Koeficient2.Text);
            //Vybrať určité riadky z tabuľky odpracovane_dni z DB a uložiť do DataGridView pre zobrazenie updatenutých dát
            OdpracovanyDen.FillDGVSelectOdpracovanedni(dataGridView_OdpracovanyDen, comboBox_IDodpracovanyDen.Text, Zamestnanec.GetID(comboBox_Zamestnanec.Text), Zakazka.GetKod(comboBox_Zakazka.Text), comboBox_Koeficient.Text, Convert.ToString(comboBox_mesiac.SelectedIndex), comboBox_Rok.Text);
        }



        //Načítanie dát z vybraného riadku v DataGridView do texboxov a comboBoxov
        private void dataGridView_OdpracovanyDen_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridView_OdpracovanyDen.SelectedRows.Count > 0)
            {
                comboBox_Zamestnanec2.Text = dataGridView_OdpracovanyDen.SelectedRows[0].Cells["MenoZamestnanca"].Value.ToString();
                comboBox_Zakazka2.Text = dataGridView_OdpracovanyDen.SelectedRows[0].Cells["NazovZakazky"].Value.ToString();
                textBox_DatumPrace.Text = dataGridView_OdpracovanyDen.SelectedRows[0].Cells["Datum"].Value.ToString();
                textBox_OdpracovanýČas.Text = dataGridView_OdpracovanyDen.SelectedRows[0].Cells["OdpracovanyCas"].Value.ToString();
                comboBox_Koeficient2.Text = dataGridView_OdpracovanyDen.SelectedRows[0].Cells["Koeficient"].Value.ToString();
            }
        }
    }
}
