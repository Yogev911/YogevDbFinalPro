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
                string Drop1 = "DROP TABLE rooms";
                string Drop2 = "DROP TABLE lecturers";
                string Drop3 = "DROP TABLE courses";
                string Drop4 = "DROP TABLE schedule";

                DBobj.DropTable(Drop1);
                DBobj.DropTable(Drop2);
                DBobj.DropTable(Drop3);
                DBobj.DropTable(Drop4);


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

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 0

            string[] ARoom_number = new string[10]      { "247"     , "246"     , "204"     , "123"     , "435"     , "62"      , "345"     , "835"     , "124"     ,"2104"     };
            string[] ABuilding = new string[10]         { "Fernik"  , "Fernik"  , "Mitchel" , "Fernik"  , "Mitchel" , "Fernik"  , "Mitchel" , "Mitchel" , "Fernik"  , "Mitchel" };
            string[] AFloor = new string[10]            { "1"       , "1"       , "3"       , "5"       , "0"       , "0"       , "12"      , "5"       , "2"       , "23"    };
            for (i = 0; i < 10; i++)
            {
                DBobj.InsertInto(String.Format("INSERT INTO rooms (room_number,building,floor)VALUES ('{0}','{1}','{2}')", ARoom_number[i], ABuilding[i], AFloor[i]));
            }

            string[] Bid = new string[10] { "247", "246", "204", "123", "435", "62", "345", "835", "124", "2104" };
            string[] Bfirst_name = new string[10] { "247", "246", "204", "247", "246", "204", "247", "246", "204", "2104" };
            string[] Blast_name = new string[10] { "247", "246", "204", "247", "246", "204", "247", "246", "204", "2104" };
            string[] Bphone_number = new string[10] { "247", "246", "204", "247", "246", "204", "247", "246", "204", "2104" };
            string[] Baddress = new string[10] { "247", "246", "204", "247", "246", "204", "247", "246", "204", "2104" };
            for (i = 0; i < 10; i++)
            {
                DBobj.InsertInto(String.Format("INSERT INTO lecturers (id, first_name, last_name,phone_number,address)VALUES ('{0}','{1}','{2}','{3}','{4}')", Bid[i], Bfirst_name[i], Blast_name[i], Bphone_number[i], Baddress[i]));
            }


            string[] Ccourse_number = new string[10] { "247", "246", "204", "247", "246", "204", "247", "246", "204", "2104" };
            string[] Cname = new string[10] { "247", "246", "204", "247", "246", "204", "247", "246", "204", "2104" };
            string[] Cyear = new string[10] { "247", "246", "204", "247", "246", "204", "247", "246", "204", "2104" };
            string[] Csemester = new string[10] { "247", "246", "204", "247", "246", "204", "247", "246", "204", "2104" };
            string[] Chours = new string[10] { "247", "246", "204", "247", "246", "204", "247", "246", "204", "2104" };
            for (i = 0; i < 10; i++)
            {
                DBobj.InsertInto(String.Format("INSERT INTO courses (course_number,name,year,semester,hours)VALUES ('{0}','{1}','{2}','{3}','{4}')", Ccourse_number[i], Cname[i], Cyear[i], Csemester[i], Chours[i]));
            }


            string[] Dcourse_number = new string[10] { "247", "246", "204", "247", "246", "204", "247", "246", "204", "2104" };
            string[] Did = new string[10] { "247", "246", "204", "247", "246", "204", "247", "246", "204", "2104" };
            string[] Droom_number = new string[10] { "247", "246", "204", "247", "246", "204", "247", "246", "204", "2104" };
            string[] Dday = new string[10] { "247", "246", "204", "247", "246", "204", "247", "246", "204", "2104" };
            string[] Dhour = new string[10] { "247", "246", "204", "247", "246", "204", "247", "246", "204", "2104" };
            for (i = 0; i < 10; i++)
            {
                DBobj.InsertInto(String.Format("INSERT INTO schedule (course_number,id,room_number,day,hour)VALUES ('{0}','{1}','{2}','{3}','{4}')", Dcourse_number[i], Did[i], Droom_number[i], Dday[i], Dhour[i]));
            }
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
    }

}
