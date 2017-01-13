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
                var culs = obj.selectDayTBL(String.Format("SELECT  a.day, a.hours,a.room_number,c.name FROM schedule AS a INNER JOIN days_tbl AS b ON a.day = b.day INNER JOIN courses AS c ON a.course_number = c.course_number WHERE b.id BETWEEN {0} and {1} AND a.hours IN (SELECT a.hours FROM schedule WHERE a.hours BETWEEN {2} AND {3}) ORDER BY c.name ASC", cb[0], cb[1], cb[2], cb[3]),4);
                dayView.Rows.Clear();
                foreach (var item in culs)
                {
                    dayView.Rows.Add(item[0], item[1], item[2], item[3]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("cant open DayWindow "+ex.Message);
            }
        }
    }
}
