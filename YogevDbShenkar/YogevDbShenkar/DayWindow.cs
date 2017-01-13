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
    public partial class DayWindow : Form
    {
        public DayWindow(DataBaseConnect obj, int[] cb)
        {
            InitializeComponent();
            try
            {
                var culs = obj.selectSecondTBL(String.Format("SELECT d.name, c.room_number, a.day, a.hours , f.first_name FROM schedule AS a INNER JOIN days_tbl AS b ON a.day = b.day INNER JOIN courses_room_tbl AS c ON b.day = c.day INNER JOIN courses AS d ON c.course_number = d.course_number INNER JOIN courses_lecturers_tbl AS e ON d.course_number = e.course_number INNER JOIN lecturers AS f ON e.id = f.id WHERE b.id BETWEEN {0} and {1} AND a.hours IN (SELECT a.hours FROM schedule WHERE a.hours BETWEEN {2} AND {3}) ORDER BY d.name ASC ", cb[0], cb[1], cb[2], cb[3]),5);
                dataGridView2.Rows.Clear();
                foreach (var item in culs)
                {
                    dataGridView2.Rows.Add(item[0], item[1], item[2], item[3], item[4]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("cant open DayWindow "+ex.Message);
            }
        }
    }
}
