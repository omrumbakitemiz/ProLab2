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
            this.SuspendLayout();
            // 
            // btn_kayitEkleEkrani
            // 
            this.btn_kayitEkleEkrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayitEkleEkrani.Location = new System.Drawing.Point(170, 102);
            this.btn_kayitEkleEkrani.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_kayitEkleEkrani.Name = "btn_kayitEkleEkrani";
            this.btn_kayitEkleEkrani.Size = new System.Drawing.Size(261, 84);
            this.btn_kayitEkleEkrani.TabIndex = 1;
            this.btn_kayitEkleEkrani.Text = "Kayıt Ekle";
            this.btn_kayitEkleEkrani.UseVisualStyleBackColor = true;
            this.btn_kayitEkleEkrani.Click += new System.EventHandler(this.btn_kayitEkleEkrani_Click);
            // 
            // btn_kayitGoruntule
            // 
            this.btn_kayitGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayitGoruntule.Location = new System.Drawing.Point(550, 102);
            this.btn_kayitGoruntule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_kayitGoruntule.Name = "btn_kayitGoruntule";
            this.btn_kayitGoruntule.Size = new System.Drawing.Size(261, 84);
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
            this.label1.Location = new System.Drawing.Point(21, 266);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lütfen seçim yapınız";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SecimSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1040, 326);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_kayitGoruntule);
            this.Controls.Add(this.btn_kayitEkleEkrani);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}

