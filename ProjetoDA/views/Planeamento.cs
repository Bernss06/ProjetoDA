using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDA.views
{
    public partial class Planeamento : Form
    {
        public Planeamento()
        {
            InitializeComponent();
        }

        private void btnVoltarInicio_Click(object sender, EventArgs e)
        {
            // Se houver um Form1 que abriu este formulário, volta a mostrar esse Form1
            
           
                // Caso contrário, cria uma nova instância (comportamento antigo)
                Form1 form1 = new Form1();
                form1.Show();
            

            // Esconde o formulário atual
            this.Hide();
        }
    }
}
