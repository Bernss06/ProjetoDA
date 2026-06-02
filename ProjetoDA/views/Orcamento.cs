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
using ProjetoDA.controllers;

namespace ProjetoDA.views
{
    public partial class Orcamento : Form
    {
        private readonly OrcamentoController _orcamentoController;
        private readonly int _utilizadorLogadoId;
        private int _mesSelecionado;
        private int _anoSelecionado;

        public Orcamento()
        {
            InitializeComponent();
            _orcamentoController = new OrcamentoController();
            _utilizadorLogadoId = 0; // Substitua 0 pelo valor correto do utilizador logado
            _mesSelecionado = DateTime.Now.Month;
            _anoSelecionado = DateTime.Now.Year;

            // Registar handlers
            this.Load += Orçamento_Load;
            this.btndefinirOrçamento.Click += btndefinirOrçamento_Click;
            this.btnVoltarInicio.Click += btnVoltarInicio_Click;
        }

        private void Orçamento_Load(object sender, EventArgs e)
        {
            // Carrega o orçamento da base de dados
            CarregarOrcamento();
        }

        private void CarregarOrcamento()
        {
            try
            {
                var orcamentos = _orcamentoController.getOrcamentos();
                var orcamentoAtual = orcamentos.FirstOrDefault(o => o.Mes == _mesSelecionado && o.Ano == _anoSelecionado);

                if (orcamentoAtual != null)
                {
                    lblOrcamentos.Text = FormatCurrency(orcamentoAtual.ValorMaximo);
                    txtOrcamento.Text = orcamentoAtual.ValorMaximo.ToString("N2", CultureInfo.CurrentCulture);
                }
                else
                {
                    lblOrcamentos.Text = "Ainda sem orçamento definido";
                    txtOrcamento.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar o orçamento: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndefinirOrçamento_Click(object sender, EventArgs e)
        {
            // Validação e gravação do orçamento
            var texto = txtOrcamento.Text?.Trim();
            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("Introduza um valor para o orçamento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(texto, NumberStyles.Number, CultureInfo.CurrentCulture, out var valor))
            {
                MessageBox.Show("Formato inválido. Use números inteiros (ex.: 1000).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (valor < 0)
            {
                MessageBox.Show("O orçamento não pode ser negativo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                bool sucesso = _orcamentoController.salvarOuAtualizarOrcamento(_mesSelecionado, _anoSelecionado, valor, _utilizadorLogadoId);

                if (sucesso)
                {
                    CarregarOrcamento();
                    MessageBox.Show("Orçamento guardado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao gravar o orçamento. Utilizador não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private string FormatCurrency(int valor)
        {
            // Formata conforme cultura do utilizador, com símbolo de moeda
            return string.Format(CultureInfo.CurrentCulture, "{0:C}", valor);
        }
    }
}