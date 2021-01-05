
namespace Informačný_systém_SOFI
{
    partial class Form_PridaťOdberateľa
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
            this.button_UložitNovehoOdberatela = new System.Windows.Forms.Button();
            this.labelNázov = new System.Windows.Forms.Label();
            this.textBox_NazovOdberatela = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNazov
            // 
            this.lblNazov.AutoSize = true;
            this.lblNazov.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazov.ForeColor = System.Drawing.SystemColors.Info;
            this.lblNazov.Location = new System.Drawing.Point(12, 9);
            this.lblNazov.Name = "lblNazov";
            this.lblNazov.Size = new System.Drawing.Size(252, 25);
            this.lblNazov.TabIndex = 5;
            this.lblNazov.Text = "Vloženie nového odberateľa";
            // 
            // button_UložitNovehoOdberatela
            // 
            this.button_UložitNovehoOdberatela.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_UložitNovehoOdberatela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.button_UložitNovehoOdberatela.FlatAppearance.BorderSize = 0;
            this.button_UložitNovehoOdberatela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_UložitNovehoOdberatela.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_UložitNovehoOdberatela.ForeColor = System.Drawing.Color.White;
            this.button_UložitNovehoOdberatela.Location = new System.Drawing.Point(554, 415);
            this.button_UložitNovehoOdberatela.Name = "button_UložitNovehoOdberatela";
            this.button_UložitNovehoOdberatela.Size = new System.Drawing.Size(209, 43);
            this.button_UložitNovehoOdberatela.TabIndex = 78;
            this.button_UložitNovehoOdberatela.Text = "Uložiť nového odberateľa";
            this.button_UložitNovehoOdberatela.UseVisualStyleBackColor = false;
            this.button_UložitNovehoOdberatela.Click += new System.EventHandler(this.button_UložitNovehoOdberatela_Click);
            // 
            // labelNázov
            // 
            this.labelNázov.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNázov.AutoSize = true;
            this.labelNázov.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNázov.ForeColor = System.Drawing.Color.White;
            this.labelNázov.Location = new System.Drawing.Point(491, 352);
            this.labelNázov.Name = "labelNázov";
            this.labelNázov.Size = new System.Drawing.Size(55, 21);
            this.labelNázov.TabIndex = 80;
            this.labelNázov.Text = "Názov";
            // 
            // textBox_NazovOdberatela
            // 
            this.textBox_NazovOdberatela.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_NazovOdberatela.BackColor = System.Drawing.Color.White;
            this.textBox_NazovOdberatela.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NazovOdberatela.Location = new System.Drawing.Point(654, 349);
            this.textBox_NazovOdberatela.Name = "textBox_NazovOdberatela";
            this.textBox_NazovOdberatela.Size = new System.Drawing.Size(156, 29);
            this.textBox_NazovOdberatela.TabIndex = 76;
            // 
            // Form_PridaťOdberateľa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1300, 825);
            this.Controls.Add(this.button_UložitNovehoOdberatela);
            this.Controls.Add(this.labelNázov);
            this.Controls.Add(this.textBox_NazovOdberatela);
            this.Controls.Add(this.lblNazov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_PridaťOdberateľa";
            this.Text = "Form_PridaťOdberateľa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazov;
        private System.Windows.Forms.Button button_UložitNovehoOdberatela;
        private System.Windows.Forms.Label labelNázov;
        private System.Windows.Forms.TextBox textBox_NazovOdberatela;
    }
}