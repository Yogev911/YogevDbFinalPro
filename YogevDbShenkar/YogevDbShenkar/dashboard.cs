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
        Thread Th_Rooms;
        Thread Th_Lec;
        Thread Th_Day_Range;

        public dashboard(DataBaseConnect obj)
        {
            InitializeComponent();
            DBobj = obj;
            initDB();
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
                /*net set yet*/
                var culs4 = DBobj.selectSecondTBL("SELECT * FROM schedule;", 5);
                dataGridView4.Rows.Clear();
                foreach (var item in culs4)
                {
                    dataGridView4.Rows.Add(item[0], item[1], item[2], item[3], item[4]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ClearAll()
        {
            DBobj.RunQuery("SET FOREIGN_KEY_CHECKS = 0");
            DropByTbl("rooms");
            DropByTbl("courses");
            DropByTbl("lecturers");
            DropByTbl("schedule");
            DropByTbl("courses_lecturers_tbl");
            DropByTbl("courses_room_tbl");
            DropByTbl("lecture_tel_tbl");
        }

        private void DropRooms_Click(object sender, EventArgs e)
        {
            DBobj.RunQuery(string.Format("DELETE FROM {0} WHERE {1}={2}", "rooms",tbRoomNumber.Text, "room_number"));
            ShowTBL();
        }

        private void DropCourses_Click(object sender, EventArgs e)
        {
            DBobj.RunQuery(string.Format("DELETE FROM {0} WHERE {1}={2}", "courses", tbCourseNumber.Text, "course_number"));
            ShowTBL();
        }

        private void DropLecturers_Click(object sender, EventArgs e)
        {
            DBobj.RunQuery(string.Format("DELETE FROM {0} WHERE {1}={2}", "lecturers", tbID.Text, "id"));
            ShowTBL();
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
                DBobj.RunQuery(string.Format("UPDATE {0} SET {1} = {2} , {3} = {4} WHERE {5} = {6}; ", "rooms", "building", StringIt(tbBuilding.Text), "floor", StringIt(tbFloorNumber.Text), "room_number", StringIt(tbRoomNumber.Text)));
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

        public string StringIt(string name)
        {
            return string.Format("'" + name + "'");
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
            ClearAll();
        }

        public void initDB()
        {
            DBobj.fillingUp();
            ShowTBL();
        }

        private void init_Click(object sender, EventArgs e)
        {
            initDB();
        }

        private void FindLecId_Click(object sender, EventArgs e)
        {
            if (Th_Lec!= null)
            {
                Th_Lec.Abort();
            }
            Th_Lec = new Thread(OpenLecWindow);
            Th_Lec.SetApartmentState(ApartmentState.STA);
            Th_Lec.Start();
            
        }

        public void OpenLecWindow(object obj)
        {
            Application.Run(new LecWindow(DBobj,tbID.Text));
        }

        private void FindRoomNum_Click(object sender, EventArgs e)
        {
            if (Th_Rooms != null)
            {
                Th_Rooms.Abort();
            }
            Th_Rooms = new Thread(OpenRoomWindow);
            Th_Rooms.SetApartmentState(ApartmentState.STA);
            Th_Rooms.Start();
        }

        public void OpenRoomWindow(object obj)
        {
            Application.Run(new RoomWindow(DBobj,tbRoomNumber.Text));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                tbRoomNumber.Text = row.Cells[0].Value.ToString();
                tbBuilding.Text = row.Cells[1].Value.ToString();
                tbFloorNumber.Text = row.Cells[2].Value.ToString();
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView3.Rows[e.RowIndex];
                tbCourseNumber.Text = row.Cells[0].Value.ToString();
                tbName.Text = row.Cells[1].Value.ToString();
                tbYear.Text = row.Cells[2].Value.ToString();
                tbSemester.Text = row.Cells[3].Value.ToString();
                tbHours.Text = row.Cells[4].Value.ToString();
            }

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                tbID.Text = row.Cells[0].Value.ToString();
                tbFirstName.Text = row.Cells[1].Value.ToString();
                tbLastName.Text = row.Cells[2].Value.ToString();
                tbPhone.Text = row.Cells[3].Value.ToString();
                tbAddress.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
