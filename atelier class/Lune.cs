using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier_class
{
    class Lune
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
            if(rayon > 0 && masse > 0)
            {
                _nom = String.Concat(nom.Where(char.IsLetterOrDigit));
                _rayon = rayon;
                _masse = masse;
            }
        }
        public string Nom
        {
            get { return _nom; }

            set
            {
                value = String.Concat(value.Where(char.IsLetterOrDigit));
                _nom = value;
            }
        }

        public double Rayon
        {
            get { return _rayon; }

            set
            {
                if (value > 0)
                    _rayon = value;
            }
        }

        public double Masse
        {
            get { return _masse; }

            set
            {
                if (value > 0)
                    _masse = (float)value;
            }
        }

        public double Volume
        {
            get
            {
                return 4 * Math.PI * Math.Pow(this.Rayon, 3) / 3;
            }
        }

        public double Superficie
        {
            get
            {
                return 4 * Math.PI * Math.Pow(this.Rayon, 2);
            }
        }

        public double MasseVolumique
        {
            get
            {
                return this.Masse / this.Volume;
            }
        }

        public bool estEgal(Lune pln2)
        {
            return (this.Nom == pln2.Nom && this.Rayon == pln2.Rayon && this.Masse == pln2.Masse) ? true : false;
        }

        public Lune plusVolumineuse(Lune pln2)
        {
            return pln2.Volume > this.Volume ? pln2 : this;
        }

        public Lune plusMassive(Lune pln2)
        {
            return pln2.Masse > this.Masse ? pln2 : this;
        }
    }
}
