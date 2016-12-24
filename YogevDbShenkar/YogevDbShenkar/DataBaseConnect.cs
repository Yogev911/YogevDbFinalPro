using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;

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
        public string select;

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
                MessageBox.Show("you are already connected!");
            }
            else
            {
                //server = "localhost";
                //database = "yogevtest";
                //uid = "root";
                //password = "1111";
                string connectionString;
                connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
                connection = new MySqlConnection(connectionString);
                connected = true;
                MessageBox.Show("connected!");
                //MessageBox.Show("SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";");
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
                MessageBox.Show("error in : ", ex.ToString());
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

        public List<string[]> selectFirstTBL(string Query,int culs)
        {
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(Query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                List<string[]> cul = new List<string[]>();
                while (reader.Read())
                {
                    string[] Cul_add = new string[culs];
                    Cul_add[0] = reader[0].ToString();
                    Cul_add[1] = reader[1].ToString();
                    Cul_add[2] = reader[2].ToString();
                    cul.Add(Cul_add);
                }
                connection.Close();
                return cul;
            }
            catch (Exception e)
            {
                MessageBox.Show("error in bla bla" + e);
            }
            return null;
        }

        public List<string[]> selectSecondTBL(string Query, int culs)
        {
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(Query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                List<string[]> cul = new List<string[]>();
                while (reader.Read())
                {
                    string[] Cul_add = new string[culs];
                    Cul_add[0] = reader[0].ToString();
                    Cul_add[1] = reader[1].ToString();
                    Cul_add[2] = reader[2].ToString();
                    Cul_add[3] = reader[3].ToString();
                    Cul_add[4] = reader[4].ToString();
                    cul.Add(Cul_add);
                }
                connection.Close();
                return cul;
            }
            catch (Exception e)
            {
                MessageBox.Show("error in bla bla" + e);
            }
            return null;
        }



        public void fillingUp()
        {
            try
            {
                int i = 0;
                string RoomsTBL = "CREATE TABLE IF NOT EXISTS rooms(room_number int, building varchar(255), floor int,PRIMARY KEY(room_number))";
                RunQuery(RoomsTBL);

                string[] ARoom_number = new string[10] { "247", "246", "204", "123", "435", "62", "345", "835", "124", "2104" };
                string[] ABuilding = new string[10] { "Fernik", "Fernik", "Mitchel", "Fernik", "Mitchel", "Fernik", "Mitchel", "Mitchel", "Fernik", "Mitchel" };
                string[] AFloor = new string[10] { "247", "246", "204", "123", "435", "62", "345", "835", "124", "2104" };

                for (i = 0; i < 10; i++)
                    RunQuery(String.Format("INSERT INTO rooms (room_number,building,floor)VALUES ('{0}','{1}','{2}')", Convert.ToInt32(ARoom_number[i]), ABuilding[i], Convert.ToInt32(AFloor[i])));

                string LecturersTBL = "CREATE TABLE IF NOT EXISTS lecturers(id int, first_name varchar(255), last_name varchar(255),phone_number varchar(255),address varchar(255),PRIMARY KEY(id))";
                RunQuery(LecturersTBL);

                string[] Bid = new string[10] { "301234546", "456214046", "304812345", "304345796", "35844046", "30483953", "33456046", "304846843", "975424046", "302467846" };
                string[] Bfirst_name = new string[10] { "Sheran", "Gal", "Fredreg", "Eitan", "Carlos", "Eran", "Eli", "Eliel", "Maor", "Gili" };
                string[] Blast_name = new string[10] { "Yeini", "Alberman", "Harush", "Tibi", "Garcia", "Zehvi", "Dasa", "Perez", "Buzaglo", "Vermot" };
                string[] Bphone_number = new string[10] { "0501987434", "0528814634", "0508822344", "0508111234", "0528877734", "0589999834", "0508811395", "0508198734", "0529878834", "0545818834" };
                string[] Baddress = new string[10] { "247", "246", "204", "247", "246", "204", "247", "246", "204", "2104" };

                for (i = 0; i < 10; i++)
                    RunQuery(String.Format("INSERT INTO lecturers (id, first_name, last_name,phone_number,address)VALUES ('{0}','{1}','{2}','{3}','{4}')", Convert.ToInt32(Bid[i]), Bfirst_name[i], Blast_name[i], Bphone_number[i], Baddress[i]));

                string CoursesTBL = "CREATE TABLE IF NOT EXISTS courses(course_number int, name varchar(255), year varchar(255),semester varchar(255),hours int, PRIMARY KEY(course_number))";
                RunQuery(CoursesTBL);

                string[] Ccourse_number = new string[10] { "22345", "22346", "22347", "22358", "18374", "22359", "33456", "33457", "33458", "33459" };
                string[] Cname = new string[10] { "Database", "communication1", "communication2", "calculus1", "calculus2", "Algorithms", "data structures", "Physics1", "Physics2", "Unix" };
                string[] Cyear = new string[10] { "A", "A", "B", "A", "B", "B", "A", "B", "C", "C" };
                string[] Csemester = new string[10] { "A", "A", "A", "B", "B", "A", "B", "B", "B", "A" };
                string[] Chours = new string[10] { "3", "3", "3", "4", "5", "3", "3", "5", "4", "3" };

                for (i = 0; i < 10; i++)
                    RunQuery(String.Format("INSERT INTO courses (course_number,name,year,semester,hours)VALUES ('{0}','{1}','{2}','{3}','{4}')", Convert.ToInt32(Ccourse_number[i]), Cname[i], Cyear[i], Csemester[i], Convert.ToInt32(Chours[i])));

                string ScheduleTBL = "CREATE TABLE IF NOT EXISTS schedule(course_number varchar(255), id varchar(255), room_number varchar(255),day varchar(255),hour varchar(255),PRIMARY KEY(course_number,id,room_number,day,hour))";
                RunQuery(ScheduleTBL);

                string[] Dcourse_number = new string[10] { "22345", "22346", "22347", "22358", "18374", "22359", "33456", "33457", "33458", "33459" };
                string[] Did = new string[10] { "301234546", "456214046", "304812345", "304345796", "35844046", "30483953", "33456046", "304846843", "975424046", "302467846" };
                string[] Droom_number = new string[10] { "247", "246", "204", "123", "435", "62", "345", "835", "124", "2104" };
                string[] Dday = new string[10] { "sunday", "monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "saturday", "tuesday", "wednesday" };
                string[] Dhour = new string[10] { "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00" };

                for (i = 0; i < 10; i++)
                {
                    RunQuery(String.Format("INSERT INTO schedule (course_number,id,room_number,day,hour)VALUES ('{0}','{1}','{2}','{3}','{4}')", Dcourse_number[i], Did[i], Droom_number[i], Dday[i], Dhour[i]));
                }

                /*
                string courses_lecturers_tbl = "CREATE TABLE IF NOT EXISTS courses_lecturers_tbl(id int, course_number varchar(255),PRIMARY KEY(id,course_number))";
                RunQuery(courses_lecturers_tbl);

                string[] ElecturerID = new string[10] { "22345", "22346", "22347", "22358", "18374", "22359", "33456", "33457", "33458", "33459" };
                string[] Ecourse_number = new string[10] { "301234546", "456214046", "304812345", "304345796", "35844046", "30483953", "33456046", "304846843", "975424046", "302467846" };

                for (i = 0; i < 10; i++)
                {
                    RunQuery(String.Format("INSERT INTO schedule (id,course_number)VALUES ('{0}','{1}')", ElecturerID[i], Ecourse_number[i]));
                }
                
                FILL F TBL
                 */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CreateTBLs()
        {
            try
            {
                
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void RunQuery(string Query)
        {
            try
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(Query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                this.CloseConnection();
                MessageBox.Show(ex.Message); 
            }
            
        }
    }

}
