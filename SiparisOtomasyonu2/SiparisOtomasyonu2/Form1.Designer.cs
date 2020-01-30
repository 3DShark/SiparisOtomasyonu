namespace SiparisOtomasyonu2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.Giris_Button = new System.Windows.Forms.Button();
            this.kayit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(435, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "SİPARİŞ OTOMASYON SİSTEMİ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(446, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(446, 276);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre:";
            // 
            // txtKullanici
            // 
            this.txtKullanici.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtKullanici.Location = new System.Drawing.Point(665, 233);
            this.txtKullanici.Margin = new System.Windows.Forms.Padding(2);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(149, 20);
            this.txtKullanici.TabIndex = 3;
            // 
            // txtSifre
            // 
            this.txtSifre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSifre.Location = new System.Drawing.Point(665, 276);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(2);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(149, 20);
            this.txtSifre.TabIndex = 3;
            // 
            // Giris_Button
            // 
            this.Giris_Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Giris_Button.Location = new System.Drawing.Point(715, 342);
            this.Giris_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Giris_Button.Name = "Giris_Button";
            this.Giris_Button.Size = new System.Drawing.Size(98, 43);
            this.Giris_Button.TabIndex = 4;
            this.Giris_Button.Text = "Giriş Yap";
            this.Giris_Button.UseVisualStyleBackColor = true;
            this.Giris_Button.Click += new System.EventHandler(this.Giris_Button_Click);
            // 
            // kayit_Button
            // 
            this.kayit_Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.kayit_Button.Location = new System.Drawing.Point(450, 342);
            this.kayit_Button.Margin = new System.Windows.Forms.Padding(2);
            this.kayit_Button.Name = "kayit_Button";
            this.kayit_Button.Size = new System.Drawing.Size(106, 37);
            this.kayit_Button.TabIndex = 5;
            this.kayit_Button.Text = "Kayıt Ol";
            this.kayit_Button.UseVisualStyleBackColor = true;
            this.kayit_Button.Click += new System.EventHandler(this.kayit_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1298, 602);
            this.Controls.Add(this.kayit_Button);
            this.Controls.Add(this.Giris_Button);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button Giris_Button;
        private System.Windows.Forms.Button kayit_Button;
    }
}

