using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lojas_Americanas
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string codigo, nome, pessoa, ativo, nascimento, cpf, rg, endereco, bairro, cidade, estado, cep, telefone, celular, contato, email, site;

            codigo = txtCodigo.Text;
            nome = txtNome.Text;
            nascimento = mtxtNascimento.Text;
            cpf = txtCPF.Text;
            rg = txtRG.Text;
            endereco = txtEndereco.Text;
            bairro = txtBairro.Text;
            cidade = txtCidade.Text;
            estado = cbxEstado.Items[cbxEstado.SelectedIndex].ToString();
            cep = txtCEP.Text;
            telefone = mtxtTelefone.Text;
            celular = mtxtCelular.Text;
            contato = txtContato.Text;
            email = txtEmail.Text;
            site = txtSite.Text;

            if (rbtnFisica.Checked == true)
            {
                pessoa = "Física";
            }
            else
            {
                pessoa = "";
            }

            if(rbtnJuridica.Checked == true)
            {
                pessoa = "Jurídica";
            }
            else
            {
                pessoa = "";
            }

            if (cbxAtivo.Checked == true)
            {
                ativo = "Ativo";
            }
            else
            {
                ativo = "Não Ativo";
            }

            SalvarClientes(codigo, nome, pessoa, ativo, nascimento, cpf, rg, endereco, bairro, cidade, estado, cep, telefone, celular, contato, email, site);

        }

        private void SalvarClientes(string codigo,
            string nome,
            string pessoa,
            string ativo,
            string nascimento,
            string cpf,
            string rg,
            string endereco,
            string bairro,
            string cidade,
            string estado,
            string cep,
            string telefone,
            string celular,
            string contato,
            string email,
            string site)
        {
            StreamWriter cliente;
            string caminho = "Cadastro de Clientes";

            cliente = File.AppendText(caminho);
            cliente.WriteLine("Código: " + codigo);
            cliente.WriteLine("Nome: " + nome);
            cliente.WriteLine("Pessoa: " + pessoa);
            cliente.WriteLine("Ativo: " + ativo);
            cliente.WriteLine("Nascimento: " + nascimento);
            cliente.WriteLine("CNPJ/CPF: " + cpf);
            cliente.WriteLine("Inscrição Estadual/RG: " + rg);
            cliente.WriteLine("Endereço: " + endereco);
            cliente.WriteLine("Bairro: " + bairro);
            cliente.WriteLine("Cidade: " + cidade);
            cliente.WriteLine("Estado: " + estado);
            cliente.WriteLine("CEP: " + cep);
            cliente.WriteLine("Telefone: " + telefone);
            cliente.WriteLine("Celular: " + celular);
            cliente.WriteLine("Contato: " + contato);
            cliente.WriteLine("E-mail: " + email);
            cliente.WriteLine("Site: " + site);
            cliente.Close();
            MessageBox.Show("Cliente Salvo com Sucesso!");
            Limpar();
        }

        private void Limpar()
        {
            txtCodigo.Clear();
            rbtnFisica.Checked = false;
            rbtnJuridica.Checked = false;
            cbxAtivo.Checked = false;
            txtNome.Clear();
            mtxtNascimento.Clear();
            txtCPF.Clear();
            txtRG.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            cbxEstado.SelectedIndex = -1;
            txtCEP.Clear();
            mtxtTelefone.Clear();
            mtxtCelular.Clear();
            txtContato.Clear();
            txtEmail.Clear();
            txtSite.Clear();
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            
            string enderecoCompleto = "";

            try
            {
                var webService = new wscep.AtendeClienteClient();
                var resposta = webService.consultaCEP(txtCEP.Text);
                txtEndereco.Text= resposta.end;
                enderecoCompleto += "\nBairro: " + resposta.bairro;
                enderecoCompleto += "\nCidade: " + resposta.cidade;
                enderecoCompleto += "\nEstado: " + resposta.uf;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Esse CEP não foi encontrado");
            }
        }

        private void txtCEP_TextChanged(object sender, EventArgs e)
        {


            string enderecoCompleto = "";

            try
            {
                var webService = new wscep.AtendeClienteClient();
                var resposta = webService.consultaCEP(txtCEP.Text);
                txtEndereco.Text = resposta.end;
                enderecoCompleto += "\nBairro: " + resposta.bairro;
                enderecoCompleto += "\nCidade: " + resposta.cidade;
                enderecoCompleto += "\nEstado: " + resposta.uf;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Esse CEP não foi encontrado");
            }
    }
}
