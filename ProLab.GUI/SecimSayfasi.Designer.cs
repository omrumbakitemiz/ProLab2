namespace ProLab.GUI
{
    partial class SecimSayfasi
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
            this.btn_kayitEkleEkrani = new System.Windows.Forms.Button();
            this.btn_kayitGoruntule = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_kayitDuzenle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_kayitEkleEkrani
            // 
            this.btn_kayitEkleEkrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayitEkleEkrani.Location = new System.Drawing.Point(46, 51);
            this.btn_kayitEkleEkrani.Margin = new System.Windows.Forms.Padding(2);
            this.btn_kayitEkleEkrani.Name = "btn_kayitEkleEkrani";
            this.btn_kayitEkleEkrani.Size = new System.Drawing.Size(149, 48);
            this.btn_kayitEkleEkrani.TabIndex = 1;
            this.btn_kayitEkleEkrani.Text = "Kayıt Ekle";
            this.btn_kayitEkleEkrani.UseVisualStyleBackColor = true;
            this.btn_kayitEkleEkrani.Click += new System.EventHandler(this.btn_kayitEkleEkrani_Click);
            // 
            // btn_kayitGoruntule
            // 
            this.btn_kayitGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayitGoruntule.Location = new System.Drawing.Point(223, 51);
            this.btn_kayitGoruntule.Margin = new System.Windows.Forms.Padding(1);
            this.btn_kayitGoruntule.Name = "btn_kayitGoruntule";
            this.btn_kayitGoruntule.Size = new System.Drawing.Size(149, 48);
            this.btn_kayitGoruntule.TabIndex = 2;
            this.btn_kayitGoruntule.Text = "Kayıt Görüntüle";
            this.btn_kayitGoruntule.UseVisualStyleBackColor = true;
            this.btn_kayitGoruntule.Click += new System.EventHandler(this.btn_kayitGoruntule_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lütfen seçim yapınız";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_kayitDuzenle
            // 
            this.btn_kayitDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayitDuzenle.Location = new System.Drawing.Point(406, 51);
            this.btn_kayitDuzenle.Name = "btn_kayitDuzenle";
            this.btn_kayitDuzenle.Size = new System.Drawing.Size(149, 48);
            this.btn_kayitDuzenle.TabIndex = 4;
            this.btn_kayitDuzenle.Text = "Kayıt Düzenle";
            this.btn_kayitDuzenle.UseVisualStyleBackColor = true;
            this.btn_kayitDuzenle.Click += new System.EventHandler(this.btn_kayitDuzenle_Click);
            // 
            // SecimSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(594, 186);
            this.Controls.Add(this.btn_kayitDuzenle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_kayitGoruntule);
            this.Controls.Add(this.btn_kayitEkleEkrani);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SecimSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_kayitEkleEkrani;
        private System.Windows.Forms.Button btn_kayitGoruntule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_kayitDuzenle;
    }
}

