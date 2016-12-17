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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(DBobj.MyDatabase, DBobj.MyPassword, DBobj.MyServer);
        }
    }
}
