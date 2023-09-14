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
    public partial class Emprestar_um_Livro : Form
    {
        public Emprestar_um_Livro()
        {
            InitializeComponent();
        }

        private void loanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libaryDataSet);

        }

        private void Emprestar_um_Livro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libaryDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.libaryDataSet.Livros);
            // TODO: This line of code loads data into the 'libaryDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.libaryDataSet.Client);
            // TODO: This line of code loads data into the 'libaryDataSet.Loan' table. You can move, or remove it, as needed.
            this.loanTableAdapter.Fill(this.libaryDataSet.Loan);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            int id = loanBindingSource.Count;
            txtLoanID.Text = id.ToString();
        }
    }
}
