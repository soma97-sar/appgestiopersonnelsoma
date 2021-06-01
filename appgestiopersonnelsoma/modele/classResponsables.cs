using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appgestiopersonnelsoma.modele
{
   public class classResponsables
    {
        private string login;
        private string pwd;


        public string Login { get => login; }
        public string Pwd { get => pwd; }

      


        public classResponsables (string login, string pwd)
        {

            this.login = login;
            this.pwd = pwd;


        }

    }
}
