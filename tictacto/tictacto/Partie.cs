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
        Plateau lePlateau;
        int tours;
        public Partie(TicTacToe controller)
        {
            _parent = controller;
            lePlateau = new Plateau(this);
            tours = 0;
        }

        public string tourJoueur()
        {
            if(tours % 2 == 0)
                return "X";
            return "O";
        }

        public bool isUsed(int laCase)
        {
            return lePlateau.isUsed(laCase);
        }
    }
}
