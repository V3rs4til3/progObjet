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
            _mesCases = new Case[10];
            for(int i = 0; i < _mesCases.Length; i++)
            {
                _mesCases[i] = new Case(this);
            }
            _maPartie = laPartie;
        }

        public bool isUsed(int laCase)
        {
            if (_mesCases[laCase].Used)
                return true;
            return false;
        }

        public void jouerTour(string joueur, int laCase)
        {
            _mesCases[laCase].Joueur = joueur;
            _mesCases[laCase].Used = true;

        }

        public bool isWon(string joueur)
        {
            if (_mesCases[0].Joueur == joueur && _mesCases[1].Joueur == joueur && _mesCases[2].Joueur == joueur)
                return true;
            else if (_mesCases[3].Joueur == joueur && _mesCases[4].Joueur == joueur && _mesCases[5].Joueur == joueur)
                return true;
            if (_mesCases[6].Joueur == joueur && _mesCases[7].Joueur == joueur && _mesCases[8].Joueur == joueur)
                return true;
            return false;
        }
        
    }
}
