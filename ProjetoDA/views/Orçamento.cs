using System;
using System.IO;
using System.Globalization;
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
    public partial class Orçamento : Form
    {
        private readonly string _orcamentoFilePath;

        public Orçamento()
        {
            InitializeComponent();

            // Inicializa caminho para guardar o orçamento (AppData\ProjetoDA\orcamento.txt)
            var appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var folder = Path.Combine(appData, "ProjetoDA");
            if (!Directory.Exists(folder))
            {
                try
                {
                    Directory.CreateDirectory(folder);
                }
                catch
                {
                    // Se não for possível criar a pasta, fallback para pasta do executável
                    folder = AppDomain.CurrentDomain.BaseDirectory;
                }
            }

            _orcamentoFilePath = Path.Combine(folder, "orcamento.txt");

            // Registar handlers
            this.Load += Orçamento_Load;
            this.btndefinirOrçamento.Click += btndefinirOrçamento_Click;
            this.btnVoltarInicio.Click += btnVoltarInicio_Click;
        }

        private void Orçamento_Load(object sender, EventArgs e)
        {
            // Carrega o orçamento guardado (se existir)
            var valor = LoadOrcamento();
            if (valor.HasValue)
            {
                lblOrçamentos.Text = FormatCurrency(valor.Value);
                txtOrçamento.Text = valor.Value.ToString("N2", CultureInfo.CurrentCulture);
            }
            else
            {
                lblOrçamentos.Text = "Ainda sem orçamento definido";
            }
        }

        private void btndefinirOrçamento_Click(object sender, EventArgs e)
        {
            // Validação e gravação do orçamento
            var texto = txtOrçamento.Text?.Trim();
            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("Introduza um valor para o orçamento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(texto, NumberStyles.Number | NumberStyles.AllowCurrencySymbol, CultureInfo.CurrentCulture, out var valor))
            {
                MessageBox.Show("Formato inválido. Use números (ex.: 1000,00).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (valor < 0)
            {
                MessageBox.Show("O orçamento não pode ser negativo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                SaveOrcamento(valor);
                lblOrçamentos.Text = FormatCurrency(valor);
                MessageBox.Show("Orçamento guardado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gravar o orçamento: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltarInicio_Click(object sender, EventArgs e)
        {
            // Fecha o formulário atual (volta para o formulário anterior)
            Form1 login = new Form1();
            login.Show();

            // Esconde o formulário de registo
            this.Hide();
        }

        private decimal? LoadOrcamento()
        {
            try
            {
                if (!File.Exists(_orcamentoFilePath))
                    return null;

                var text = File.ReadAllText(_orcamentoFilePath).Trim();
                if (string.IsNullOrEmpty(text))
                    return null;

                if (decimal.TryParse(text, NumberStyles.Number | NumberStyles.AllowCurrencySymbol, CultureInfo.InvariantCulture, out var valorInvariant))
                {
                    // Foi guardado em invariant
                    return valorInvariant;
                }

                // Tenta com a cultura atual (ex.: pt-BR usa vírgula)
                if (decimal.TryParse(text, NumberStyles.Number | NumberStyles.AllowCurrencySymbol, CultureInfo.CurrentCulture, out var valorLocal))
                {
                    return valorLocal;
                }

                return null;
            }
            catch
            {
                return null;
            }
        }

        private void SaveOrcamento(decimal valor)
        {
            // Guarda em formato invariant para facilitar leitura futura
            File.WriteAllText(_orcamentoFilePath, valor.ToString(CultureInfo.InvariantCulture));
        }

        private string FormatCurrency(decimal valor)
        {
            // Formata conforme cultura do utilizador, com símbolo de moeda
            return string.Format(CultureInfo.CurrentCulture, "{0:C}", valor);
        }
    }
}
