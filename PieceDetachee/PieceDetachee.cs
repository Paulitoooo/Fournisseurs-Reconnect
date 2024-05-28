using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fournisseurs_Reconnect
{
    public class PieceDetachees
    {
        int idPieceDetachee;
        int idTypePieceDetachee;
        string nomModelAppareil;
        string nomPieceDetachee;

        public PieceDetachees(int idPieceDetachee, int idTypePieceDetachee, string nomModelAppareil, string nomPieceDetachee)
        {
            this.idPieceDetachee = idPieceDetachee;
            this.idTypePieceDetachee = idTypePieceDetachee;
            this.nomModelAppareil = nomModelAppareil;
            this.nomPieceDetachee = nomPieceDetachee;
        }

        public int getIdPieceDetachee() { return idPieceDetachee; }

        public int getIdTypePieceDetachee() { return idTypePieceDetachee; }

        public string getNomModele() { return nomModelAppareil; }

        public string getNomPieceDetachee() { return nomPieceDetachee; }


    }
}
