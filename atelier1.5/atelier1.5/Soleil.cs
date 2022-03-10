using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier1._5
{
    class Soleil : Astre
    { 
        public Soleil()
        {
            this.Nom = "";
            this.Masse = 0;
            this.Rayon = 0;
        }
        public Soleil(SysSolaire systeme)
        {
            this.Nom = "";
            this.Masse = 0;
            this.Rayon = 0;
            systeme.addAstre(this);
            Parent = systeme;
        }
        public Soleil(String nom, double rayon, double masse)
        {
            this.Nom = nom;
            this.Masse = masse;
            this.Rayon = rayon;
        }

        public Soleil(SysSolaire systeme,  String nom, double rayon, double masse)
        {
            this.Nom = "";
            this.Masse = 0;
            this.Rayon = 0;
            systeme.addAstre(this);
            Parent = systeme;
        }

        public override string ToString()
        {
            return "Soleil : " + base.ToString();
        }
    }
}
