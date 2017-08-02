namespace ProLab.GUI
{
    partial class AracEkle
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
            this.txtbox_plaka = new System.Windows.Forms.TextBox();
            this.txtbox_marka = new System.Windows.Forms.TextBox();
            this.txtbox_model = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_kayit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_kullaniciAdi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbox_plaka
            // 
            this.txtbox_plaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbox_plaka.Location = new System.Drawing.Point(227, 155);
            this.txtbox_plaka.Name = "txtbox_plaka";
            this.txtbox_plaka.Size = new System.Drawing.Size(275, 37);
            this.txtbox_plaka.TabIndex = 0;
            // 
            // txtbox_marka
            // 
            this.txtbox_marka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbox_marka.Location = new System.Drawing.Point(227, 224);
            this.txtbox_marka.Name = "txtbox_marka";
            this.txtbox_marka.Size = new System.Drawing.Size(275, 37);
            this.txtbox_marka.TabIndex = 1;
            // 
            // txtbox_model
            // 
            this.txtbox_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbox_model.Location = new System.Drawing.Point(227, 290);
            this.txtbox_model.Name = "txtbox_model";
            this.txtbox_model.Size = new System.Drawing.Size(275, 37);
            this.txtbox_model.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(106, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Plaka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(106, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(106, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Model";
            // 
            // btn_kayit
            // 
            this.btn_kayit.BackColor = System.Drawing.SystemColors.Info;
            this.btn_kayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayit.Location = new System.Drawing.Point(611, 194);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(190, 103);
            this.btn_kayit.TabIndex = 6;
            this.btn_kayit.Text = "Kaydet";
            this.btn_kayit.UseVisualStyleBackColor = false;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(272, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(365, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lütfen araç bilgilerini girin...";
            // 
            // lbl_kullaniciAdi
            // 
            this.lbl_kullaniciAdi.AutoSize = true;
            this.lbl_kullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kullaniciAdi.Location = new System.Drawing.Point(41, 487);
            this.lbl_kullaniciAdi.Name = "lbl_kullaniciAdi";
            this.lbl_kullaniciAdi.Size = new System.Drawing.Size(244, 39);
            this.lbl_kullaniciAdi.TabIndex = 8;
            this.lbl_kullaniciAdi.Text = "lbl_kullaniciAdi";
            // 
            // AddRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(914, 547);
            this.Controls.Add(this.lbl_kullaniciAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_kayit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_model);
            this.Controls.Add(this.txtbox_marka);
            this.Controls.Add(this.txtbox_plaka);
            this.Name = "AddRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Ekle";
            this.Load += new System.EventHandler(this.AddRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_plaka;
        private System.Windows.Forms.TextBox txtbox_model;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_kayit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbox_marka;
        private System.Windows.Forms.Label lbl_kullaniciAdi;
    }
}