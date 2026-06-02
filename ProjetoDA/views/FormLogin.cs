using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// IMPORTANTE: Adiciona esta linha para poderes usar a Base de Dados SQL Server
using System.Data.SqlClient;

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
            // 1. Obter os dados introduzidos pelo utilizador nas TextBoxes
            string username = txtusername.Text.Trim();
            string password = txtpassword.Text.Trim();

            // 2. Validação local: Não permite campos vazios
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios!.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Chamar o método que valida os dados na Base de Dados
            if (ValidarLoginBD(username, password))
            {
                MessageBox.Show("Login efetuado com sucesso!", "Bem-vindo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 4. Se estiver correto, cria e abre o Form1 (Menu Principal)
                Form1 menuPrincipal = new Form1();
                menuPrincipal.Show();

                // Esconde o formulário de login atual
                this.Hide();
            }
            else
            {
                // Se as credenciais estiverem erradas ou não existirem
                MessageBox.Show("Utilizador ou Palavra-passe incorretos. Tente novamente.", "Erro de Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método responsável por ligar à Base de Dados e verificar se o utilizador existe.
        /// </summary>
        private bool ValidarLoginBD(string username, string password)
        {
            // ATENÇÃO: Substitui esta string pela string de conexão real da tua Base de Dados!
            string connectionString = @"Data Source=TEU_SERVIDOR;Initial Catalog=TEU_BANCO_DADOS;Integrated Security=True";

            // Query SQL segura utilizando parâmetros para evitar SQL Injection
            string query = "SELECT COUNT(1) FROM Utilizadores WHERE Username = @username AND Password = @password";

            try
            {
                // Abre a conexão e executa o comando de forma segura com o 'using'
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Vincula os dados das variáveis aos parâmetros da Query SQL
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        conn.Open();

                        // Executa a query e devolve o número de linhas encontradas
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        // Se count for 1, significa que o utilizador e password coincidem
                        return count == 1;
                    }
                }
            }
            catch (Exception ex)
            {
                // Caso haja falha na ligação com o servidor/BD, mostra o erro
                MessageBox.Show("Erro ao ligar à base de dados: " + ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}