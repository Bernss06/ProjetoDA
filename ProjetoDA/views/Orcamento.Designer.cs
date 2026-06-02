namespace ProjetoDA.views
{
    partial class Orçamento
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVoltarInicio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblOrçamentos = new System.Windows.Forms.Label();
            this.btndefinirOrçamento = new System.Windows.Forms.Button();
            this.txtOrçamento = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btndefinirOrçamento);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(224, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 341);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnVoltarInicio);
            this.groupBox2.Location = new System.Drawing.Point(12, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 62);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnVoltarInicio
            // 
            this.btnVoltarInicio.Location = new System.Drawing.Point(6, 21);
            this.btnVoltarInicio.Name = "btnVoltarInicio";
            this.btnVoltarInicio.Size = new System.Drawing.Size(101, 34);
            this.btnVoltarInicio.TabIndex = 0;
            this.btnVoltarInicio.Text = "<- Inicio";
            this.btnVoltarInicio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Orçamento Mensal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "O seu orçamento para o mes:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtOrçamento);
            this.groupBox3.Controls.Add(this.lblOrçamentos);
            this.groupBox3.Location = new System.Drawing.Point(37, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 86);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // lblOrçamentos
            // 
            this.lblOrçamentos.AutoSize = true;
            this.lblOrçamentos.Location = new System.Drawing.Point(128, 55);
            this.lblOrçamentos.Name = "lblOrçamentos";
            this.lblOrçamentos.Size = new System.Drawing.Size(44, 16);
            this.lblOrçamentos.TabIndex = 0;
            this.lblOrçamentos.Text = "label3";
            // 
            // btndefinirOrçamento
            // 
            this.btndefinirOrçamento.Location = new System.Drawing.Point(116, 211);
            this.btndefinirOrçamento.Name = "btndefinirOrçamento";
            this.btndefinirOrçamento.Size = new System.Drawing.Size(158, 40);
            this.btndefinirOrçamento.TabIndex = 2;
            this.btndefinirOrçamento.Text = "Definir Orçamento";
            this.btndefinirOrçamento.UseVisualStyleBackColor = true;
            // 
            // txtOrçamento
            // 
            this.txtOrçamento.Location = new System.Drawing.Point(97, 21);
            this.txtOrçamento.Name = "txtOrçamento";
            this.txtOrçamento.Size = new System.Drawing.Size(100, 22);
            this.txtOrçamento.TabIndex = 1;
            // 
            // Orçamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Orçamento";
            this.Text = "Orçamento";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltarInicio;
        private System.Windows.Forms.Button btndefinirOrçamento;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtOrçamento;
        private System.Windows.Forms.Label lblOrçamentos;
        private System.Windows.Forms.Label label2;
    }
}