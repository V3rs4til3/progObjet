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
        public Plateau monPlateau;
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

        public void plusTours()
        {
            this._tours++;
        }
    }
}
