namespace emreugur
{
    partial class Form7
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALDIKLARI_HİZMETLER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RANDEVU_TARİHİ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ÖDENECEK_TUTAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ALDIKLARI_HİZMETLER,
            this.RANDEVU_TARİHİ,
            this.Column2,
            this.Column3,
            this.Column4,
            this.ÖDENECEK_TUTAR});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(931, 282);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(523, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(304, 109);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(312, 109);
            this.button2.TabIndex = 2;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "TC_KİMLİK_NO";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // ALDIKLARI_HİZMETLER
            // 
            this.ALDIKLARI_HİZMETLER.HeaderText = "ALDIKLARI_HİZMETLER";
            this.ALDIKLARI_HİZMETLER.MinimumWidth = 6;
            this.ALDIKLARI_HİZMETLER.Name = "ALDIKLARI_HİZMETLER";
            this.ALDIKLARI_HİZMETLER.Width = 125;
            // 
            // RANDEVU_TARİHİ
            // 
            this.RANDEVU_TARİHİ.HeaderText = "RANDEVU_TARİHİ";
            this.RANDEVU_TARİHİ.MinimumWidth = 6;
            this.RANDEVU_TARİHİ.Name = "RANDEVU_TARİHİ";
            this.RANDEVU_TARİHİ.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "AD_SOYAD";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "TELEFON_NO";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "CİNSİYET";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // ÖDENECEK_TUTAR
            // 
            this.ÖDENECEK_TUTAR.HeaderText = "ÖDENECEK_TUTAR";
            this.ÖDENECEK_TUTAR.MinimumWidth = 6;
            this.ÖDENECEK_TUTAR.Name = "ÖDENECEK_TUTAR";
            this.ÖDENECEK_TUTAR.Width = 125;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 444);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form7";
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn ÖDENECEK_TUTAR;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn ALDIKLARI_HİZMETLER;
        private DataGridViewTextBoxColumn RANDEVU_TARİHİ;
    }
}