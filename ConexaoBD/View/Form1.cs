using ConexaoBD.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexaoBD
{
    public partial class Form1 : Form
    {
        Conexao conexao = new Conexao();
        public Form1()
        {
            InitializeComponent();
            Conexao.getConexao();
            Console.WriteLine("Conexao feita com sucesso");

            //MessageBox.Show("Conexao feita com sucesso "+ Conexao.conexao.State.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindo MAno Valter");
        }

    }
}
