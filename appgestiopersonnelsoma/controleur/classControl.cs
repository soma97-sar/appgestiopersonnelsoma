using System;
using System.Collections.Generic;
using appgestiopersonnelsoma.dal;
using appgestiopersonnelsoma.modele;
using appgestiopersonnelsoma.vue;
using appgestiopersonnelsoma.connexion;
using System.Threading.Tasks;

namespace appgestiopersonnelsoma.controleur
{
    public class classControl
    {
        //public classControl()
        //{
        //    (new responsablegestioper(this)).ShowDialog();
        //}
        /// <summary>
        /// getpersonnel
        /// </summary>
        /// <returns></returns>
        public List<classPersonnels> GetPersonnels()
        {
            return classdal.GetPersonnels();
        }
        /// <summary>
        /// getabsence
        /// </summary>
        /// <returns></returns>
        public List<classAbsences> GetAbsences()
        {
            return classdal.GetAbsences();
        }
        //public classResponsables()
        //{
        //    return classdal.GetResponsables();
        //}
        /// <summary>
        /// delpersonnel
        /// </summary>
        /// <param name="personnel"></param>
        public void DelPersonnels( classPersonnels personnel)
        {
            classdal.DelPersonnels(personnel);
        }
        /// <summary>
        /// addpersonnel
        /// </summary>
        /// <param name="personnel"></param>
        public void AddPersonnels(classPersonnels personnel)
        {
            classdal.AddPersonnels(personnel);
        }
        /// <summary>
        /// updatepersonnel
        /// </summary>
        /// <param name="personnel"></param>
        public void UpdatePersonnels(classPersonnels personnel)
        {
            classdal.UpdatePersonnels(personnel);
        }
        /// <summary>
        /// delabsence
        /// </summary>
        /// <param name="absence"></param>
        public void DelAbsences(classAbsences absence)
        {
            classdal.DelAbsences(absence);
        }
        /// <summary>
        /// addabsence
        /// </summary>
        /// <param name="absence"></param>
        public void AddAbsences(classAbsences absence)
        {
            classdal.AddAbsences(absence);
        }
        /// <summary>
        /// updateabsence
        /// </summary>
        /// <param name="absence"></param>
        public void UpdateAbsences(classAbsences absence)
        {
            classdal.UpdateAbsences(absence);
        }
        /// <summary>
        /// validelogin
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        
        public static Boolean ValidateLogin(string login, string pwd)
        {

            if (classdal.Controlelogin(login, pwd))
            {
                return true;
            }
            else
            {
                return false;
            }
        }








    }
}
