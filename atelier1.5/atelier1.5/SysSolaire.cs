using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier1._5
{
    class SysSolaire : ObjetCeleste
    {
        List<Soleil> _listSoleil;
        public SysSolaire()
        {
            this.Nom = "";
            _listSoleil = new List<Soleil>();
        }

        public SysSolaire(string nom)
        {
            this.Nom = nom;
            _listSoleil = new List<Soleil>();
        }
        public SysSolaire(string nom, List<Soleil> listeSoleil)
        {
            this.Nom = nom;
            _listSoleil = listeSoleil;
        }

        public override string ToString()
        {
            return "Systeme Solaire : " + base.ToString();
        }
    }
}
