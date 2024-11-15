using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCommerciauxV2
{
    public class ServiceCommercial
    {

        public List<Commercial> LesCommerciaux { get; set; }
       
        public List<NoteFrais> MesNotes { get; set; }

        public DateTime Date { get; set; }

        public ServiceCommercial() { 
            this.MesNotes = new List<NoteFrais>();
            this.LesCommerciaux = new List<Commercial>(); }


        public void ajouterCommercial(Commercial c)
        {
     
            LesCommerciaux.Add(c);
        }
        //public int NbFraisNonRembourses()
        //{
        //    int nb = 0;
        //    foreach (Commercial c in this.LesCommerciaux)
        //    {
        //        foreach (NoteFrais nf in c.MesNotes)
        //        {
        //            if (!nf.EstRembourse)
        //                nb++;
        //        }
        //    }
        //    return nb;
        //}
        public void AjouterNote(Commercial c, DateTime date, int nbKm)
        {
            this.MesNotes.Add(new FraisTransport(date, c, nbKm));
        }

        public void ajouterNote(Commercial c, DateTime d, double montant)
        {
            c.AjouterNote(d, montant);
            Date = d;
        }

        //public void ajouterNote(Commercial c, DateTime d, double montant, string commentaire)
        //{
        //    c.AjouterNote(d, montant, commentaire);
        //    Date = d;
        //}
        public void AjouterNote( DateTime d,Commercial c)
        {
            //c.AjouterNote(d, c);
            this.MesNotes.Add(new NoteFrais(d,c));
        }
        public string AfficherNote()
        {
            string s = "";
            foreach (NoteFrais noteFrais in this.MesNotes)
            {
                s += noteFrais.ToString() + " ";
            }
            return s;
        }
        public string AfficherCommerciaux()
        {
            string s = "";
            foreach (Commercial leCommercial in this.LesCommerciaux)
            {
                s += leCommercial.ToString() + "\n";
            }
            return s;
        }
    }
}
