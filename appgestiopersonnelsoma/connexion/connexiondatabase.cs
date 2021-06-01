using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace appgestiopersonnelsoma.connexion
{
   public class connexiondatabase
    {
        private static connexiondatabase instance = null;
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;
        private connexiondatabase(string stringConnect)
        {
            try
            {
                connection = new MySqlConnection(stringConnect);
                connection.Open();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Application.Exit();
            }
        }
        public static connexiondatabase GetInstance(string stringConnect)
        {
            if(instance is null)
            {
                instance = new connexiondatabase(stringConnect);
            }
            return instance;
        }
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
        public bool Read()
        {
            if (reader is null)
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
        public object Field(string nameField)
        {
            if (reader is null)
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
        public void Close()
        {
            if (!(reader is null))
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
