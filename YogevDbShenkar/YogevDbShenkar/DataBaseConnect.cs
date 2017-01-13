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
        MySqlCommand cmd;

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

        public List<string[]> selectRoomWindowTBL(string Query, int culs)
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

        public List<string[]> selectFirstTBL(string Query, int culs)
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
                /*TABLES INIT*/

                //
                //rooms
                //
                    string RoomsTBL = "CREATE TABLE IF NOT EXISTS rooms(room_number int, building varchar(255), floor int,PRIMARY KEY(room_number), INDEX room_number_ind(room_number))";
                RunQuery(RoomsTBL);

                string[] ARoom_number = new string[10] { "62", "2102", "2104", "246", "245", "204", "63", "2108", "2107", "247" };
                string[] ABuilding = new string[10] { "Fernik", "Mitchel", "Mitchel", "Fernik", "Fernik", "Fernik", "Fernik", "Mitchel", "Mitchel", "Fernik" };
                string[] AFloor = new string[10] { "0", "0", "2", "2", "2", "2", "2", "2", "3", "3" };

                for (i = 0; i < 10; i++)
                    RunQuery(String.Format("INSERT INTO rooms (room_number,building,floor)VALUES ('{0}','{1}','{2}')", Convert.ToInt32(ARoom_number[i]), ABuilding[i], Convert.ToInt32(AFloor[i])));

                //
                //lecturers
                //
                string LecturersTBL = "CREATE TABLE IF NOT EXISTS lecturers(id int, first_name varchar(255), last_name varchar(255),phone_number varchar(255),address varchar(255),PRIMARY KEY(id) ,INDEX id_ind(id), INDEX phone_ind(phone_number))";
                RunQuery(LecturersTBL);

                string[] Bid = new string[10] { "306488195"     , "328768195"   , "306498256"   , "303208194"   , "058489995"   , "364858195"   , "306489999"   , "389528134"   , "326598495"   , "259788192" };
                string[] Bfirst_name = new string[10] { "Yonit" , "Avihai"      , "Shaula"      , "Haim"        , "Nezer"       , "Noa"         , "Zila"        , "Emanuel"     , "Izhak"       , "Marselo" };
                string[] Blast_name = new string[10] { "Rusho", "Meged", "HItner", "Michael", "Zainderberg", "Levinshtain", "Hasin", "Gruengard", "Nudler", "Shichman" };
                string[] Bphone_number = new string[10] { "0501987434", "0528814634", "0508822344", "0508111234", "0528877734", "0589999834", "0508811395", "0508198734", "0529878834", "0545818834" };
                string[] Baddress = new string[10] { "Tel Aviv", "Rishon Le Zion", "Rehovot", "Holon", "Beer Yaakov", "Jaffa", "Bat Yam", "Hifa", "Ramle", "Ramat Hasharon" };

                for (i = 0; i < 10; i++)
                    RunQuery(String.Format("INSERT INTO lecturers (id, first_name, last_name,phone_number,address)VALUES ('{0}','{1}','{2}','{3}','{4}')", Convert.ToInt32(Bid[i]), Bfirst_name[i], Blast_name[i], Bphone_number[i], Baddress[i]));

                //
                //courses
                //
                string CoursesTBL = "CREATE TABLE IF NOT EXISTS courses(course_number int, name varchar(255), year varchar(255),semester varchar(255),hours int, PRIMARY KEY(course_number) ,INDEX course_number_ind(course_number))";
                RunQuery(CoursesTBL);

                string[] Ccourse_number = new string[10] {  "3503812"   , "3500165"     , "3503832" , "3503833" , "3500876"     , "3500836"         , "3503834"         , "3503849"     , "3502830" , "3500815" };
                string[] Cname = new string[10] {           "Automate"  , "Life Online" , "DBA"     , "OS"      , "Web Design"  , "Web Application" , "Communication1"  , "C#"          , "UNIX"    ,"HTML" };
                string[] Cyear = new string[10] { "C", "C", "C", "C", "C", "C", "C", "B", "B", "A" };
                string[] Csemester = new string[10] { "A", "A", "A", "A", "A", "A", "A", "C", "C", "B" };
                string[] Chours = new string[10] { "13", "14", "9", "15", "8", "17", "16", "11", "12", "10" };

                for (i = 0; i < 10; i++)
                    RunQuery(String.Format("INSERT INTO courses (course_number,name,year,semester,hours)VALUES ('{0}','{1}','{2}','{3}','{4}')", Convert.ToInt32(Ccourse_number[i]), Cname[i], Cyear[i], Csemester[i], Convert.ToInt32(Chours[i])));

                //
                //schedule
                //
                string ScheduleTBL = "CREATE TABLE IF NOT EXISTS schedule(course_number int, id int, room_number int,day varchar(255),hours int,PRIMARY KEY(course_number,id,room_number,day,hours),CONSTRAINT FOREIGN KEY(course_number) REFERENCES courses(course_number) ON DELETE CASCADE ON UPDATE CASCADE , CONSTRAINT FOREIGN KEY(id) REFERENCES lecturers(id) ON DELETE CASCADE ON UPDATE CASCADE , CONSTRAINT FOREIGN KEY(room_number) REFERENCES rooms(room_number) ON DELETE CASCADE ON UPDATE CASCADE)";
                RunQuery(ScheduleTBL);

                string[] Did = new string[10] { "306488195", "328768195", "306498256", "303208194", "058489995", "364858195", "306489999", "389528134", "326598495", "306488195" };
                string[] Dcourse_number = new string[10] { "3500876", "3503832", "3500815", "3503849", "3502830", "3503812", "3500165", "3503833", "3503834", "3500836" };
                string[] Droom_number = new string[10] { "62", "2102", "2104", "246", "246", "204", "63", "2104", "2104", "247" };
                string[] Dday = new string[10] { "sun", "mon", "thu", "tue", "thu", "fri", "wed", "wed", "mon", "fri" };
                string[] Dhour = new string[10] { "8", "9", "10", "11", "12", "13", "14", "15", "16", "17" };

                for (i = 0; i < 10; i++)
                {
                    RunQuery(String.Format("INSERT INTO schedule (course_number,id,room_number,day,hours)VALUES ('{0}','{1}','{2}','{3}','{4}')", Convert.ToInt32(Dcourse_number[i]), Convert.ToInt32(Did[i]), Convert.ToInt32(Droom_number[i]), Dday[i], Convert.ToInt32(Dhour[i])));
                }

                //
                //courses_lecturers_tbl
                //
                string courses_lecturers_tbl = "CREATE TABLE IF NOT EXISTS courses_lecturers_tbl(id int, course_number int,CONSTRAINT FOREIGN KEY(course_number) REFERENCES courses(course_number) ON DELETE CASCADE ON UPDATE CASCADE ,CONSTRAINT FOREIGN KEY(id) REFERENCES lecturers(id) ON DELETE CASCADE ON UPDATE CASCADE )";
                RunQuery(courses_lecturers_tbl);

                string[] ElecturerID = new string[10] { "306488195", "328768195", "306498256", "303208194", "058489995", "364858195", "306489999", "389528134", "326598495", "306488195" };
                string[] Ecourse_number = new string[10] { "3500876", "3503832", "3500815", "3503849", "3502830", "3503812", "3500165", "3503833", "3503834", "3500836" };

                for (i = 0; i < 10; i++)
                {
                    RunQuery(String.Format("INSERT INTO courses_lecturers_tbl(id,course_number)VALUES ('{0}','{1}')", Convert.ToInt32(ElecturerID[i]),Convert.ToInt32(Ecourse_number[i])));
                }

                //
                //courses_room_tbl
                //
                string courses_room_tbl = "CREATE TABLE IF NOT EXISTS courses_room_tbl (room_number int, course_number int, day varchar(255) , hours int,CONSTRAINT FOREIGN KEY(course_number) REFERENCES courses(course_number) ON DELETE CASCADE ON UPDATE CASCADE ,CONSTRAINT FOREIGN KEY(room_number) REFERENCES rooms(room_number) ON DELETE CASCADE ON UPDATE CASCADE )";
                RunQuery(courses_room_tbl);

                string[] FRoom_number = new string[10] { "62", "2102", "2104", "246", "246", "204", "63", "2104", "2104", "247" };
                string[] Fcourse_number = new string[10] { "3500876", "3503832", "3500815", "3503849", "3502830", "3503812", "3500165", "3503833", "3503834", "3500836" };
                string[] FDay = new string[10] { "sun", "mon", "thu", "tue", "thu", "fri", "wed", "wed", "mon", "fri" };
                string[] FHour = new string[10] { "8", "9", "10", "11", "12", "13", "14", "15", "16", "17" };


                for (i = 0; i < 10; i++)
                {
                    RunQuery(String.Format("INSERT INTO courses_room_tbl (room_number,course_number,day,hours)VALUES ('{0}','{1}','{2}','{3}')", Convert.ToInt32(FRoom_number[i]), Convert.ToInt32(Fcourse_number[i]),FDay[i],Convert.ToInt32(FHour[i])));
                }

                //
                //lecture_tel_tbl
                //
                string lecture_tel_tbl = "CREATE TABLE IF NOT EXISTS lecture_tel_tbl (id int, phone_number varchar(255), type varchar(255),PRIMARY KEY(phone_number,type))";
                RunQuery(lecture_tel_tbl);

                string[] Gid = new string[10] { "306488195", "328768195", "306498256", "303208194", "058489995", "364858195", "306489999", "389528134", "326598495", "306488195" };
                string[] Gtel = new string[10] { "0501987434", "0528814634", "0508822344", "0508111234", "0528877734", "0589999834", "0508811395", "0508198734", "0529878834", "039658798" };
                string[] Gpriotiry = new string[10] { "sec", "prim", "prim", "prim", "prim", "prim", "prim", "prim", "prim", "prim" };

                for (i = 0; i < 10; i++)
                {
                    RunQuery(String.Format("INSERT INTO lecture_tel_tbl (id,phone_number,type)VALUES ('{0}','{1}','{2}')", Convert.ToInt32(Gid[i]), Gtel[i], Gpriotiry[i]));
                }
                //
                //days_tbl
                //
                string days_tbl = "CREATE TABLE IF NOT EXISTS days_tbl (id int, day varchar(255))";
                RunQuery(days_tbl);

                string[] Hday = new string[6] { "sun", "mon", "tue", "wed", "thu", "fri" };
                string[] Hid = new string[6] { "1", "2", "3", "4", "5", "6"};
               
                for (i = 0; i < 6; i++)
                {
                    RunQuery(String.Format("INSERT INTO days_tbl (id,day)VALUES ('{0}','{1}')", Convert.ToInt32(Hid[i]) , Hday[i]));
                }
                //
                //updateTimeTableClasses
                //TRIGGER
                RunQuery("CREATE TABLE Logger (tableName VARCHAR(25),lastUpdate timestamp)");
                RunQuery("CREATE TRIGGER courses_trigger AFTER INSERT ON courses FOR EACH ROW INSERT INTO Logger VALUES ('courses' ,DEFAULT )");
                RunQuery("CREATE TRIGGER courses_lecturers_tbl_trigger AFTER INSERT ON courses_lecturers_tbl FOR EACH ROW INSERT INTO Logger VALUES ('courses_lecturers_tbl' ,DEFAULT )");
                RunQuery("CREATE TRIGGER courses_room_tbl_trigger AFTER INSERT ON courses_room_tbl FOR EACH ROW INSERT INTO Logger VALUES ('courses_room_tbl' ,DEFAULT )");
                RunQuery("CREATE TRIGGER days_tbl_trigger AFTER INSERT ON days_tbl FOR EACH ROW INSERT INTO Logger VALUES ('days_tbl' ,DEFAULT )");
                RunQuery("CREATE TRIGGER lecturers_trigger AFTER INSERT ON lecturers FOR EACH ROW INSERT INTO Logger VALUES ('lecturers' ,DEFAULT )");
                RunQuery("CREATE TRIGGER lecture_tel_tbl_trigger AFTER INSERT ON lecture_tel_tbl FOR EACH ROW INSERT INTO Logger VALUES ('lecture_tel_tbl' ,DEFAULT )");
                RunQuery("CREATE TRIGGER rooms_trigger AFTER INSERT ON rooms FOR EACH ROW INSERT INTO Logger VALUES ('rooms' ,DEFAULT )");
                RunQuery("CREATE TRIGGER schedule_trigger AFTER INSERT ON schedule FOR EACH ROW INSERT INTO Logger VALUES ('schedule' ,DEFAULT )");


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
                    this.cmd = new MySqlCommand(Query, connection);
                    
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                try
                {
                    cmd.Transaction.Rollback();
                }
                catch (Exception)
                {
                    MessageBox.Show("rollback" + ex.Message);
                    this.CloseConnection();
                }
                this.CloseConnection();
                MessageBox.Show("no rollback"+ex.Message);
            }


        }
    }

}
