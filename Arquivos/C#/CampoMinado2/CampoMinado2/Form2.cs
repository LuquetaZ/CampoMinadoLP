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
        // Declaração de variáveis para o contador das chances, e guardar a informação do espaço da célula usada
        int contador = 6;
        string bomba = "Bomba!";
        string vazio = "Vazio";
        
        public Form2()
        {
            // Inicialização do Form e definição do texto de mensagem para o jogador
            InitializeComponent();
            label14.Text = "Você tem " + contador + " tentativas";
        }

        // Criação de uma função para atualizar a verificação
        // Dentro do vetor tem uma variável que irá guardar o tipo da posição (vazio ou bomba)
        public void Verificar(String txt)
        {
            // Condição criada para verificar o que vai fazer caso a célula(botão) seja vazio ou bomba
            if (txt.Equals(vazio))
            {
                // Caso vazio ele diminui a variavel que conta as chances que sobram até ele finalizar
                contador = contador - 1;
                label14.Text = "Você tem " + contador + " tentativas";
            }
            else { 
                // Caso seja bomba, há a aparição de uma Message Box alertando que ele perdeu por acertar a bomba
                label14.Text = "Você Perdeu!";
                string title = "Você Perdeu!";
                string message = "Você atingiu uma bomba, quer voltar ao menu?";
                // Definição do título, mensagem e o tipo de interação que vai ter o usuário
                var result = MessageBox.Show(message, title, MessageBoxButtons.YesNo);
                // Condição para definir as respostas dadas pelo mesmo
                if (result == DialogResult.Yes)
                {
                    // Volta ao menu, caso fosse um jogo de fases ou dificuldades, iria jogar novamente
                    Form1 media = new Form1();
                    this.Hide();
                    media.Show();
                }
                else
                {
                    // Caso não queira voltar, irá sair do jogo
                    Application.Exit();
                }
            }


            // Condição para a vitória do jogador, a cada vez que o contador diminui, elel verifica se o contador não é zero, indicando vitória do mesmo
            if(contador == 0)
            {
                // Definição do título, mensagem e o tipo de interação que vai ter o usuário
                string title = "VOCÊ GANHOU!";
                string message = "PARABENS POR PASSAR DESTA FASE! GOSTARIA DE VOLTAR AO MENU?";
                var result = MessageBox.Show(message, title, MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Volta ao menu, caso fosse um jogo de fases ou dificuldades, iria jogar novamente
                    Form1 media = new Form1();
                    this.Hide();
                    media.Show();
                }
                else
                {
                    // Caso não queira voltar, irá sair do jogo
                    Application.Exit();
                }
            }
        }


        // Botão voltar, caso ele queira abandonar o jogo 
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

        // Cada botão tem sua posição específica. No clique irá ter 2 possibilidades
        private void btnA1_Click(object sender, EventArgs e)
        {
            // A primeira possibilidade é caso seja vazio
            // Aqui há a definição da informação que irá aparecer no botão
            btnA1.Text = vazio;
            // Chama a função para tomar as devidas definições
            Verificar(vazio);
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            // Aqui há a definição da informação que irá aparecer no botão
            btnA2.Text = vazio;
            Verificar(vazio);
        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            // Caso seja bomba, há outra informação que irá aparecer no botão 
            btnA3.Text = bomba;
            // E consequentemente há a chamada da função definindo que esta posição é da bomba
            Verificar(bomba);
        }
        private void btnA4_Click(object sender, EventArgs e)
        {
            // Aqui há a definição da informação que irá aparecer no botão
            btnA4.Text = vazio;
            Verificar(vazio);
        }

        private void btnA5_Click(object sender, EventArgs e)
        {
            // Aqui há a definição da informação que irá aparecer no botão
            btnA5.Text = vazio;
            Verificar(vazio);
        }

        private void btnA6_Click(object sender, EventArgs e)
        {
            // Caso seja bomba, há outra informação que irá aparecer no botão
            btnA6.Text = bomba;
            Verificar(bomba);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            // Caso seja bomba, há outra informação que irá aparecer no botão
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
            // Aqui há a definição da informação que irá aparecer no botão
            btnF6.Text = vazio;
            Verificar(vazio);

        }

        private void button28_Click(object sender, EventArgs e)
        {
            // Aqui há a definição da informação que irá aparecer no botão
            btnF5.Text = vazio;
            Verificar(vazio);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            // Aqui há a definição da informação que irá aparecer no botão
            btnF4.Text = vazio;
            Verificar(vazio);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            // Caso seja bomba, há outra informação que irá aparecer no botão
            btnF3.Text = bomba;
            Verificar(bomba);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            // Aqui há a definição da informação que irá aparecer no botão
            btnF2.Text = vazio;
            Verificar(vazio);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            // Aqui há a definição da informação que irá aparecer no botão
            btnF1.Text = vazio;
            Verificar(vazio);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            // Aqui há a definição da informação que irá aparecer no botão
            btnE6.Text = vazio;
            Verificar(vazio);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            // Caso seja bomba, há outra informação que irá aparecer no botão
            btnE5.Text = bomba;
            Verificar(bomba);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            // Aqui há a definição da informação que irá aparecer no botão
            btnE4.Text = vazio;
            Verificar(vazio); 
        }

        private void button24_Click(object sender, EventArgs e)
        {
            // Aqui há a definição da informação que irá aparecer no botão
            btnE3.Text = vazio;
            Verificar(vazio);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            // Caso seja bomba, há outra informação que irá aparecer no botão
            btnE2.Text = bomba;
            Verificar(bomba);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            // Caso seja bomba, há outra informação que irá aparecer no botão
            btnE1.Text = bomba;
           Verificar(bomba);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // Aqui há a definição da informação que irá aparecer no botão
            btnD6.Text = vazio;
            Verificar(vazio);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // Aqui há a definição da informação que irá aparecer no botão
            btnD5.Text = vazio;
            Verificar(vazio);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // Aqui há a definição da informação que irá aparecer no botão
            btnD4.Text = vazio;
            Verificar(vazio);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            // Aqui há a definição da informação que irá aparecer no botão
            btnD2.Text = vazio;
            Verificar(vazio);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            // Aqui há a definição da informação que irá aparecer no botão
            btnD1.Text = vazio;
            Verificar(vazio);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Caso seja bomba, há outra informação que irá aparecer no botão
            btnC6.Text = bomba;
            Verificar(bomba);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Aqui há a definição da informação que irá aparecer no botão
            btnC5.Text = vazio;
            Verificar(vazio);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Caso seja bomba, há outra informação que irá aparecer no botão
            btnC4.Text = bomba;
            Verificar(bomba);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Aqui há a definição da informação que irá aparecer no botão
            btnC3.Text = vazio;
            Verificar(vazio);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // Aqui há a definição da informação que irá aparecer no botão
            btnC2.Text = vazio;
            Verificar(vazio);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // Aqui há a definição da informação que irá aparecer no botão
            btnC1.Text = vazio;
            Verificar(vazio);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Aqui há a definição da informação que irá aparecer no botão
            btnB6.Text = vazio;
            Verificar(vazio);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Aqui há a definição da informação que irá aparecer no botão
            btnB5.Text = vazio;
            Verificar(vazio);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Aqui há a definição da informação que irá aparecer no botão
            btnB4.Text = vazio;
            Verificar(vazio);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Aqui há a definição da informação que irá aparecer no botão
            btnB3.Text = vazio;
            Verificar(vazio);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Aqui há a definição da informação que irá aparecer no botão
            btnB2.Text = vazio;
            Verificar(vazio);
        }

        private void button8_Click(object sender, EventArgs e)
        {
           // Aqui há a definição da informação que irá aparecer no botão
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
