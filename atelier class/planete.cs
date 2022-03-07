using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier_class
{
    internal class Planete
    {
        String _nom;
        double _rayon;
        float _masse;

        public Planete()
        {
            _nom = "";
            _rayon = 0;
            _masse = 0;
        }

        public Planete(String nomPlanete, double rayonPlanete, float massePlanete)
        { //constructeur planete minimum parametre
            if (rayonPlanete > 0 && massePlanete > 0)
            {
                nomPlanete = String.Concat(nomPlanete.Where(char.IsLetterOrDigit));
                _nom = nomPlanete;
                _rayon = rayonPlanete;
                _masse = massePlanete;
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

        public float Volume
        {
            get
            {
                return calculVolume(this);
            }
        }

        public double MasseVolumique
        {
            get
            {
                return calculMasseVol(this);
            }
        }

        public double Superficie
        {
            get
            {
                return calculSuperficie(this);
            }
        }

        public float calculVolume(Planete pln1)
        {
            double volume = (4 * Math.PI * Math.Pow(pln1.Rayon, 3)) / 3;
            return (float)volume;
        }

        public double calculSuperficie(Planete pln1)
        {
            double superficie = 4 * Math.PI * Math.Pow(pln1.Rayon, 2);
            return superficie;
        }

        public double calculMasseVol(Planete pln1)
        {
            double masseVol = 0;

            if (pln1.Masse > 0 && pln1.Volume > 0)
                masseVol = pln1.Masse / pln1.Volume;
            return masseVol;
        }

        public bool estEgal(Planete pln1, Planete pln2)
        {
            if (pln1.Nom == pln2.Nom && pln1.Rayon == pln2.Rayon && pln1.Masse == pln2.Masse)
                return true;

            return false;
        }

        public Planete plusVolumineuse(Planete pln1, Planete pln2)
        {
            if (pln2.Volume > pln1.Volume)
                return pln2;
            return pln1;

        }

        public Planete plusMassive(Planete pln1, Planete pln2)
        {
            if (pln2.Masse > pln1.Masse)
                return pln2;
            return pln1;
        }
    }
}
