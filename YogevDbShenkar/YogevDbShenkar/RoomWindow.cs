using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YogevDbShenkar
{
    public partial class RoomWindow : Form
    {
        public RoomWindow(DataBaseConnect obj,string txt)
        {
            InitializeComponent();
            try
            {
                var culs = obj.selectRoomWindowTBL(string.Format("SELECT courses.name, lecturers.first_name FROM rooms INNER JOIN courses_room_tbl ON rooms.room_number = courses_room_tbl.room_number INNER JOIN courses ON courses_room_tbl.course_number = courses.course_number INNER JOIN courses_lecturers_tbl ON courses.course_number = courses_lecturers_tbl.course_number INNER JOIN lecturers ON courses_lecturers_tbl.id = lecturers.id WHERE rooms.room_number = {0} ",txt), 2);
                dataGridView2.Rows.Clear();
                foreach (var item in culs)
                {
                    dataGridView2.Rows.Add(item[0], item[1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
