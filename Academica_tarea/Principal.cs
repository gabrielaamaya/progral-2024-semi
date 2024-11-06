using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academica_tarea
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Form1 objForm = new Form1();
           
            objForm.Show();
        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Materia objForm = new Materia();
            
            objForm.Show();

        }
    }
}
