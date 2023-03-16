using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace CampoMinado2
{
    public partial class Form2 : Form
    {
        int contador = 6;
        string bomba = "Bomba!";
        string vazio = "Vazio";
        
        public Form2()
        {
            InitializeComponent();
            label14.Text = "Você tem " + contador + " tentativas";
        }

        public void Verificar(String txt)
        {
            if (txt.Equals(vazio))
            {
                contador = contador - 1;
                label14.Text = "Você tem " + contador + " tentativas";
            }
            else { 
                label14.Text = "Você Perdeu!";
                string title = "Você Perdeu!";
                string message = "Você atingiu uma bomba, quer voltar ao menu?";
                var result = MessageBox.Show(message, title, MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Form1 media = new Form1();
                    this.Hide();
                    media.Show();
                }
                else
                {
                    Application.Exit();
                }
            }

            if(contador == 0)
            {
                string title = "VOCÊ GANHOU!";
                string message = "PARABENS POR PASSAR DESTA FASE! GOSTARIA DE VOLTAR AO MENU?";
                var result = MessageBox.Show(message, title, MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Form1 media = new Form1();
                    this.Hide();
                    media.Show();
                }
                else
                {
                    Application.Exit();
                }
            }
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
            btnA1.Text = vazio;
            Verificar(vazio);
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            btnA2.Text = vazio;
            Verificar(vazio);
        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            btnA3.Text = bomba;
            Verificar(bomba);
        }
        private void btnA4_Click(object sender, EventArgs e)
        {
            btnA4.Text = vazio;
            Verificar(vazio);
        }

        private void btnA5_Click(object sender, EventArgs e)
        {
            btnA5.Text = vazio;
            Verificar(vazio);
        }

        private void btnA6_Click(object sender, EventArgs e)
        {
            btnA6.Text = bomba;
            Verificar(bomba);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            btnD3.Text = bomba;
            Verificar(bomba);
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
            btnF6.Text = vazio;
            Verificar(vazio);

        }

        private void button28_Click(object sender, EventArgs e)
        {
            btnF5.Text = vazio;
            Verificar(vazio);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            btnF4.Text = vazio;
            Verificar(vazio);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            btnF3.Text = bomba;
            Verificar(bomba);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            btnF2.Text = vazio;
            Verificar(vazio);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            btnF1.Text = vazio;
            Verificar(vazio);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            btnE6.Text = vazio;
            Verificar(vazio);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            btnE5.Text = bomba;
            Verificar(bomba);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            btnE4.Text = vazio;
            Verificar(vazio); 
        }

        private void button24_Click(object sender, EventArgs e)
        {
            btnE3.Text = vazio;
            Verificar(vazio);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            btnE2.Text = bomba;
            Verificar(bomba);
        }

        private void button26_Click(object sender, EventArgs e)
        {
           btnE1.Text = bomba;
           Verificar(bomba);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            btnD6.Text = vazio;
            Verificar(vazio);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            btnD5.Text = vazio;
            Verificar(vazio);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            btnD4.Text = vazio;
            Verificar(vazio);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            btnD2.Text = vazio;
            Verificar(vazio);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            btnD1.Text = vazio;
            Verificar(vazio);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            btnC6.Text = bomba;
            Verificar(bomba);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            btnC5.Text = vazio;
            Verificar(vazio);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            btnC4.Text = bomba;
            Verificar(bomba);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            btnC3.Text = vazio;
            Verificar(vazio);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            btnC2.Text = vazio;
            Verificar(vazio);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            btnC1.Text = vazio;
            Verificar(vazio);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnB6.Text = vazio;
            Verificar(vazio);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnB5.Text = vazio;
            Verificar(vazio);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btnB4.Text = vazio;
            Verificar(vazio);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btnB3.Text = vazio;
            Verificar(vazio);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            btnB2.Text = vazio;
            Verificar(vazio);

        }

        private void button8_Click(object sender, EventArgs e)
        {
           btnB1.Text = bomba;
           Verificar(bomba);
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {
            
        }
    }
}
