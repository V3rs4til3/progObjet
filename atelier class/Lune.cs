using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier_class
{
    class Lune : Planete
    {
        //lune vierge
        public Lune()
        {
            this.Nom = "";
            this.Rayon = 0;
            this.Masse = 0;
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

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Lune lune = obj as Lune;
            if (this.Rayon > lune.Rayon) return 1;
            else if (this.Rayon == lune.Rayon) return 0;
            return 1;
        }

    }
}
