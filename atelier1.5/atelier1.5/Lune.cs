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

        public Lune(Planete planeteMere, String nom, double rayon, float masse)
        {
            this.Nom = String.Concat(nom.Where(char.IsLetterOrDigit));
            this.Rayon = rayon;
            this.Masse = masse;
            planeteMere.addLune(this);
            Parent = planeteMere;
        }

        //lune sans nom
        public Lune(double rayon, float masse)
        {
            if (rayon > 0 && masse > 0)
            {
                this.Nom = "";
                this.Rayon = rayon;
                this.Masse = masse;
            }
        }

        //lune complete
        public Lune(String nom, double rayon, float masse)
        {
            if (rayon > 0 && masse > 0)
            {
                this.Nom = String.Concat(nom.Where(char.IsLetterOrDigit));
                this.Rayon = rayon;
                this.Masse = masse;
            }
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
