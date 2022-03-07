using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier1._5
{
    class Planete : IComparable
    {
        String _nom;
        double _rayon;
        float _masse;
        List<Lune> _cLune;

        public Planete()
        {
            _nom = "";
            _rayon = 0;
            _masse = 0;
            _cLune = new List<Lune>();
        }

        public Planete(String nomPlanete, double rayonPlanete, float massePlanete)
        { //constructeur planete minimum parametre
            if (rayonPlanete > 0 && massePlanete > 0)
            {
                nomPlanete = String.Concat(nomPlanete.Where(char.IsLetterOrDigit));
                _nom = nomPlanete;
                _rayon = rayonPlanete;
                _masse = massePlanete;
                _cLune = new List<Lune>();
            }
        }

        public Planete(String nomPlanete, double rayonPlanete, float massePlanete, List<Lune> listLune)
        { //constructeur planete minimum parametre
            if (rayonPlanete > 0 && massePlanete > 0)
            {
                nomPlanete = String.Concat(nomPlanete.Where(char.IsLetterOrDigit));
                _nom = nomPlanete;
                _rayon = rayonPlanete;
                _masse = massePlanete;
                _cLune = listLune;
                _cLune = new List<Lune>();
            }
        }

        public Lune this[int index]
        {
            get
            {
                return this._cLune[index];
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            Planete planete = obj as Planete;
            if (this.Nom == planete.Nom && this.Rayon == planete.Rayon && this.Masse == planete.Masse)
                return true;

            return false;
        }

        public override string ToString()
        {
            return "Planete :" + this.Nom + " , rayon de :" + this.Rayon + " , masse de : " + this.Masse + ", as " + this._cLune.Count() + " lunes";
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Planete planete = obj as Planete;
            if (this.Rayon > planete.Rayon) return 1;
            else if (this.Rayon == planete.Rayon) return 0;
            return 1;
        }

        public void addLune(Lune laLune)
        {
            this._cLune.Add(laLune);
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

        public List<Lune> ListedeLune
        {
            get
            {
                return _cLune;
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

        public static bool operator >(Planete pln1, Planete pln2)
        {
            if (pln2.Masse > pln1.Masse)
                return false;
            return true;
        }

        public static bool operator <(Planete pln1, Planete pln2)
        {
            if (pln2.Masse > pln1.Masse)
                return false;
            return true;
        }

        public static double operator +(Planete pln1, Planete pln2)
        {
            return pln1.Masse + pln2.Masse;
        }

        public static double operator -(Planete pln1, Planete pln2)
        {
            return pln1.Masse - pln2.Masse;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier1._5
{
    class Planete
    {
    }
}
