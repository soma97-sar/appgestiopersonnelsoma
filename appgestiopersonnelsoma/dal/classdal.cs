using System;
using System.Collections.Generic;
using appgestiopersonnelsoma.connexion;
using appgestiopersonnelsoma.modele;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace appgestiopersonnelsoma.dal
{
    /// <summary>
    /// la classe dal
    /// </summary>
     public class classdal
    {
        
       
        private static string connectionString = ConfigurationManager.ConnectionStrings["myCnxString"].ConnectionString.ToString();
        /// <summary>
        /// getper
        /// </summary>
        /// <returns></returns>
        public static List<classPersonnels> GetPersonnels()
        {
            List<classPersonnels> lesPersonnels = new List<classPersonnels>();
            string req = "select p.idpersonnels as idpersonnels,p.idservices as idservices, p.mail as mail, p.nom as nom, p.prenom as prenom, p.tel as tel";
            req += " from personnels p join services s on (p.idservices = s.idservices) ";
            connexiondatabase curs =  connexiondatabase.GetInstance();
            curs.ReqSelect(req);
            while (curs.Read())
            {
                classPersonnels personnel = new classPersonnels((int)curs.Field("idpersonnels"), (int)curs.Field("idservices"), (string)curs.Field("mail"), (string)curs.Field("nom"), (string)curs.Field("prenom"), (string)curs.Field("tel"));       
                lesPersonnels.Add(personnel);
            }
            curs.Close();
            return lesPersonnels;

        }
        /// <summary>
        /// getabs
        /// </summary>
        /// <returns></returns>
        public static List<classAbsences> GetAbsences()
        {
            List<classAbsences> lesAbsences = new List<classAbsences>();
            string req = "select a.datedebuts as datedebuts,a.datefins as datefins, a.idmotifs as idmotifs, a.idpersonnels as idpersonnels";
            req += " from absences a join motifs m on (a.idmotifs = m.idmotifs) ";
            connexiondatabase curs = connexiondatabase.GetInstance();
            curs.ReqSelect(req);
            while (curs.Read())
            {
                classAbsences absences = new classAbsences((string)curs.Field("datedebuts"), (string)curs.Field("datefins"), (int)curs.Field("idmotifs"), (int)curs.Field("idpersonnels"));
                lesAbsences.Add(absences);
            }
            curs.Close();
            return lesAbsences;

        }
        /// <summary>
        /// detapersonnel
        /// </summary>
        /// <param name="personnel"></param>
        public static void DelPersonnels(classPersonnels personnel)
        {
            string req = "delete from personnels where idpersonnels = @idpersonnels;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnels", personnel.Idpersonnel);
            connexiondatabase conn = connexiondatabase.GetInstance();
            conn.ReqUpdate(req, parameters);
        }
        /// <summary>
        /// delabs
        /// </summary>
        /// <param name="absence"></param>
        public static void DelAbsences(classAbsences absence)
        {
            string req = "delete from absences where datedebuts = @datedebuts;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@datedebuts", absence.Datedebut);
            connexiondatabase conn = connexiondatabase.GetInstance();
            conn.ReqUpdate(req, parameters);
        }
        /// <summary>
        /// addpers
        /// </summary>
        /// <param name="personnel"></param>
        public static void AddPersonnels(classPersonnels personnel)
        {
            string req = "insert into personnels(nom, prenom, tel, mail, idservices) ";
            req += "values (@nom, @prenom, @tel, @mail, @service;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);
            parameters.Add("@idservices", personnel.Idservice);
          
            connexiondatabase conn = connexiondatabase.GetInstance();
            conn.ReqUpdate(req, parameters);
        }
        /// <summary>
        /// addabs
        /// </summary>
        /// <param name="absence"></param>
        public static void AddAbsences(classAbsences absence)
        {
            string req = "insert into absences(datedebuts, datefins, idmotifs) ";
            req += "values (@datedebuts, @datefins, @idmotifs, @pwd);";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@datedebuts", absence.Datedebut);
            parameters.Add("@datefins", absence.Datefin);
            parameters.Add("@idmotifs", absence.Idmotif);
            
            connexiondatabase conn = connexiondatabase.GetInstance();
            conn.ReqUpdate(req, parameters);
        }
        /// <summary>
        /// updatepers
        /// </summary>
        /// <param name="personnel"></param>
        public static void UpdatePersonnels(classPersonnels personnel)
        {
            string req = "update personnels set idpersonnels = @idpersonnels, idservices = @idservices, mail = @mail, nom = @nom, prenom = @prenom, tel = @tel ";
            req += "where idpersonnels = @idpersonnels;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnels", personnel.Idpersonnel);
            parameters.Add("@idservices", personnel.Idservice);
            parameters.Add("@mail", personnel.Mail);
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            connexiondatabase conn = connexiondatabase.GetInstance();
            conn.ReqUpdate(req, parameters);
        }
        /// <summary>
        /// audateabs
        /// </summary>
        /// <param name="absence"></param>
        public static void UpdateAbsences(classAbsences absence)
        {
            string req = "update developpeur set datedebuts = @datedebuts, datefins = @datefins, idmotifs = @idmotifs, idpersonnels = @idpersonnels ";
            req += "where idmotifs = @idmotifs;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@datedebuts", absence.Datedebut);
            parameters.Add("@datefins", absence.Datefin);
            parameters.Add("@idmotifs", absence.Idmotif);

            connexiondatabase conn = connexiondatabase.GetInstance();
            conn.ReqUpdate(req, parameters);

        }
        /// <summary>
        /// contrologin
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
       
        public static Boolean Controlelogin(string login, string pwd)
        {
            string cod = GetStringSha256Hash(pwd);
            string req = "select login ,pwd from responsables where login=@login and pwd=@pwd ;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@login", login);
            parameters.Add("@pwd", cod);
            connexiondatabase curs = connexiondatabase.GetInstance();
            curs.ReqSelect(req);
            if (curs.Read())
            {
                curs.Close();
                return true;
            }
            else
            {
                curs.Close();
                return false;
            }
        }
        internal static string GetStringSha256Hash(string text)
        {
            if (string.IsNullOrEmpty(text))
                return string.Empty;

            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textData = System.Text.Encoding.UTF8.GetBytes(text);
                byte[] hash = sha.ComputeHash(textData);
                return BitConverter.ToString(hash).Replace("-", string.Empty);
            }
        }
    }




}
    
    


