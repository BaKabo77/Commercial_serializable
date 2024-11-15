using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCommerciauxV2
{
    public class Nuite : NoteFrais
    {
        private char region;
        private double montantFacture;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="leCommercial"></param>
        /// <param name="montantFacture"></param>
        /// <param name="region"></param>
        public Nuite(DateTime date, Commercial leCommercial, double montantFacture, char region)
    : base(date, leCommercial)
        {
            this.montantFacture = montantFacture;
            this.region = region;
            this.MontantARembourser = calculMontantARembourser();
        }
        override public double calculMontantARembourser()
        {
            char categorie = this.LeCommercial.Categorie;
            double remboursement = 0;
            switch (categorie)
            {
                case 'A': { remboursement = 65; break; }
                case 'B': { remboursement = 55; break; }
                case 'C': { remboursement = 50; break; }
            }
            switch (this.region)
            {
                case '1': { remboursement *= 0.9; break; }
                case '2': { remboursement *= 1; break; }
                case '3': { remboursement *= 1.15; break; }
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
            string ch = $"Nuité - {base.ToString()} - payé : {this.montantFacture} € - {this.region} -";
            return ch;
        }
    }
}

