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
    public partial class FormPartie : Form
    {
        TicTacToe _parent;
        public FormPartie(TicTacToe controller)
        {
            InitializeComponent();
            _parent = controller;
        }

        private void FormPartie_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parent.quitPartie();
        }

        private void click(object sender, EventArgs e)
        {
            _parent.jouerTour((Button)sender);
           
        }
    }
}
