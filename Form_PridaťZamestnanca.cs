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
    public partial class Form_PridaťZamestnanca : Form
    {
        public Form_PridaťZamestnanca()
        {
            InitializeComponent();
        }

        private void button_UložitNovehoOdberatela_Click(object sender, EventArgs e)
        {               
                Zamestnanec.UlozZamestnanca( textBox_Meno.Text, textBox_Priezvisko.Text, comboBox_pracovnaPozicia.Text, textBox_HodinovaMzda.Text);
        }
    }
}
