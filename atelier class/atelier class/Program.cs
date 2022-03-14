using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Planete terre = new Planete("terre", 25, 500);
            Lune lune = new Lune("Lune", 12, 200);
            terre.addLune(lune);
            string nomLune = lune.Nom;
            terre.ListedeLune.IndexOf(lune);
        }
    }
}
