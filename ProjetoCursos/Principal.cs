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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToShortTimeString();
        }


        ///////////////////////Eventos//////////////////////
        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }


        private void locatárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroLocatarios frm1 = new frmCadastroLocatarios();
            frm1.Show();
        }

        private void funcionáriioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionarios frm2 = new frmCadastroFuncionarios();
            frm2.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCursos frm3 = new frmCadastroCursos();
            frm3.Show();
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroProfessores frm4 = new frmCadastroProfessores();
            frm4.Show();
        }
    }
}
