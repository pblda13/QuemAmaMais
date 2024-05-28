using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuemAmaMais
{
    public class Calculo
    {
        public long n1 { get; set; }


        public Calculo(long n)
        {
            n1 = n;
        }

        public void Calcular()
        {
            if (n1 <= 0)
            {
                MessageBox.Show("Você não está doido(a)! Pode voltar e por um valor decente.");
            }
            else if (n1 > 0 && n1 <= 5)
            {
                MessageBox.Show("Ainda está muito pouco! Pode fazer de novo!");
            }
            else if (n1 > 5 && n1 <= 10)
            {
                MessageBox.Show("Eu te amo mais!");
            }
            else if (n1 > 10 && n1 <= 100)
            {
                MessageBox.Show("Seu amor pode até ser grande, mas eu ainda te amo mais!");
            }
            else if (n1 > 100)
            {
                MessageBox.Show("Boa tentativa, mas seu(sua) namorado(a) ainda te ama muito mais!");
            }
        }

    }
}