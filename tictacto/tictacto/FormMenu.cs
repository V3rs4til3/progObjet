using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictacto
{
    public partial class FormMenu : Form
    {
        TicTacToe _parent;
        public FormMenu(TicTacToe controller)
        {
            InitializeComponent();
            _parent = controller;
        }

        private void btNovelllePartie_Click(object sender, EventArgs e)
        {
            _parent.nouvellePartie();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            _parent.quit();
        }
    }
}
