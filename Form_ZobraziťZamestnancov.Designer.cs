
namespace Informačný_systém_SOFI
{
    partial class Form_ZobraziťZamestnancov
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
            this.dataGridView_Zamestnanec = new System.Windows.Forms.DataGridView();
            this.idzamestnanci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Meno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priezvisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PracovnaPozicia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HodinovaMzda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_PracovnaPozicia2 = new System.Windows.Forms.ComboBox();
            this.label_HodinovaMzda = new System.Windows.Forms.Label();
            this.textBox_HodinovaMzda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Priezvisko = new System.Windows.Forms.Label();
            this.textBox_Priezvisko = new System.Windows.Forms.TextBox();
            this.button_UlozitZmeny = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Meno = new System.Windows.Forms.TextBox();
            this.comboBox_IDzamestannca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_MenoZamestannca = new System.Windows.Forms.ComboBox();
            this.button_ZobraziťVšetko = new System.Windows.Forms.Button();
            this.comboBox_pracovnaPozicia = new System.Windows.Forms.ComboBox();
            this.label_PracovnaPozicia = new System.Windows.Forms.Label();
            this.button_ZobraziťVýber = new System.Windows.Forms.Button();
            this.labelMeno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Zamestnanec)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNazov
            // 
            this.lblNazov.AutoSize = true;
            this.lblNazov.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazov.ForeColor = System.Drawing.SystemColors.Info;
            this.lblNazov.Location = new System.Drawing.Point(12, 9);
            this.lblNazov.Name = "lblNazov";
            this.lblNazov.Size = new System.Drawing.Size(235, 25);
            this.lblNazov.TabIndex = 5;
            this.lblNazov.Text = "Zobrazenie zamestnancov";
            // 
            // dataGridView_Zamestnanec
            // 
            this.dataGridView_Zamestnanec.AllowUserToAddRows = false;
            this.dataGridView_Zamestnanec.AllowUserToDeleteRows = false;
            this.dataGridView_Zamestnanec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Zamestnanec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Zamestnanec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idzamestnanci,
            this.Meno,
            this.Priezvisko,
            this.PracovnaPozicia,
            this.HodinovaMzda});
            this.dataGridView_Zamestnanec.Location = new System.Drawing.Point(136, 66);
            this.dataGridView_Zamestnanec.Name = "dataGridView_Zamestnanec";
            this.dataGridView_Zamestnanec.RowHeadersVisible = false;
            this.dataGridView_Zamestnanec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Zamestnanec.Size = new System.Drawing.Size(505, 689);
            this.dataGridView_Zamestnanec.TabIndex = 7;
            this.dataGridView_Zamestnanec.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView_Zamestnanec_RowStateChanged);
            // 
            // idzamestnanci
            // 
            this.idzamestnanci.DataPropertyName = "idzamestnanci";
            this.idzamestnanci.HeaderText = "ID zamestnanec";
            this.idzamestnanci.Name = "idzamestnanci";
            // 
            // Meno
            // 
            this.Meno.DataPropertyName = "Meno";
            this.Meno.HeaderText = "Meno";
            this.Meno.Name = "Meno";
            // 
            // Priezvisko
            // 
            this.Priezvisko.DataPropertyName = "Priezvisko";
            this.Priezvisko.HeaderText = "Priezvisko";
            this.Priezvisko.Name = "Priezvisko";
            // 
            // PracovnaPozicia
            // 
            this.PracovnaPozicia.DataPropertyName = "PracovnaPozicia";
            this.PracovnaPozicia.HeaderText = "Pracovná pozícia";
            this.PracovnaPozicia.Name = "PracovnaPozicia";
            // 
            // HodinovaMzda
            // 
            this.HodinovaMzda.DataPropertyName = "HodinovaMzda";
            this.HodinovaMzda.HeaderText = "Hodinová mzda";
            this.HodinovaMzda.Name = "HodinovaMzda";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox_PracovnaPozicia2);
            this.panel1.Controls.Add(this.label_HodinovaMzda);
            this.panel1.Controls.Add(this.textBox_HodinovaMzda);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label_Priezvisko);
            this.panel1.Controls.Add(this.textBox_Priezvisko);
            this.panel1.Controls.Add(this.button_UlozitZmeny);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_Meno);
            this.panel1.Controls.Add(this.comboBox_IDzamestannca);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox_MenoZamestannca);
            this.panel1.Controls.Add(this.button_ZobraziťVšetko);
            this.panel1.Controls.Add(this.comboBox_pracovnaPozicia);
            this.panel1.Controls.Add(this.label_PracovnaPozicia);
            this.panel1.Controls.Add(this.button_ZobraziťVýber);
            this.panel1.Controls.Add(this.labelMeno);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(800, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 825);
            this.panel1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(18, 466);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 115;
            this.label5.Text = "Upraviť ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(18, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Vyhladať";
            // 
            // comboBox_PracovnaPozicia2
            // 
            this.comboBox_PracovnaPozicia2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_PracovnaPozicia2.BackColor = System.Drawing.Color.White;
            this.comboBox_PracovnaPozicia2.DisplayMember = "1";
            this.comboBox_PracovnaPozicia2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_PracovnaPozicia2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_PracovnaPozicia2.FormattingEnabled = true;
            this.comboBox_PracovnaPozicia2.Location = new System.Drawing.Point(256, 590);
            this.comboBox_PracovnaPozicia2.Name = "comboBox_PracovnaPozicia2";
            this.comboBox_PracovnaPozicia2.Size = new System.Drawing.Size(156, 29);
            this.comboBox_PracovnaPozicia2.TabIndex = 114;
            // 
            // label_HodinovaMzda
            // 
            this.label_HodinovaMzda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_HodinovaMzda.AutoSize = true;
            this.label_HodinovaMzda.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_HodinovaMzda.ForeColor = System.Drawing.Color.White;
            this.label_HodinovaMzda.Location = new System.Drawing.Point(98, 628);
            this.label_HodinovaMzda.Name = "label_HodinovaMzda";
            this.label_HodinovaMzda.Size = new System.Drawing.Size(124, 21);
            this.label_HodinovaMzda.TabIndex = 113;
            this.label_HodinovaMzda.Text = "Hodinová mzda";
            // 
            // textBox_HodinovaMzda
            // 
            this.textBox_HodinovaMzda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_HodinovaMzda.BackColor = System.Drawing.Color.White;
            this.textBox_HodinovaMzda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_HodinovaMzda.Location = new System.Drawing.Point(256, 625);
            this.textBox_HodinovaMzda.Name = "textBox_HodinovaMzda";
            this.textBox_HodinovaMzda.Size = new System.Drawing.Size(156, 29);
            this.textBox_HodinovaMzda.TabIndex = 112;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(98, 593);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 21);
            this.label2.TabIndex = 111;
            this.label2.Text = "Pracovná pozícia";
            // 
            // label_Priezvisko
            // 
            this.label_Priezvisko.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Priezvisko.AutoSize = true;
            this.label_Priezvisko.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Priezvisko.ForeColor = System.Drawing.Color.White;
            this.label_Priezvisko.Location = new System.Drawing.Point(98, 558);
            this.label_Priezvisko.Name = "label_Priezvisko";
            this.label_Priezvisko.Size = new System.Drawing.Size(82, 21);
            this.label_Priezvisko.TabIndex = 110;
            this.label_Priezvisko.Text = "Priezvisko";
            // 
            // textBox_Priezvisko
            // 
            this.textBox_Priezvisko.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Priezvisko.BackColor = System.Drawing.Color.White;
            this.textBox_Priezvisko.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Priezvisko.Location = new System.Drawing.Point(256, 555);
            this.textBox_Priezvisko.Name = "textBox_Priezvisko";
            this.textBox_Priezvisko.Size = new System.Drawing.Size(156, 29);
            this.textBox_Priezvisko.TabIndex = 109;
            // 
            // button_UlozitZmeny
            // 
            this.button_UlozitZmeny.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_UlozitZmeny.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.button_UlozitZmeny.FlatAppearance.BorderSize = 0;
            this.button_UlozitZmeny.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_UlozitZmeny.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_UlozitZmeny.ForeColor = System.Drawing.Color.White;
            this.button_UlozitZmeny.Location = new System.Drawing.Point(143, 679);
            this.button_UlozitZmeny.Name = "button_UlozitZmeny";
            this.button_UlozitZmeny.Size = new System.Drawing.Size(220, 43);
            this.button_UlozitZmeny.TabIndex = 107;
            this.button_UlozitZmeny.Text = "Uložiť zmeny";
            this.button_UlozitZmeny.UseVisualStyleBackColor = false;
            this.button_UlozitZmeny.Click += new System.EventHandler(this.button_UlozitZmeny_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(99, 523);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 108;
            this.label3.Text = "Meno";
            // 
            // textBox_Meno
            // 
            this.textBox_Meno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Meno.BackColor = System.Drawing.Color.White;
            this.textBox_Meno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Meno.Location = new System.Drawing.Point(256, 520);
            this.textBox_Meno.Name = "textBox_Meno";
            this.textBox_Meno.Size = new System.Drawing.Size(156, 29);
            this.textBox_Meno.TabIndex = 106;
            // 
            // comboBox_IDzamestannca
            // 
            this.comboBox_IDzamestannca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_IDzamestannca.BackColor = System.Drawing.Color.White;
            this.comboBox_IDzamestannca.DisplayMember = "1";
            this.comboBox_IDzamestannca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_IDzamestannca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_IDzamestannca.FormattingEnabled = true;
            this.comboBox_IDzamestannca.Location = new System.Drawing.Point(241, 66);
            this.comboBox_IDzamestannca.Name = "comboBox_IDzamestannca";
            this.comboBox_IDzamestannca.Size = new System.Drawing.Size(190, 29);
            this.comboBox_IDzamestannca.TabIndex = 105;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 104;
            this.label1.Text = "ID zamestnanca";
            // 
            // comboBox_MenoZamestannca
            // 
            this.comboBox_MenoZamestannca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_MenoZamestannca.BackColor = System.Drawing.Color.White;
            this.comboBox_MenoZamestannca.DisplayMember = "1";
            this.comboBox_MenoZamestannca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_MenoZamestannca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_MenoZamestannca.FormattingEnabled = true;
            this.comboBox_MenoZamestannca.Location = new System.Drawing.Point(241, 101);
            this.comboBox_MenoZamestannca.Name = "comboBox_MenoZamestannca";
            this.comboBox_MenoZamestannca.Size = new System.Drawing.Size(190, 29);
            this.comboBox_MenoZamestannca.TabIndex = 103;
            // 
            // button_ZobraziťVšetko
            // 
            this.button_ZobraziťVšetko.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_ZobraziťVšetko.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.button_ZobraziťVšetko.FlatAppearance.BorderSize = 0;
            this.button_ZobraziťVšetko.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ZobraziťVšetko.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_ZobraziťVšetko.ForeColor = System.Drawing.Color.White;
            this.button_ZobraziťVšetko.Location = new System.Drawing.Point(37, 202);
            this.button_ZobraziťVšetko.Name = "button_ZobraziťVšetko";
            this.button_ZobraziťVšetko.Size = new System.Drawing.Size(259, 43);
            this.button_ZobraziťVšetko.TabIndex = 102;
            this.button_ZobraziťVšetko.Text = "Zobraziť všetkých zamestnancov";
            this.button_ZobraziťVšetko.UseVisualStyleBackColor = false;
            this.button_ZobraziťVšetko.Click += new System.EventHandler(this.button_ZobraziťVšetko_Click);
            // 
            // comboBox_pracovnaPozicia
            // 
            this.comboBox_pracovnaPozicia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_pracovnaPozicia.BackColor = System.Drawing.Color.White;
            this.comboBox_pracovnaPozicia.DisplayMember = "1";
            this.comboBox_pracovnaPozicia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_pracovnaPozicia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_pracovnaPozicia.FormattingEnabled = true;
            this.comboBox_pracovnaPozicia.Location = new System.Drawing.Point(241, 136);
            this.comboBox_pracovnaPozicia.Name = "comboBox_pracovnaPozicia";
            this.comboBox_pracovnaPozicia.Size = new System.Drawing.Size(190, 29);
            this.comboBox_pracovnaPozicia.TabIndex = 101;
            // 
            // label_PracovnaPozicia
            // 
            this.label_PracovnaPozicia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_PracovnaPozicia.AutoSize = true;
            this.label_PracovnaPozicia.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_PracovnaPozicia.ForeColor = System.Drawing.Color.White;
            this.label_PracovnaPozicia.Location = new System.Drawing.Point(83, 139);
            this.label_PracovnaPozicia.Name = "label_PracovnaPozicia";
            this.label_PracovnaPozicia.Size = new System.Drawing.Size(131, 21);
            this.label_PracovnaPozicia.TabIndex = 98;
            this.label_PracovnaPozicia.Text = "Pracovná pozícia";
            // 
            // button_ZobraziťVýber
            // 
            this.button_ZobraziťVýber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_ZobraziťVýber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.button_ZobraziťVýber.FlatAppearance.BorderSize = 0;
            this.button_ZobraziťVýber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ZobraziťVýber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_ZobraziťVýber.ForeColor = System.Drawing.Color.White;
            this.button_ZobraziťVýber.Location = new System.Drawing.Point(316, 202);
            this.button_ZobraziťVýber.Name = "button_ZobraziťVýber";
            this.button_ZobraziťVýber.Size = new System.Drawing.Size(144, 43);
            this.button_ZobraziťVýber.TabIndex = 94;
            this.button_ZobraziťVýber.Text = "Zobraziť";
            this.button_ZobraziťVýber.UseVisualStyleBackColor = false;
            this.button_ZobraziťVýber.Click += new System.EventHandler(this.button_ZobraziťVýber_Click);
            // 
            // labelMeno
            // 
            this.labelMeno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMeno.AutoSize = true;
            this.labelMeno.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMeno.ForeColor = System.Drawing.Color.White;
            this.labelMeno.Location = new System.Drawing.Point(83, 104);
            this.labelMeno.Name = "labelMeno";
            this.labelMeno.Size = new System.Drawing.Size(53, 21);
            this.labelMeno.TabIndex = 95;
            this.labelMeno.Text = "Meno";
            // 
            // Form_ZobraziťZamestnancov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1300, 825);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_Zamestnanec);
            this.Controls.Add(this.lblNazov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ZobraziťZamestnancov";
            this.Text = "FormZobraziťZamestnancov";
            this.Shown += new System.EventHandler(this.Form_ZobraziťZamestnancov_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Zamestnanec)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazov;
        private System.Windows.Forms.DataGridView dataGridView_Zamestnanec;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_ZobraziťVšetko;
        private System.Windows.Forms.ComboBox comboBox_pracovnaPozicia;
        private System.Windows.Forms.Label label_PracovnaPozicia;
        private System.Windows.Forms.Button button_ZobraziťVýber;
        private System.Windows.Forms.Label labelMeno;
        private System.Windows.Forms.ComboBox comboBox_IDzamestannca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_MenoZamestannca;
        private System.Windows.Forms.DataGridViewTextBoxColumn idzamestnanci;
        private System.Windows.Forms.DataGridViewTextBoxColumn Meno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priezvisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn PracovnaPozicia;
        private System.Windows.Forms.DataGridViewTextBoxColumn HodinovaMzda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_PracovnaPozicia2;
        private System.Windows.Forms.Label label_HodinovaMzda;
        private System.Windows.Forms.TextBox textBox_HodinovaMzda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Priezvisko;
        private System.Windows.Forms.TextBox textBox_Priezvisko;
        private System.Windows.Forms.Button button_UlozitZmeny;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Meno;
    }
}