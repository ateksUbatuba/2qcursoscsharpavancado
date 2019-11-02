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

        private void professorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.professorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdprojetocursosDataSet);

        }

        private void frmCadastroProfessores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdprojetocursosDataSet.Professor'. Você pode movê-la ou removê-la conforme necessário.
            this.professorTableAdapter.Fill(this.bdprojetocursosDataSet.Professor);

        }
    }
}
