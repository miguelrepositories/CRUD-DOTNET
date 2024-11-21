using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using DAL;
using System.Windows.Forms;
using Modelos;

namespace GUI
{
    public partial class lblNome : Form
    {
        public lblNome()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            IRepositorio rep = new RepositorioNpgsql();
            try
            {
                rep.Inserir(doenca: new Doencas(txtCID.Text, txtTipo.Text, txtNome.Text, txtSintomas.Text));
                MessageBox.Show(text: $"Cadastro de doença inserido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(text: $"Ocorreu um erro: {ex.Message}");
            }   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListarDoencas();

        }

        private void ListarDoencas()
        {
            IRepositorio rep = new RepositorioNpgsql();
            try
            {
                gridClientes.DataSource = null;
                gridClientes.DataSource = rep.Listar();
                gridClientes.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(text: $"Ocorreu um erro: {ex.Message}");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtCID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNome_Load(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ListarDoencas();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            IRepositorio rep = new RepositorioNpgsql();
            try
            {
                rep.Deletar(txtNome.Text);
                ListarDoencas();
                MessageBox.Show(text: $"Registro da {txtNome.Text}, deletado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(text: $"Ocorreu um erro: {ex.Message}");
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            IRepositorio rep = new RepositorioNpgsql();
            try
            {
                rep.Atualizar(doenca: new Doencas(txtCID.Text, txtTipo.Text, txtNome.Text, txtSintomas.Text));
                MessageBox.Show(text: $"Cadastro da doença: {txtNome.Text}, atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(text: $"Ocorreu um erro: {ex.Message}");
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
