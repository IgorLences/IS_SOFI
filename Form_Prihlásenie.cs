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
    public partial class Form_Prihlásenie : Form
    {
        DBConnection DBConnection = new DBConnection();
        public Form_Prihlásenie()
        {
            InitializeComponent();
        }

        private void Form_Prihlásenie_Load(object sender, EventArgs e)
        {

        }

        private void Form_Prihlásenie_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ( this.DialogResult == DialogResult.OK)
            {
                switch (DBConnection.Login(textBox_Meno.Text, textBox_Heslo.Text))
                {
                    case 0:
                        {
                            MessageBox.Show("Nedá sa pripojiť na server.r");
                            e.Cancel = true;
                        }
                        break;

                    case 1:
                        {
                            MessageBox.Show("Úspešné prihlásenie.");
                        }
                        break;

                    case 1040:
                        {
                            MessageBox.Show("Veľa pripojení na server.");
                            e.Cancel = true;
                        }
                        break;

                    case 1045:
                        {
                            MessageBox.Show("Nesprávne prihlasovacie údaje.");
                            e.Cancel = true;
                        }
                        break;

                    default:
                        {
                            MessageBox.Show(" MySQL-Exception number:" + Convert.ToString(DBConnection.Login(textBox_Meno.Text, textBox_Heslo.Text)));
                            e.Cancel = true;
                        }
                        break;
                }
            }

        }

        private void button_Prihlásiť_Click(object sender, EventArgs e)
        {

        }
    }
}
