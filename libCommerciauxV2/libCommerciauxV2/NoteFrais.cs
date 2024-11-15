using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace libCommerciauxV2
{
   
    public class NoteFrais
    {
        private double montantARembourser;
        private bool estRembourse;
        public double MontantARembourser
        {
            get { return montantARembourser; }
            set { this.montantARembourser = calculMontantARembourser(); }
        }

       public Commercial LeCommercial { get; set; }
        public DateTime DateNoteFrais { get; set; }

        public bool EstRembourse
        {
            get { return estRembourse; }
            set { this.estRembourse = true; }
        }
        public int numero;
        public NoteFrais() { }

        public NoteFrais(DateTime d, Commercial c)
        {

            this.DateNoteFrais = d;
           this.LeCommercial = c;
            this.EstRembourse = false;
            //this.LeCommercial.ajouterNoteFrais(this);
            //this.numero = LeCommercial.MesNotes.Count;
            //this.numero = 1;
        }


        virtual public double calculMontantARembourser() { return 0; }
        public override string ToString()
        {
            string s = $"Numéro : {this.numero} - Date : {this.DateNoteFrais} - Montant à rembourser: {this.MontantARembourser} euros";
            if (this.EstRembourse)
            {
                s = s + " - remboursé";
            }
            else
            {
                s = s + " - Non remboursé";
            }
            return s;
        }

    }
}
