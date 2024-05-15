using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fournisseurs_Reconnect
{
    internal class Appareil
    {
        int idAppareil;
        string typeAppareil;
        Marque Marque;
        string modele;
        int stockageAppareil;
        bool Neuf;

        public Appareil(int idAppareil, string typeAppareil, Marque marque, string modele, int stockageAppareil, bool neuf)
        {
            this.idAppareil = idAppareil;
            this.typeAppareil = typeAppareil;
            Marque = marque;
            this.modele = modele;
            this.stockageAppareil = stockageAppareil;
            Neuf = neuf;
        }
        public int getIdAppareil() { return idAppareil; }

        public string getModeleAppareil() { return  modele; }
    }
}
