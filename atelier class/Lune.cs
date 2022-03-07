using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier_class
{
    class Lune : Planete
    {
        String _nom;
        double _rayon;
        float _masse;

        //lune vierge
        public Lune()
        {
            _nom = "";
            _rayon = 0;
            _masse = 0;
        }

        //lune sans nom
        public Lune(double rayon, float masse)
        {
            if (rayon > 0 && masse > 0)
            {
                _nom = "";
                _rayon = rayon;
                _masse = masse;
            }
        }

        //lune complete
        public Lune(String nom, double rayon, float masse)
        {
            if (rayon > 0 && masse > 0)
            {
                _nom = String.Concat(nom.Where(char.IsLetterOrDigit));
                _rayon = rayon;
                _masse = masse;
            }
        }
       
    }
}
