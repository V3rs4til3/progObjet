using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictacto
{
    public class TicTacToe
    { 
        public FormMenu leMenu;
        public FormPartie laPartie;
        public Partie maPartie;

        [STAThread]
        static void Main()
        {
            TicTacToe leTicTacToe = new TicTacToe();
        }
        public TicTacToe()
        {
            leMenu = new FormMenu(this);
            Application.Run(leMenu);
            Application.Run(laPartie);
        }

        public void nouvellePartie()
        {
            // creer la partie
            maPartie = new Partie(this);
            //creer la form de la partie
            laPartie = new FormPartie(this);
            laPartie.Show();
            leMenu.Hide();
        }

        public void quit()
        {
            Application.Exit();
        }

        public void quitPartie()
        {
            laPartie?.Dispose();
            laPartie = null;
            leMenu.Show();
        }

        public void jouerTour(Button btn)
        {
            if (!maPartie.isUsed(Int32.Parse(btn.Name.Remove(0, 6))))
            {
                //toDo


                //btn.Text =
            }
            else
            {
                string message = "La case est deja utiliser";
                string caption = "Case utiliser";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }
        }

    }
}
