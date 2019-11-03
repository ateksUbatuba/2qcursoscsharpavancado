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
    public partial class frmCadastroProfessores : Form
    {
        public frmCadastroProfessores()
        {
            InitializeComponent();
        }


        ////////////////////Icones de navegação////////////////////////////////
       
        
     
        //////////////////////////////////////////////////////////////////////////////
        
        private void frmCadastroProfessores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdprojetocursosDataSet.Professor'. Você pode movê-la ou removê-la conforme necessário.
            

        }

        ////////////////////Funções de Tela///////////////////
        private void Limpacampos()
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
