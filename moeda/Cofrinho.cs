using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moeda
{
    public partial class Cofrinho : Form
    {
        List<Moeda> listaMoedas = new List<Moeda>();
        public Cofrinho()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               Double valor = Convert.ToDouble(valorTextBox.Text);
                Moeda moeda = new Moeda();
                if (moeda.setValor(valor))
                {
                    inserirMoeda(moeda);
                    inseridoTextBox.Text = moeda.getValorExtenso();

                } else
                {
                    MessageBox.Show("Insira apenas um dos seguintes valores : 0,25, 0,5 e 2");
                }



            }
            catch 
            {
                MessageBox.Show("Entre com uma moeda válida");

            }
            valorTextBox.Text = ""; 
        }

        void inserirMoeda(Moeda moeda)
        {
            listaMoedas.Add(moeda);
        }

       public double valorTotalReais()
        {
            double total = 0;
            foreach (Moeda moeda in listaMoedas)
            {
                total += moeda.getValor();
            }

            return total;
        }
       public int quantidadeMoedas()
        {
            return listaMoedas.Count();
        }
       public int quantidadeMoedasUmReal()
        {
            int total = 0;
            foreach (Moeda moeda in listaMoedas)
            {
               if(moeda.getValor() == 1.0)
                {
                    total++;
                }
            }

            return total;
        }
       public double valorTotalDolar(double cotacaoDolar)
        {
            return valorTotalReais() * cotacaoDolar;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Relatorio relatorio = new Relatorio(this);
            relatorio.Show();
        }
    }
}
