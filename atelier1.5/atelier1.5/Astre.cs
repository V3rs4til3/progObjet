using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier1._5
{
    abstract class Astre : SysSolaire
    {
        double _rayon;
        float _masse;

        public double Rayon
        {
            get { return _rayon; }

            set
            {
                if (value > 0)
                    _rayon = value;
            }
        }

        public double Masse
        {
            get { return _masse; }

            set
            {
                if (value > 0)
                    _masse = (float)value;
            }
        }
    }
}
