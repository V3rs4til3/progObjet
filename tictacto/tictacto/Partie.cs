using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictacto
{
    public class Partie
    {
        TicTacToe _parent;
        Plateau monPlateau;
        int _tours;
        public Partie(TicTacToe controller)
        {
            _parent = controller;
            monPlateau = new Plateau(this);
            _tours = 0;
        }

        public string tourJoueur(int laCase)
        {
            if (_tours % 2 == 0)
                return "X";
            return "O";
        }

        public void jouer(string leJoueur, int laCase)
        {
            monPlateau.jouerTour(leJoueur, laCase);
        }


        public bool isUsed(int laCase)
        {
            return monPlateau.isUsed(laCase);
        }

        public bool isWon(string joueur)
        {
            if (monPlateau.isWon(joueur))
                return true;
            return false;
        }

        public int Tours
        {

            get { return _tours; }
            set { _tours++; }
        }

    }
}
