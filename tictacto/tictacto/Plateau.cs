using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictacto
{
    public class Plateau
    {

        Case[] _mesCases;
        Partie _maPartie;

        public Plateau(Partie laPartie)
        {
            _mesCases = new Case[9];
            _maPartie = laPartie;
        }

        public bool isUsed(int laCase)
        {
            if (_mesCases[laCase].Name == 1)
                return false;
            return true;
        }

        
    }
}
