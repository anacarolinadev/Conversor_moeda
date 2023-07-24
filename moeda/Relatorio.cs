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
    public partial class Relatorio : Form
    {
        public Relatorio(Cofrinho cofrinho) : this()
        {
            string quant = Convert.ToString(cofrinho.quantidadeMoedas());
            quantMoedaTextBox.Text = quant;
            totalTextBox.Text = Convert.ToString(cofrinho.valorTotalReais());
            quantRealTextBox.Text = "R$"+Convert.ToString(cofrinho.quantidadeMoedasUmReal());
            totalDolarTextBox.Text = "U$"+Convert.ToString(cofrinho.valorTotalDolar(3.88));



        }
        public Relatorio()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
