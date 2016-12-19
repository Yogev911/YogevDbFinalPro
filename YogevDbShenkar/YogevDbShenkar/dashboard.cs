using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace YogevDbShenkar
{
    public partial class dashboard : Form
    {
        DataBaseConnect DBobj = new DataBaseConnect();

        public dashboard(DataBaseConnect obj)
        {
            InitializeComponent();
            DBobj = obj;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBobj.fillingUp();
        }

        private void ClassInsert_Click(object sender, EventArgs e)
        {
            DBobj.RunQuery(String.Format("INSERT INTO rooms (room_number,building,floor)VALUES ('{0}','{1}','{2}')", tbRoomNumber.Text, tbBuilding.Text, tbFloorNumber.Text));
            var culs = DBobj.selectFirstTBL("SELECT * FROM rooms;", 3);
            dataGridView1.Rows.Clear();
            foreach (var item in culs)
            {
                dataGridView1.Rows.Add(item[0], item[1], item[2]);
            }
        }

        private void CoursesInsert_Click(object sender, EventArgs e)
        {
            DBobj.RunQuery(String.Format("INSERT INTO courses (course_number,name,year,semester,hours)VALUES ('{0}','{1}','{2}','{3}','{4}')", tbCourseNumber.Text, tbName.Text, tbYear.Text, tbSemester.Text, tbHours.Text));
            var culs = DBobj.selectSecondTBL("SELECT * FROM courses;", 5);
            dataGridView3.Rows.Clear();
            foreach (var item in culs)
            {
                dataGridView3.Rows.Add(item[0], item[1], item[2],item[3],item[4]);
            }
        }

        private void lecturersInsert_Click(object sender, EventArgs e)
        {
            DBobj.RunQuery(String.Format("INSERT INTO lecturers (id, first_name, last_name,phone_number,address)VALUES ('{0}','{1}','{2}','{3}','{4}')", tbID.Text, tbFirstName.Text, tbLastName.Text, tbPhone.Text, tbAddress.Text));
            var culs = DBobj.selectSecondTBL("SELECT * FROM lecturers;", 5);
            dataGridView2.Rows.Clear();
            foreach (var item in culs)
            {
                dataGridView2.Rows.Add(item[0], item[1], item[2], item[3], item[4]);
            }
        }
    }
}
