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
    public partial class Cadastro_de_Autores : Form
    {
        public Cadastro_de_Autores()
        {
            InitializeComponent();
        }

        private void authorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.authorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libaryDataSet);

        }

        private void Cadastro_de_Autores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libaryDataSet.Author' table. You can move, or remove it, as needed.
            this.authorTableAdapter.Fill(this.libaryDataSet.Author);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            int id = authorBindingSource.Count;
            txtID.Text = id.ToString();
        }
    }
}
