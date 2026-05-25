using ProjetoDA.controllers;
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
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Instancia o controlador existente, exatamente como na Ficha 9
            UtilizadorController utilizadorController = new UtilizadorController();

            // Chama o método que faz a validação e insere na base de dados
            bool sucesso = utilizadorController.adicionarUtilizador(username, password);

            if (sucesso)
            {
                MessageBox.Show("Utilizador registado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Fecha a janela de registo e volta ao Login
            }
            else
            {
                // Alerta caso o Username já exista na base de dados (Regra 4)
                MessageBox.Show("Erro: Este Username já está a ser utilizado por outro membro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
