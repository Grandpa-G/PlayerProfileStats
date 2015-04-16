using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Windows.Forms.DataVisualization.Charting;

namespace PlayerProfileStats
{
    public partial class Profile : Form
    {
        private static string PROGRAMREG = "PlayerProfile";
        public static string PROGRAMNAME = "Player Profile";

        RemoteUtils ru = new RemoteUtils();

        public static bool DEBUG = false;

        public Profile()
        {
            InitializeComponent();
            lblVersion.Text = "Version " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            string[] args = Environment.GetCommandLineArgs();
            foreach (string arg in args)
            {
                if (arg.Length > 0 && arg.Equals("-d"))
                {
                    DEBUG = true;
                    Console.WriteLine("Debug Mode On.");
                }
            }

            restoreSettings();
            startProfile();
        }

        private void startProfile()
        {
            initializeTabs();

            serverAddress.Text = "Not Connected";
            if (ru.getToken())
            {
                ru.getVersion();
                serverAddress.Text = ru.conn.Server;
                lblVersion.Text = "Version " + Assembly.GetExecutingAssembly().GetName().Version.ToString() + " on " +ru.conn.dbType;
             }
        }
        private void initializeTabs()
        {

            chartTop10PlayerAverage.Series.Clear();
  
            player24Hours.Checked = true;
            player7Days.Checked = false;
            player12Months.Checked = false;

            Top10Avg24Hours.Checked = true;
            Top10Avg7Days.Checked = false;
            Top10Avg1Month.Checked = false;
            Top10Avg12Months.Checked = false;

            top10Count24Hours.Checked = true;
            top10Count7Days.Checked = false;
            top10Count1Month.Checked = false;
            top10Count12Months.Checked = false;
        }

        private void loadPlayerLoad_Click(object sender, EventArgs e)
        {
            fillPlayerLoad();
        }
        DateTime startDate = DateTime.Now;
        DateTime endDate = DateTime.Now;

        private void playerSetNow_Click(object sender, EventArgs e)
        {
            startDate = DateTime.Now;
            playerStart.Value = startDate;
        }
        private void fillPlayerLoad()
        {

            if (ru.conn.dbType == null)
                return;
            startDate = playerStart.Value;

            chartPlayerLoad.Series.Clear();
            chartPlayerLoad.ChartAreas["ChartPlayerLoad"].AxisX.CustomLabels.Clear();
            if (player24Hours.Checked)
                playerStats24Hours();
            if (player7Days.Checked)
                playerStats7Day();
            if (player1Month.Checked)
                playerStats1Month();
            if (player12Months.Checked)
                playerStats12Months();

            //            lblVersion.Text = lblVersion.Text + " [dll version " + logList.DBStats.Version + "]";
        }
         private void loadPlayerAverageLoad_Click(object sender, EventArgs e)
        {
            if (ru.conn.dbType == null)
                return;
            startDate = playerStart.Value;

            if (Top10Avg24Hours.Checked)
                playerAverage24Hours();
            if (Top10Avg7Days.Checked)
                playerAverage7Days();
            if (Top10Avg1Month.Checked)
                playerAverage1Month();
            if (Top10Avg12Months.Checked)
                playerAverage12Months();
        }

         private void loadPlayerCountLoad_Click(object sender, EventArgs e)
         {
             if (ru.conn.dbType == null)
                 return;
             startDate = playerStart.Value;

             if (top10Count24Hours.Checked)
                 playerCount24Hours();
             if (top10Count7Days.Checked)
                 playerCount7Days();
             if (top10Count1Month.Checked)
                 playerCount1Month();
             if (top10Count12Months.Checked)
                 playerCount12Months();
         }

         private void Top10CountSetNow_Click(object sender, EventArgs e)
         {
             startDate = DateTime.Now;
             top10CountStart.Value = startDate;
         }
         private void playerAvgSetNow_Click(object sender, EventArgs e)
        {
            startDate = DateTime.Now;
            top10AvgStart.Value = startDate;
 
        }
         private void btnSettings_Click(object sender, EventArgs e)
        {
            if (ShowDialog(ru.conn.UserId, "Enter Credentials"))
            {
                saveSettings();
                startProfile();
            }
        }

        private void refreshChart_Click(object sender, EventArgs e)
        {
            startProfile();
        }

        private void saveSettings()
        {
            Microsoft.Win32.RegistryKey exampleRegistryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(PROGRAMREG);
            exampleRegistryKey.SetValue("UserId", ru.conn.UserId);
            exampleRegistryKey.SetValue("Password", ru.conn.Password);
            exampleRegistryKey.SetValue("Server", ru.conn.Server);
            exampleRegistryKey.Close();
        }
        private void clearSettings()
        {
            Microsoft.Win32.RegistryKey exampleRegistryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(PROGRAMREG);
            exampleRegistryKey.SetValue("UserId", "");
            exampleRegistryKey.SetValue("Password", "");
            exampleRegistryKey.SetValue("Server", "");
            exampleRegistryKey.Close();
            ru.conn.UserId = "";
            ru.conn.Password = "";
            ru.conn.Server = "";
        }
        private void restoreSettings()
        {
            Microsoft.Win32.RegistryKey exampleRegistryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(PROGRAMREG);
            ru.conn.UserId = (string)exampleRegistryKey.GetValue("UserId");
            ru.conn.Password = (string)exampleRegistryKey.GetValue("Password");
            ru.conn.Server = (string)exampleRegistryKey.GetValue("Server");
            exampleRegistryKey.Close();

        }
        private bool ShowDialog(string text, string caption)
        {
            Credentials creds = new Credentials();
            creds.txtUserid.Text = ru.conn.UserId;
            creds.txtPassword.Text = ru.conn.Password;
            creds.txtServer.Text = ru.conn.Server;

            if (creds.ShowDialog() == DialogResult.OK)
            {
                ru.conn.UserId = creds.txtUserid.Text;
                ru.conn.Password = creds.txtPassword.Text;
                ru.conn.Server = creds.txtServer.Text;
                return true;
            }

            return false;
        }

 

    }
}
