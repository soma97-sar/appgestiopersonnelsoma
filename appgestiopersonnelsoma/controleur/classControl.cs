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
        public List<classPersonnels> GetPersonnels()
        {
            return classdal.GetPersonnels();
        }
        public List<classAbsences> GetAbsences()
        {
            return classdal.GetAbsences();
        }
        //public classResponsables()
        //{
        //    return classdal.GetResponsables();
        //}
        public void DelPersonnels( classPersonnels personnel)
        {
            classdal.DelPersonnels(personnel);
        }
        public void AddPersonnels(classPersonnels personnel)
        {
            classdal.AddPersonnels(personnel);
        }
        public void UpdatePersonnels(classPersonnels personnel)
        {
            classdal.UpdatePersonnels(personnel);
        }
        public void DelAbsences(classAbsences absence)
        {
            classdal.DelAbsences(absence);
        }
        public void AddAbsences(classAbsences absence)
        {
            classdal.AddAbsences(absence);
        }
        public void UpdateAbsences(classAbsences absence)
        {
            classdal.UpdateAbsences(absence);
        }
        //public static Boolean Controlelogin(string login, string pwd)
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
