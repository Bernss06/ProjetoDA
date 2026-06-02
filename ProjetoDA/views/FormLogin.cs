using System;
using System.Windows.Forms;
using ProjetoDA.controllers;

namespace ProjetoDA.views
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text.Trim();
            string password = txtpassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoginController controller = new LoginController();

            int userId = controller.AutenticarUtilizador(username, password);

            if (userId != -1)
            {
                MessageBox.Show("Login efetuado com sucesso!", "Bem-vindo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // (opcional) guardar utilizador logado
                // Session.UserId = userId;
                this.Hide();

                Form1 form1 = new Form1();
                form1.ShowDialog();// Utilizar ShowDialog() garante que o utilizador vai para a página de login

                // Fecha esta janela de vez após fechar o login (opcional, para limpar memória)
                this.Close();
            }
            else
            {
                MessageBox.Show("Utilizador ou password incorretos!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}