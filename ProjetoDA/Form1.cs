using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnorcamento_Click(object sender, EventArgs e)
        {
            // Abre a view de Orçamento e esconde o Form1
            var orcamentoForm = new views.Orcamento();
            orcamentoForm.Show();
            this.Hide();
        }

        // Adicione este método à classe Form1 para corrigir o erro CS1061.
        // Este método permite que o formulário Orcamento atualize a label do orçamento no Form1.
        public void AtualizarOrcamentoLabel(int valorMaximo)
        {
            // Exemplo: supondo que existe uma label chamada labelOrcamento no Form1.
            // Substitua "labelOrcamento" pelo nome real da label que exibe o orçamento.
            if (this.Controls.Find("labelOrcamento", true).FirstOrDefault() is Label label)
            {
                label.Text = valorMaximo.ToString("C");
            }
            // Caso queira atualizar outra label específica, substitua acima conforme necessário.
        }
    }
}
