using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier1._5
{
    class SysSolaire : ObjetCeleste
    {
        Galaxie _parent;
        List<Astre> _listAstre;
        public SysSolaire()
        {
            this.Nom = "";
            _listAstre = new List<Astre>();
        }

        public SysSolaire(Galaxie galax)
        {
            this.Nom = "";
            _listAstre = new List<Astre>();
            base.addSys(this);
        }

        public SysSolaire(string nom)
        {
            this.Nom = nom;
            _listAstre = new List<Astre>();
        }
        public SysSolaire(string nom, List<Astre> listeSoleil)
        {
            this.Nom = nom;
            _listAstre = listeSoleil;
        }

        public override string ToString()
        {
            return "Systeme Solaire : " + base.ToString();
        }

        public void addAstre(Astre obj)
        {
            _listAstre.Add(obj);
        }

        public List<Astre> listAstre
        {
            get
            {
                return _listAstre;
            }
        }

        public SysSolaire this[int index]
        {

        } 
    }
}
