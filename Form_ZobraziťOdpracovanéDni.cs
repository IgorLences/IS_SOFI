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

        private void button_ZobraziťVšetkyOdpravoneDni_Click(object sender, EventArgs e)
        {
            OdpracovanyDen.FillDGVAllOdpracovaneDni(dataGridView_OdpracovanyDen);
        }

        private void button_Zobraziť_Click(object sender, EventArgs e)
        {
            OdpracovanyDen.FillDGVSelectOdpracovanedni( dataGridView_OdpracovanyDen, comboBox_IDodpracovanyDen.Text, Zamestnanec.GetID(comboBox_Zamestnanec.Text), Zakazka.GetKod(comboBox_Zakazka.Text), comboBox_Koeficient.Text, Convert.ToString(comboBox_mesiac.SelectedIndex), comboBox_Rok.Text);
        }

        private void Form_ZobraziťOdpracovanéDni_Shown(object sender, EventArgs e)
        {
            comboBox_mesiac.SelectedIndex = 0;
            OdpracovanyDen.FillComboBoxIDodpracovaneDni(comboBox_IDodpracovanyDen);
            Zamestnanec.FillComboBoxMeno(comboBox_Zamestnanec);
            Zakazka.FillComboBoxNazov(comboBox_Zakazka);
            Zamestnanec.FillComboBoxMeno(comboBox_Zamestnanec2);
            Zakazka.FillComboBoxNazov(comboBox_Zakazka2);

        }

        private void button_UpdateOdpracovaneDni_Click(object sender, EventArgs e)
        {
            string idodpracovanyden = dataGridView_OdpracovanyDen.SelectedRows[0].Cells["IDOdpracovaneDni"].Value.ToString();
            OdpracovanyDen.UpdateOdpracovanyDen(idodpracovanyden, comboBox_Zamestnanec2.Text, comboBox_Zakazka2.Text, textBox_DatumPrace.Text, textBox_OdpracovanýČas.Text, comboBox_Koeficient2.Text);
            OdpracovanyDen.FillDGVSelectOdpracovanedni(dataGridView_OdpracovanyDen, comboBox_IDodpracovanyDen.Text, Zamestnanec.GetID(comboBox_Zamestnanec.Text), Zakazka.GetKod(comboBox_Zakazka.Text), comboBox_Koeficient.Text, Convert.ToString(comboBox_mesiac.SelectedIndex), comboBox_Rok.Text);
        }

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
