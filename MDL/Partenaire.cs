using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDL
{
    class Partenaire
    {
        private Boolean cluborganisateur;
        private Boolean equipementier;

        public Partenaire(Boolean unClub, Boolean unEquip)
        {
            this.cluborganisateur = unClub;
            this.equipementier = unEquip;
        }

    }

}
