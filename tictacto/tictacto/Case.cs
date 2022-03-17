using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictacto
{
    public class Case
    {
        int _name;
        Plateau _monPlateau;

        public Case(Plateau lePlateau)
        {
            _monPlateau = lePlateau;
            _name = 0;
        }

        public int Name
        {
            get { return _name; }
        }

    }
}
