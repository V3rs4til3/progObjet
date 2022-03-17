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
        public FormMenu(TicTacToe Controller)
        {
            InitializeComponent();
            this._parent = Controller;
        }

        private void btNovelllePartie_Click(object sender, EventArgs e)
        {
            this._parent.nouvellePartie();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this._parent.quit();
        }
    }
}
