using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fournisseurs_Reconnect
{
    internal class Marque
    {
        int idMarque;
        string nomMarque;

        public Marque(int unId, string unNom)
        {
            this.idMarque = unId;
            this.nomMarque = unNom;
        }

        public int getMarqueId() { return idMarque; }

        public string getNomMarque() { return nomMarque; }

    }
}
