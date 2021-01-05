
namespace Informačný_systém_SOFI
{
    partial class Form_PridaťZamestnanca
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
            this.button_UložitNovehoZamestnanca = new System.Windows.Forms.Button();
            this.labelMeno = new System.Windows.Forms.Label();
            this.textBox_Meno = new System.Windows.Forms.TextBox();
            this.label_PracovnaPozicia = new System.Windows.Forms.Label();
            this.label_Priezvisko = new System.Windows.Forms.Label();
            this.textBox_Priezvisko = new System.Windows.Forms.TextBox();
            this.label_HodinovaMzda = new System.Windows.Forms.Label();
            this.textBox_HodinovaMzda = new System.Windows.Forms.TextBox();
            this.comboBox_pracovnaPozicia = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNazov
            // 
            this.lblNazov.AutoSize = true;
            this.lblNazov.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazov.ForeColor = System.Drawing.SystemColors.Info;
            this.lblNazov.Location = new System.Drawing.Point(12, 9);
            this.lblNazov.Name = "lblNazov";
            this.lblNazov.Size = new System.Drawing.Size(271, 25);
            this.lblNazov.TabIndex = 4;
            this.lblNazov.Text = "Vloženie nového zamestnanca";
            // 
            // button_UložitNovehoZamestnanca
            // 
            this.button_UložitNovehoZamestnanca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_UložitNovehoZamestnanca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.button_UložitNovehoZamestnanca.FlatAppearance.BorderSize = 0;
            this.button_UložitNovehoZamestnanca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_UložitNovehoZamestnanca.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_UložitNovehoZamestnanca.ForeColor = System.Drawing.Color.White;
            this.button_UložitNovehoZamestnanca.Location = new System.Drawing.Point(530, 476);
            this.button_UložitNovehoZamestnanca.Name = "button_UložitNovehoZamestnanca";
            this.button_UložitNovehoZamestnanca.Size = new System.Drawing.Size(220, 43);
            this.button_UložitNovehoZamestnanca.TabIndex = 83;
            this.button_UložitNovehoZamestnanca.Text = "Uložiť nového zamestnanca";
            this.button_UložitNovehoZamestnanca.UseVisualStyleBackColor = false;
            this.button_UložitNovehoZamestnanca.Click += new System.EventHandler(this.button_UložitNovehoOdberatela_Click);
            // 
            // labelMeno
            // 
            this.labelMeno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMeno.AutoSize = true;
            this.labelMeno.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMeno.ForeColor = System.Drawing.Color.White;
            this.labelMeno.Location = new System.Drawing.Point(486, 320);
            this.labelMeno.Name = "labelMeno";
            this.labelMeno.Size = new System.Drawing.Size(53, 21);
            this.labelMeno.TabIndex = 85;
            this.labelMeno.Text = "Meno";
            // 
            // textBox_Meno
            // 
            this.textBox_Meno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Meno.BackColor = System.Drawing.Color.White;
            this.textBox_Meno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Meno.Location = new System.Drawing.Point(643, 317);
            this.textBox_Meno.Name = "textBox_Meno";
            this.textBox_Meno.Size = new System.Drawing.Size(156, 29);
            this.textBox_Meno.TabIndex = 82;
            // 
            // label_PracovnaPozicia
            // 
            this.label_PracovnaPozicia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_PracovnaPozicia.AutoSize = true;
            this.label_PracovnaPozicia.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_PracovnaPozicia.ForeColor = System.Drawing.Color.White;
            this.label_PracovnaPozicia.Location = new System.Drawing.Point(485, 390);
            this.label_PracovnaPozicia.Name = "label_PracovnaPozicia";
            this.label_PracovnaPozicia.Size = new System.Drawing.Size(131, 21);
            this.label_PracovnaPozicia.TabIndex = 89;
            this.label_PracovnaPozicia.Text = "Pracovná pozícia";
            // 
            // label_Priezvisko
            // 
            this.label_Priezvisko.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Priezvisko.AutoSize = true;
            this.label_Priezvisko.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Priezvisko.ForeColor = System.Drawing.Color.White;
            this.label_Priezvisko.Location = new System.Drawing.Point(485, 355);
            this.label_Priezvisko.Name = "label_Priezvisko";
            this.label_Priezvisko.Size = new System.Drawing.Size(82, 21);
            this.label_Priezvisko.TabIndex = 88;
            this.label_Priezvisko.Text = "Priezvisko";
            // 
            // textBox_Priezvisko
            // 
            this.textBox_Priezvisko.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Priezvisko.BackColor = System.Drawing.Color.White;
            this.textBox_Priezvisko.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Priezvisko.Location = new System.Drawing.Point(643, 352);
            this.textBox_Priezvisko.Name = "textBox_Priezvisko";
            this.textBox_Priezvisko.Size = new System.Drawing.Size(156, 29);
            this.textBox_Priezvisko.TabIndex = 86;
            // 
            // label_HodinovaMzda
            // 
            this.label_HodinovaMzda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_HodinovaMzda.AutoSize = true;
            this.label_HodinovaMzda.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_HodinovaMzda.ForeColor = System.Drawing.Color.White;
            this.label_HodinovaMzda.Location = new System.Drawing.Point(485, 425);
            this.label_HodinovaMzda.Name = "label_HodinovaMzda";
            this.label_HodinovaMzda.Size = new System.Drawing.Size(124, 21);
            this.label_HodinovaMzda.TabIndex = 91;
            this.label_HodinovaMzda.Text = "Hodinová mzda";
            // 
            // textBox_HodinovaMzda
            // 
            this.textBox_HodinovaMzda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_HodinovaMzda.BackColor = System.Drawing.Color.White;
            this.textBox_HodinovaMzda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_HodinovaMzda.Location = new System.Drawing.Point(643, 422);
            this.textBox_HodinovaMzda.Name = "textBox_HodinovaMzda";
            this.textBox_HodinovaMzda.Size = new System.Drawing.Size(156, 29);
            this.textBox_HodinovaMzda.TabIndex = 90;
            // 
            // comboBox_pracovnaPozicia
            // 
            this.comboBox_pracovnaPozicia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_pracovnaPozicia.BackColor = System.Drawing.Color.White;
            this.comboBox_pracovnaPozicia.DisplayMember = "1";
            this.comboBox_pracovnaPozicia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_pracovnaPozicia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_pracovnaPozicia.FormattingEnabled = true;
            this.comboBox_pracovnaPozicia.Location = new System.Drawing.Point(643, 387);
            this.comboBox_pracovnaPozicia.Name = "comboBox_pracovnaPozicia";
            this.comboBox_pracovnaPozicia.Size = new System.Drawing.Size(156, 29);
            this.comboBox_pracovnaPozicia.TabIndex = 92;
            // 
            // Form_PridaťZamestnanca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1300, 825);
            this.Controls.Add(this.comboBox_pracovnaPozicia);
            this.Controls.Add(this.label_HodinovaMzda);
            this.Controls.Add(this.textBox_HodinovaMzda);
            this.Controls.Add(this.label_PracovnaPozicia);
            this.Controls.Add(this.label_Priezvisko);
            this.Controls.Add(this.textBox_Priezvisko);
            this.Controls.Add(this.button_UložitNovehoZamestnanca);
            this.Controls.Add(this.labelMeno);
            this.Controls.Add(this.textBox_Meno);
            this.Controls.Add(this.lblNazov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_PridaťZamestnanca";
            this.Text = "Form_PridaťZamestnanca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazov;
        private System.Windows.Forms.Button button_UložitNovehoZamestnanca;
        private System.Windows.Forms.Label labelMeno;
        private System.Windows.Forms.TextBox textBox_Meno;
        private System.Windows.Forms.Label label_PracovnaPozicia;
        private System.Windows.Forms.Label label_Priezvisko;
        private System.Windows.Forms.TextBox textBox_Priezvisko;
        private System.Windows.Forms.Label label_HodinovaMzda;
        private System.Windows.Forms.TextBox textBox_HodinovaMzda;
        private System.Windows.Forms.ComboBox comboBox_pracovnaPozicia;
    }
}