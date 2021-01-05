
namespace Informačný_systém_SOFI
{
    partial class Form_Prihlásenie
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
            this.button_Prihlásiť = new System.Windows.Forms.Button();
            this.label_Používateľ = new System.Windows.Forms.Label();
            this.label_Heslo = new System.Windows.Forms.Label();
            this.textBox_Heslo = new System.Windows.Forms.TextBox();
            this.button_Zrušiť = new System.Windows.Forms.Button();
            this.textBox_Meno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Prihlásiť
            // 
            this.button_Prihlásiť.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Prihlásiť.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.button_Prihlásiť.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_Prihlásiť.FlatAppearance.BorderSize = 0;
            this.button_Prihlásiť.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Prihlásiť.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Prihlásiť.ForeColor = System.Drawing.Color.White;
            this.button_Prihlásiť.Location = new System.Drawing.Point(408, 237);
            this.button_Prihlásiť.Name = "button_Prihlásiť";
            this.button_Prihlásiť.Size = new System.Drawing.Size(148, 43);
            this.button_Prihlásiť.TabIndex = 77;
            this.button_Prihlásiť.Text = "Prihlásiť";
            this.button_Prihlásiť.UseVisualStyleBackColor = false;
            this.button_Prihlásiť.Click += new System.EventHandler(this.button_Prihlásiť_Click);
            // 
            // label_Používateľ
            // 
            this.label_Používateľ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Používateľ.AutoSize = true;
            this.label_Používateľ.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Používateľ.ForeColor = System.Drawing.Color.White;
            this.label_Používateľ.Location = new System.Drawing.Point(264, 145);
            this.label_Používateľ.Name = "label_Používateľ";
            this.label_Používateľ.Size = new System.Drawing.Size(84, 21);
            this.label_Používateľ.TabIndex = 79;
            this.label_Používateľ.Text = "Používateľ";
            // 
            // label_Heslo
            // 
            this.label_Heslo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Heslo.AutoSize = true;
            this.label_Heslo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Heslo.ForeColor = System.Drawing.Color.White;
            this.label_Heslo.Location = new System.Drawing.Point(264, 194);
            this.label_Heslo.Name = "label_Heslo";
            this.label_Heslo.Size = new System.Drawing.Size(52, 21);
            this.label_Heslo.TabIndex = 78;
            this.label_Heslo.Text = "Heslo";
            // 
            // textBox_Heslo
            // 
            this.textBox_Heslo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Heslo.BackColor = System.Drawing.Color.White;
            this.textBox_Heslo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Heslo.Location = new System.Drawing.Point(370, 191);
            this.textBox_Heslo.MaxLength = 20;
            this.textBox_Heslo.Name = "textBox_Heslo";
            this.textBox_Heslo.PasswordChar = '*';
            this.textBox_Heslo.Size = new System.Drawing.Size(156, 29);
            this.textBox_Heslo.TabIndex = 75;
            this.textBox_Heslo.Text = "748e6c6c";
            // 
            // button_Zrušiť
            // 
            this.button_Zrušiť.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Zrušiť.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.button_Zrušiť.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Zrušiť.FlatAppearance.BorderSize = 0;
            this.button_Zrušiť.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Zrušiť.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Zrušiť.ForeColor = System.Drawing.Color.White;
            this.button_Zrušiť.Location = new System.Drawing.Point(235, 237);
            this.button_Zrušiť.Name = "button_Zrušiť";
            this.button_Zrušiť.Size = new System.Drawing.Size(148, 43);
            this.button_Zrušiť.TabIndex = 80;
            this.button_Zrušiť.Text = "Zrušiť";
            this.button_Zrušiť.UseVisualStyleBackColor = false;
            // 
            // textBox_Meno
            // 
            this.textBox_Meno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Meno.BackColor = System.Drawing.Color.White;
            this.textBox_Meno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Meno.Location = new System.Drawing.Point(370, 142);
            this.textBox_Meno.MaxLength = 20;
            this.textBox_Meno.Name = "textBox_Meno";
            this.textBox_Meno.Size = new System.Drawing.Size(156, 29);
            this.textBox_Meno.TabIndex = 81;
            this.textBox_Meno.Text = "b04b42a934c174";
            // 
            // Form_Prihlásenie
            // 
            this.AcceptButton = this.button_Prihlásiť;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.CancelButton = this.button_Zrušiť;
            this.ClientSize = new System.Drawing.Size(672, 419);
            this.Controls.Add(this.textBox_Meno);
            this.Controls.Add(this.button_Zrušiť);
            this.Controls.Add(this.button_Prihlásiť);
            this.Controls.Add(this.label_Používateľ);
            this.Controls.Add(this.label_Heslo);
            this.Controls.Add(this.textBox_Heslo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Prihlásenie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_Prihlásenie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Prihlásenie_FormClosing);
            this.Load += new System.EventHandler(this.Form_Prihlásenie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Prihlásiť;
        private System.Windows.Forms.Label label_Používateľ;
        private System.Windows.Forms.Label label_Heslo;
        public System.Windows.Forms.TextBox textBox_Heslo;
        private System.Windows.Forms.Button button_Zrušiť;
        public System.Windows.Forms.TextBox textBox_Meno;
    }
}