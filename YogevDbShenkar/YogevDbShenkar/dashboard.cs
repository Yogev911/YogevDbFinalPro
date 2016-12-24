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
            DBobj.fillingUp();
            ShowTBL();
        }

        ~dashboard()
        {
            ClearAll();
        }
        
        private void ClassInsert_Click(object sender, EventArgs e)
        {
            try
            {
                DBobj.RunQuery(String.Format("INSERT INTO rooms (room_number,building,floor)VALUES ('{0}','{1}','{2}')", tbRoomNumber.Text, tbBuilding.Text, tbFloorNumber.Text));
                var culs = DBobj.selectFirstTBL("SELECT * FROM rooms;", 3);
                dataGridView1.Rows.Clear();
                foreach (var item in culs)
                {
                    dataGridView1.Rows.Add(item[0], item[1], item[2]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void CoursesInsert_Click(object sender, EventArgs e)
        {
            try
            {
                DBobj.RunQuery(String.Format("INSERT INTO courses (course_number,name,year,semester,hours)VALUES ('{0}','{1}','{2}','{3}','{4}')", tbCourseNumber.Text, tbName.Text, tbYear.Text, tbSemester.Text, tbHours.Text));
                var culs = DBobj.selectSecondTBL("SELECT * FROM courses;", 5);
                dataGridView3.Rows.Clear();
                foreach (var item in culs)
                {
                    dataGridView3.Rows.Add(item[0], item[1], item[2], item[3], item[4]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lecturersInsert_Click(object sender, EventArgs e)
        {
            try
            {
                DBobj.RunQuery(String.Format("INSERT INTO lecturers (id, first_name, last_name,phone_number,address)VALUES ('{0}','{1}','{2}','{3}','{4}')", tbID.Text, tbFirstName.Text, tbLastName.Text, tbPhone.Text, tbAddress.Text));
                var culs = DBobj.selectSecondTBL("SELECT * FROM lecturers;", 5);
                dataGridView2.Rows.Clear();
                foreach (var item in culs)
                {
                    dataGridView2.Rows.Add(item[0], item[1], item[2], item[3], item[4]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            ShowTBL();
        }

        public void ShowTBL()
        {
            try
            {
                var culs1 = DBobj.selectFirstTBL("SELECT * FROM rooms;", 3);
                dataGridView1.Rows.Clear();
                foreach (var item in culs1)
                {
                    dataGridView1.Rows.Add(item[0], item[1], item[2]);
                }
                var culs2 = DBobj.selectSecondTBL("SELECT * FROM courses;", 5);
                dataGridView3.Rows.Clear();
                foreach (var item in culs2)
                {
                    dataGridView3.Rows.Add(item[0], item[1], item[2], item[3], item[4]);
                }
                var culs3 = DBobj.selectSecondTBL("SELECT * FROM lecturers;", 5);
                dataGridView2.Rows.Clear();
                foreach (var item in culs3)
                {
                    dataGridView2.Rows.Add(item[0], item[1], item[2], item[3], item[4]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ClearAll()
        {
            DropByTbl("rooms");
            DropByTbl("courses");
            DropByTbl("lecturers");
            DropByTbl("ff");
            DropByTbl("ee");
            DropByTbl("www");
        }

        private void DropRooms_Click(object sender, EventArgs e)
        {
            DropByTbl("rooms");
        }

        private void DropCourses_Click(object sender, EventArgs e)
        {
            DropByTbl("courses");
        }

        private void DropLecturers_Click(object sender, EventArgs e)
        {
            DropByTbl("lecturers");
        }

        public void DropByTbl(string TblName)
        {
            try
            {
                DBobj.RunQuery(string.Format("DROP TABLE {0}", TblName));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateClass_Click(object sender, EventArgs e)
        {
            try
            {
                DBobj.RunQuery(string.Format("UPDATE {0} SET {1} = {2} , {3} = {4} WHERE {5} = {6}; ", "rooms", "building", string.Format("'" + tbBuilding.Text + "'"), "floor", string.Format("'" + tbFloorNumber.Text + "'"), "room_number", string.Format("'" + tbRoomNumber.Text + "'")));
                var culs1 = DBobj.selectFirstTBL("SELECT * FROM rooms;", 3);
                dataGridView1.Rows.Clear();
                foreach (var item in culs1)
                {
                    dataGridView1.Rows.Add(item[0], item[1], item[2]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateCourse_Click(object sender, EventArgs e)
        {
            try
            {
                DBobj.RunQuery(string.Format("UPDATE {0} SET {1} = {2} , {3} = {4} ,{5} = {6} ,{7} = {8} WHERE {9}={10}; ", "courses", "name", string.Format("'" + tbName.Text + "'"), "year", string.Format("'" + tbYear.Text + "'"), "semester", string.Format("'" + tbSemester.Text + "'"), "hours", string.Format("'" + tbHours.Text + "'"), "course_number", string.Format("'" + tbCourseNumber.Text + "'")));
                var culs2 = DBobj.selectSecondTBL("SELECT * FROM courses;", 5);
                dataGridView3.Rows.Clear();
                foreach (var item in culs2)
                {
                    dataGridView3.Rows.Add(item[0], item[1], item[2], item[3], item[4]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateLecture_Click(object sender, EventArgs e)
        {
            try
            {
                DBobj.RunQuery(string.Format("UPDATE {0} SET {1} = {2} , {3} = {4} ,{5} = {6} ,{7} = {8} WHERE {9}={10}; ", "lecturers", "first_name", string.Format("'" + tbFirstName.Text + "'"), "last_name", string.Format("'" + tbLastName.Text + "'"), "phone_number", string.Format("'" + tbPhone.Text + "'"), "address", string.Format("'" + tbAddress.Text + "'"), "id", string.Format("'" + tbID.Text + "'")));
                var culs3 = DBobj.selectSecondTBL("SELECT * FROM lecturers;", 5);
                dataGridView2.Rows.Clear();
                foreach (var item in culs3)
                {
                    dataGridView2.Rows.Add(item[0], item[1], item[2], item[3], item[4]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SystemMessage_Click(object sender, EventArgs e)
        {
            
        }
    }
}
