
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fournisseurs_Reconnect.Accessoires
{
    public class Accessoire
    {
        int idAccessoire;
        int idTypeAccessoire;
        int idMarqueAccessoire;
        string nomAccessoire;

        public Accessoire(int idAccessoire, int idTypeAccessoire, int idMarqueAccessoire, string nomAccessoire)
        {
            this.idAccessoire = idAccessoire;
            this.idTypeAccessoire = idTypeAccessoire;
            this.idMarqueAccessoire = idMarqueAccessoire;
            this.nomAccessoire = nomAccessoire;
        }

        public int getIdAccessoire() { return idAccessoire; }


        public int getIdTypeAccessoire() { return idTypeAccessoire; }

        public int getIdMarqueAccessoire() { return idMarqueAccessoire; }

        public string getNomAccessoire()
        {
            return nomAccessoire;

        }
    }
}
