using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
        }

        private void livrosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.livrosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libaryDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libaryDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.libaryDataSet.Livros);

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroDeLivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_de_Livros formcadastroDeLivros = new Cadastro_de_Livros();
            formcadastroDeLivros.ShowDialog();
        }

        private void cadastrarUmClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_de_Autores formCadastrarumAutor = new Cadastro_de_Autores();
            formCadastrarumAutor.ShowDialog();
        }

        private void cadastrosDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_de_Clientes formCadastrarUmCliente = new Cadastro_de_Clientes();
            formCadastrarUmCliente.ShowDialog();
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            Emprestar_um_Livro formEmprestarUmLivro = new Emprestar_um_Livro();
            formEmprestarUmLivro.ShowDialog();
        }

        private void livrosEmprestadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
