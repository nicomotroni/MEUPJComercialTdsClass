using ComercialTDSClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercialTDSDesk
{
    public partial class FrmPedido : Form
    {
        public FrmPedido()
        {
            InitializeComponent();
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtIdCliente.Text.Length > 4)
            {
                var cliente = cliente.obterPorId(int.Parse(txtIdCliente.Text));
                if (cliente.id > 0)
                {
                    txtNomeCliente.Text = cliente.Nome;
                }
            }
        }

        private void btnInserePedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new(Program.UsuarioLogado, Cliente.ObterPorId(int.Parse(txtIdCliente)));
            pedido.Inserir();
            if (pedido.Id >)
            {

            }


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodBar_TextChanged(object sender, EventArgs e)
        {

            if (txtCodBar.Text.Length > 6)
            {
                var produto = produto.ObterPorCodBar(txtCodBar.Text);
                if (produto.Id == 0)
                {
                    var produto = Produto.ObterPorId(int.Parse(txtCodBar.Text));
                }
                textDescricao.Text = produto.Descricao;
                txtValorUnit.Text = produto.ValorUnit.Tostring("R$##,00");

            }
            else if
            {
                var produto = produto.ObterPorCodBar(txtCodBar.Text);
            }
        }
    }
