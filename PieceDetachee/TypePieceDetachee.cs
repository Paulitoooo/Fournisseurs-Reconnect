using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fournisseurs_Reconnect.PieceDetachee
{
    public class TypePieceDetachee
    {
        int idTypePieceDetachee;
        string libelleTypePieceDetachee;

        public TypePieceDetachee(int idTypePieceDetachee, string libelleTypePieceDetachee)
        {
            this.idTypePieceDetachee = idTypePieceDetachee;
            this.libelleTypePieceDetachee = libelleTypePieceDetachee;
        }

        public int getIdTypePieceDetachee()
        {
            return this.idTypePieceDetachee;
        }

        public string getLibelleTypePieceDetachee()
        {
            return this.libelleTypePieceDetachee;
        }
    }
}
