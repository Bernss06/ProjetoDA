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
    }
}
