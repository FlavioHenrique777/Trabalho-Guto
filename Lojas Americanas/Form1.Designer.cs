namespace Lojas_Americanas
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
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnSetor = new System.Windows.Forms.Button();
            this.btnCargos = new System.Windows.Forms.Button();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(127, 52);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(133, 45);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Cadastro de Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.Location = new System.Drawing.Point(127, 118);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(133, 45);
            this.btnFuncionarios.TabIndex = 1;
            this.btnFuncionarios.Text = "Cadastro de Funcionários";
            this.btnFuncionarios.UseVisualStyleBackColor = true;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Location = new System.Drawing.Point(127, 187);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(133, 45);
            this.btnProdutos.TabIndex = 2;
            this.btnProdutos.Text = "Cadastro de Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnSetor
            // 
            this.btnSetor.Location = new System.Drawing.Point(330, 52);
            this.btnSetor.Name = "btnSetor";
            this.btnSetor.Size = new System.Drawing.Size(133, 45);
            this.btnSetor.TabIndex = 3;
            this.btnSetor.Text = "Cadastro de Setores";
            this.btnSetor.UseVisualStyleBackColor = true;
            this.btnSetor.Click += new System.EventHandler(this.btnSetor_Click);
            // 
            // btnCargos
            // 
            this.btnCargos.Location = new System.Drawing.Point(330, 118);
            this.btnCargos.Name = "btnCargos";
            this.btnCargos.Size = new System.Drawing.Size(133, 45);
            this.btnCargos.TabIndex = 4;
            this.btnCargos.Text = "Cadastro de Cargos";
            this.btnCargos.UseVisualStyleBackColor = true;
            this.btnCargos.Click += new System.EventHandler(this.btnCargos_Click);
            // 
            // btnAjuda
            // 
            this.btnAjuda.Location = new System.Drawing.Point(330, 187);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(133, 45);
            this.btnAjuda.TabIndex = 5;
            this.btnAjuda.Text = "AJUDA";
            this.btnAjuda.UseVisualStyleBackColor = true;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 280);
            this.Controls.Add(this.btnAjuda);
            this.Controls.Add(this.btnCargos);
            this.Controls.Add(this.btnSetor);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnFuncionarios);
            this.Controls.Add(this.btnClientes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnSetor;
        private System.Windows.Forms.Button btnCargos;
        private System.Windows.Forms.Button btnAjuda;
    }
}

