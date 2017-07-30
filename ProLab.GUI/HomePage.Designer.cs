namespace ProLab.GUI
{
    partial class HomePage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_kayitEkleEkrani = new System.Windows.Forms.Button();
            this.btn_kayitGoruntule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 692);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1408, 604);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(14, 14);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1408, 656);
            this.dataGridView2.TabIndex = 0;
            // 
            // btn_kayitEkleEkrani
            // 
            this.btn_kayitEkleEkrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayitEkleEkrani.Location = new System.Drawing.Point(391, 1336);
            this.btn_kayitEkleEkrani.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_kayitEkleEkrani.Name = "btn_kayitEkleEkrani";
            this.btn_kayitEkleEkrani.Size = new System.Drawing.Size(234, 96);
            this.btn_kayitEkleEkrani.TabIndex = 1;
            this.btn_kayitEkleEkrani.Text = "Kayıt Ekle";
            this.btn_kayitEkleEkrani.UseVisualStyleBackColor = true;
            this.btn_kayitEkleEkrani.Click += new System.EventHandler(this.btn_kayitEkleEkrani_Click);
            // 
            // btn_kayitGoruntule
            // 
            this.btn_kayitGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayitGoruntule.Location = new System.Drawing.Point(689, 1336);
            this.btn_kayitGoruntule.Name = "btn_kayitGoruntule";
            this.btn_kayitGoruntule.Size = new System.Drawing.Size(298, 96);
            this.btn_kayitGoruntule.TabIndex = 2;
            this.btn_kayitGoruntule.Text = "Kayıt Görüntüle";
            this.btn_kayitGoruntule.UseVisualStyleBackColor = true;
            this.btn_kayitGoruntule.Click += new System.EventHandler(this.btn_kayitGoruntule_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1436, 1474);
            this.Controls.Add(this.btn_kayitGoruntule);
            this.Controls.Add(this.btn_kayitEkleEkrani);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_kayitEkleEkrani;
        private System.Windows.Forms.Button btn_kayitGoruntule;
    }
}

