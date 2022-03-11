using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier1._5
{
    abstract class Astre : ObjetCeleste
    {
        SysSolaire _parent;
        double _rayon;
        float _masse;

        public Astre():base("")
        {
            _rayon = 0;
            _masse = 0;
        }
        public Astre(double rayon, float masse) : base("")
        {
            _rayon = rayon;
            _masse= masse;
        }

        public Astre(string name) : base(name)
        {
            _rayon = 0;
            _masse = 0;
        }

        public Astre(string name,double rayon, float masse) : base(name)
        {
            _rayon = rayon;
            _masse = masse;
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

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            Astre unAstre = obj as Astre;
            if (this.Nom == unAstre.Nom && this.Rayon == unAstre.Rayon && this.Masse == unAstre.Masse)
                return true;

            return false;
        }

        public SysSolaire Parent
        {
            get { return _parent; }
            set { _parent = value; }
        }
    }
}
