using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appgestiopersonnelsoma.modele
{
   public class classAbsences
    {
        private int idpersonnel;
        private string datedebut;
        private string datefin;
        private int idmotif;


        public int Idpersonnel { get => idpersonnel; }
        public string Datedebut { get => datedebut; }
        public string Datefin { get => datefin; }
        public int Idmotif { get => idmotif; }
        public int V3 { get; }
        public int V4 { get; }



      

        public classAbsences (string datedebut, string datefin, int idmotif, int idpersonnel)
        {
            this.idpersonnel = idpersonnel;
            this.datedebut = datedebut;
            this.datefin = datefin;
            this.idmotif = idmotif;

        }


    }
}

    

