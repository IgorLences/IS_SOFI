
namespace Informačný_systém_SOFI
{
    partial class Form_ZobraziťOdpracovanéDni
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
            this.dataGridView_OdpracovanyDen = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_Rok = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_mesiac = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Koeficient = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_IDodpracovanyDen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Zamestnanec = new System.Windows.Forms.ComboBox();
            this.button_ZobraziťVšetkyOdpravoneDni = new System.Windows.Forms.Button();
            this.comboBox_Zakazka = new System.Windows.Forms.ComboBox();
            this.label_PracovnaPozicia = new System.Windows.Forms.Label();
            this.button_Zobraziť = new System.Windows.Forms.Button();
            this.labelMeno = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Zakazka2 = new System.Windows.Forms.ComboBox();
            this.comboBox_Zamestnanec2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelDatumZalozenia = new System.Windows.Forms.Label();
            this.textBox_DatumPrace = new System.Windows.Forms.TextBox();
            this.button_UpdateOdpracovaneDni = new System.Windows.Forms.Button();
            this.comboBox_Koeficient2 = new System.Windows.Forms.ComboBox();
            this.labelKoeficient = new System.Windows.Forms.Label();
            this.labelOdpracopvanyCas = new System.Windows.Forms.Label();
            this.textBox_OdpracovanýČas = new System.Windows.Forms.TextBox();
            this.IDOdpracovaneDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenoZamestnanca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazovZakazky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OdpracovanyCas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Koeficient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CenaPrace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OdpracovanyDen)).BeginInit();
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
            this.lblNazov.Size = new System.Drawing.Size(275, 25);
            this.lblNazov.TabIndex = 6;
            this.lblNazov.Text = "Zobrazenie odpracovaných dní";
            // 
            // dataGridView_OdpracovanyDen
            // 
            this.dataGridView_OdpracovanyDen.AllowUserToAddRows = false;
            this.dataGridView_OdpracovanyDen.AllowUserToDeleteRows = false;
            this.dataGridView_OdpracovanyDen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_OdpracovanyDen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_OdpracovanyDen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDOdpracovaneDni,
            this.MenoZamestnanca,
            this.NazovZakazky,
            this.Datum,
            this.OdpracovanyCas,
            this.Koeficient,
            this.CenaPrace});
            this.dataGridView_OdpracovanyDen.Location = new System.Drawing.Point(49, 47);
            this.dataGridView_OdpracovanyDen.Name = "dataGridView_OdpracovanyDen";
            this.dataGridView_OdpracovanyDen.RowHeadersVisible = false;
            this.dataGridView_OdpracovanyDen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_OdpracovanyDen.Size = new System.Drawing.Size(704, 732);
            this.dataGridView_OdpracovanyDen.TabIndex = 7;
            this.dataGridView_OdpracovanyDen.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView_OdpracovanyDen_RowStateChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBox_Zakazka2);
            this.panel1.Controls.Add(this.comboBox_Zamestnanec2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.labelDatumZalozenia);
            this.panel1.Controls.Add(this.textBox_DatumPrace);
            this.panel1.Controls.Add(this.button_UpdateOdpracovaneDni);
            this.panel1.Controls.Add(this.comboBox_Koeficient2);
            this.panel1.Controls.Add(this.labelKoeficient);
            this.panel1.Controls.Add(this.labelOdpracopvanyCas);
            this.panel1.Controls.Add(this.textBox_OdpracovanýČas);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboBox_Rok);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox_mesiac);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox_Koeficient);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox_IDodpracovanyDen);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox_Zamestnanec);
            this.panel1.Controls.Add(this.button_ZobraziťVšetkyOdpravoneDni);
            this.panel1.Controls.Add(this.comboBox_Zakazka);
            this.panel1.Controls.Add(this.label_PracovnaPozicia);
            this.panel1.Controls.Add(this.button_Zobraziť);
            this.panel1.Controls.Add(this.labelMeno);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(800, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 825);
            this.panel1.TabIndex = 11;
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
            // comboBox_IDodpracovanyDen
            // 
            this.comboBox_IDodpracovanyDen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_IDodpracovanyDen.BackColor = System.Drawing.Color.White;
            this.comboBox_IDodpracovanyDen.DisplayMember = "1";
            this.comboBox_IDodpracovanyDen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_IDodpracovanyDen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_IDodpracovanyDen.FormattingEnabled = true;
            this.comboBox_IDodpracovanyDen.Location = new System.Drawing.Point(241, 66);
            this.comboBox_IDodpracovanyDen.Name = "comboBox_IDodpracovanyDen";
            this.comboBox_IDodpracovanyDen.Size = new System.Drawing.Size(190, 29);
            this.comboBox_IDodpracovanyDen.TabIndex = 105;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 21);
            this.label1.TabIndex = 104;
            this.label1.Text = "ID odpracovany deň";
            // 
            // comboBox_Zamestnanec
            // 
            this.comboBox_Zamestnanec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_Zamestnanec.BackColor = System.Drawing.Color.White;
            this.comboBox_Zamestnanec.DisplayMember = "1";
            this.comboBox_Zamestnanec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Zamestnanec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_Zamestnanec.FormattingEnabled = true;
            this.comboBox_Zamestnanec.Location = new System.Drawing.Point(241, 101);
            this.comboBox_Zamestnanec.Name = "comboBox_Zamestnanec";
            this.comboBox_Zamestnanec.Size = new System.Drawing.Size(190, 29);
            this.comboBox_Zamestnanec.TabIndex = 103;
            // 
            // button_ZobraziťVšetkyOdpravoneDni
            // 
            this.button_ZobraziťVšetkyOdpravoneDni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_ZobraziťVšetkyOdpravoneDni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.button_ZobraziťVšetkyOdpravoneDni.FlatAppearance.BorderSize = 0;
            this.button_ZobraziťVšetkyOdpravoneDni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ZobraziťVšetkyOdpravoneDni.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_ZobraziťVšetkyOdpravoneDni.ForeColor = System.Drawing.Color.White;
            this.button_ZobraziťVšetkyOdpravoneDni.Location = new System.Drawing.Point(39, 292);
            this.button_ZobraziťVšetkyOdpravoneDni.Name = "button_ZobraziťVšetkyOdpravoneDni";
            this.button_ZobraziťVšetkyOdpravoneDni.Size = new System.Drawing.Size(259, 43);
            this.button_ZobraziťVšetkyOdpravoneDni.TabIndex = 102;
            this.button_ZobraziťVšetkyOdpravoneDni.Text = "Zobraziť všetky zákazky";
            this.button_ZobraziťVšetkyOdpravoneDni.UseVisualStyleBackColor = false;
            this.button_ZobraziťVšetkyOdpravoneDni.Click += new System.EventHandler(this.button_ZobraziťVšetkyOdpravoneDni_Click);
            // 
            // comboBox_Zakazka
            // 
            this.comboBox_Zakazka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_Zakazka.BackColor = System.Drawing.Color.White;
            this.comboBox_Zakazka.DisplayMember = "1";
            this.comboBox_Zakazka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Zakazka.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_Zakazka.FormattingEnabled = true;
            this.comboBox_Zakazka.Location = new System.Drawing.Point(241, 136);
            this.comboBox_Zakazka.Name = "comboBox_Zakazka";
            this.comboBox_Zakazka.Size = new System.Drawing.Size(190, 29);
            this.comboBox_Zakazka.TabIndex = 101;
            // 
            // label_PracovnaPozicia
            // 
            this.label_PracovnaPozicia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_PracovnaPozicia.AutoSize = true;
            this.label_PracovnaPozicia.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_PracovnaPozicia.ForeColor = System.Drawing.Color.White;
            this.label_PracovnaPozicia.Location = new System.Drawing.Point(83, 139);
            this.label_PracovnaPozicia.Name = "label_PracovnaPozicia";
            this.label_PracovnaPozicia.Size = new System.Drawing.Size(66, 21);
            this.label_PracovnaPozicia.TabIndex = 98;
            this.label_PracovnaPozicia.Text = "Zákazka";
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
            this.labelMeno.Size = new System.Drawing.Size(106, 21);
            this.labelMeno.TabIndex = 95;
            this.labelMeno.Text = "Zamestnanec";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(32, 469);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 130;
            this.label6.Text = "Upraviť ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(32, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 25);
            this.label7.TabIndex = 129;
            this.label7.Text = "Vyhladať";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(83, 579);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 141;
            this.label5.Text = "Zákazka";
            // 
            // comboBox_Zakazka2
            // 
            this.comboBox_Zakazka2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_Zakazka2.BackColor = System.Drawing.Color.White;
            this.comboBox_Zakazka2.DisplayMember = "1";
            this.comboBox_Zakazka2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Zakazka2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_Zakazka2.FormattingEnabled = true;
            this.comboBox_Zakazka2.Location = new System.Drawing.Point(254, 576);
            this.comboBox_Zakazka2.Name = "comboBox_Zakazka2";
            this.comboBox_Zakazka2.Size = new System.Drawing.Size(156, 29);
            this.comboBox_Zakazka2.TabIndex = 140;
            // 
            // comboBox_Zamestnanec2
            // 
            this.comboBox_Zamestnanec2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_Zamestnanec2.BackColor = System.Drawing.Color.White;
            this.comboBox_Zamestnanec2.DisplayMember = "1";
            this.comboBox_Zamestnanec2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Zamestnanec2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_Zamestnanec2.FormattingEnabled = true;
            this.comboBox_Zamestnanec2.Items.AddRange(new object[] {
            "Igor Lenčéš"});
            this.comboBox_Zamestnanec2.Location = new System.Drawing.Point(254, 541);
            this.comboBox_Zamestnanec2.Name = "comboBox_Zamestnanec2";
            this.comboBox_Zamestnanec2.Size = new System.Drawing.Size(156, 29);
            this.comboBox_Zamestnanec2.TabIndex = 139;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(83, 544);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 21);
            this.label8.TabIndex = 138;
            this.label8.Text = "Zamestnanec";
            // 
            // labelDatumZalozenia
            // 
            this.labelDatumZalozenia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDatumZalozenia.AutoSize = true;
            this.labelDatumZalozenia.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDatumZalozenia.ForeColor = System.Drawing.Color.White;
            this.labelDatumZalozenia.Location = new System.Drawing.Point(83, 614);
            this.labelDatumZalozenia.Name = "labelDatumZalozenia";
            this.labelDatumZalozenia.Size = new System.Drawing.Size(103, 21);
            this.labelDatumZalozenia.TabIndex = 135;
            this.labelDatumZalozenia.Text = "Dátum práce";
            // 
            // textBox_DatumPrace
            // 
            this.textBox_DatumPrace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_DatumPrace.BackColor = System.Drawing.Color.White;
            this.textBox_DatumPrace.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DatumPrace.Location = new System.Drawing.Point(254, 611);
            this.textBox_DatumPrace.Name = "textBox_DatumPrace";
            this.textBox_DatumPrace.Size = new System.Drawing.Size(156, 29);
            this.textBox_DatumPrace.TabIndex = 131;
            // 
            // button_UpdateOdpracovaneDni
            // 
            this.button_UpdateOdpracovaneDni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_UpdateOdpracovaneDni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.button_UpdateOdpracovaneDni.FlatAppearance.BorderSize = 0;
            this.button_UpdateOdpracovaneDni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_UpdateOdpracovaneDni.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_UpdateOdpracovaneDni.ForeColor = System.Drawing.Color.White;
            this.button_UpdateOdpracovaneDni.Location = new System.Drawing.Point(147, 734);
            this.button_UpdateOdpracovaneDni.Name = "button_UpdateOdpracovaneDni";
            this.button_UpdateOdpracovaneDni.Size = new System.Drawing.Size(191, 43);
            this.button_UpdateOdpracovaneDni.TabIndex = 134;
            this.button_UpdateOdpracovaneDni.Text = "Uložiť zmeny";
            this.button_UpdateOdpracovaneDni.UseVisualStyleBackColor = false;
            this.button_UpdateOdpracovaneDni.Click += new System.EventHandler(this.button_UpdateOdpracovaneDni_Click);
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
            this.comboBox_Koeficient2.Location = new System.Drawing.Point(254, 681);
            this.comboBox_Koeficient2.Name = "comboBox_Koeficient2";
            this.comboBox_Koeficient2.Size = new System.Drawing.Size(156, 29);
            this.comboBox_Koeficient2.TabIndex = 133;
            // 
            // labelKoeficient
            // 
            this.labelKoeficient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelKoeficient.AutoSize = true;
            this.labelKoeficient.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKoeficient.ForeColor = System.Drawing.Color.White;
            this.labelKoeficient.Location = new System.Drawing.Point(83, 684);
            this.labelKoeficient.Name = "labelKoeficient";
            this.labelKoeficient.Size = new System.Drawing.Size(85, 21);
            this.labelKoeficient.TabIndex = 137;
            this.labelKoeficient.Text = "Koeficient";
            // 
            // labelOdpracopvanyCas
            // 
            this.labelOdpracopvanyCas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOdpracopvanyCas.AutoSize = true;
            this.labelOdpracopvanyCas.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOdpracopvanyCas.ForeColor = System.Drawing.Color.White;
            this.labelOdpracopvanyCas.Location = new System.Drawing.Point(83, 649);
            this.labelOdpracopvanyCas.Name = "labelOdpracopvanyCas";
            this.labelOdpracopvanyCas.Size = new System.Drawing.Size(134, 21);
            this.labelOdpracopvanyCas.TabIndex = 136;
            this.labelOdpracopvanyCas.Text = "Odpracovaný čas";
            // 
            // textBox_OdpracovanýČas
            // 
            this.textBox_OdpracovanýČas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_OdpracovanýČas.BackColor = System.Drawing.Color.White;
            this.textBox_OdpracovanýČas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_OdpracovanýČas.Location = new System.Drawing.Point(254, 646);
            this.textBox_OdpracovanýČas.Name = "textBox_OdpracovanýČas";
            this.textBox_OdpracovanýČas.Size = new System.Drawing.Size(156, 29);
            this.textBox_OdpracovanýČas.TabIndex = 132;
            // 
            // IDOdpracovaneDni
            // 
            this.IDOdpracovaneDni.DataPropertyName = "IDOdpracovaneDni";
            this.IDOdpracovaneDni.HeaderText = "ID odpracovaný deň";
            this.IDOdpracovaneDni.Name = "IDOdpracovaneDni";
            // 
            // MenoZamestnanca
            // 
            this.MenoZamestnanca.DataPropertyName = "FullName";
            this.MenoZamestnanca.HeaderText = "Meno";
            this.MenoZamestnanca.Name = "MenoZamestnanca";
            // 
            // NazovZakazky
            // 
            this.NazovZakazky.DataPropertyName = "NazovZakazky";
            this.NazovZakazky.HeaderText = "Zákazka";
            this.NazovZakazky.Name = "NazovZakazky";
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Dátum práce";
            this.Datum.Name = "Datum";
            // 
            // OdpracovanyCas
            // 
            this.OdpracovanyCas.DataPropertyName = "OdpracovanyCas";
            this.OdpracovanyCas.HeaderText = "Odpracovaný čas";
            this.OdpracovanyCas.Name = "OdpracovanyCas";
            // 
            // Koeficient
            // 
            this.Koeficient.DataPropertyName = "Koeficient";
            this.Koeficient.HeaderText = "Koeficient";
            this.Koeficient.Name = "Koeficient";
            // 
            // CenaPrace
            // 
            this.CenaPrace.DataPropertyName = "CenaPrace";
            this.CenaPrace.HeaderText = "Cena práce";
            this.CenaPrace.Name = "CenaPrace";
            // 
            // Form_ZobraziťOdpracovanéDni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1300, 825);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNazov);
            this.Controls.Add(this.dataGridView_OdpracovanyDen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ZobraziťOdpracovanéDni";
            this.Text = "Form_ZobraziťOdpracovanéDni";
            this.Shown += new System.EventHandler(this.Form_ZobraziťOdpracovanéDni_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OdpracovanyDen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazov;
        private System.Windows.Forms.DataGridView dataGridView_OdpracovanyDen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_Rok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_mesiac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_Koeficient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_IDodpracovanyDen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Zamestnanec;
        private System.Windows.Forms.Button button_ZobraziťVšetkyOdpravoneDni;
        private System.Windows.Forms.ComboBox comboBox_Zakazka;
        private System.Windows.Forms.Label label_PracovnaPozicia;
        private System.Windows.Forms.Button button_Zobraziť;
        private System.Windows.Forms.Label labelMeno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Zakazka2;
        private System.Windows.Forms.ComboBox comboBox_Zamestnanec2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelDatumZalozenia;
        private System.Windows.Forms.TextBox textBox_DatumPrace;
        private System.Windows.Forms.Button button_UpdateOdpracovaneDni;
        private System.Windows.Forms.ComboBox comboBox_Koeficient2;
        private System.Windows.Forms.Label labelKoeficient;
        private System.Windows.Forms.Label labelOdpracopvanyCas;
        private System.Windows.Forms.TextBox textBox_OdpracovanýČas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDOdpracovaneDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenoZamestnanca;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazovZakazky;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdpracovanyCas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Koeficient;
        private System.Windows.Forms.DataGridViewTextBoxColumn CenaPrace;
    }
}