using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace YogevDbShenkar
{
    public partial class Form1 : Form
    {
        private DataBaseConnect DBobj = new DataBaseConnect();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBobj.Initialize();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DBobj.OpenConnection() == true)
            {
                string query;
                MySqlCommand cmd;

                query = "DROP TABLE nullsssss";
                cmd = new MySqlCommand(query, DBobj.connection);
                cmd.ExecuteNonQuery();

                

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Table1 = "CREATE TABLE IF NOT EXISTS rooms(room_number int, building varchar(255), floor int,PRIMARY KEY(room_number))";
            string Table2 = "CREATE TABLE IF NOT EXISTS lecturers(id int, first_name varchar(255), last_name varchar(255),phone_number varchar(255),address varchar(255),PRIMARY KEY(id))";
            string Table3 = "CREATE TABLE IF NOT EXISTS courses(course_number int, name varchar(255), year int,semester int,hours int, PRIMARY KEY(course_number))";
            string Table4 = "CREATE TABLE IF NOT EXISTS schedule(course_number int, id int, room_number int,day int,hour int,PRIMARY KEY(course_number,id,room_number,day,hour))";
            DBobj.AddTable(Table1);
            DBobj.AddTable(Table2);
            DBobj.AddTable(Table3);
            DBobj.AddTable(Table4);
        }
    }


    class DataBaseConnect
    {

        public MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        public bool connected = false;

        //Constructor
        public DataBaseConnect()
        {
            //Initialize();
        }

        //Initialize values
        public void Initialize()
        {
            if (connected == true)
            {
                MessageBox.Show("you are already connected!");
            }
            else
            {
                server = "localhost";
                database = "yogevtest";
                uid = "root";
                password = "";
                string connectionString;
                connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
                connection = new MySqlConnection(connectionString);
                MessageBox.Show("connected!");
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
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
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
                MessageBox.Show(ex.Message);
                return false;
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
    }

}
