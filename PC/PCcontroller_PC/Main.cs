using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCcontroller_PC
{
    
    public partial class Main : Form
    {
       // string[] cmd = new string[1];
        bool isListening = false;
        Condb con = new Condb();
        private Timer timer1;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
         
                InitTimer();
            
        }
        
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 3000; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isListening)
            {
                GetCommands();
            }
        }

        public void GetCommands()
        {
            
                con.Connect();
                 string cmd = Convert.ToString(con.ExeScalar("Select CMD from cmds LIMIT 1"));
            Debug.WriteLine(cmd);
                con.Disconnect();
                switch (cmd)
                {
                    case "1":
                        Process.Start("http://www.google.com");
                        lblcmd.Text = "Last executed command: Open Google";
                        break;
                    case "2":
                        Process.Start("http://www.facebook.com");
                        lblcmd.Text = "Last executed command: Open Facebook";
                        break;
                    case "3":
                        Process.Start(@"C:\WINDOWS\system32\rundll32.exe", "user32.dll,LockWorkStation");
                        lblcmd.Text = "Last executed command: Lock screen";
                        break;
                    default:break;

                }
                con.Connect();
                con.ExeNonquerry("DELETE FROM `cmds`");
                con.Disconnect();
            

        }
        public bool gotCMD()
        {
            con.Connect();
            int k = Convert.ToInt32(con.ExeScalar("Select count(*) from cmds"));
            con.Disconnect();
            return k > 0;
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            lblStats.Text = "Listening...";
            lblStats.ForeColor = Color.Green;
            isListening = true;
        }

        private void btnStopListening_Click(object sender, EventArgs e)
        {
            lblStats.Text = "Not listening...";
            lblStats.ForeColor = Color.Red;
            isListening = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
