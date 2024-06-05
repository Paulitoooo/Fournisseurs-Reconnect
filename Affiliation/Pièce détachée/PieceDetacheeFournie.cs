using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fournisseurs_Reconnect.Fournisseur;
using Fournisseurs_Reconnect.PieceDetachee;

namespace Fournisseurs_Reconnect.Affiliation.Pièce_détachée
{
    public  class PieceDetacheeFournie
    {
        Fournisseurs Fournisseur;
        PieceDetachees pieceDetachee;
        float prix;
        string site;

        public PieceDetacheeFournie(Fournisseurs unFournisseur,PieceDetachees unePieceDetachee,float unPrix, string unSite)
        {
            this.Fournisseur = unFournisseur;
            this.pieceDetachee = unePieceDetachee;
            this.prix = unPrix;
            this.site = unSite;
        }

        public string getSitePieceDetachee() { return site; }

        public float getPrix() { return prix; }

        public int getIdFourisseur() { return Fournisseur.getIdFournisseur(); }

        public int getIdPieceDetachee() { return pieceDetachee.getIdPieceDetachee(); }

        public string getNomModelePourPieceDetachee() { return pieceDetachee.getNomModele(); }
    }
}
