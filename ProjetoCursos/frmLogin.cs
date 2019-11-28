using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCursos
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            /*
            int result = funcionarioTableAdapter.FillByLogin(bdprojetocursosDataSet.Funcionario, txtusuario.Text, mkdSenha.Text);//retorna 1 caso ache um registro e 0 caso nao ache
            
            if (result == 1)
           {
                Principal form = new Principal();
                form.Show();
               this.Visible = false;
           }
           else
            {
                MessageBox.Show("Usuário ou senha incorretos.","Ocorreu um erro ao autenticar",MessageBoxButtons.OK,MessageBoxIcon.Error);
                31084183 + ateksUbatuba@users.noreply.github.com
            }
           */

           if (txtusuario.Text == "adm" && mkdSenha.Text == "123")
            {
                Principal form = new Principal();
                form.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.", "Ocorreu um erro ao autenticar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdprojetocursosDataSet.Funionario'. Você pode movê-la ou removê-la conforme necessário.
            //this.funionarioTableAdapter.Fill(this.bdprojetocursosDataSet.Funionario);

        }
    }
}
