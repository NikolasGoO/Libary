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
    public partial class Cadastro_de_Clientes : Form
    {
        public Cadastro_de_Clientes()
        {
            InitializeComponent();
        }

        private void Cadastro_de_Clientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libaryDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.libaryDataSet.Client);

        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libaryDataSet);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            int id = clientBindingSource.Count;
            txtID.Text = id.ToString();
        }
    }
}
