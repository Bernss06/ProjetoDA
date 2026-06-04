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
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnSavePlan = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numArtigo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltarInicio
            // 
            this.btnVoltarInicio.Location = new System.Drawing.Point(12, 12);
            this.btnVoltarInicio.Name = "btnVoltarInicio";
            this.btnVoltarInicio.Size = new System.Drawing.Size(101, 34);
            this.btnVoltarInicio.TabIndex = 0;
            this.btnVoltarInicio.Text = "<- Inicio";
            this.btnVoltarInicio.UseVisualStyleBackColor = true;
            this.btnVoltarInicio.Click += new System.EventHandler(this.btnVoltarInicio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Artigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade:";
            // 
            // btnAddItem
            // 
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
            // 
            // Planeamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 557);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVoltarInicio);
            this.Controls.Add(this.groupBox2);
            this.Name = "Planeamento";
            this.Text = "Planeamento";
            ((System.ComponentModel.ISupportInitialize)(this.numArtigo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnSavePlan;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.ListBox listBox1;
    }
}