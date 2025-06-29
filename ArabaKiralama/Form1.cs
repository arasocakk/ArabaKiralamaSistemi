using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaKiralama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        VeriTabaniIslemleri vtIslemleri = new VeriTabaniIslemleri();
        SqlConnection baglanti;
        SqlCommand komut;
        string komutSatiri;

        public void Listele()
        {
            try
            {
                baglanti = vtIslemleri.baglan();
                komutSatiri = "SELECT * FROM KiralamaTBL";
                SqlDataAdapter da = new SqlDataAdapter(komutSatiri, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtpKiralama.DataSource = dt;

                dtpKiralama.Columns["ID"].HeaderText = "ID";
                dtpKiralama.Columns["Plaka"].HeaderText = "Plaka";
                dtpKiralama.Columns["Marka"].HeaderText = "Marka";
                dtpKiralama.Columns["Model"].HeaderText = "Model";
                dtpKiralama.Columns["UretimYili"].HeaderText = "Üretim Yılı";
                dtpKiralama.Columns["KM"].HeaderText = "KM";
                dtpKiralama.Columns["Renk"].HeaderText = "Renk";
                dtpKiralama.Columns["YakitTuru"].HeaderText = "Yakıt Türü";
                dtpKiralama.Columns["KiraUcreti"].HeaderText = "Kiralama Ücreti";
                dtpKiralama.Columns["Durum"].HeaderText = "Durumu";
                dtpKiralama.Columns["Resim"].HeaderText = "Resim";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata oluştu!");
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti = vtIslemleri.baglan();
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }

                komutSatiri = "INSERT INTO KiralamaTBL VALUES(@plaka,@marka,@model,@uretim,@km,@renk,@yakitTuru,@kiraUcreti,@durum,@resim)";
                komut = new SqlCommand(komutSatiri, baglanti);
                komut.Parameters.AddWithValue("@id", dtpKiralama.CurrentRow.Cells["ID"].Value.ToString());
                komut.Parameters.AddWithValue("@plaka", txtPlaka.Text);
                komut.Parameters.AddWithValue("@marka", txtMarka.Text);
                komut.Parameters.AddWithValue("@model", txtModel.Text);
                komut.Parameters.AddWithValue("@uretim", txtUretim.Text);
                komut.Parameters.AddWithValue("@km", txtKm.Text);
                komut.Parameters.AddWithValue("@renk", txtRenk.Text);
                komut.Parameters.AddWithValue("@yakitTuru", cmbYakit.Text);
                komut.Parameters.AddWithValue("@kiraUcreti", txtKira.Text);
                komut.Parameters.AddWithValue("@durum", cmbDurum.Text);
                komut.Parameters.AddWithValue("@resim", txtFoto.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ekleme İşlemi Başarılı");
                Listele();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu!");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpKiralama.DefaultCellStyle.BackColor = Color.Pink;
            dtpKiralama.DefaultCellStyle.ForeColor = Color.Black;

            dtpKiralama.RowsDefaultCellStyle.BackColor = Color.Pink;
            dtpKiralama.RowsDefaultCellStyle.ForeColor = Color.Black;

            dtpKiralama.EnableHeadersVisualStyles = false; // ÖNEMLİ: Varsayılan tema kapatılmalı
            dtpKiralama.ColumnHeadersDefaultCellStyle.BackColor = Color.Pink;
            dtpKiralama.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dtpKiralama.ColumnHeadersDefaultCellStyle.Font = new Font("Righteous", 10, FontStyle.Bold);




            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti = vtIslemleri.baglan();

                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }

                DialogResult result = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (result == DialogResult.Yes)
                {
                    komutSatiri = "DELETE FROM KiralamaTBL WHERE ID = @id";
                    komut = new SqlCommand(komutSatiri, baglanti);
                    komut.Parameters.AddWithValue("@id", dtpKiralama.CurrentRow.Cells["ID"].Value.ToString());
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu!");

            }

            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti = vtIslemleri.baglan();
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }

                komutSatiri = "UPDATE KiralamaTBL SET Plaka = @plaka,Marka = @marka,Model = @model, UretimYili = @uretim, KM = @km, Renk = @renk, YakitTuru = @yakitTuru, KiraUcreti = @kiraUcreti, Durum =  @durum, Resim = @resim WHERE ID=@id";
                komut = new SqlCommand(komutSatiri, baglanti);

                komut.Parameters.AddWithValue("@id", dtpKiralama.CurrentRow.Cells["ID"].Value.ToString());
                komut.Parameters.AddWithValue("@plaka", txtPlaka.Text);
                komut.Parameters.AddWithValue("@marka", txtMarka.Text);
                komut.Parameters.AddWithValue("@model", txtModel.Text);
                komut.Parameters.AddWithValue("@uretim", txtUretim.Text);
                komut.Parameters.AddWithValue("@km", txtKm.Text);
                komut.Parameters.AddWithValue("@renk", txtRenk.Text);
                komut.Parameters.AddWithValue("@yakitTuru", cmbYakit.Text);
                komut.Parameters.AddWithValue("@kiraUcreti", txtKira.Text);
                komut.Parameters.AddWithValue("@durum", cmbDurum.Text);
                komut.Parameters.AddWithValue("@resim", txtFoto.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme İşlemi Başarılı");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu!");
            }
            Listele();
        }
    }
}
