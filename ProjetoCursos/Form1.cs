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
    public partial class frmSplash : Form
    {

        public frmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pgbbarradeprogresso.Value <= 62)
            {
                pgbbarradeprogresso.Value += pgbbarradeprogresso.Value + 2;
            }
            else
            {
               //Application.Exit();
               timer1.Enabled = false;
               frmLogin form = new frmLogin();
               form.Show();
               this.Visible = false;
            }
        }
    }
}
