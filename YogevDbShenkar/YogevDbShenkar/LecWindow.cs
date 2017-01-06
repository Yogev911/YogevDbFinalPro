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
    public partial class LecWindow : Form
    {
        public LecWindow(DataBaseConnect obj,string id)
        {
            InitializeComponent();
            try
            {
                var culs = obj.selectFirstTBL(string.Format("SELECT rooms.room_number, courses.name, courses.hours FROM lecturers INNER JOIN courses_lecturers_tbl ON lecturers.id = courses_lecturers_tbl.id INNER JOIN courses ON courses_lecturers_tbl.course_number = courses.course_number INNER JOIN courses_room_tbl ON courses.course_number = courses_room_tbl.course_number INNER JOIN rooms ON courses_room_tbl.room_number = rooms.room_number WHERE courses_lecturers_tbl.id = '{0}'",id), 3);
                dataGridView2.Rows.Clear();
                foreach (var item in culs)
                {
                    dataGridView2.Rows.Add(item[0], item[1], item[2]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
