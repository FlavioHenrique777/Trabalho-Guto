namespace Lojas_Americanas
{
    partial class frmClientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.gbxFisicaJuridica = new System.Windows.Forms.GroupBox();
            this.rbtnFisica = new System.Windows.Forms.RadioButton();
            this.rbtnJuridica = new System.Windows.Forms.RadioButton();
            this.cbxAtivo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mtxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mtxtNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.mtxtCelular = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.gbxFisicaJuridica.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(80, 18);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // gbxFisicaJuridica
            // 
            this.gbxFisicaJuridica.Controls.Add(this.rbtnFisica);
            this.gbxFisicaJuridica.Controls.Add(this.rbtnJuridica);
            this.gbxFisicaJuridica.Location = new System.Drawing.Point(200, 0);
            this.gbxFisicaJuridica.Name = "gbxFisicaJuridica";
            this.gbxFisicaJuridica.Size = new System.Drawing.Size(140, 38);
            this.gbxFisicaJuridica.TabIndex = 2;
            this.gbxFisicaJuridica.TabStop = false;
            this.gbxFisicaJuridica.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbtnFisica
            // 
            this.rbtnFisica.AutoSize = true;
            this.rbtnFisica.Location = new System.Drawing.Point(82, 16);
            this.rbtnFisica.Name = "rbtnFisica";
            this.rbtnFisica.Size = new System.Drawing.Size(54, 17);
            this.rbtnFisica.TabIndex = 1;
            this.rbtnFisica.TabStop = true;
            this.rbtnFisica.Text = "Física";
            this.rbtnFisica.UseVisualStyleBackColor = true;
            // 
            // rbtnJuridica
            // 
            this.rbtnJuridica.AutoSize = true;
            this.rbtnJuridica.Location = new System.Drawing.Point(3, 16);
            this.rbtnJuridica.Name = "rbtnJuridica";
            this.rbtnJuridica.Size = new System.Drawing.Size(63, 17);
            this.rbtnJuridica.TabIndex = 0;
            this.rbtnJuridica.TabStop = true;
            this.rbtnJuridica.Text = "Jurídica";
            this.rbtnJuridica.UseVisualStyleBackColor = true;
            // 
            // cbxAtivo
            // 
            this.cbxAtivo.AutoSize = true;
            this.cbxAtivo.Location = new System.Drawing.Point(359, 16);
            this.cbxAtivo.Name = "cbxAtivo";
            this.cbxAtivo.Size = new System.Drawing.Size(50, 17);
            this.cbxAtivo.TabIndex = 2;
            this.cbxAtivo.Text = "Ativo";
            this.cbxAtivo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(80, 56);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(256, 20);
            this.txtNome.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CNPJ/CPF:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(99, 96);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(167, 20);
            this.txtCPF.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(93, 135);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(247, 20);
            this.txtEndereco.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cidade:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(80, 172);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(186, 20);
            this.txtCidade.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Telefone:";
            // 
            // mtxtTelefone
            // 
            this.mtxtTelefone.Location = new System.Drawing.Point(89, 208);
            this.mtxtTelefone.Mask = "(99) 99999-9999";
            this.mtxtTelefone.Name = "mtxtTelefone";
            this.mtxtTelefone.Size = new System.Drawing.Size(91, 20);
            this.mtxtTelefone.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "E-mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(75, 238);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(191, 20);
            this.txtEmail.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nascimento:";
            // 
            // mtxtNascimento
            // 
            this.mtxtNascimento.Location = new System.Drawing.Point(428, 56);
            this.mtxtNascimento.Mask = "00/00/0000";
            this.mtxtNascimento.Name = "mtxtNascimento";
            this.mtxtNascimento.Size = new System.Drawing.Size(68, 20);
            this.mtxtNascimento.TabIndex = 16;
            this.mtxtNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(304, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Inscrição Estadual/RG:";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(428, 96);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(137, 20);
            this.txtRG.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(381, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Bairro:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(428, 135);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(137, 20);
            this.txtBairro.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(304, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Estado:";
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "MG",
            "SC"});
            this.cbxEstado.Location = new System.Drawing.Point(353, 171);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(69, 21);
            this.cbxEstado.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(437, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "CEP:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(225, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Celular:";
            // 
            // mtxtCelular
            // 
            this.mtxtCelular.Location = new System.Drawing.Point(273, 208);
            this.mtxtCelular.Mask = "(99) 00000-0000";
            this.mtxtCelular.Name = "mtxtCelular";
            this.mtxtCelular.Size = new System.Drawing.Size(88, 20);
            this.mtxtCelular.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(377, 211);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Contato:";
            // 
            // txtContato
            // 
            this.txtContato.Location = new System.Drawing.Point(430, 208);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(135, 20);
            this.txtContato.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(279, 241);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Site:";
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(313, 238);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(252, 20);
            this.txtSite.TabIndex = 30;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(630, 77);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(120, 39);
            this.btnLimpar.TabIndex = 31;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(630, 186);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(120, 38);
            this.btnSalvar.TabIndex = 32;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(474, 171);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(91, 20);
            this.txtCEP.TabIndex = 24;
            this.txtCEP.TextChanged += new System.EventHandler(this.txtCEP_TextChanged);
            this.txtCEP.Leave += new System.EventHandler(this.txtCEP_Leave);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 283);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtSite);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtContato);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.mtxtCelular);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mtxtNascimento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mtxtTelefone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxAtivo);
            this.Controls.Add(this.gbxFisicaJuridica);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.gbxFisicaJuridica.ResumeLayout(false);
            this.gbxFisicaJuridica.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox gbxFisicaJuridica;
        private System.Windows.Forms.RadioButton rbtnFisica;
        private System.Windows.Forms.RadioButton rbtnJuridica;
        private System.Windows.Forms.CheckBox cbxAtivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtxtTelefone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtxtNascimento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox mtxtCelular;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtCEP;
    }
}