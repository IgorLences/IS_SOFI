using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Informačný_systém_SOFI.classes
{
    public class SideMenu
    {
        private static Form activeForm = null;


        public static void zobrazChildForm(Form childForm, Panel panelChildForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        public static void zobrazSubMenu(Panel SubMenu, Panel[] SubMenus)
        {
            if (SubMenu.Visible == false)
            {
                skryťSubMenu(SubMenus);
                SubMenu.Visible = true;
            }
            else SubMenu.Visible = false;
        }


        public static void skryťSubMenu(Panel[] SubMenus)
        {
            foreach (Panel subMenu in SubMenus)
            {
                if (subMenu.Visible == true) subMenu.Visible = false;
            }
        }

    }
}
