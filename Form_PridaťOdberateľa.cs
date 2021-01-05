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
    public partial class Form_PridaťOdberateľa : Form
    {


        public Form_PridaťOdberateľa()
        {
            InitializeComponent();
        }



        //Vložiť nový záznam Odberateľa do DB
        private void button_UložitNovehoOdberatela_Click(object sender, EventArgs e)
        {
                Odberatel.UlozOdberatel(textBox_NazovOdberatela.Text);
        }
    }
}
