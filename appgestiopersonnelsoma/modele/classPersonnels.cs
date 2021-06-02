using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appgestiopersonnelsoma.modele
{
    /// <summary>
    /// class personnell
    /// </summary>
   public class classPersonnels
    {
        private int idpersonnel;
        private string nom;
        private string prenom;
        private string tel;
        private string mail;

        private int idservice;
        /// <summary>
        /// les variables
        /// </summary>

        public int Idpersonnel { get { return this.idpersonnel; } }
        public string Nom { get { return this.nom; } }
        public string Prenom { get { return this.prenom; } }
        public string Tel { get { return this.tel; } }
        public string Mail { get { return this.mail; } }

        public int Idservice { get { return this.idservice; } }

        /// <summary>
        /// les variables
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="idservice"></param>
        /// <param name="mail"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>

      

        public classPersonnels(int idpersonnel, int idservice, string mail, string nom, string prenom, string tel)
        {
            this.idpersonnel = idpersonnel;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.mail = mail;
            this.idservice = idservice;

        }

    }
}
    


    

