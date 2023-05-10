using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuemAmaMais
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            try
            {
                long n1 = int.Parse(textBox1.Text);

                Calculo c = new Calculo(n1);

                c.Calcular();
            }catch
            {
                MessageBox.Show("Não adianta apelar ,que eu ainda continuo te amando mais !! . Insira um número menor ,pra não bugar meu programa.");
            }

        }
    }
}
