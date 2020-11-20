using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho.Ltp.Data.Interfaces;
using Trabalho.LTP.Aplicacao.Interfaces;



namespace Trabalho.LTP.UI
{
    public partial class Principal : Form
    {
        private IItemRepo _repo;


        public Principal()
        {
            InitializeComponent();
            _repo = Program.container.GetInstance<IItemRepo>();

            PreencherGrid();

        }

        private void PreencherGrid()
        {
            GridItems.DataSource = _repo.ObterTodos();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_3(object sender, EventArgs e)
        {

        }

        private Trabalho.LTP.Dominio.ItensRoot.Item MapearDominio()
        {
            
            Trabalho.LTP.Dominio.ItensRoot.Item model = new Trabalho.LTP.Dominio.ItensRoot.Item();

            if (!string.IsNullOrEmpty(TxtId.Text))
            {
                model.ID = Convert.ToInt32(TxtId.Text);
            }

            model.Nome = TxtName.Text;
            model.Descricao = TxtDescricao.Text;
            if (String.IsNullOrEmpty(TxtQuantidade.Text))
            {
                
                LimparComponentes();

                TxtName.Focus();
            }

            else
            {
                model.Quantidade = Convert.ToInt32(TxtQuantidade.Text);
            }

            if (String.IsNullOrEmpty(TxtPreco.Text))
            {
               

                LimparComponentes();

                TxtName.Focus();
            }

            else
            {
                model.Preco = Convert.ToDecimal(TxtPreco.Text);
            }

            

            return model;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Trabalho.LTP.Dominio.ItensRoot.Item model = MapearDominio();

            

            IItemServices service = Program.container.GetInstance<IItemServices>();

            if (service.Adicionar(model))
            {            
                PreencherGrid();

                MessageBox.Show(this, "Item Adicionado com sucesso.", "Trabalho", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparComponentes();

                TxtName.Focus();


            }
            else
            {
                TxtName.Focus();

                MessageBox.Show(this, "Item não Cadastrado.\n \n"+ service.ObterNotificacoes(), "Trabalho", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void LimparComponentes()
        {
            TxtName.Text = string.Empty;
            TxtDescricao.Text = string.Empty;
            TxtQuantidade.Text = string.Empty;
            TxtPreco.Text = string.Empty;

            BtAdicionar.Enabled = true;
            BtAtualizar.Enabled = false;
            BtRemover.Enabled = false;
        }

        private void GridItems_DoubleClick(object sender, EventArgs e)
        {
            if (GridItems.Rows.Count == 0)
            {
                return;
            }


            int ID = Convert.ToInt32(GridItems.SelectedRows[0].Cells[ColumID.Index].Value);

            Trabalho.LTP.Dominio.ItensRoot.Item model = _repo.ObeterPorId(ID);

            TxtId.Text = model.ID.ToString();

            TxtName.Text = model.Nome;
            TxtDescricao.Text = model.Nome;
            TxtPreco.Text = model.Preco.ToString();
            TxtQuantidade.Text = model.Quantidade.ToString();
            TxtName.Focus();

            BtAdicionar.Enabled = false;
            BtAtualizar.Enabled = true;
            BtRemover.Enabled = true;
        }

       


        

        private void BtAtualizar_Click_1(object sender, EventArgs e)
        {
            Trabalho.LTP.Dominio.ItensRoot.Item model = MapearDominio();

            var service = Program.container.GetInstance<IItemServices>();

            if (service.Atualizar(model))
            {
                PreencherGrid();

                MessageBox.Show(this, "Item Atualizado com sucesso.", "Trabalho", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TxtName.Focus();

                LimparComponentes();

            }
            else
            {
                TxtName.Focus();

                MessageBox.Show(this, "Item não Cadastrado.\n \n" + service.ObterNotificacoes(), "Trabalho", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_2(object sender, EventArgs e)
        {

        }

        private void BtRemover_Click(object sender, EventArgs e)
        {

            IItemServices service = Program.container.GetInstance<IItemServices>();

            int ID = Convert.ToInt32(TxtId.Text);


            if (service.Excluir(ID))
            {

                PreencherGrid();


                LimparComponentes();
            }
            else
            {
                MessageBox.Show(this, "Item não Atualizado.\n \n" + service.ObterNotificacoes(), "Trabalho", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtQuantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label5_Click_3(object sender, EventArgs e)
        {

        }
    }


    
}
