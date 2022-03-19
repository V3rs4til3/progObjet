using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictacto
{
    public class Case
    {
        bool _isUsed;
        string _joueur;
        Plateau _monPlateau;

        public Case(Plateau lePlateau)
        {
            _monPlateau = lePlateau;
            _isUsed = false;
        }

        public bool Used
        {
            get { return _isUsed; }

            set { _isUsed = value; }
        }


        public string Joueur
        {
            get { return _joueur; }

            set { _joueur = value; }
        }

    }
}
