using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCommerciauxV2
{
    public class Commercial
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int PuissanceVoiture { get; set; }
        public char Categorie { get; set; }
        public List<NoteFrais> MesNotes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nm"></param>
        /// <param name="prn"></param>
        /// <param name="psvtr"></param>
        /// <param name="cat"></param>
        public Commercial(string nm, string prn, int psvtr, char cat)
        {
            this.Nom = nm;
            this.Prenom = prn;
            this.PuissanceVoiture = psvtr;
            this.Categorie = cat;
            this.MesNotes = new List<NoteFrais>();


        }
        public Commercial() { }
        public override string ToString()
        {
            return $"Nom : {this.Nom} Prénom : {this.Prenom} Puissance voiture : {this.PuissanceVoiture} Catégorie : {this.Categorie}";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="f"></param>
        //public void ajouterNoteFrais(NoteFrais f)
        //{
        //    this.MesNotes.Add(f);
        //}

        public string AfficherNote()
        {
            string s = "";
            foreach (NoteFrais noteFrais in MesNotes)
            {
                s += noteFrais.ToString() + " ";
            }
            return s;
        }
        public void AjouterNote(DateTime date, int nbKm)
        {
            FraisTransport ft = new FraisTransport(date, this, nbKm);
        }
        /// <summary>
        /// note repas
        /// </summary>
        /// <param name="date"></param>
        /// <param name="montantFacture"></param>
        public void AjouterNote(DateTime date, double montantFacture)
        {

            RepasMidi rm = new RepasMidi(date, this, montantFacture);
        }
        /// <summary>
        /// note nuite
        /// </summary>
        /// <param name="date"></param>
        /// <param name="montantFacture"></param>
        /// <param name="region"></param>
        public void AjouterNote(DateTime date, double montantFacture, char region)
        {

            Nuite n = new Nuite(date, this, montantFacture, region);
        }



    }
}
