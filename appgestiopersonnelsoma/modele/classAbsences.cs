using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appgestiopersonnelsoma.modele
{
    /// <summary>
    /// classe des absences
    /// </summary>
   public class classAbsences
    {
        private int idpersonnel;
        private string datedebut;
        private string datefin;
        private int idmotif;
        /// <summary>
        /// les variables
        /// </summary>

        public int Idpersonnel { get { return this.idpersonnel; }  }
        public string Datedebut { get { return datedebut; } }
        public string Datefin { get { return this.datefin; } }
        public int Idmotif { get { return this.idmotif; } }
        public int V3 { get; }
        public int V4 { get; }

        /// <summary>
        /// les variables
        /// </summary>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="idmotif"></param>
        /// <param name="idpersonnel"></param>

      

        public classAbsences (string datedebut, string datefin, int idmotif, int idpersonnel)
        {
            this.idpersonnel = idpersonnel;
            this.datedebut = datedebut;
            this.datefin = datefin;
            this.idmotif = idmotif;

        }


    }
}

    

