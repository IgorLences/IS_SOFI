
namespace Informačný_systém_SOFI
{
    partial class Form_VytvoriťNovúZákazku
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNazov = new System.Windows.Forms.Label();
            this.comboBox_Odberatelia = new System.Windows.Forms.ComboBox();
            this.labelDatumZalozenia = new System.Windows.Forms.Label();
            this.textBox_DatumZalozenia = new System.Windows.Forms.TextBox();
            this.button_VytvoritNovuZakazku = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_KodZakazky = new System.Windows.Forms.TextBox();
            this.comboBox_Koeficient = new System.Windows.Forms.ComboBox();
            this.labelKoeficient = new System.Windows.Forms.Label();
            this.labelVycerpanyRozpocet = new System.Windows.Forms.Label();
            this.textBox_VycerpanyRozpocet = new System.Windows.Forms.TextBox();
            this.labelRozpocetNaMontaz = new System.Windows.Forms.Label();
            this.textBox_RozpocetNaMontaz = new System.Windows.Forms.TextBox();
            this.labelOdberatel = new System.Windows.Forms.Label();
            this.labelNazovZakazky = new System.Windows.Forms.Label();
            this.textBox_NazovZakazky = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNazov
            // 
            this.lblNazov.AutoSize = true;
            this.lblNazov.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazov.ForeColor = System.Drawing.SystemColors.Info;
            this.lblNazov.Location = new System.Drawing.Point(12, 9);
            this.lblNazov.Name = "lblNazov";
            this.lblNazov.Size = new System.Drawing.Size(230, 25);
            this.lblNazov.TabIndex = 2;
            this.lblNazov.Text = "Vytvorenie novej zákazky";
            // 
            // comboBox_Odberatelia
            // 
            this.comboBox_Odberatelia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_Odberatelia.BackColor = System.Drawing.Color.White;
            this.comboBox_Odberatelia.DisplayMember = "1";
            this.comboBox_Odberatelia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Odberatelia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_Odberatelia.FormattingEnabled = true;
            this.comboBox_Odberatelia.Location = new System.Drawing.Point(654, 288);
            this.comboBox_Odberatelia.Name = "comboBox_Odberatelia";
            this.comboBox_Odberatelia.Size = new System.Drawing.Size(156, 29);
            this.comboBox_Odberatelia.TabIndex = 67;
            // 
            // labelDatumZalozenia
            // 
            this.labelDatumZalozenia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDatumZalozenia.AutoSize = true;
            this.labelDatumZalozenia.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDatumZalozenia.ForeColor = System.Drawing.Color.White;
            this.labelDatumZalozenia.Location = new System.Drawing.Point(483, 326);
            this.labelDatumZalozenia.Name = "labelDatumZalozenia";
            this.labelDatumZalozenia.Size = new System.Drawing.Size(128, 21);
            this.labelDatumZalozenia.TabIndex = 71;
            this.labelDatumZalozenia.Text = "Dátum založenia";
            // 
            // textBox_DatumZalozenia
            // 
            this.textBox_DatumZalozenia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_DatumZalozenia.BackColor = System.Drawing.Color.White;
            this.textBox_DatumZalozenia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DatumZalozenia.Location = new System.Drawing.Point(654, 323);
            this.textBox_DatumZalozenia.Name = "textBox_DatumZalozenia";
            this.textBox_DatumZalozenia.Size = new System.Drawing.Size(156, 29);
            this.textBox_DatumZalozenia.TabIndex = 62;
            // 
            // button_VytvoritNovuZakazku
            // 
            this.button_VytvoritNovuZakazku.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_VytvoritNovuZakazku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.button_VytvoritNovuZakazku.FlatAppearance.BorderSize = 0;
            this.button_VytvoritNovuZakazku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_VytvoritNovuZakazku.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_VytvoritNovuZakazku.Location = new System.Drawing.Point(552, 481);
            this.button_VytvoritNovuZakazku.Name = "button_VytvoritNovuZakazku";
            this.button_VytvoritNovuZakazku.Size = new System.Drawing.Size(181, 43);
            this.button_VytvoritNovuZakazku.TabIndex = 66;
            this.button_VytvoritNovuZakazku.Text = "Vytvoriť novú zákazku";
            this.button_VytvoritNovuZakazku.UseVisualStyleBackColor = false;
            this.button_VytvoritNovuZakazku.Click += new System.EventHandler(this.button_VytvoritNovuZakazku_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(483, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 68;
            this.label1.Text = "Kód zákazky";
            // 
            // textBox_KodZakazky
            // 
            this.textBox_KodZakazky.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_KodZakazky.BackColor = System.Drawing.Color.White;
            this.textBox_KodZakazky.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_KodZakazky.Location = new System.Drawing.Point(654, 218);
            this.textBox_KodZakazky.Name = "textBox_KodZakazky";
            this.textBox_KodZakazky.Size = new System.Drawing.Size(156, 29);
            this.textBox_KodZakazky.TabIndex = 60;
            // 
            // comboBox_Koeficient
            // 
            this.comboBox_Koeficient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_Koeficient.BackColor = System.Drawing.Color.White;
            this.comboBox_Koeficient.DisplayMember = "1";
            this.comboBox_Koeficient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Koeficient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_Koeficient.FormattingEnabled = true;
            this.comboBox_Koeficient.Items.AddRange(new object[] {
            "SK",
            "EU1",
            "EU2"});
            this.comboBox_Koeficient.Location = new System.Drawing.Point(654, 428);
            this.comboBox_Koeficient.Name = "comboBox_Koeficient";
            this.comboBox_Koeficient.Size = new System.Drawing.Size(156, 29);
            this.comboBox_Koeficient.TabIndex = 65;
            // 
            // labelKoeficient
            // 
            this.labelKoeficient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelKoeficient.AutoSize = true;
            this.labelKoeficient.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKoeficient.ForeColor = System.Drawing.Color.White;
            this.labelKoeficient.Location = new System.Drawing.Point(483, 431);
            this.labelKoeficient.Name = "labelKoeficient";
            this.labelKoeficient.Size = new System.Drawing.Size(85, 21);
            this.labelKoeficient.TabIndex = 74;
            this.labelKoeficient.Text = "Koeficient";
            // 
            // labelVycerpanyRozpocet
            // 
            this.labelVycerpanyRozpocet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelVycerpanyRozpocet.AutoSize = true;
            this.labelVycerpanyRozpocet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVycerpanyRozpocet.ForeColor = System.Drawing.Color.White;
            this.labelVycerpanyRozpocet.Location = new System.Drawing.Point(483, 396);
            this.labelVycerpanyRozpocet.Name = "labelVycerpanyRozpocet";
            this.labelVycerpanyRozpocet.Size = new System.Drawing.Size(156, 21);
            this.labelVycerpanyRozpocet.TabIndex = 73;
            this.labelVycerpanyRozpocet.Text = "Vyčerpaný rozpočet";
            // 
            // textBox_VycerpanyRozpocet
            // 
            this.textBox_VycerpanyRozpocet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_VycerpanyRozpocet.BackColor = System.Drawing.Color.White;
            this.textBox_VycerpanyRozpocet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VycerpanyRozpocet.Location = new System.Drawing.Point(654, 393);
            this.textBox_VycerpanyRozpocet.Name = "textBox_VycerpanyRozpocet";
            this.textBox_VycerpanyRozpocet.Size = new System.Drawing.Size(156, 29);
            this.textBox_VycerpanyRozpocet.TabIndex = 64;
            this.textBox_VycerpanyRozpocet.Text = "0";
            // 
            // labelRozpocetNaMontaz
            // 
            this.labelRozpocetNaMontaz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRozpocetNaMontaz.AutoSize = true;
            this.labelRozpocetNaMontaz.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRozpocetNaMontaz.ForeColor = System.Drawing.Color.White;
            this.labelRozpocetNaMontaz.Location = new System.Drawing.Point(483, 361);
            this.labelRozpocetNaMontaz.Name = "labelRozpocetNaMontaz";
            this.labelRozpocetNaMontaz.Size = new System.Drawing.Size(159, 21);
            this.labelRozpocetNaMontaz.TabIndex = 72;
            this.labelRozpocetNaMontaz.Text = "Rozpočet na montáž";
            // 
            // textBox_RozpocetNaMontaz
            // 
            this.textBox_RozpocetNaMontaz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_RozpocetNaMontaz.BackColor = System.Drawing.Color.White;
            this.textBox_RozpocetNaMontaz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_RozpocetNaMontaz.Location = new System.Drawing.Point(654, 358);
            this.textBox_RozpocetNaMontaz.Name = "textBox_RozpocetNaMontaz";
            this.textBox_RozpocetNaMontaz.Size = new System.Drawing.Size(156, 29);
            this.textBox_RozpocetNaMontaz.TabIndex = 63;
            this.textBox_RozpocetNaMontaz.Text = "0";
            // 
            // labelOdberatel
            // 
            this.labelOdberatel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOdberatel.AutoSize = true;
            this.labelOdberatel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOdberatel.ForeColor = System.Drawing.Color.White;
            this.labelOdberatel.Location = new System.Drawing.Point(483, 291);
            this.labelOdberatel.Name = "labelOdberatel";
            this.labelOdberatel.Size = new System.Drawing.Size(85, 21);
            this.labelOdberatel.TabIndex = 70;
            this.labelOdberatel.Text = "Odberateľ";
            // 
            // labelNazovZakazky
            // 
            this.labelNazovZakazky.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNazovZakazky.AutoSize = true;
            this.labelNazovZakazky.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNazovZakazky.ForeColor = System.Drawing.Color.White;
            this.labelNazovZakazky.Location = new System.Drawing.Point(483, 256);
            this.labelNazovZakazky.Name = "labelNazovZakazky";
            this.labelNazovZakazky.Size = new System.Drawing.Size(113, 21);
            this.labelNazovZakazky.TabIndex = 69;
            this.labelNazovZakazky.Text = "Názov zákazky";
            // 
            // textBox_NazovZakazky
            // 
            this.textBox_NazovZakazky.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_NazovZakazky.BackColor = System.Drawing.Color.White;
            this.textBox_NazovZakazky.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NazovZakazky.Location = new System.Drawing.Point(654, 253);
            this.textBox_NazovZakazky.Name = "textBox_NazovZakazky";
            this.textBox_NazovZakazky.Size = new System.Drawing.Size(156, 29);
            this.textBox_NazovZakazky.TabIndex = 61;
            // 
            // Form_VytvoriťNovúZákazku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1300, 825);
            this.Controls.Add(this.comboBox_Odberatelia);
            this.Controls.Add(this.labelDatumZalozenia);
            this.Controls.Add(this.textBox_DatumZalozenia);
            this.Controls.Add(this.button_VytvoritNovuZakazku);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_KodZakazky);
            this.Controls.Add(this.comboBox_Koeficient);
            this.Controls.Add(this.labelKoeficient);
            this.Controls.Add(this.labelVycerpanyRozpocet);
            this.Controls.Add(this.textBox_VycerpanyRozpocet);
            this.Controls.Add(this.labelRozpocetNaMontaz);
            this.Controls.Add(this.textBox_RozpocetNaMontaz);
            this.Controls.Add(this.labelOdberatel);
            this.Controls.Add(this.labelNazovZakazky);
            this.Controls.Add(this.textBox_NazovZakazky);
            this.Controls.Add(this.lblNazov);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_VytvoriťNovúZákazku";
            this.Text = "Form_VytvoriťNovúZákazku";
            this.Shown += new System.EventHandler(this.Form_VytvoriťNovúZákazku_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazov;
        private System.Windows.Forms.ComboBox comboBox_Odberatelia;
        private System.Windows.Forms.Label labelDatumZalozenia;
        private System.Windows.Forms.TextBox textBox_DatumZalozenia;
        private System.Windows.Forms.Button button_VytvoritNovuZakazku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_KodZakazky;
        private System.Windows.Forms.ComboBox comboBox_Koeficient;
        private System.Windows.Forms.Label labelKoeficient;
        private System.Windows.Forms.Label labelVycerpanyRozpocet;
        private System.Windows.Forms.TextBox textBox_VycerpanyRozpocet;
        private System.Windows.Forms.Label labelRozpocetNaMontaz;
        private System.Windows.Forms.TextBox textBox_RozpocetNaMontaz;
        private System.Windows.Forms.Label labelOdberatel;
        private System.Windows.Forms.Label labelNazovZakazky;
        private System.Windows.Forms.TextBox textBox_NazovZakazky;
    }
}