﻿namespace ProLab.GUI
{
    partial class AracArama
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
            this.btn_kayitGuncelle = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_secimSayfasınaGit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_kayitAra = new System.Windows.Forms.Button();
            this.txb_aracPlaka = new System.Windows.Forms.TextBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_sil = new System.Windows.Forms.Button();
            this.comboBox_islemAdi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_islemID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_islemDurumu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kayitGuncelle
            // 
            this.btn_kayitGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayitGuncelle.Location = new System.Drawing.Point(574, 198);
            this.btn_kayitGuncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_kayitGuncelle.Name = "btn_kayitGuncelle";
            this.btn_kayitGuncelle.Size = new System.Drawing.Size(242, 72);
            this.btn_kayitGuncelle.TabIndex = 22;
            this.btn_kayitGuncelle.Text = "Düzenle";
            this.btn_kayitGuncelle.UseVisualStyleBackColor = true;
            this.btn_kayitGuncelle.Click += new System.EventHandler(this.btn_kayitGuncelle_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_secimSayfasınaGit);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btn_kayitAra);
            this.splitContainer1.Panel1.Controls.Add(this.txb_aracPlaka);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView4);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView3);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView2);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.comboBox_islemDurumu);
            this.splitContainer1.Panel2.Controls.Add(this.btn_sil);
            this.splitContainer1.Panel2.Controls.Add(this.btn_kayitGuncelle);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox_islemAdi);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.txb_islemID);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Size = new System.Drawing.Size(1713, 1230);
            this.splitContainer1.SplitterDistance = 890;
            this.splitContainer1.TabIndex = 23;
            // 
            // btn_secimSayfasınaGit
            // 
            this.btn_secimSayfasınaGit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_secimSayfasınaGit.Location = new System.Drawing.Point(1085, 23);
            this.btn_secimSayfasınaGit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_secimSayfasınaGit.Name = "btn_secimSayfasınaGit";
            this.btn_secimSayfasınaGit.Size = new System.Drawing.Size(320, 79);
            this.btn_secimSayfasınaGit.TabIndex = 42;
            this.btn_secimSayfasınaGit.Text = "Seçim Sayfasına Git";
            this.btn_secimSayfasınaGit.UseVisualStyleBackColor = true;
            this.btn_secimSayfasınaGit.Click += new System.EventHandler(this.btn_secimSayfasınaGit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(79, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 39);
            this.label1.TabIndex = 41;
            this.label1.Text = "Plaka:";
            // 
            // btn_kayitAra
            // 
            this.btn_kayitAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayitAra.Location = new System.Drawing.Point(564, 26);
            this.btn_kayitAra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_kayitAra.Name = "btn_kayitAra";
            this.btn_kayitAra.Size = new System.Drawing.Size(215, 60);
            this.btn_kayitAra.TabIndex = 40;
            this.btn_kayitAra.Text = "Ara";
            this.btn_kayitAra.UseVisualStyleBackColor = true;
            this.btn_kayitAra.Click += new System.EventHandler(this.btn_kayitAra_Click);
            // 
            // txb_aracPlaka
            // 
            this.txb_aracPlaka.Cursor = System.Windows.Forms.Cursors.Default;
            this.txb_aracPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txb_aracPlaka.Location = new System.Drawing.Point(217, 35);
            this.txb_aracPlaka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_aracPlaka.Name = "txb_aracPlaka";
            this.txb_aracPlaka.Size = new System.Drawing.Size(275, 44);
            this.txb_aracPlaka.TabIndex = 39;
            // 
            // dataGridView4
            // 
            this.dataGridView4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(5, 690);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(1676, 175);
            this.dataGridView4.TabIndex = 38;
            // 
            // dataGridView3
            // 
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(5, 506);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1676, 175);
            this.dataGridView3.TabIndex = 37;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(5, 318);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1676, 175);
            this.dataGridView2.TabIndex = 36;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(5, 135);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1676, 175);
            this.dataGridView1.TabIndex = 35;
            // 
            // btn_sil
            // 
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Location = new System.Drawing.Point(900, 198);
            this.btn_sil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(242, 72);
            this.btn_sil.TabIndex = 52;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // comboBox_islemAdi
            // 
            this.comboBox_islemAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_islemAdi.FormattingEnabled = true;
            this.comboBox_islemAdi.Items.AddRange(new object[] {
            "Kaporta",
            "Elektrik",
            "Motor",
            "Lastik"});
            this.comboBox_islemAdi.Location = new System.Drawing.Point(294, 66);
            this.comboBox_islemAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_islemAdi.Name = "comboBox_islemAdi";
            this.comboBox_islemAdi.Size = new System.Drawing.Size(265, 40);
            this.comboBox_islemAdi.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1136, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 32);
            this.label3.TabIndex = 43;
            this.label3.Text = "İşlem Durumu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(116, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 32);
            this.label5.TabIndex = 50;
            this.label5.Text = "İşlem Adı";
            // 
            // txb_islemID
            // 
            this.txb_islemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txb_islemID.Location = new System.Drawing.Point(805, 66);
            this.txb_islemID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_islemID.Name = "txb_islemID";
            this.txb_islemID.Size = new System.Drawing.Size(251, 39);
            this.txb_islemID.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(634, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 32);
            this.label4.TabIndex = 49;
            this.label4.Text = "İşlem ID";
            // 
            // comboBox_islemDurumu
            // 
            this.comboBox_islemDurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_islemDurumu.FormattingEnabled = true;
            this.comboBox_islemDurumu.Location = new System.Drawing.Point(1364, 66);
            this.comboBox_islemDurumu.Name = "comboBox_islemDurumu";
            this.comboBox_islemDurumu.Size = new System.Drawing.Size(298, 46);
            this.comboBox_islemDurumu.TabIndex = 53;
            // 
            // AracArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1713, 1230);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AracArama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detay Sayfası";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_kayitGuncelle;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_secimSayfasınaGit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_kayitAra;
        private System.Windows.Forms.TextBox txb_aracPlaka;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_islemID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.ComboBox comboBox_islemDurumu;
        private System.Windows.Forms.ComboBox comboBox_islemAdi;
    }
}