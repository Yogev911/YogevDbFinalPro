using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;

namespace YogevDbShenkar
{
    public partial class Connection : Form
    {
        private DataBaseConnect DBobj = new DataBaseConnect();
        Thread th;

        public Connection()
        {
            InitializeComponent();
        }

        public void OpenDash(object obj)
        {
            Application.Run(new dashboard(DBobj));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBobj.MyServer = Server.Text;
            DBobj.MyDatabase = Database.Text;
            DBobj.MyUidr = ID.Text;
            DBobj.MyPassword = password.Text;

            //DBobj.Initialize();

            //this.Close();
            th = new Thread(OpenDash);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            Close();
            
            
        }
        
    }

}
