using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Informačný_systém_SOFI.classes;
using MySql.Data.MySqlClient;

namespace Informačný_systém_SOFI

{
    public partial class Form_Menu : Form
    {
        Panel[] SubMenus = new Panel[4];

        public Form_Menu()
        {
            InitializeComponent();
            
        }
        

        private void Menu_Shown(object sender, EventArgs e)
        {
            
            SubMenus[0] = panel_SubMenu_Zákazky;
            SubMenus[1] = panel_SubMenu_Zamestnanci;
            SubMenus[2] = panel_SubMenu_Dochádzka;
            SubMenus[3] = panel_SubMenu_Odberatelia;

            SideMenu.skryťSubMenu(SubMenus);

            //vytvoríme objekt okna a zobrazíme ho ako dialóg
            Form_Prihlásenie frmLogin = new Form_Prihlásenie();
            DialogResult odpoved = frmLogin.ShowDialog();

            //ak odpoveď nášho dialógu nebola OK, zatvoríme aplikáciu
            if (odpoved != DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                label_Prihlásenie.Visible = false;
            }


            /* MySqlCommand commandDatabase = new MySqlCommand("INSERT INTO zasielky values (148,13,1,12,15,2,12);", databaseConnection);
                commandDatabase.CommandTimeout = 60;

                try
                {
                    databaseConnection.Open();
                    commandDatabase.ExecuteNonQuery();
                    databaseConnection.Close();
                }
                catch(MySqlException ex)
                {

                }*/
        }





        private void button_Zákazky_Click(object sender, EventArgs e)
        {
            SideMenu.zobrazSubMenu(panel_SubMenu_Zákazky, SubMenus);
        }

        private void button_Zamestnanci_Click(object sender, EventArgs e)
        {
            SideMenu.zobrazSubMenu(panel_SubMenu_Zamestnanci, SubMenus);
        }

        private void button_Dochádzka_Click(object sender, EventArgs e)
        {
            SideMenu.zobrazSubMenu(panel_SubMenu_Dochádzka, SubMenus);
        }

        private void button_Odberatelia_Click(object sender, EventArgs e)
        {
            SideMenu.zobrazSubMenu(panel_SubMenu_Odberatelia, SubMenus);
        }




        // Otvorenie Child  form v paneli panel_ChildForm
        private void buttonVytvoritZakazku_Click(object sender, EventArgs e)
        {
            SideMenu.zobrazChildForm(new Form_VytvoriťNovúZákazku(), panel_ChildForm);
        }

        private void buttonZobraziťZakazky_Click(object sender, EventArgs e)
        {
            SideMenu.zobrazChildForm(new Form_ZobraziťZákazky(), panel_ChildForm);
        }

        private void buttonVlozitNovehoZamestnanca_Click(object sender, EventArgs e)
        {
            SideMenu.zobrazChildForm(new Form_PridaťZamestnanca(), panel_ChildForm);
        }

        private void buttonZobrazitZamestnancov_Click(object sender, EventArgs e)
        {
            SideMenu.zobrazChildForm(new Form_ZobraziťZamestnancov(), panel_ChildForm);
        }

        private void buttonZapisOdpracovanyDen_Click(object sender, EventArgs e)
        {
            SideMenu.zobrazChildForm(new Form_ZapísaťOdpracovanýDeň(), panel_ChildForm);
        }

        private void buttonZobrazOdpracovaneDni_Click(object sender, EventArgs e)
        {
            SideMenu.zobrazChildForm(new Form_ZobraziťOdpracovanéDni(), panel_ChildForm);
        }

        private void button_PridaťOdberateľa_Click(object sender, EventArgs e)
        {
            SideMenu.zobrazChildForm(new Form_PridaťOdberateľa(), panel_ChildForm);
        }

        private void button_ZobraziťOdebraťeľov_Click(object sender, EventArgs e)
        {
            SideMenu.zobrazChildForm(new Form_ZobraziťOdberateľov(), panel_ChildForm);
        }
    }
}
