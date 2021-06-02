using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appgestiopersonnelsoma.modele
{
    /// <summary>
    /// class responsable
    /// </summary>
   public class classResponsables
    {
        private string login;
        private string pwd;
        /// <summary>
        /// les variables
        /// </summary>

        public string Login { get { return this.login; } }
        public string Pwd { get {return this.pwd; } }

      
        /// <summary>
        /// les variables
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>

        public classResponsables (string login, string pwd)
        {

            this.login = login;
            this.pwd = pwd;


        }

    }
}
