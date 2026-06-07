namespace ProjetoDA.views
{
    partial class Planeamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnVoltarInicio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.comboArtigo = new System.Windows.Forms.ComboBox();
            this.comboTipoArtigo = new System.Windows.Forms.ComboBox();
            this.numArtigo = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
<<<<<<< HEAD
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnSavePlan = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numArtigo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
=======
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numArtigo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
>>>>>>> 6d5f55a8419b4c2e36c56acdcccee4c16c13c77a
            this.SuspendLayout();
            // 
            // btnVoltarInicio
            // 
            this.btnVoltarInicio.Location = new System.Drawing.Point(6, 234);
            this.btnVoltarInicio.Name = "btnVoltarInicio";
            this.btnVoltarInicio.Size = new System.Drawing.Size(150, 34);
            this.btnVoltarInicio.TabIndex = 0;
            this.btnVoltarInicio.Text = "<- Sair";
            this.btnVoltarInicio.UseVisualStyleBackColor = true;
<<<<<<< HEAD
            this.btnVoltarInicio.Click += new System.EventHandler(this.btnVoltarInicio_Click);
=======
>>>>>>> 6d5f55a8419b4c2e36c56acdcccee4c16c13c77a
            // 
            // label1
            // 
            this.label1.AutoSize = true;
<<<<<<< HEAD
            this.label1.Location = new System.Drawing.Point(13, 129);
=======
            this.label1.Location = new System.Drawing.Point(11, 163);
>>>>>>> 6d5f55a8419b4c2e36c56acdcccee4c16c13c77a
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Artigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
<<<<<<< HEAD
            this.label2.Location = new System.Drawing.Point(77, 63);
=======
            this.label2.Location = new System.Drawing.Point(77, 92);
>>>>>>> 6d5f55a8419b4c2e36c56acdcccee4c16c13c77a
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
<<<<<<< HEAD
            this.label3.Location = new System.Drawing.Point(37, 197);
=======
            this.label3.Location = new System.Drawing.Point(35, 244);
>>>>>>> 6d5f55a8419b4c2e36c56acdcccee4c16c13c77a
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade:";
<<<<<<< HEAD
=======
            // 
            // btnAddItem
            // 
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(115, 350);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(171, 42);
            this.btnAddItem.TabIndex = 3;
            this.btnAddItem.Text = "Adicionar";
            this.btnAddItem.UseVisualStyleBackColor = true;
            // 
            // comboArtigo
            // 
            this.comboArtigo.FormattingEnabled = true;
            this.comboArtigo.Location = new System.Drawing.Point(129, 160);
            this.comboArtigo.Name = "comboArtigo";
            this.comboArtigo.Size = new System.Drawing.Size(166, 24);
            this.comboArtigo.TabIndex = 4;
            // 
            // comboTipoArtigo
            // 
            this.comboTipoArtigo.FormattingEnabled = true;
            this.comboTipoArtigo.Location = new System.Drawing.Point(129, 89);
            this.comboTipoArtigo.Name = "comboTipoArtigo";
            this.comboTipoArtigo.Size = new System.Drawing.Size(166, 24);
            this.comboTipoArtigo.TabIndex = 5;
            // 
            // numArtigo
            // 
            this.numArtigo.Location = new System.Drawing.Point(129, 242);
            this.numArtigo.Name = "numArtigo";
            this.numArtigo.Size = new System.Drawing.Size(166, 22);
            this.numArtigo.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numArtigo);
            this.groupBox1.Controls.Add(this.comboTipoArtigo);
            this.groupBox1.Controls.Add(this.comboArtigo);
            this.groupBox1.Controls.Add(this.btnAddItem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(378, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 460);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.btnRemoveItem);
            this.groupBox2.Location = new System.Drawing.Point(748, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 460);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(312, 278);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.Location = new System.Drawing.Point(85, 354);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(200, 41);
            this.btnRemoveItem.TabIndex = 7;
            this.btnRemoveItem.Text = "Remover item selecionado";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btnVoltarInicio);
            this.groupBox3.Location = new System.Drawing.Point(12, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(162, 274);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "Artigos";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Planeamento";
            this.button2.UseVisualStyleBackColor = true;
>>>>>>> 6d5f55a8419b4c2e36c56acdcccee4c16c13c77a
            // 
            // btnAddItem
            // 
<<<<<<< HEAD
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(82, 279);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(171, 42);
            this.btnAddItem.TabIndex = 3;
            this.btnAddItem.Text = "Adicionar";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // comboArtigo
            // 
            this.comboArtigo.FormattingEnabled = true;
            this.comboArtigo.Location = new System.Drawing.Point(129, 126);
            this.comboArtigo.Name = "comboArtigo";
            this.comboArtigo.Size = new System.Drawing.Size(166, 24);
            this.comboArtigo.TabIndex = 4;
            this.comboArtigo.SelectedIndexChanged += new System.EventHandler(this.comboArtigo_SelectedIndexChanged);
            // 
            // comboTipoArtigo
            // 
            this.comboTipoArtigo.FormattingEnabled = true;
            this.comboTipoArtigo.Location = new System.Drawing.Point(129, 60);
            this.comboTipoArtigo.Name = "comboTipoArtigo";
            this.comboTipoArtigo.Size = new System.Drawing.Size(166, 24);
            this.comboTipoArtigo.TabIndex = 5;
            this.comboTipoArtigo.SelectedIndexChanged += new System.EventHandler(this.comboTipoArtigo_SelectedIndexChanged);
            // 
            // numArtigo
            // 
            this.numArtigo.Location = new System.Drawing.Point(129, 195);
            this.numArtigo.Name = "numArtigo";
            this.numArtigo.Size = new System.Drawing.Size(166, 22);
            this.numArtigo.TabIndex = 6;
            this.numArtigo.ValueChanged += new System.EventHandler(this.numArtigo_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numArtigo);
            this.groupBox1.Controls.Add(this.comboTipoArtigo);
            this.groupBox1.Controls.Add(this.comboArtigo);
            this.groupBox1.Controls.Add(this.btnAddItem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(100, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 397);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecionar Compra";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSavePlan);
            this.groupBox2.Controls.Add(this.btnRemoveItem);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(438, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 397);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "A";
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.Location = new System.Drawing.Point(65, 283);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(200, 41);
            this.btnRemoveItem.TabIndex = 7;
            this.btnRemoveItem.Text = "Remover item selecionado";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            // 
            // btnSavePlan
            // 
            this.btnSavePlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePlan.Location = new System.Drawing.Point(65, 340);
            this.btnSavePlan.Name = "btnSavePlan";
            this.btnSavePlan.Size = new System.Drawing.Size(200, 40);
            this.btnSavePlan.TabIndex = 8;
            this.btnSavePlan.Text = "Guardar Planeamento";
            this.btnSavePlan.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(21, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(268, 244);
            this.listBox1.TabIndex = 0;
=======
            this.button1.Location = new System.Drawing.Point(6, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Estatísticas";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(204, 164);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(168, 175);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "label4";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(32, 99);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
>>>>>>> 6d5f55a8419b4c2e36c56acdcccee4c16c13c77a
            // 
            // Planeamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 557);
<<<<<<< HEAD
=======
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
>>>>>>> 6d5f55a8419b4c2e36c56acdcccee4c16c13c77a
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Planeamento";
            this.Text = "Planeamento";
            ((System.ComponentModel.ISupportInitialize)(this.numArtigo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
<<<<<<< HEAD
=======
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
>>>>>>> 6d5f55a8419b4c2e36c56acdcccee4c16c13c77a
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnVoltarInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ComboBox comboArtigo;
        private System.Windows.Forms.ComboBox comboTipoArtigo;
        private System.Windows.Forms.NumericUpDown numArtigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
<<<<<<< HEAD
        private System.Windows.Forms.Button btnSavePlan;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.ListBox listBox1;
=======
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
>>>>>>> 6d5f55a8419b4c2e36c56acdcccee4c16c13c77a
    }
}