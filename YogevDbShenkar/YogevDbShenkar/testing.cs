using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YogevDbShenkar
{/*
    public partial class Form331 : Form33
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

            string Drop1 = "DROP TABLE rooms";
            string Drop2 = "DROP TABLE lecturers";
            string Drop3 = "DROP TABLE courses";
            string Drop4 = "DROP TABLE schedule";

            DBobj.DropTable(Drop1);
            DBobj.DropTable(Drop2);
            DBobj.DropTable(Drop3);
            DBobj.DropTable(Drop4);

        }
        private void testing()
        {
            Console.WriteLine("hello");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Table1 = "CREATE TABLE IF NOT EXISTS rooms(room_number varchar(255), building varchar(255), floor varchar(255),PRIMARY KEY(room_number))";
            string Table2 = "CREATE TABLE IF NOT EXISTS lecturers(id varchar(255), first_name varchar(255), last_name varchar(255),phone_number varchar(255),address varchar(255),PRIMARY KEY(id))";
            string Table3 = "CREATE TABLE IF NOT EXISTS courses(course_number varchar(255), name varchar(255), year varchar(255),semester varchar(255),hours varchar(255), PRIMARY KEY(course_number))";
            string Table4 = "CREATE TABLE IF NOT EXISTS schedule(course_number varchar(255), id varchar(255), room_number varchar(255),day varchar(255),hour varchar(255),PRIMARY KEY(course_number,id,room_number,day,hour))";
            DBobj.AddTable(Table1);
            DBobj.AddTable(Table2);
            DBobj.AddTable(Table3);
            DBobj.AddTable(Table4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 0;

            string[] ARoom_number = new string[10] { "247", "246", "204", "123", "435", "62", "345", "835", "124", "2104" };
            string[] ABuilding = new string[10] { "Fernik", "Fernik", "Mitchel", "Fernik", "Mitchel", "Fernik", "Mitchel", "Mitchel", "Fernik", "Mitchel" };
            string[] AFloor = new string[10] { "1", "1", "3", "5", "0", "0", "12", "5", "2", "23" };
            for (i = 0; i < 10; i++)
            {
                DBobj.InsertInto(String.Format("INSERT INTO rooms (room_number,building,floor)VALUES ('{0}','{1}','{2}')", ARoom_number[i], ABuilding[i], AFloor[i]));
            }

            string[] Bid = new string[10] { "301234546", "456214046", "304812345", "304345796", "35844046", "30483953", "33456046", "304846843", "975424046", "302467846" };
            string[] Bfirst_name = new string[10] { "Sheran", "Gal", "Fredreg", "Eitan", "Carlos", "Eran", "Eli", "Eliel", "Maor", "Gili" };
            string[] Blast_name = new string[10] { "Yeini", "Alberman", "Harush", "Tibi", "Garcia", "Zehvi", "Dasa", "Perez", "Buzaglo", "Vermot" };
            string[] Bphone_number = new string[10] { "0501987434", "0528814634", "0508822344", "0508111234", "0528877734", "0589999834", "0508811395", "0508198734", "0529878834", "0545818834" };
            string[] Baddress = new string[10] { "247", "246", "204", "247", "246", "204", "247", "246", "204", "2104" };
            for (i = 0; i < 10; i++)
            {
                DBobj.InsertInto(String.Format("INSERT INTO lecturers (id, first_name, last_name,phone_number,address)VALUES ('{0}','{1}','{2}','{3}','{4}')", Bid[i], Bfirst_name[i], Blast_name[i], Bphone_number[i], Baddress[i]));
            }


            string[] Ccourse_number = new string[10] { "22345", "22346", "22347", "22358", "18374", "22359", "33456", "33457", "33458", "33459" };
            string[] Cname = new string[10] { "Database", "communication1", "communication2", "calculus1", "calculus2", "Algorithms", "data structures", "Physics1", "Physics2", "Unix" };
            string[] Cyear = new string[10] { "A", "A", "B", "A", "B", "B", "A", "B", "C", "C" };
            string[] Csemester = new string[10] { "A", "A", "A", "B", "B", "A", "B", "B", "B", "A" };
            string[] Chours = new string[10] { "3", "3", "3", "4", "5", "3", "3", "5", "4", "3" };
            for (i = 0; i < 10; i++)
            {
                DBobj.InsertInto(String.Format("INSERT INTO courses (course_number,name,year,semester,hours)VALUES ('{0}','{1}','{2}','{3}','{4}')", Ccourse_number[i], Cname[i], Cyear[i], Csemester[i], Chours[i]));
            }


            string[] Dcourse_number = new string[10] { "22345", "22346", "22347", "22358", "18374", "22359", "33456", "33457", "33458", "33459" };
            string[] Did = new string[10] { "301234546", "456214046", "304812345", "304345796", "35844046", "30483953", "33456046", "304846843", "975424046", "302467846" };
            string[] Droom_number = new string[10] { "247", "246", "204", "123", "435", "62", "345", "835", "124", "2104" };
            string[] Dday = new string[10] { "sunday", "monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "saturday", "tuesday", "wednesday" };
            string[] Dhour = new string[10] { "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00" };
            for (i = 0; i < 10; i++)
            {
                DBobj.InsertInto(String.Format("INSERT INTO schedule (course_number,id,room_number,day,hour)VALUES ('{0}','{1}','{2}','{3}','{4}')", Dcourse_number[i], Did[i], Droom_number[i], Dday[i], Dhour[i]));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string Table1 = "CREATE TABLE IF NOT EXISTS lecturers(id int, first_name varchar(255), last_name varchar(255),phone_number varchar(255),address varchar(255),PRIMARY KEY(id))";
            DBobj.AddTable(Table1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DBobj.InsertInto(String.Format("INSERT INTO lecturers (id, first_name, last_name,phone_number,address)VALUES ('{0}','{1}','{2}','{3}','{4}')", "fvfve", "fvfve", "fvfve", "fvfve", "fvfve"));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string Drop2 = "DROP TABLE lecturers";
            DBobj.DropTable(Drop2);
        }
    }*/
}
