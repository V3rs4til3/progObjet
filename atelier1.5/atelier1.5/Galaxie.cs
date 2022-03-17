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

        public Galaxie(string name) : base(name)
        {
            _listSS = new List<SysSolaire>();
        }
        public Galaxie(string name, List<SysSolaire> liste) : base(name)
        {
            _listSS = liste;
        }

        public override string ToString()
        {
            return "Galaxie : " + base.ToString();
        }

        public void addSys(SysSolaire systeme)
        {
            _listSS.Add(systeme);
        }

        public void addTout(List<SysSolaire> listSolaire)
        {
            listSolaire.ForEach(add);
        }
        void add(SysSolaire systeme)
        {
            _listSS.Add(systeme);
        }

        public void listToString()
        {
            foreach (SysSolaire systeme in _listSS)
            {
                systeme.ToString();
            }
        }
    }
}
