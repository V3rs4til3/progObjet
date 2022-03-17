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
        public SysSolaire():base("")
        {
            _listAstre = new List<Astre>();
        }

        public SysSolaire(Galaxie galaxie):base("")
        {
            _listAstre = new List<Astre>();
            _parent = galaxie;
        }

        public SysSolaire(Galaxie galaxie,string nom):base(nom)
        {
            _listAstre = new List<Astre>();
            _parent = galaxie;
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
            get { return _listAstre; }
        }

        public void ajouterSoleil(string name)
        {
            new Soleil(this, name);
        }
    }
}
