using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampoMinado2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 media = new Form1();
            this.Hide();
            media.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnA1_Click(object sender, EventArgs e)
        {
            btnA1.Text = "Vazio";
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            btnA2.Text = "Vazio";
        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            btnA3.Text = "BOMBA!";
        }

        private void btnA4_Click(object sender, EventArgs e)
        {
            btnA4.Text = "Vazio";
        }

        private void btnA5_Click(object sender, EventArgs e)
        {
            btnA5.Text = "Vazio";
        }

        private void btnA6_Click(object sender, EventArgs e)
        {
            btnA6.Text = "BOMBA!";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            btnD3.Text = "BOMBA!";
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {
            btnF6.Text = "Vazio";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            btnF5.Text = "Vazio";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            btnF4.Text = "Vazio";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            btnF3.Text = "BOMBA!";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            btnF2.Text = "Vazio";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            btnF1.Text = "Vazio";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            btnE6.Text = "Vazio";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            btnE5.Text = "BOMBA!";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            btnE4.Text = "Vazio";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            btnE3.Text = "Vazio";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            btnE2.Text = "BOMBA!";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            btnE1.Text = "BOMBA!";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            btnD6.Text = "Vazio";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            btnD5.Text = "Vazio";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            btnD4.Text = "Vazio";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            btnD2.Text = "Vazio";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            btnD1.Text = "Vazio";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            btnC6.Text = "BOMBA!";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            btnC5.Text = "Vazio";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            btnC4.Text = "BOMBA!";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            btnC3.Text = "Vazio";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            btnC2.Text = "Vazio";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            btnC1.Text = "Vazio";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnB6.Text = "Vazio";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnB5.Text = "Vazio";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btnB4.Text = "Vazio";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btnB3.Text = "Vazio";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            btnB2.Text = "Vazio";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            btnB1.Text = "BOMBA!";
            label14.Text = "Você Perdeu!";
            MessageBox.Show("Você Perdeu.");
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
