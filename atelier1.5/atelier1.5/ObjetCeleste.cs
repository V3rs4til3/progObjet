using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier1._5
{
    public abstract class ObjetCeleste
    {
        string _nom;
        ObjetCeleste _parent;
        public ObjetCeleste(){}
        public ObjetCeleste(String nom)
        {
            _nom = nom;
        }

        public string Nom
        {
            get
            {
                return _nom;
            }
            set
            {
                value = String.Concat(value.Where(char.IsLetterOrDigit));
                this.Nom = value;
            }
        }

        public override string ToString()
        {
            return this._nom;
        }

        public virtual ObjetCeleste Parent
        {
            get { return this._parent; }
            set { this._parent = value; }
        }
            
    }
}
