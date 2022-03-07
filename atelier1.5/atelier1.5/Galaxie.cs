using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier1._5
{
    class Galaxie : ObjetCeleste
    {
        List<SysSolaire> _listSS;
        public Galaxie()
        {
            this.Nom = "";
            _listSS = new List<SysSolaire>();
        }
        public Galaxie(string name)
        {
            this.Nom = name;
            _listSS = new List<SysSolaire>();
        }
        public Galaxie(string name, List<SysSolaire> liste)
        {
            this.Nom = name;
            _listSS = liste;
        }

        public override string ToString()
        {
            return "Galaxie : " + base.ToString();
        }
    }
}
