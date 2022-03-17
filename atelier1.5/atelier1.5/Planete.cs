using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier1._5
{
    class Planete : Astre, IComparable
    {
        List<Lune> _cLune;
        public Planete(string name) : base(name)
        {
            _cLune = new List<Lune>();
        }

        public Planete(SysSolaire systeme):base("")
        {
            _cLune = new List<Lune>();
            systeme.addAstre(this);
            this.Parent = systeme;
        }

        public Planete(SysSolaire systeme, double rayon, float masse) : base(rayon, masse)
        {
            _cLune = new List<Lune>();
            systeme.addAstre(this);
            this.Parent = systeme;
        }

        public Planete(SysSolaire systeme, string name) : base(name)
        {
            _cLune = new List<Lune>();
            systeme.addAstre(this);
            this.Parent = systeme;
        }

        public Planete(SysSolaire systeme, string name, double rayon, float masse) : base(name, rayon, masse)
        {
            _cLune = new List<Lune>();
            systeme.addAstre(this);
            this.Parent = systeme;
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
            string stringPlanete = "Planete :" + this.Nom + " , rayon de :" + this.Rayon + " , masse de : " + this.Masse;
            
            stringPlanete.Insert(stringPlanete.Last(), " { ( ");
            foreach (Lune lune in this._cLune)
            {
                    stringPlanete.Insert(stringPlanete.Last(), lune.ToString() + " ) , ( ");
            }
            stringPlanete.Insert(stringPlanete.Last(), " ) } ");
            return stringPlanete;
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

