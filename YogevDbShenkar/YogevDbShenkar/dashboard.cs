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

        

        private void ClassInsert_Click(object sender, EventArgs e)
        {
            int i = 0;
            DBobj.RunQuery(String.Format("INSERT INTO rooms (room_number,building,floor)VALUES ('{0}','{1}','{2}')", tbRoomNumber.Text, tbBuilding.Text, tbFloorNumber.Text));
            var culs = DBobj.selectFirstTBL("SELECT * FROM rooms;", 3);
            dataGridView1.Rows.Clear();
            foreach (var item in culs)
            {
                dataGridView1.Rows.Add(item[0], item[1], item[2]);
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBobj.fillingUp();
        }
    }
}
