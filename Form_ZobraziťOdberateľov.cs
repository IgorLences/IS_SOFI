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
    public partial class Form_ZobraziťOdberateľov : Form
    {


        public Form_ZobraziťOdberateľov()
        {
            InitializeComponent();
        }



        //Vybrať tabulku odberatelia z DB a uložiť do DataGridView pre zobrazenie dát
        private void button_ZobraziťVšetko_Click(object sender, EventArgs e)
        {
            Odberatel.FillDGVAllOdberatelia(dataGridView_Odberatel);
        }



        //Vybrať určité riadky z tabuľky odberatelia z DB a uložiť do DataGridView pre zobrazenie dát
        private void button_Zobraziť_Click(object sender, EventArgs e)
        {
            Odberatel.FillDGVSelectOdberatelia(dataGridView_Odberatel, comboBox_IDodberatela.Text, comboBox_NazovOdberatela.Text);
        }




        private void Form_ZobraziťOdberateľov_Shown(object sender, EventArgs e)
        {        
            //Vybranie zoznamu IDodberatel z DB a uloženie ich do ComboBoxu
            Odberatel.FillComboBoxID(comboBox_IDodberatela);
            //Vybranie zoznamu Názvov z DB a uloženie ich do ComboBoxu
            Odberatel.FillComboBoxNazov(comboBox_NazovOdberatela);
        }



        //Update vybraného riadku
        private void button_UpdateOdberatelov_Click(object sender, EventArgs e)
        {   
            //uloženie  IDodberatela z vybraného riadku
            string Idodberatel = dataGridView_Odberatel.SelectedRows[0].Cells["Idodberatel"].Value.ToString();
            // Úprava vybraného riadku v tabulke odberatelia v DB
            Odberatel.UpdateOdberatel(Idodberatel, textBox_NazovOdberatela.Text);
            //Vybrať určité riadky z tabuľky odberatelia z DB a uložiť do DataGridView pre  zobrazenie updatenutých dát
            Odberatel.FillDGVSelectOdberatelia(dataGridView_Odberatel, comboBox_IDodberatela.Text, comboBox_NazovOdberatela.Text);
        }



        //Načítanie dát z vybraného riadku v DataGridView do texboxu
        private void dataGridView_Odberatel_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridView_Odberatel.SelectedRows.Count > 0)
            {
                textBox_NazovOdberatela.Text = dataGridView_Odberatel.SelectedRows[0].Cells["Nazov"].Value.ToString();
            }
        }



        // Odstránenie vybraného záznamu v tabulke odberatelia v DB
        private void button_Odstrániť_Click(object sender, EventArgs e)
        {
            //uloženie  IDodberatela z vybraného riadku
            string Idodberatel = dataGridView_Odberatel.SelectedRows[0].Cells["Idodberatel"].Value.ToString();
            // Odstránenie existujúceho záznamu v tabulke odberatelia v DB
            Odberatel.DeleteOdberatel(Idodberatel);
            //Vybrať určité riadky z tabuľky odberatelia z DB a uložiť do DataGridView pre zobrazenie dát
            Odberatel.FillDGVSelectOdberatelia(dataGridView_Odberatel, comboBox_IDodberatela.Text, comboBox_NazovOdberatela.Text);
        }
    }
}
