namespace Biblioteca
{
    partial class Form_Principal
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeLivrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarUmClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emprestimosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosEmprestadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoan = new System.Windows.Forms.Button();
            this.libaryDataSet = new Biblioteca.LibaryDataSet();
            this.livrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livrosTableAdapter = new Biblioteca.LibaryDataSetTableAdapters.LivrosTableAdapter();
            this.tableAdapterManager = new Biblioteca.LibaryDataSetTableAdapters.TableAdapterManager();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livrosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.emprestimosToolStripMenuItem,
            this.clientesToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // livrosToolStripMenuItem
            // 
            this.livrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeLivrosToolStripMenuItem});
            this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            this.livrosToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.livrosToolStripMenuItem.Text = "Livros";
            // 
            // cadastroDeLivrosToolStripMenuItem
            // 
            this.cadastroDeLivrosToolStripMenuItem.Name = "cadastroDeLivrosToolStripMenuItem";
            this.cadastroDeLivrosToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.cadastroDeLivrosToolStripMenuItem.Text = "Cadastro de Livros";
            this.cadastroDeLivrosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeLivrosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarUmClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.clientesToolStripMenuItem.Text = "Autores";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // cadastrarUmClienteToolStripMenuItem
            // 
            this.cadastrarUmClienteToolStripMenuItem.Name = "cadastrarUmClienteToolStripMenuItem";
            this.cadastrarUmClienteToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.cadastrarUmClienteToolStripMenuItem.Text = "Cadastro de Autores";
            this.cadastrarUmClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastrarUmClienteToolStripMenuItem_Click);
            // 
            // emprestimosToolStripMenuItem
            // 
            this.emprestimosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livrosEmprestadosToolStripMenuItem});
            this.emprestimosToolStripMenuItem.Name = "emprestimosToolStripMenuItem";
            this.emprestimosToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.emprestimosToolStripMenuItem.Text = "Emprestimos";
            // 
            // livrosEmprestadosToolStripMenuItem
            // 
            this.livrosEmprestadosToolStripMenuItem.Name = "livrosEmprestadosToolStripMenuItem";
            this.livrosEmprestadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.livrosEmprestadosToolStripMenuItem.Text = "Livros Emprestados";
            this.livrosEmprestadosToolStripMenuItem.Click += new System.EventHandler(this.livrosEmprestadosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosDeClienteToolStripMenuItem});
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            // 
            // cadastrosDeClienteToolStripMenuItem
            // 
            this.cadastrosDeClienteToolStripMenuItem.Name = "cadastrosDeClienteToolStripMenuItem";
            this.cadastrosDeClienteToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cadastrosDeClienteToolStripMenuItem.Text = "Cadastros de Cliente";
            this.cadastrosDeClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastrosDeClienteToolStripMenuItem_Click);
            // 
            // btnLoan
            // 
            this.btnLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoan.Location = new System.Drawing.Point(661, 422);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(127, 48);
            this.btnLoan.TabIndex = 1;
            this.btnLoan.Text = "Emprestar um Livro";
            this.btnLoan.UseVisualStyleBackColor = true;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // libaryDataSet
            // 
            this.libaryDataSet.DataSetName = "LibaryDataSet";
            this.libaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // livrosBindingSource
            // 
            this.livrosBindingSource.DataMember = "Livros";
            this.livrosBindingSource.DataSource = this.libaryDataSet;
            // 
            // livrosTableAdapter
            // 
            this.livrosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.LivrosTableAdapter = this.livrosTableAdapter;
            this.tableAdapterManager.LoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Biblioteca.LibaryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.btnLoan);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Principal";
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibaryDataSet libaryDataSet;
        private System.Windows.Forms.BindingSource livrosBindingSource;
        private LibaryDataSetTableAdapters.LivrosTableAdapter livrosTableAdapter;
        private LibaryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeLivrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarUmClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emprestimosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livrosEmprestadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosDeClienteToolStripMenuItem;
        private System.Windows.Forms.Button btnLoan;
    }
}

