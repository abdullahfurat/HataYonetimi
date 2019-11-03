using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WFA_HataYonetimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            int transactionNo = Convert.ToInt32(textBox1.Text);
            MessageBox.Show("Kayıt işlemi başarılı");
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            try
            {
                int transactionNo = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Kayıt işlemi başarılı");
            }
            catch
            {
                MessageBox.Show("İşlem Hatası");
            }
        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            try
            {
                int transactionNo = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Kayıt işlemi başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem Hatası");
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOrnek4_Click(object sender, EventArgs e)
        {
            try
            {
                int transactionNo = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Kayıt işlemi başarılı");
            }
            catch (DivideByZeroException ex)
            {
                // A birimi kontrol edecek.
                // LogManager("A",ex);
            }
            catch (FormatException ex)
            {
                // B birimi kontrol edecek
                // LogManager("B",ex);
            }
            catch (SqlException ex)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem Hatası");
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOrnek5_Click(object sender, EventArgs e)
        {
            try
            {
                int transactionNo = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Kayıt işlemi başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem Hatası");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Her işlem sonrası mutlaka çalışırım :)");
                // Con.close() 
            }
        }
    }
}
