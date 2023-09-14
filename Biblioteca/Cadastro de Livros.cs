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
    public partial class Cadastro_de_Livros : Form
    {
        public Cadastro_de_Livros()
        {
            InitializeComponent();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.livrosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libaryDataSet);

        }

        private void livrosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.livrosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libaryDataSet);

        }

        private void Cadastro_de_Livros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libaryDataSet.Author' table. You can move, or remove it, as needed.
            this.authorTableAdapter.Fill(this.libaryDataSet.Author);
            // TODO: This line of code loads data into the 'libaryDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.libaryDataSet.Livros);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            int id = livrosBindingSource.Count;
            txtID.Text = id.ToString();
        }
    }
}
