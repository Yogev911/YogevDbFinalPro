using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace YogevDbShenkar
{

    public class DataBaseConnect
    {

        public MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        public bool connected = false;

        public string MyServer { get { return server; } set { server = value; } }
        public string MyDatabase { get { return database; } set { database = value; } }
        public string MyUidr { get { return uid; } set { uid = value; } }
        public string MyPassword { get { return password; } set { password = value; } }

        //Constructor
        public DataBaseConnect()
        {
        //    Initialize();
        }

        //Initialize values
        public void Initialize()
        {
            if (connected == true)
            {
                Console.WriteLine("you are already connected!");
            }
            else
            {
                server = "localhost";
                database = "yogevtest";
                uid = "root";
                password = "1111";
                string connectionString;
                connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
                connection = new MySqlConnection(connectionString);
                connected = true;
                Console.WriteLine("connected!");
            }
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                Console.WriteLine("error in : ", ex);
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public void DropTable(string query)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void InsertInto(string query)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        public void AddTable(string TableName)
        {
            //string query = string.Format("CREATE TABLE IF NOT EXISTS {0}(id int NOT NULL AUTO_INCREMENT, first varchar(255), last varchar(255),PRIMARY KEY(id))",TableName);
            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(TableName, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public void RunQuery(string Query)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(Query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
    }

}
