using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

namespace appgestiopersonnelsoma.connexion
{
    /// <summary>
    /// la connexion a database
    /// </summary>
   public class connexiondatabase
    {

      //  private static connexiondatabase instance = null;
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;
        private string CnxString = ConfigurationManager.ConnectionStrings["myCnxString"].ConnectionString.ToString();
        public connexiondatabase()
        {
            try
            {
                connection = new MySqlConnection(this.CnxString);
                connection.Open();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Application.Exit();
            }
        }
        /// <summary>
        /// GetInstance
        /// </summary>
        /// <returns></returns>
        public static connexiondatabase GetInstance( )
        {
            return new connexiondatabase();
        }
        /// <summary>
        /// les requettes
        /// </summary>
        /// <param name="stringQuery"></param>
        /// <param name="parameters"></param>
        public void ReqUpdate(string stringQuery, Dictionary<string, Object> parameters)
        {
            try
            {
                command = new MySqlCommand(stringQuery, connection);
                foreach (KeyValuePair<string, Object>parameter in parameters )
                {
                    command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                }
                command.Prepare();
                command.ExecuteNonQuery();

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// les requettes
        /// </summary>
        /// <param name="stringQuery"></param>
        public void ReqSelect(string stringQuery)
        {
            try
            {
                command = new MySqlCommand(stringQuery, connection);
                reader = command.ExecuteReader();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// requette
        /// </summary>
        /// <returns></returns>
        public bool Read()
        {
            if (reader == null)
            {
                return false;
            }
            try
            {
                return reader.Read();
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// field
        /// </summary>
        /// <param name="nameField"></param>
        /// <returns></returns>
        public object Field(string nameField)
        {
            if (reader == null)
            {
                return null;
            }
            try
            {
                return reader[nameField];
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// reader
        /// </summary>
        public void Close()
        {
            if (!(reader == null))
            {
                reader.Close();
            }
        }

        //internal void ReqSelect(string req, Dictionary<string, object> parameters)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
