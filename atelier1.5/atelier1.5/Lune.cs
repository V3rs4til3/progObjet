using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier1._5
{
    class Lune : Astre
    {
        //lune vierge
        public Lune():base(){}

        public Lune(Planete planeteMere):base()
        {
            if(planeteMere != null)
            {
                planeteMere.addLune(this);
                Parent = planeteMere;
            }
        }

        public Lune(Planete planeteMere, string name):base(name)
        {
            planeteMere.addLune(this);
            Parent = planeteMere;
        }
        public Lune(Planete planeteMere, string name, double rayon, float masse) : base(name, rayon, masse)
        {
            planeteMere.addLune(this);
            Parent = planeteMere;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            Lune lune = obj as Lune;
            if (this.Nom == lune.Nom && this.Rayon == lune.Rayon && this.Masse == lune.Masse)
                return true;

            return false;
        }

        public override string ToString()
        {
            return "Lune :" + this.Nom + " , rayon de :" + this.Rayon + " , masse de : " + this.Masse;
        }

        new public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Lune lune = obj as Lune;
            if (this.Rayon > lune.Rayon) return 1;
            else if (this.Rayon == lune.Rayon) return 0;
            return 1;
        }

        new public Planete Parent
        {
            get { return this.Parent; }
            set { this.Parent = value; }
        }
    }
}
