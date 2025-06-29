namespace ArabaKiralama
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dtpKiralama = new System.Windows.Forms.DataGridView();
            this.txtFoto = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnResim = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKira = new System.Windows.Forms.TextBox();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbYakit = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMarkaAra = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUretim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dtpKiralama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpKiralama
            // 
            this.dtpKiralama.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtpKiralama.BackgroundColor = System.Drawing.Color.Pink;
            this.dtpKiralama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Righteous", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtpKiralama.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtpKiralama.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtpKiralama.Location = new System.Drawing.Point(12, 401);
            this.dtpKiralama.Name = "dtpKiralama";
            this.dtpKiralama.RowHeadersVisible = false;
            this.dtpKiralama.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtpKiralama.Size = new System.Drawing.Size(1176, 143);
            this.dtpKiralama.TabIndex = 75;
            // 
            // txtFoto
            // 
            this.txtFoto.Location = new System.Drawing.Point(586, 279);
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.Size = new System.Drawing.Size(136, 20);
            this.txtFoto.TabIndex = 74;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(789, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Righteous", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(487, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 19);
            this.label12.TabIndex = 72;
            this.label12.Text = "Foto Ekle :";
            // 
            // btnResim
            // 
            this.btnResim.BackColor = System.Drawing.Color.Purple;
            this.btnResim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResim.Location = new System.Drawing.Point(727, 274);
            this.btnResim.Margin = new System.Windows.Forms.Padding(2);
            this.btnResim.Name = "btnResim";
            this.btnResim.Size = new System.Drawing.Size(38, 29);
            this.btnResim.TabIndex = 71;
            this.btnResim.Text = "...";
            this.btnResim.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Righteous", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(478, 236);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 19);
            this.label11.TabIndex = 70;
            this.label11.Text = "Kira Ücreti :";
            // 
            // txtKira
            // 
            this.txtKira.Location = new System.Drawing.Point(586, 235);
            this.txtKira.Name = "txtKira";
            this.txtKira.Size = new System.Drawing.Size(136, 20);
            this.txtKira.TabIndex = 69;
            // 
            // cmbDurum
            // 
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Items.AddRange(new object[] {
            "Boşta",
            "Kiralı"});
            this.cmbDurum.Location = new System.Drawing.Point(586, 190);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(133, 21);
            this.cmbDurum.TabIndex = 68;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Righteous", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(492, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 19);
            this.label10.TabIndex = 67;
            this.label10.Text = "Durumu :";
            // 
            // cmbYakit
            // 
            this.cmbYakit.FormattingEnabled = true;
            this.cmbYakit.Items.AddRange(new object[] {
            "Benzin",
            "Dizel",
            "LPG",
            "Elektrik",
            "Hybrid"});
            this.cmbYakit.Location = new System.Drawing.Point(586, 144);
            this.cmbYakit.Name = "cmbYakit";
            this.cmbYakit.Size = new System.Drawing.Size(133, 21);
            this.cmbYakit.TabIndex = 66;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Righteous", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(480, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 19);
            this.label9.TabIndex = 65;
            this.label9.Text = "Yakıt Türü :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Righteous", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(502, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 19);
            this.label8.TabIndex = 64;
            this.label8.Text = "Renk :";
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(586, 100);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(136, 20);
            this.txtRenk.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Righteous", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(73, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 19);
            this.label7.TabIndex = 62;
            this.label7.Text = "Marka Arama :";
            // 
            // txtMarkaAra
            // 
            this.txtMarkaAra.Location = new System.Drawing.Point(202, 375);
            this.txtMarkaAra.Name = "txtMarkaAra";
            this.txtMarkaAra.Size = new System.Drawing.Size(178, 20);
            this.txtMarkaAra.TabIndex = 61;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Purple;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSil.Location = new System.Drawing.Point(890, 358);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(85, 37);
            this.btnSil.TabIndex = 60;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Purple;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuncelle.Location = new System.Drawing.Point(979, 358);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(113, 37);
            this.btnGuncelle.TabIndex = 59;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Purple;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEkle.Location = new System.Drawing.Point(945, 319);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(89, 37);
            this.btnEkle.TabIndex = 58;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Righteous", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(198, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 19);
            this.label6.TabIndex = 57;
            this.label6.Text = "KM :";
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(282, 285);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(136, 20);
            this.txtKm.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Righteous", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(168, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 19);
            this.label5.TabIndex = 55;
            this.label5.Text = "Üretim Yılı :";
            // 
            // txtUretim
            // 
            this.txtUretim.Location = new System.Drawing.Point(282, 237);
            this.txtUretim.Name = "txtUretim";
            this.txtUretim.Size = new System.Drawing.Size(136, 20);
            this.txtUretim.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Righteous", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(185, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 53;
            this.label4.Text = "Model :";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(282, 191);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(136, 20);
            this.txtModel.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Righteous", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(184, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 51;
            this.label3.Text = "Marka :";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(282, 146);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(136, 20);
            this.txtMarka.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Righteous", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(186, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 49;
            this.label2.Text = "Plaka :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkMagenta;
            this.label1.Font = new System.Drawing.Font("Righteous", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(440, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 41);
            this.label1.TabIndex = 48;
            this.label1.Text = "Araba Kiralama Sistemi";
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(282, 100);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(136, 20);
            this.txtPlaka.TabIndex = 47;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1200, 560);
            this.Controls.Add(this.dtpKiralama);
            this.Controls.Add(this.txtFoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnResim);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtKira);
            this.Controls.Add(this.cmbDurum);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbYakit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRenk);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMarkaAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUretim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlaka);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araba Kiralama";
            ((System.ComponentModel.ISupportInitialize)(this.dtpKiralama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtpKiralama;
        private System.Windows.Forms.TextBox txtFoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnResim;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtKira;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbYakit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMarkaAra;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUretim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

