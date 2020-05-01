using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uçak_Bilet_Rezervasyon_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Nereden: " + comboBox1.Text + " - " + "Nereye: " + comboBox2.Text + "-   Tarih: " + dateTimePicker1.Text + "-   Saati: " + maskedTextBox1.Text +"-   Adı Soyadı: " + textBox1.Text+"-   TC no: "+maskedTextBox2.Text+"-   Tel no: " + maskedTextBox3.Text);
            MessageBox.Show("Kayıt Başarıyla Tamamlandı");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = label9.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
