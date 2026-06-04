using System;
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
    public partial class ModoCompra : Form
    {
        private readonly ArtigoController _artigoController;
        private readonly TipoArtigoController _tipoArtigoController;
        private readonly CompraController _compraController;
        private Form1 _parent;

        public ModoCompra()
        {
            InitializeComponent();
            _artigoController = new ArtigoController();
            _tipoArtigoController = new TipoArtigoController();
            _compraController = new CompraController();
            
            this.Load += ModoCompra_Load;
            this.FormClosing += ModoCompra_FormClosing;
        }

        // Construtor que recebe o Form1 como referência
        public ModoCompra(Form1 parent) : this()
        {
            _parent = parent;
        }

        private void ModoCompra_Load(object sender, EventArgs e)
        {
            CarregarTiposArtigo();
        }

        private void CarregarTiposArtigo()
        {
            try
            {
                var tipos = _tipoArtigoController.getTiposArtigo();
                comboTipoArtigo.DataSource = tipos;
                comboTipoArtigo.DisplayMember = "Categoria";
                comboTipoArtigo.ValueMember = "Id";
                comboTipoArtigo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar tipos de artigo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboTipoArtigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTipoArtigo.SelectedIndex == -1)
            {
                comboArtigo.DataSource = null;
                return;
            }

            try
            {
                // Recupera o objeto TipoArtigo selecionado
                var tipoSelecionado = (dynamic)comboTipoArtigo.SelectedItem;
                int tipoId = tipoSelecionado.Id;
                
                var artigos = _artigoController.getArtigos()
                    .Where(a => a.TipoArtigo != null && a.TipoArtigo.Id == tipoId)
                    .ToList();

                comboArtigo.DataSource = artigos;
                comboArtigo.DisplayMember = "Nome";
                comboArtigo.ValueMember = "Id";
                comboArtigo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar artigos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltarInicio_Click(object sender, EventArgs e)
        {
            // Se temos referência ao Form1 parent, mostra-o novamente
            if (_parent != null)
            {
                _parent.Show();
            }
            else
            {
                // Caso contrário, cria uma nova instância
                Form1 form1 = new Form1();
                form1.Show();
            }

            // Esconde o formulário atual
            this.Hide();
        }

        private void comboArtigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Pode ser usado para atualizar outras informações do artigo selecionado
        }

        private void numArtigo_ValueChanged(object sender, EventArgs e)
        {
            // Tratamento de mudança de quantidade
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (comboArtigo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um artigo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numArtigo.Value <= 0)
            {
                MessageBox.Show("Por favor, introduza uma quantidade válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Adicionar o item à listBox1
                string artigo = comboArtigo.Text;
                int quantidade = (int)numArtigo.Value;
                listBox1.Items.Add($"{artigo} - Qtd: {quantidade}");

                // Limpar os campos
                comboArtigo.SelectedIndex = -1;
                numArtigo.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar item: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSavePlan_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Por favor, adicione pelo menos um artigo à compra.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Aqui você pode implementar a lógica de guardar a compra
                MessageBox.Show("Compra guardada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Limpar a lista após guardar
                listBox1.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao guardar a compra: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um item para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void ModoCompra_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Não é necessário fazer nada especial aqui
        }
    }
}
