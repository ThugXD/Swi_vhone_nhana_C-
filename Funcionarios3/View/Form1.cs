using Funcionario2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funcionarios3
{
    public partial class Form1 : Form
    {
        Conexao conexao = new Conexao();

        public Form1()
        {

            InitializeComponent();
            //CarregarLista();
            Conexao.getConexao();
            CarregarLista();
            //MessageBox.Show("Conexao Realizada com Sucesso " + Conexao.conexao.State.ToString());

        }
        //Conexao
        
        //Editar
        private void button1_Click(object sender, EventArgs e)
        {
            if (listViewFuncionario.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewFuncionario.SelectedItems[0];
                txtCodigo.Text = item.SubItems[0].Text;
                txtNome.Text = item.SubItems[1].Text;
                txtDiasTrabalho.Text = item.SubItems[2].Text;
                txtSalario.Text = item.SubItems[3].Text;

                // Desativar o campo de código para evitar alterações
                txtCodigo.Enabled = false;
            }
            else
            {
                MessageBox.Show("Selecione um funcionário para editar.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtDiasTrabalho.Text) || string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("Deve preencher todos os campos");
                return;
            }

            int codigo = int.Parse(txtCodigo.Text);
            string nome = txtNome.Text;
            int diasTrabalho = int.Parse(txtDiasTrabalho.Text);
            double salario = double.Parse(txtSalario.Text);

            Funcionario funcionario = new Funcionario(codigo, nome, diasTrabalho, salario);
            //conexao.insert(funcionario);

            if (txtCodigo.Enabled)
            {
                if (conexao.insert(funcionario))
                {
                    MessageBox.Show("Funcionário Gravado");
                    limparCampos();
                    CarregarLista();
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao Gravar");
                }
            }
            else
            {
                if (conexao.update(funcionario))
                {
                    MessageBox.Show("Dados do Funcionário Atualizados");
                    txtCodigo.Enabled = true;
                    limparCampos();
                    CarregarLista();
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao Atualizar");
                }

            }

        }


        private void CarregarLista()
        {
            List<Funcionario> funcionarios = conexao.ListaFuncionarios();
            listViewFuncionario.Items.Clear();
            foreach (Funcionario funcionario in funcionarios)
            {
                ListViewItem lista = new ListViewItem(funcionario.Codigo.ToString());
                lista.SubItems.Add(funcionario.Nome);
                lista.SubItems.Add(funcionario.DiasTrabalho.ToString());
                lista.SubItems.Add(funcionario.Salario.ToString());
                lista.SubItems.Add(funcionario.SalarioDiario().ToString());
                lista.SubItems.Add(funcionario.SalarioMensal().ToString());

                listViewFuncionario.Items.Add(lista);
            }
        }

        private void limparCampos()
        {
            txtCodigo.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtDiasTrabalho.Text = string.Empty;
            txtSalario.Text = string.Empty;
        }
    }
}


