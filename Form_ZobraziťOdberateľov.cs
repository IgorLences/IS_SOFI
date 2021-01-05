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

        private void button_ZobraziťVšetko_Click(object sender, EventArgs e)
        {
            Odberatel.FillDGVAllOdberatelia(dataGridView_Odberatel);
        }

        private void button_UložitNovehoZamestnanca_Click(object sender, EventArgs e)
        {
            Odberatel.FillDGVSelectOdberatelia(dataGridView_Odberatel, comboBox_IDodberatela.Text, comboBox_NazovOdberatela.Text);
        }

        private void Form_ZobraziťOdberateľov_Shown(object sender, EventArgs e)
        {
            Odberatel.FillComboBoxID(comboBox_IDodberatela);
            Odberatel.FillComboBoxNazov(comboBox_NazovOdberatela);
        }

        private void button_UpdateOdberatelov_Click(object sender, EventArgs e)
        {
            string Idodberatel = dataGridView_Odberatel.SelectedRows[0].Cells["Idodberatel"].Value.ToString();
            Odberatel.UpdateOdberatel(Idodberatel, textBox_NazovOdberatela.Text);
            Odberatel.FillDGVSelectOdberatelia(dataGridView_Odberatel, comboBox_IDodberatela.Text, comboBox_NazovOdberatela.Text);
        }

        private void dataGridView_Odberatel_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridView_Odberatel.SelectedRows.Count > 0)
            {
                textBox_NazovOdberatela.Text = dataGridView_Odberatel.SelectedRows[0].Cells["Nazov"].Value.ToString();

            }
        }
    }
}
