using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.Drawing.Printing;

namespace StajProjeCalisma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti;
        OleDbCommand komut;
        OleDbDataAdapter da;

        void VeriListele()
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Tablomuz.accdb");
            baglanti.Open();
            da = new OleDbDataAdapter("SELECT *FROM Veriler", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridViewVeriler.DataSource = tablo;
            baglanti.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VeriListele();
            dataGridViewVeriler.CellDoubleClick += dataGridView1_CellDoubleClick;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!GirdileriDogrula())
            {
                return;
            }

            string sorgu = "INSERT INTO Veriler ([Kullanıcı Adı], [Malzeme No], [Seri Numarası], [Envanter No]) values (@kadi, @mlzno, @serino, @envno)";
            komut = new OleDbCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kadi", txtKadi.Text);
            komut.Parameters.AddWithValue("@mlzno", txtMlzno.Text);
            komut.Parameters.AddWithValue("@serino", txtSerino.Text);
            komut.Parameters.AddWithValue("@envno", txtEnvno.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            VeriListele();
            MessageBox.Show("Kullanıcı ve Veriler Başarıyla Eklendi..!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!GirdileriDogrula())
            {
                return;
            }

            string sorgu = "DELETE FROM Veriler WHERE [Kullanıcı Adı] = @kadi AND [Malzeme No] = @mlzno AND [Seri Numarası] = @serino AND [Envanter No] = @envno";
            komut = new OleDbCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kadi", txtKadi.Text);
            komut.Parameters.AddWithValue("@mlzno", txtMlzno.Text);
            komut.Parameters.AddWithValue("@serino", txtSerino.Text);
            komut.Parameters.AddWithValue("@envno", txtEnvno.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            VeriListele();
            MessageBox.Show("Kullanıcı ve Veriler Başarıyla Silindi..!");
        }

        private bool GirdileriDogrula()
        {


            if (Regex.IsMatch(txtKadi.Text, @"\d"))
            {
                MessageBox.Show("Kullanıcı adı sayı içermemelidir.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtKadi.Text))
            {
                MessageBox.Show("Kullanıcı Adı Boş Bırakılmamalı.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMlzno.Text))
            {
                MessageBox.Show("Malzeme No Boş Bırakılmamalı.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSerino.Text))
            {
                MessageBox.Show("Seri No Boş Bırakılmamalı.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEnvno.Text))
            {
                MessageBox.Show("Envanter No Boş Bırakılmamalı.");
                return false;
            }

            return true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewVeriler.Rows[e.RowIndex];
                txtKadi.Text = row.Cells["Kullanıcı Adı"].Value.ToString();
                txtMlzno.Text = row.Cells["Malzeme No"].Value.ToString();
                txtSerino.Text = row.Cells["Seri Numarası"].Value.ToString();
                txtEnvno.Text = row.Cells["Envanter No"].Value.ToString();
            }
        }



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewVeriler.Rows[e.RowIndex];
                txtKadi.Text = row.Cells["Kullanıcı Adı"].Value.ToString();
                txtMlzno.Text = row.Cells["Malzeme No"].Value.ToString();
                txtSerino.Text = row.Cells["Seri Numarası"].Value.ToString();
                txtEnvno.Text = row.Cells["Envanter No"].Value.ToString();
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!GirdileriDogrula())
            {
                return;
            }

            string sorgu = "UPDATE Veriler SET [Malzeme No] = @mlzno, [Seri Numarası] = @serino, [Envanter No] = @envno WHERE [Kullanıcı Adı] = @kadi";
            OleDbCommand komut = new OleDbCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@mlzno", txtMlzno.Text);
            komut.Parameters.AddWithValue("@serino", txtSerino.Text);
            komut.Parameters.AddWithValue("@envno", txtEnvno.Text);
            komut.Parameters.AddWithValue("@kadi", txtKadi.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Veri başarıyla güncellendi.");
            VeriListele();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            PrintDialog pdialog = new PrintDialog();
            pdialog.Document = pd;

            if (pdialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }
    }
}