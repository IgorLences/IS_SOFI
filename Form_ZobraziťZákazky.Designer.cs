
namespace Informačný_systém_SOFI
{
    partial class Form_ZobraziťZákazky
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
            this.dataGridView_Zákazka = new System.Windows.Forms.DataGridView();
            this.KodZakazky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazovZakazky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumZalozenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RozpocetNaMontaz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VycerpanyRozpocet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Koeficient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_Odberatelia = new System.Windows.Forms.ComboBox();
            this.labelDatumZalozenia = new System.Windows.Forms.Label();
            this.textBox_DatumZalozenia = new System.Windows.Forms.TextBox();
            this.button_UpdateZakazku = new System.Windows.Forms.Button();
            this.comboBox_Koeficient2 = new System.Windows.Forms.ComboBox();
            this.labelKoeficient = new System.Windows.Forms.Label();
            this.labelVycerpanyRozpocet = new System.Windows.Forms.Label();
            this.textBox_VycerpanyRozpocet = new System.Windows.Forms.TextBox();
            this.labelRozpocetNaMontaz = new System.Windows.Forms.Label();
            this.textBox_RozpocetNaMontaz = new System.Windows.Forms.TextBox();
            this.labelOdberatel = new System.Windows.Forms.Label();
            this.labelNazovZakazky = new System.Windows.Forms.Label();
            this.textBox_NazovZakazky = new System.Windows.Forms.TextBox();
            this.comboBox_Rok = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_mesiac = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Koeficient = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Kodzakazky = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_NazovZakazky = new System.Windows.Forms.ComboBox();
            this.button_ZobraziťVšetkyZakazky = new System.Windows.Forms.Button();
            this.comboBox_Odberatel = new System.Windows.Forms.ComboBox();
            this.label_PracovnaPozicia = new System.Windows.Forms.Label();
            this.button_Zobraziť = new System.Windows.Forms.Button();
            this.labelMeno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Zákazka)).BeginInit();
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
            this.lblNazov.Size = new System.Drawing.Size(181, 25);
            this.lblNazov.TabIndex = 3;
            this.lblNazov.Text = "Zobrazenie zákazok";
            // 
            // dataGridView_Zákazka
            // 
            this.dataGridView_Zákazka.AllowUserToAddRows = false;
            this.dataGridView_Zákazka.AllowUserToDeleteRows = false;
            this.dataGridView_Zákazka.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Zákazka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Zákazka.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KodZakazky,
            this.NazovZakazky,
            this.Nazov,
            this.DatumZalozenia,
            this.RozpocetNaMontaz,
            this.VycerpanyRozpocet,
            this.Koeficient});
            this.dataGridView_Zákazka.Location = new System.Drawing.Point(53, 59);
            this.dataGridView_Zákazka.Name = "dataGridView_Zákazka";
            this.dataGridView_Zákazka.RowHeadersVisible = false;
            this.dataGridView_Zákazka.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView_Zákazka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Zákazka.Size = new System.Drawing.Size(685, 689);
            this.dataGridView_Zákazka.TabIndex = 7;
            this.dataGridView_Zákazka.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView_Zákazka_RowStateChanged);
            // 
            // KodZakazky
            // 
            this.KodZakazky.DataPropertyName = "KodZakazky";
            this.KodZakazky.HeaderText = "Kód zákazky";
            this.KodZakazky.Name = "KodZakazky";
            // 
            // NazovZakazky
            // 
            this.NazovZakazky.DataPropertyName = "NazovZakazky";
            this.NazovZakazky.HeaderText = "Názov";
            this.NazovZakazky.Name = "NazovZakazky";
            // 
            // Nazov
            // 
            this.Nazov.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nazov.DataPropertyName = "Nazov";
            this.Nazov.HeaderText = "Odberateľ";
            this.Nazov.Name = "Nazov";
            this.Nazov.Width = 80;
            // 
            // DatumZalozenia
            // 
            this.DatumZalozenia.DataPropertyName = "DatumZalozenia";
            this.DatumZalozenia.HeaderText = "Dátum založenia";
            this.DatumZalozenia.Name = "DatumZalozenia";
            // 
            // RozpocetNaMontaz
            // 
            this.RozpocetNaMontaz.DataPropertyName = "RozpocetNaMontaz";
            this.RozpocetNaMontaz.HeaderText = "Rozpočet na montáž";
            this.RozpocetNaMontaz.Name = "RozpocetNaMontaz";
            // 
            // VycerpanyRozpocet
            // 
            this.VycerpanyRozpocet.DataPropertyName = "VycerpanyRozpocet";
            this.VycerpanyRozpocet.HeaderText = "Vyčerpaný rozpočet";
            this.VycerpanyRozpocet.Name = "VycerpanyRozpocet";
            // 
            // Koeficient
            // 
            this.Koeficient.DataPropertyName = "Koeficient";
            this.Koeficient.HeaderText = "Koeficient";
            this.Koeficient.Name = "Koeficient";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboBox_Odberatelia);
            this.panel1.Controls.Add(this.labelDatumZalozenia);
            this.panel1.Controls.Add(this.textBox_DatumZalozenia);
            this.panel1.Controls.Add(this.button_UpdateZakazku);
            this.panel1.Controls.Add(this.comboBox_Koeficient2);
            this.panel1.Controls.Add(this.labelKoeficient);
            this.panel1.Controls.Add(this.labelVycerpanyRozpocet);
            this.panel1.Controls.Add(this.textBox_VycerpanyRozpocet);
            this.panel1.Controls.Add(this.labelRozpocetNaMontaz);
            this.panel1.Controls.Add(this.textBox_RozpocetNaMontaz);
            this.panel1.Controls.Add(this.labelOdberatel);
            this.panel1.Controls.Add(this.labelNazovZakazky);
            this.panel1.Controls.Add(this.textBox_NazovZakazky);
            this.panel1.Controls.Add(this.comboBox_Rok);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox_mesiac);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox_Koeficient);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox_Kodzakazky);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox_NazovZakazky);
            this.panel1.Controls.Add(this.button_ZobraziťVšetkyZakazky);
            this.panel1.Controls.Add(this.comboBox_Odberatel);
            this.panel1.Controls.Add(this.label_PracovnaPozicia);
            this.panel1.Controls.Add(this.button_Zobraziť);
            this.panel1.Controls.Add(this.labelMeno);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(800, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 825);
            this.panel1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(34, 469);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 128;
            this.label6.Text = "Upraviť ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(34, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 25);
            this.label7.TabIndex = 127;
            this.label7.Text = "Vyhladať";
            // 
            // comboBox_Odberatelia
            // 
            this.comboBox_Odberatelia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_Odberatelia.BackColor = System.Drawing.Color.White;
            this.comboBox_Odberatelia.DisplayMember = "1";
            this.comboBox_Odberatelia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Odberatelia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_Odberatelia.FormattingEnabled = true;
            this.comboBox_Odberatelia.Location = new System.Drawing.Point(254, 547);
            this.comboBox_Odberatelia.Name = "comboBox_Odberatelia";
            this.comboBox_Odberatelia.Size = new System.Drawing.Size(156, 29);
            this.comboBox_Odberatelia.TabIndex = 119;
            // 
            // labelDatumZalozenia
            // 
            this.labelDatumZalozenia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDatumZalozenia.AutoSize = true;
            this.labelDatumZalozenia.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDatumZalozenia.ForeColor = System.Drawing.Color.White;
            this.labelDatumZalozenia.Location = new System.Drawing.Point(83, 585);
            this.labelDatumZalozenia.Name = "labelDatumZalozenia";
            this.labelDatumZalozenia.Size = new System.Drawing.Size(128, 21);
            this.labelDatumZalozenia.TabIndex = 123;
            this.labelDatumZalozenia.Text = "Dátum založenia";
            // 
            // textBox_DatumZalozenia
            // 
            this.textBox_DatumZalozenia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_DatumZalozenia.BackColor = System.Drawing.Color.White;
            this.textBox_DatumZalozenia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DatumZalozenia.Location = new System.Drawing.Point(254, 582);
            this.textBox_DatumZalozenia.Name = "textBox_DatumZalozenia";
            this.textBox_DatumZalozenia.Size = new System.Drawing.Size(156, 29);
            this.textBox_DatumZalozenia.TabIndex = 114;
            // 
            // button_UpdateZakazku
            // 
            this.button_UpdateZakazku.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_UpdateZakazku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.button_UpdateZakazku.FlatAppearance.BorderSize = 0;
            this.button_UpdateZakazku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_UpdateZakazku.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_UpdateZakazku.ForeColor = System.Drawing.Color.White;
            this.button_UpdateZakazku.Location = new System.Drawing.Point(152, 740);
            this.button_UpdateZakazku.Name = "button_UpdateZakazku";
            this.button_UpdateZakazku.Size = new System.Drawing.Size(181, 43);
            this.button_UpdateZakazku.TabIndex = 118;
            this.button_UpdateZakazku.Text = "Uložiť zmeny";
            this.button_UpdateZakazku.UseVisualStyleBackColor = false;
            this.button_UpdateZakazku.Click += new System.EventHandler(this.button_UpdateZakazku_Click);
            // 
            // comboBox_Koeficient2
            // 
            this.comboBox_Koeficient2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_Koeficient2.BackColor = System.Drawing.Color.White;
            this.comboBox_Koeficient2.DisplayMember = "1";
            this.comboBox_Koeficient2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Koeficient2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_Koeficient2.FormattingEnabled = true;
            this.comboBox_Koeficient2.Items.AddRange(new object[] {
            "SK",
            "EU1",
            "EU2"});
            this.comboBox_Koeficient2.Location = new System.Drawing.Point(254, 687);
            this.comboBox_Koeficient2.Name = "comboBox_Koeficient2";
            this.comboBox_Koeficient2.Size = new System.Drawing.Size(156, 29);
            this.comboBox_Koeficient2.TabIndex = 117;
            // 
            // labelKoeficient
            // 
            this.labelKoeficient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelKoeficient.AutoSize = true;
            this.labelKoeficient.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKoeficient.ForeColor = System.Drawing.Color.White;
            this.labelKoeficient.Location = new System.Drawing.Point(83, 690);
            this.labelKoeficient.Name = "labelKoeficient";
            this.labelKoeficient.Size = new System.Drawing.Size(85, 21);
            this.labelKoeficient.TabIndex = 126;
            this.labelKoeficient.Text = "Koeficient";
            // 
            // labelVycerpanyRozpocet
            // 
            this.labelVycerpanyRozpocet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelVycerpanyRozpocet.AutoSize = true;
            this.labelVycerpanyRozpocet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVycerpanyRozpocet.ForeColor = System.Drawing.Color.White;
            this.labelVycerpanyRozpocet.Location = new System.Drawing.Point(83, 655);
            this.labelVycerpanyRozpocet.Name = "labelVycerpanyRozpocet";
            this.labelVycerpanyRozpocet.Size = new System.Drawing.Size(156, 21);
            this.labelVycerpanyRozpocet.TabIndex = 125;
            this.labelVycerpanyRozpocet.Text = "Vyčerpaný rozpočet";
            // 
            // textBox_VycerpanyRozpocet
            // 
            this.textBox_VycerpanyRozpocet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_VycerpanyRozpocet.BackColor = System.Drawing.Color.White;
            this.textBox_VycerpanyRozpocet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VycerpanyRozpocet.Location = new System.Drawing.Point(254, 652);
            this.textBox_VycerpanyRozpocet.Name = "textBox_VycerpanyRozpocet";
            this.textBox_VycerpanyRozpocet.Size = new System.Drawing.Size(156, 29);
            this.textBox_VycerpanyRozpocet.TabIndex = 116;
            this.textBox_VycerpanyRozpocet.Text = "0";
            // 
            // labelRozpocetNaMontaz
            // 
            this.labelRozpocetNaMontaz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRozpocetNaMontaz.AutoSize = true;
            this.labelRozpocetNaMontaz.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRozpocetNaMontaz.ForeColor = System.Drawing.Color.White;
            this.labelRozpocetNaMontaz.Location = new System.Drawing.Point(83, 620);
            this.labelRozpocetNaMontaz.Name = "labelRozpocetNaMontaz";
            this.labelRozpocetNaMontaz.Size = new System.Drawing.Size(159, 21);
            this.labelRozpocetNaMontaz.TabIndex = 124;
            this.labelRozpocetNaMontaz.Text = "Rozpočet na montáž";
            // 
            // textBox_RozpocetNaMontaz
            // 
            this.textBox_RozpocetNaMontaz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_RozpocetNaMontaz.BackColor = System.Drawing.Color.White;
            this.textBox_RozpocetNaMontaz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_RozpocetNaMontaz.Location = new System.Drawing.Point(254, 617);
            this.textBox_RozpocetNaMontaz.Name = "textBox_RozpocetNaMontaz";
            this.textBox_RozpocetNaMontaz.Size = new System.Drawing.Size(156, 29);
            this.textBox_RozpocetNaMontaz.TabIndex = 115;
            this.textBox_RozpocetNaMontaz.Text = "0";
            // 
            // labelOdberatel
            // 
            this.labelOdberatel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOdberatel.AutoSize = true;
            this.labelOdberatel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOdberatel.ForeColor = System.Drawing.Color.White;
            this.labelOdberatel.Location = new System.Drawing.Point(83, 550);
            this.labelOdberatel.Name = "labelOdberatel";
            this.labelOdberatel.Size = new System.Drawing.Size(85, 21);
            this.labelOdberatel.TabIndex = 122;
            this.labelOdberatel.Text = "Odberateľ";
            // 
            // labelNazovZakazky
            // 
            this.labelNazovZakazky.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNazovZakazky.AutoSize = true;
            this.labelNazovZakazky.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNazovZakazky.ForeColor = System.Drawing.Color.White;
            this.labelNazovZakazky.Location = new System.Drawing.Point(83, 515);
            this.labelNazovZakazky.Name = "labelNazovZakazky";
            this.labelNazovZakazky.Size = new System.Drawing.Size(113, 21);
            this.labelNazovZakazky.TabIndex = 121;
            this.labelNazovZakazky.Text = "Názov zákazky";
            // 
            // textBox_NazovZakazky
            // 
            this.textBox_NazovZakazky.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_NazovZakazky.BackColor = System.Drawing.Color.White;
            this.textBox_NazovZakazky.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NazovZakazky.Location = new System.Drawing.Point(254, 512);
            this.textBox_NazovZakazky.Name = "textBox_NazovZakazky";
            this.textBox_NazovZakazky.Size = new System.Drawing.Size(156, 29);
            this.textBox_NazovZakazky.TabIndex = 113;
            // 
            // comboBox_Rok
            // 
            this.comboBox_Rok.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_Rok.BackColor = System.Drawing.Color.White;
            this.comboBox_Rok.DisplayMember = "1";
            this.comboBox_Rok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Rok.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_Rok.FormattingEnabled = true;
            this.comboBox_Rok.Items.AddRange(new object[] {
            "",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.comboBox_Rok.Location = new System.Drawing.Point(241, 238);
            this.comboBox_Rok.Name = "comboBox_Rok";
            this.comboBox_Rok.Size = new System.Drawing.Size(190, 29);
            this.comboBox_Rok.TabIndex = 111;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(83, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 21);
            this.label3.TabIndex = 110;
            this.label3.Text = "Rok";
            // 
            // comboBox_mesiac
            // 
            this.comboBox_mesiac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_mesiac.BackColor = System.Drawing.Color.White;
            this.comboBox_mesiac.DisplayMember = "1";
            this.comboBox_mesiac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_mesiac.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_mesiac.FormattingEnabled = true;
            this.comboBox_mesiac.Items.AddRange(new object[] {
            "",
            "Január",
            "Frebruár",
            "Marec",
            "Apríl",
            "Máj",
            "Jún",
            "Júl",
            "August",
            "September",
            "Október",
            "November",
            "December"});
            this.comboBox_mesiac.Location = new System.Drawing.Point(241, 204);
            this.comboBox_mesiac.Name = "comboBox_mesiac";
            this.comboBox_mesiac.Size = new System.Drawing.Size(190, 29);
            this.comboBox_mesiac.TabIndex = 109;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(83, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 108;
            this.label4.Text = "Mesiac";
            // 
            // comboBox_Koeficient
            // 
            this.comboBox_Koeficient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_Koeficient.AutoCompleteCustomSource.AddRange(new string[] {
            "SK",
            "EU1",
            "EU2"});
            this.comboBox_Koeficient.BackColor = System.Drawing.Color.White;
            this.comboBox_Koeficient.DisplayMember = "1";
            this.comboBox_Koeficient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Koeficient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_Koeficient.FormattingEnabled = true;
            this.comboBox_Koeficient.Items.AddRange(new object[] {
            "",
            "SK",
            "EU1",
            "EU2"});
            this.comboBox_Koeficient.Location = new System.Drawing.Point(241, 170);
            this.comboBox_Koeficient.Name = "comboBox_Koeficient";
            this.comboBox_Koeficient.Size = new System.Drawing.Size(190, 29);
            this.comboBox_Koeficient.TabIndex = 107;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(83, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 106;
            this.label2.Text = "Koeficient";
            // 
            // comboBox_Kodzakazky
            // 
            this.comboBox_Kodzakazky.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_Kodzakazky.BackColor = System.Drawing.Color.White;
            this.comboBox_Kodzakazky.DisplayMember = "1";
            this.comboBox_Kodzakazky.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Kodzakazky.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_Kodzakazky.FormattingEnabled = true;
            this.comboBox_Kodzakazky.Location = new System.Drawing.Point(241, 66);
            this.comboBox_Kodzakazky.Name = "comboBox_Kodzakazky";
            this.comboBox_Kodzakazky.Size = new System.Drawing.Size(190, 29);
            this.comboBox_Kodzakazky.TabIndex = 105;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 104;
            this.label1.Text = "Kód zákazky";
            // 
            // comboBox_NazovZakazky
            // 
            this.comboBox_NazovZakazky.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_NazovZakazky.BackColor = System.Drawing.Color.White;
            this.comboBox_NazovZakazky.DisplayMember = "1";
            this.comboBox_NazovZakazky.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_NazovZakazky.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_NazovZakazky.FormattingEnabled = true;
            this.comboBox_NazovZakazky.Location = new System.Drawing.Point(241, 101);
            this.comboBox_NazovZakazky.Name = "comboBox_NazovZakazky";
            this.comboBox_NazovZakazky.Size = new System.Drawing.Size(190, 29);
            this.comboBox_NazovZakazky.TabIndex = 103;
            // 
            // button_ZobraziťVšetkyZakazky
            // 
            this.button_ZobraziťVšetkyZakazky.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_ZobraziťVšetkyZakazky.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.button_ZobraziťVšetkyZakazky.FlatAppearance.BorderSize = 0;
            this.button_ZobraziťVšetkyZakazky.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ZobraziťVšetkyZakazky.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_ZobraziťVšetkyZakazky.ForeColor = System.Drawing.Color.White;
            this.button_ZobraziťVšetkyZakazky.Location = new System.Drawing.Point(39, 292);
            this.button_ZobraziťVšetkyZakazky.Name = "button_ZobraziťVšetkyZakazky";
            this.button_ZobraziťVšetkyZakazky.Size = new System.Drawing.Size(259, 43);
            this.button_ZobraziťVšetkyZakazky.TabIndex = 102;
            this.button_ZobraziťVšetkyZakazky.Text = "Zobraziť všetky zákazky";
            this.button_ZobraziťVšetkyZakazky.UseVisualStyleBackColor = false;
            this.button_ZobraziťVšetkyZakazky.Click += new System.EventHandler(this.button_ZobraziťVšetkyZakazky_Click);
            // 
            // comboBox_Odberatel
            // 
            this.comboBox_Odberatel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_Odberatel.BackColor = System.Drawing.Color.White;
            this.comboBox_Odberatel.DisplayMember = "1";
            this.comboBox_Odberatel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Odberatel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_Odberatel.FormattingEnabled = true;
            this.comboBox_Odberatel.Location = new System.Drawing.Point(241, 136);
            this.comboBox_Odberatel.Name = "comboBox_Odberatel";
            this.comboBox_Odberatel.Size = new System.Drawing.Size(190, 29);
            this.comboBox_Odberatel.TabIndex = 101;
            // 
            // label_PracovnaPozicia
            // 
            this.label_PracovnaPozicia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_PracovnaPozicia.AutoSize = true;
            this.label_PracovnaPozicia.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_PracovnaPozicia.ForeColor = System.Drawing.Color.White;
            this.label_PracovnaPozicia.Location = new System.Drawing.Point(83, 139);
            this.label_PracovnaPozicia.Name = "label_PracovnaPozicia";
            this.label_PracovnaPozicia.Size = new System.Drawing.Size(85, 21);
            this.label_PracovnaPozicia.TabIndex = 98;
            this.label_PracovnaPozicia.Text = "Odberateľ";
            // 
            // button_Zobraziť
            // 
            this.button_Zobraziť.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Zobraziť.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.button_Zobraziť.FlatAppearance.BorderSize = 0;
            this.button_Zobraziť.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Zobraziť.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Zobraziť.ForeColor = System.Drawing.Color.White;
            this.button_Zobraziť.Location = new System.Drawing.Point(318, 292);
            this.button_Zobraziť.Name = "button_Zobraziť";
            this.button_Zobraziť.Size = new System.Drawing.Size(144, 43);
            this.button_Zobraziť.TabIndex = 94;
            this.button_Zobraziť.Text = "Zobraziť";
            this.button_Zobraziť.UseVisualStyleBackColor = false;
            this.button_Zobraziť.Click += new System.EventHandler(this.button_Zobraziť_Click);
            // 
            // labelMeno
            // 
            this.labelMeno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMeno.AutoSize = true;
            this.labelMeno.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMeno.ForeColor = System.Drawing.Color.White;
            this.labelMeno.Location = new System.Drawing.Point(83, 104);
            this.labelMeno.Name = "labelMeno";
            this.labelMeno.Size = new System.Drawing.Size(55, 21);
            this.labelMeno.TabIndex = 95;
            this.labelMeno.Text = "Názov";
            // 
            // Form_ZobraziťZákazky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1300, 825);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_Zákazka);
            this.Controls.Add(this.lblNazov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ZobraziťZákazky";
            this.Text = "Form_ZobraziťZákazky";
            this.Shown += new System.EventHandler(this.Form_ZobraziťZákazky_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Zákazka)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazov;
        private System.Windows.Forms.DataGridView dataGridView_Zákazka;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_Kodzakazky;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_NazovZakazky;
        private System.Windows.Forms.Button button_ZobraziťVšetkyZakazky;
        private System.Windows.Forms.ComboBox comboBox_Odberatel;
        private System.Windows.Forms.Label label_PracovnaPozicia;
        private System.Windows.Forms.Button button_Zobraziť;
        private System.Windows.Forms.Label labelMeno;
        private System.Windows.Forms.ComboBox comboBox_Koeficient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Rok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_mesiac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_Odberatelia;
        private System.Windows.Forms.Label labelDatumZalozenia;
        private System.Windows.Forms.TextBox textBox_DatumZalozenia;
        private System.Windows.Forms.Button button_UpdateZakazku;
        private System.Windows.Forms.ComboBox comboBox_Koeficient2;
        private System.Windows.Forms.Label labelKoeficient;
        private System.Windows.Forms.Label labelVycerpanyRozpocet;
        private System.Windows.Forms.TextBox textBox_VycerpanyRozpocet;
        private System.Windows.Forms.Label labelRozpocetNaMontaz;
        private System.Windows.Forms.TextBox textBox_RozpocetNaMontaz;
        private System.Windows.Forms.Label labelOdberatel;
        private System.Windows.Forms.Label labelNazovZakazky;
        private System.Windows.Forms.TextBox textBox_NazovZakazky;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodZakazky;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazovZakazky;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazov;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumZalozenia;
        private System.Windows.Forms.DataGridViewTextBoxColumn RozpocetNaMontaz;
        private System.Windows.Forms.DataGridViewTextBoxColumn VycerpanyRozpocet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Koeficient;
    }
}