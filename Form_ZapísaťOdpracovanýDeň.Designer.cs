
namespace Informačný_systém_SOFI
{
    partial class Form_ZapísaťOdpracovanýDeň
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
            this.labelDatumZalozenia = new System.Windows.Forms.Label();
            this.textBox_DatumPrace = new System.Windows.Forms.TextBox();
            this.button_ZapísaťOdpracovanýDeň = new System.Windows.Forms.Button();
            this.comboBox_Koeficient = new System.Windows.Forms.ComboBox();
            this.labelKoeficient = new System.Windows.Forms.Label();
            this.labelOdpracopvanyCas = new System.Windows.Forms.Label();
            this.textBox_OdpracovanýČas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Zamestnanci = new System.Windows.Forms.ComboBox();
            this.comboBox_Zakazka = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNazov
            // 
            this.lblNazov.AutoSize = true;
            this.lblNazov.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazov.ForeColor = System.Drawing.SystemColors.Info;
            this.lblNazov.Location = new System.Drawing.Point(12, 9);
            this.lblNazov.Name = "lblNazov";
            this.lblNazov.Size = new System.Drawing.Size(268, 25);
            this.lblNazov.TabIndex = 5;
            this.lblNazov.Text = "Zapísanie odpracovaného dňa";
            // 
            // labelDatumZalozenia
            // 
            this.labelDatumZalozenia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDatumZalozenia.AutoSize = true;
            this.labelDatumZalozenia.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDatumZalozenia.ForeColor = System.Drawing.Color.White;
            this.labelDatumZalozenia.Location = new System.Drawing.Point(487, 367);
            this.labelDatumZalozenia.Name = "labelDatumZalozenia";
            this.labelDatumZalozenia.Size = new System.Drawing.Size(103, 21);
            this.labelDatumZalozenia.TabIndex = 86;
            this.labelDatumZalozenia.Text = "Dátum práce";
            // 
            // textBox_DatumPrace
            // 
            this.textBox_DatumPrace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_DatumPrace.BackColor = System.Drawing.Color.White;
            this.textBox_DatumPrace.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DatumPrace.Location = new System.Drawing.Point(658, 364);
            this.textBox_DatumPrace.Name = "textBox_DatumPrace";
            this.textBox_DatumPrace.Size = new System.Drawing.Size(156, 29);
            this.textBox_DatumPrace.TabIndex = 77;
            // 
            // button_ZapísaťOdpracovanýDeň
            // 
            this.button_ZapísaťOdpracovanýDeň.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_ZapísaťOdpracovanýDeň.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.button_ZapísaťOdpracovanýDeň.FlatAppearance.BorderSize = 0;
            this.button_ZapísaťOdpracovanýDeň.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ZapísaťOdpracovanýDeň.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_ZapísaťOdpracovanýDeň.ForeColor = System.Drawing.Color.White;
            this.button_ZapísaťOdpracovanýDeň.Location = new System.Drawing.Point(551, 487);
            this.button_ZapísaťOdpracovanýDeň.Name = "button_ZapísaťOdpracovanýDeň";
            this.button_ZapísaťOdpracovanýDeň.Size = new System.Drawing.Size(191, 43);
            this.button_ZapísaťOdpracovanýDeň.TabIndex = 81;
            this.button_ZapísaťOdpracovanýDeň.Text = "Uložiť odpracovaný čas";
            this.button_ZapísaťOdpracovanýDeň.UseVisualStyleBackColor = false;
            this.button_ZapísaťOdpracovanýDeň.Click += new System.EventHandler(this.button_ZapísaťOdpracovanýDeň_Click);
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
            this.comboBox_Koeficient.Location = new System.Drawing.Point(658, 434);
            this.comboBox_Koeficient.Name = "comboBox_Koeficient";
            this.comboBox_Koeficient.Size = new System.Drawing.Size(156, 29);
            this.comboBox_Koeficient.TabIndex = 80;
            // 
            // labelKoeficient
            // 
            this.labelKoeficient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelKoeficient.AutoSize = true;
            this.labelKoeficient.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKoeficient.ForeColor = System.Drawing.Color.White;
            this.labelKoeficient.Location = new System.Drawing.Point(487, 437);
            this.labelKoeficient.Name = "labelKoeficient";
            this.labelKoeficient.Size = new System.Drawing.Size(85, 21);
            this.labelKoeficient.TabIndex = 89;
            this.labelKoeficient.Text = "Koeficient";
            // 
            // labelOdpracopvanyCas
            // 
            this.labelOdpracopvanyCas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOdpracopvanyCas.AutoSize = true;
            this.labelOdpracopvanyCas.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOdpracopvanyCas.ForeColor = System.Drawing.Color.White;
            this.labelOdpracopvanyCas.Location = new System.Drawing.Point(487, 402);
            this.labelOdpracopvanyCas.Name = "labelOdpracopvanyCas";
            this.labelOdpracopvanyCas.Size = new System.Drawing.Size(134, 21);
            this.labelOdpracopvanyCas.TabIndex = 87;
            this.labelOdpracopvanyCas.Text = "Odpracovaný čas";
            // 
            // textBox_OdpracovanýČas
            // 
            this.textBox_OdpracovanýČas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_OdpracovanýČas.BackColor = System.Drawing.Color.White;
            this.textBox_OdpracovanýČas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_OdpracovanýČas.Location = new System.Drawing.Point(658, 399);
            this.textBox_OdpracovanýČas.Name = "textBox_OdpracovanýČas";
            this.textBox_OdpracovanýČas.Size = new System.Drawing.Size(156, 29);
            this.textBox_OdpracovanýČas.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(487, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 21);
            this.label1.TabIndex = 91;
            this.label1.Text = "Zamestnanec";
            // 
            // comboBox_Zamestnanci
            // 
            this.comboBox_Zamestnanci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_Zamestnanci.BackColor = System.Drawing.Color.White;
            this.comboBox_Zamestnanci.DisplayMember = "1";
            this.comboBox_Zamestnanci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Zamestnanci.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_Zamestnanci.FormattingEnabled = true;
            this.comboBox_Zamestnanci.Items.AddRange(new object[] {
            "Igor Lenčéš"});
            this.comboBox_Zamestnanci.Location = new System.Drawing.Point(658, 294);
            this.comboBox_Zamestnanci.Name = "comboBox_Zamestnanci";
            this.comboBox_Zamestnanci.Size = new System.Drawing.Size(156, 29);
            this.comboBox_Zamestnanci.TabIndex = 92;
            // 
            // comboBox_Zakazka
            // 
            this.comboBox_Zakazka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_Zakazka.BackColor = System.Drawing.Color.White;
            this.comboBox_Zakazka.DisplayMember = "1";
            this.comboBox_Zakazka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Zakazka.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_Zakazka.FormattingEnabled = true;
            this.comboBox_Zakazka.Location = new System.Drawing.Point(658, 329);
            this.comboBox_Zakazka.Name = "comboBox_Zakazka";
            this.comboBox_Zakazka.Size = new System.Drawing.Size(156, 29);
            this.comboBox_Zakazka.TabIndex = 94;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(487, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 95;
            this.label2.Text = "Zákazka";
            // 
            // Form_ZapísaťOdpracovanýDeň
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1300, 825);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Zakazka);
            this.Controls.Add(this.comboBox_Zamestnanci);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDatumZalozenia);
            this.Controls.Add(this.textBox_DatumPrace);
            this.Controls.Add(this.button_ZapísaťOdpracovanýDeň);
            this.Controls.Add(this.comboBox_Koeficient);
            this.Controls.Add(this.labelKoeficient);
            this.Controls.Add(this.labelOdpracopvanyCas);
            this.Controls.Add(this.textBox_OdpracovanýČas);
            this.Controls.Add(this.lblNazov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ZapísaťOdpracovanýDeň";
            this.Text = "FormZapísaťOdpracovanýDeň";
            this.Shown += new System.EventHandler(this.Form_ZapísaťOdpracovanýDeň_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazov;
        private System.Windows.Forms.Label labelDatumZalozenia;
        private System.Windows.Forms.TextBox textBox_DatumPrace;
        private System.Windows.Forms.Button button_ZapísaťOdpracovanýDeň;
        private System.Windows.Forms.ComboBox comboBox_Koeficient;
        private System.Windows.Forms.Label labelKoeficient;
        private System.Windows.Forms.Label labelOdpracopvanyCas;
        private System.Windows.Forms.TextBox textBox_OdpracovanýČas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Zamestnanci;
        private System.Windows.Forms.ComboBox comboBox_Zakazka;
        private System.Windows.Forms.Label label2;
    }
}