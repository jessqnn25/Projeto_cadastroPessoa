using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuPrimeiroApp
{
    public partial class FrmCadastroPessoa : Form
    {
        public FrmCadastroPessoa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            VO.Fisica v = new VO.Fisica();
            v.codigo = 10;
            v.cpf = "";
            v.endereco = "10";
            v.nome = "nome1";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            VO.Fisica v = new VO.Fisica();
            v.codigo = int.Parse(txtCodigo.Text);
            v.cpf = txtCPF.Text;
            v.endereco = txtEnd.Text;
            v.nome = txtNome.Text;

            BE.PessoaFisicaBE be = new BE.PessoaFisicaBE();
            be.pessoa = v;
            be.create();

            carregar();


        }
        public void carregar(){
            BE.PessoaFisicaBE be = new BE.PessoaFisicaBE();
            lstPessoa.DataSource = null;
            lstPessoa.DataSource = be.list();
            lstPessoa.ValueMember = "codigo";
            lstPessoa.DisplayMember = "nome";
            lstPessoa.Refresh();
    }

        private void button3_Click(object sender, EventArgs e)
        {
            BE.PessoaFisicaBE be = new BE.PessoaFisicaBE();
            lstPessoa.DataSource = null;
            lstPessoa.DataSource = be.list();
            lstPessoa.ValueMember = "";
            lstPessoa.DisplayMember = "";
            lstPessoa.Refresh();
        }
    }
}
