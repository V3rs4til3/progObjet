using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier1._5
{
    class Soleil : Astre
    { 
        public Soleil():base(){}
        public Soleil(SysSolaire systeme):base()
        {
            systeme.addAstre(this);
            Parent = systeme;
        }
        public Soleil(SysSolaire systeme, String nom):base(nom)
        {
            systeme.addAstre(this);
            Parent = systeme;
        }

        public Soleil(SysSolaire systeme,  String nom, double rayon, float masse):base(nom, rayon , masse)
        {
            systeme.addAstre(this);
            Parent = systeme;
        }

        public override string ToString()
        {
            return "Soleil : " + base.ToString();
        }
    }
}
