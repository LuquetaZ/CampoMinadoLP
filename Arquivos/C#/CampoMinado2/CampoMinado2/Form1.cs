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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // botão que leva o usuário até o Form2 onde ocorrerá o jogo
        private void btnjogar_Click(object sender, EventArgs e)
        {
            Form2 media = new Form2();
            this.Hide();
            media.Show();
        }

        // botão que sai da aplicação
        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
