
namespace Informačný_systém_SOFI
{
    partial class Form_ZobraziťOdberateľov
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
            this.dataGridView_Odberatel = new System.Windows.Forms.DataGridView();
            this.Idodberatel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_UpdateOdberatelov = new System.Windows.Forms.Button();
            this.labelNázov = new System.Windows.Forms.Label();
            this.textBox_NazovOdberatela = new System.Windows.Forms.TextBox();
            this.comboBox_IDodberatela = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_NazovOdberatela = new System.Windows.Forms.ComboBox();
            this.button_ZobraziťVšetko = new System.Windows.Forms.Button();
            this.button_UložitNovehoZamestnanca = new System.Windows.Forms.Button();
            this.labelMeno = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Odberatel)).BeginInit();
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
            this.lblNazov.Size = new System.Drawing.Size(216, 25);
            this.lblNazov.TabIndex = 5;
            this.lblNazov.Text = "Zobrazenie odberateľov";
            // 
            // dataGridView_Odberatel
            // 
            this.dataGridView_Odberatel.AllowUserToAddRows = false;
            this.dataGridView_Odberatel.AllowUserToDeleteRows = false;
            this.dataGridView_Odberatel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Odberatel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Odberatel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idodberatel,
            this.Nazov});
            this.dataGridView_Odberatel.Location = new System.Drawing.Point(258, 69);
            this.dataGridView_Odberatel.Name = "dataGridView_Odberatel";
            this.dataGridView_Odberatel.RowHeadersVisible = false;
            this.dataGridView_Odberatel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Odberatel.Size = new System.Drawing.Size(254, 689);
            this.dataGridView_Odberatel.TabIndex = 6;
            this.dataGridView_Odberatel.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView_Odberatel_RowStateChanged);
            // 
            // Idodberatel
            // 
            this.Idodberatel.DataPropertyName = "Idodberatel";
            this.Idodberatel.HeaderText = "ID odberateľ";
            this.Idodberatel.Name = "Idodberatel";
            // 
            // Nazov
            // 
            this.Nazov.DataPropertyName = "Nazov";
            this.Nazov.HeaderText = "Názov odberateľa";
            this.Nazov.Name = "Nazov";
            this.Nazov.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button_UpdateOdberatelov);
            this.panel1.Controls.Add(this.labelNázov);
            this.panel1.Controls.Add(this.textBox_NazovOdberatela);
            this.panel1.Controls.Add(this.comboBox_IDodberatela);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox_NazovOdberatela);
            this.panel1.Controls.Add(this.button_ZobraziťVšetko);
            this.panel1.Controls.Add(this.button_UložitNovehoZamestnanca);
            this.panel1.Controls.Add(this.labelMeno);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(800, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 825);
            this.panel1.TabIndex = 10;
            // 
            // button_UpdateOdberatelov
            // 
            this.button_UpdateOdberatelov.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_UpdateOdberatelov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.button_UpdateOdberatelov.FlatAppearance.BorderSize = 0;
            this.button_UpdateOdberatelov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_UpdateOdberatelov.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_UpdateOdberatelov.ForeColor = System.Drawing.Color.White;
            this.button_UpdateOdberatelov.Location = new System.Drawing.Point(146, 683);
            this.button_UpdateOdberatelov.Name = "button_UpdateOdberatelov";
            this.button_UpdateOdberatelov.Size = new System.Drawing.Size(209, 43);
            this.button_UpdateOdberatelov.TabIndex = 107;
            this.button_UpdateOdberatelov.Text = "Uložiť zmeny";
            this.button_UpdateOdberatelov.UseVisualStyleBackColor = false;
            this.button_UpdateOdberatelov.Click += new System.EventHandler(this.button_UpdateOdberatelov_Click);
            // 
            // labelNázov
            // 
            this.labelNázov.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNázov.AutoSize = true;
            this.labelNázov.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNázov.ForeColor = System.Drawing.Color.White;
            this.labelNázov.Location = new System.Drawing.Point(83, 620);
            this.labelNázov.Name = "labelNázov";
            this.labelNázov.Size = new System.Drawing.Size(55, 21);
            this.labelNázov.TabIndex = 108;
            this.labelNázov.Text = "Názov";
            // 
            // textBox_NazovOdberatela
            // 
            this.textBox_NazovOdberatela.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_NazovOdberatela.BackColor = System.Drawing.Color.White;
            this.textBox_NazovOdberatela.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NazovOdberatela.Location = new System.Drawing.Point(246, 617);
            this.textBox_NazovOdberatela.Name = "textBox_NazovOdberatela";
            this.textBox_NazovOdberatela.Size = new System.Drawing.Size(156, 29);
            this.textBox_NazovOdberatela.TabIndex = 106;
            // 
            // comboBox_IDodberatela
            // 
            this.comboBox_IDodberatela.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_IDodberatela.BackColor = System.Drawing.Color.White;
            this.comboBox_IDodberatela.DisplayMember = "1";
            this.comboBox_IDodberatela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_IDodberatela.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_IDodberatela.FormattingEnabled = true;
            this.comboBox_IDodberatela.Location = new System.Drawing.Point(241, 66);
            this.comboBox_IDodberatela.Name = "comboBox_IDodberatela";
            this.comboBox_IDodberatela.Size = new System.Drawing.Size(190, 29);
            this.comboBox_IDodberatela.TabIndex = 105;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 104;
            this.label1.Text = "ID odberateľa";
            // 
            // comboBox_NazovOdberatela
            // 
            this.comboBox_NazovOdberatela.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_NazovOdberatela.BackColor = System.Drawing.Color.White;
            this.comboBox_NazovOdberatela.DisplayMember = "1";
            this.comboBox_NazovOdberatela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_NazovOdberatela.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_NazovOdberatela.FormattingEnabled = true;
            this.comboBox_NazovOdberatela.Location = new System.Drawing.Point(241, 101);
            this.comboBox_NazovOdberatela.Name = "comboBox_NazovOdberatela";
            this.comboBox_NazovOdberatela.Size = new System.Drawing.Size(190, 29);
            this.comboBox_NazovOdberatela.TabIndex = 103;
            // 
            // button_ZobraziťVšetko
            // 
            this.button_ZobraziťVšetko.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_ZobraziťVšetko.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.button_ZobraziťVšetko.FlatAppearance.BorderSize = 0;
            this.button_ZobraziťVšetko.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ZobraziťVšetko.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_ZobraziťVšetko.ForeColor = System.Drawing.Color.White;
            this.button_ZobraziťVšetko.Location = new System.Drawing.Point(35, 164);
            this.button_ZobraziťVšetko.Name = "button_ZobraziťVšetko";
            this.button_ZobraziťVšetko.Size = new System.Drawing.Size(259, 43);
            this.button_ZobraziťVšetko.TabIndex = 102;
            this.button_ZobraziťVšetko.Text = "Zobraziť všetkých odberateľov";
            this.button_ZobraziťVšetko.UseVisualStyleBackColor = false;
            this.button_ZobraziťVšetko.Click += new System.EventHandler(this.button_ZobraziťVšetko_Click);
            // 
            // button_UložitNovehoZamestnanca
            // 
            this.button_UložitNovehoZamestnanca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_UložitNovehoZamestnanca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.button_UložitNovehoZamestnanca.FlatAppearance.BorderSize = 0;
            this.button_UložitNovehoZamestnanca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_UložitNovehoZamestnanca.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_UložitNovehoZamestnanca.ForeColor = System.Drawing.Color.White;
            this.button_UložitNovehoZamestnanca.Location = new System.Drawing.Point(317, 164);
            this.button_UložitNovehoZamestnanca.Name = "button_UložitNovehoZamestnanca";
            this.button_UložitNovehoZamestnanca.Size = new System.Drawing.Size(144, 43);
            this.button_UložitNovehoZamestnanca.TabIndex = 94;
            this.button_UložitNovehoZamestnanca.Text = "Zobraziť";
            this.button_UložitNovehoZamestnanca.UseVisualStyleBackColor = false;
            this.button_UložitNovehoZamestnanca.Click += new System.EventHandler(this.button_UložitNovehoZamestnanca_Click);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(30, 469);
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
            this.label7.Location = new System.Drawing.Point(30, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 25);
            this.label7.TabIndex = 129;
            this.label7.Text = "Vyhladať";
            // 
            // Form_ZobraziťOdberateľov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1300, 825);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_Odberatel);
            this.Controls.Add(this.lblNazov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ZobraziťOdberateľov";
            this.Text = "Form_ZobraziťOdberateľa";
            this.Shown += new System.EventHandler(this.Form_ZobraziťOdberateľov_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Odberatel)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazov;
        private System.Windows.Forms.DataGridView dataGridView_Odberatel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_IDodberatela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_NazovOdberatela;
        private System.Windows.Forms.Button button_ZobraziťVšetko;
        private System.Windows.Forms.Button button_UložitNovehoZamestnanca;
        private System.Windows.Forms.Label labelMeno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idodberatel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazov;
        private System.Windows.Forms.Button button_UpdateOdberatelov;
        private System.Windows.Forms.Label labelNázov;
        private System.Windows.Forms.TextBox textBox_NazovOdberatela;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}