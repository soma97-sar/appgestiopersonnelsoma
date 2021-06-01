using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appgestiopersonnelsoma.modele
{
   public class classPersonnels
    {
        private int idpersonnel;
        private string nom;
        private string prenom;
        private string tel;
        private string mail;

        private int idservice;


        public int Idpersonnel { get => idpersonnel; }
        public string Nom { get => nom; }
        public string Prenom { get => prenom; }
        public string Tel { get => tel; }
        public string Mail { get => mail; }

        public int Idservice { get => idservice; }



      

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
    


    

