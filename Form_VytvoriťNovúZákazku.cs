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
    public partial class Form_VytvoriťNovúZákazku : Form
    {



        public Form_VytvoriťNovúZákazku()
        {
            InitializeComponent();
        }



        //Vložiť nový záznam zakazky do DB
        private void button_VytvoritNovuZakazku_Click(object sender, EventArgs e)
        {
                string idodberatel = Odberatel.GetID(comboBox_Odberatelia.Text);
                Zakazka.UlozZakazku(textBox_KodZakazky.Text, textBox_NazovZakazky.Text, idodberatel, textBox_DatumZalozenia.Text, textBox_RozpocetNaMontaz.Text, textBox_VycerpanyRozpocet.Text, comboBox_Koeficient.Text);
        }



        private void Form_VytvoriťNovúZákazku_Shown(object sender, EventArgs e)
        {
            //Vybranie zoznamu Názvov z DB a uloženie ich do ComboBoxu
            Odberatel.FillComboBoxNazov(comboBox_Odberatelia);
            //Výpočet nového kódu zákazky(auto increment na strane appky)
            textBox_KodZakazky.Text = Convert.ToString(Zakazka.GetNovyKod());
        }
    }
}
