namespace ControleBar
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMostrarTotal = new System.Windows.Forms.Label();
            this.lblQtdPessoa = new System.Windows.Forms.Label();
            this.tbxQtdPessoa = new System.Windows.Forms.TextBox();
            this.lblProcentagem = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblTotalPessoa = new System.Windows.Forms.Label();
            this.lblPrecoPessoa = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblValorUnitario = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.tbxValorUnitario = new System.Windows.Forms.TextBox();
            this.tbxQuantidade = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(24, 13);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total:";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // lblMostrarTotal
            // 
            this.lblMostrarTotal.AutoSize = true;
            this.lblMostrarTotal.Location = new System.Drawing.Point(116, 13);
            this.lblMostrarTotal.Name = "lblMostrarTotal";
            this.lblMostrarTotal.Size = new System.Drawing.Size(28, 13);
            this.lblMostrarTotal.TabIndex = 1;
            this.lblMostrarTotal.Text = "0,00";
            // 
            // lblQtdPessoa
            // 
            this.lblQtdPessoa.AutoSize = true;
            this.lblQtdPessoa.Location = new System.Drawing.Point(24, 54);
            this.lblQtdPessoa.Name = "lblQtdPessoa";
            this.lblQtdPessoa.Size = new System.Drawing.Size(67, 13);
            this.lblQtdPessoa.TabIndex = 2;
            this.lblQtdPessoa.Text = "Qnt.Pessoas";
            // 
            // tbxQtdPessoa
            // 
            this.tbxQtdPessoa.Location = new System.Drawing.Point(119, 51);
            this.tbxQtdPessoa.Name = "tbxQtdPessoa";
            this.tbxQtdPessoa.Size = new System.Drawing.Size(100, 20);
            this.tbxQtdPessoa.TabIndex = 3;
            this.tbxQtdPessoa.Text = "1";
            // 
            // lblProcentagem
            // 
            this.lblProcentagem.AutoSize = true;
            this.lblProcentagem.Location = new System.Drawing.Point(24, 90);
            this.lblProcentagem.Name = "lblProcentagem";
            this.lblProcentagem.Size = new System.Drawing.Size(58, 13);
            this.lblProcentagem.TabIndex = 4;
            this.lblProcentagem.Text = "Incluir 10%";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(119, 86);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(41, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "sim";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblTotalPessoa
            // 
            this.lblTotalPessoa.AutoSize = true;
            this.lblTotalPessoa.Location = new System.Drawing.Point(24, 125);
            this.lblTotalPessoa.Name = "lblTotalPessoa";
            this.lblTotalPessoa.Size = new System.Drawing.Size(89, 13);
            this.lblTotalPessoa.TabIndex = 6;
            this.lblTotalPessoa.Text = "Total por pessoa:";
            // 
            // lblPrecoPessoa
            // 
            this.lblPrecoPessoa.AutoSize = true;
            this.lblPrecoPessoa.Location = new System.Drawing.Point(116, 125);
            this.lblPrecoPessoa.Name = "lblPrecoPessoa";
            this.lblPrecoPessoa.Size = new System.Drawing.Size(28, 13);
            this.lblPrecoPessoa.TabIndex = 7;
            this.lblPrecoPessoa.Text = "0,00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbxQuantidade);
            this.groupBox1.Controls.Add(this.tbxValorUnitario);
            this.groupBox1.Controls.Add(this.lblQuantidade);
            this.groupBox1.Controls.Add(this.lblValorUnitario);
            this.groupBox1.Location = new System.Drawing.Point(15, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 121);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Despesas";
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.AutoSize = true;
            this.lblValorUnitario.Location = new System.Drawing.Point(9, 31);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(73, 13);
            this.lblValorUnitario.TabIndex = 0;
            this.lblValorUnitario.Text = "Valor Unitario:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(9, 61);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lblQuantidade.TabIndex = 1;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // tbxValorUnitario
            // 
            this.tbxValorUnitario.Location = new System.Drawing.Point(87, 28);
            this.tbxValorUnitario.Name = "tbxValorUnitario";
            this.tbxValorUnitario.Size = new System.Drawing.Size(100, 20);
            this.tbxValorUnitario.TabIndex = 2;
            // 
            // tbxQuantidade
            // 
            this.tbxQuantidade.Location = new System.Drawing.Point(90, 61);
            this.tbxQuantidade.Name = "tbxQuantidade";
            this.tbxQuantidade.Size = new System.Drawing.Size(97, 20);
            this.tbxQuantidade.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 277);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPrecoPessoa);
            this.Controls.Add(this.lblTotalPessoa);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblProcentagem);
            this.Controls.Add(this.tbxQtdPessoa);
            this.Controls.Add(this.lblQtdPessoa);
            this.Controls.Add(this.lblMostrarTotal);
            this.Controls.Add(this.lblTotal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMostrarTotal;
        private System.Windows.Forms.Label lblQtdPessoa;
        private System.Windows.Forms.TextBox tbxQtdPessoa;
        private System.Windows.Forms.Label lblProcentagem;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblTotalPessoa;
        private System.Windows.Forms.Label lblPrecoPessoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxQuantidade;
        private System.Windows.Forms.TextBox tbxValorUnitario;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblValorUnitario;
    }
}

