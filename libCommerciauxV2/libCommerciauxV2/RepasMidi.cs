using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCommerciauxV2
{
    internal class RepasMidi:NoteFrais
    {
        private double montantFacture;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="leCommercial"></param>
        /// <param name="montantFacture"></param>
        public RepasMidi(DateTime date, Commercial leCommercial, double montantFacture)
    : base(date, leCommercial)
        {
            this.montantFacture = montantFacture;
            this.MontantARembourser = calculMontantARembourser();
        }
        override public double calculMontantARembourser()
        {
            char categorie = this.LeCommercial.Categorie;
            double remboursement = 0;
            switch (categorie)
            {
                case 'A': { remboursement = 25; break; }
                case 'B': { remboursement = 22; break; }
                case 'C': { remboursement = 20; break; }
            }
            if (remboursement >= this.montantFacture)
                remboursement = this.montantFacture;
            return remboursement;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string ch = $"Repas - {base.ToString()} - payé : {this.montantFacture} €";
            return ch;
        }
    }
}
