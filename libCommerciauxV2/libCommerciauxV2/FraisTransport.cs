using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCommerciauxV2
{
    public class FraisTransport : NoteFrais
    {
        private int nbKm;
        public FraisTransport() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="leCommercial"></param>
        /// <param name="nbKm"></param>
        public FraisTransport(DateTime date, Commercial leCommercial, int nbKm)
    : base(date, leCommercial)
        {
            this.nbKm = nbKm;
            this.MontantARembourser = calculMontantARembourser();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        override public double calculMontantARembourser()
        {
            double coef;
            int puissance = this.LeCommercial.PuissanceVoiture;
            if (puissance < 5)
                coef = 0.1;
            else
                if (puissance < 10)
                coef = 0.2;
            else
                coef = 0.3;
            return coef * this.nbKm;
        }
        public override string ToString()
        {
            string ch = $"Transport - {base.ToString()} - {this.nbKm} km-";
            return ch;
        }
    }
}
