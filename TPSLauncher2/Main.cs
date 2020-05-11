using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;
using System.Collections.Specialized;

namespace TPSLauncher2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.Icon = TPSLauncher2.Properties.Resources.TPSicon;
            picLogo.Image = TPSLauncher2.Properties.Resources.TPS1;
            //if (!File.Exists("Lithtech.exe"))
           //{
            //    MessageBox.Show("Please move the launcher into the TPS folder.");
            //    Application.Exit();
            //}
        }

        /*private void Login()
        {
            bool networkUp = NetworkInterface.GetIsNetworkAvailable();
            if (networkUp == true)
            {
                //Code to link to forum login here
                MessageBox.Show("Welcome to TPS! Thanks for logging in " + txtUsername.Text, "Welcome" );
                if (txtUsername.Text.Contains("Debug") && txtPassword.Text.Contains("Debug"))
                {
                    LoggedIn player = new LoggedIn();
                    player.Show();
                    player.FormClosed += (s, ev) => Application.Exit();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Network Not Detected");
                //Debug login OR have hashed info saved from last time user logged in when connected to the forum and log them in automatically?
                if (txtUsername.Text.Contains("Debug") && txtPassword.Text.Contains("Debug"))
                {
                    LoggedIn player = new LoggedIn();
                    player.Show();
                    player.FormClosed += (s, ev) => Application.Exit();
                    this.Hide();
                }
            }
        }*/

        private void Login()
        {
            if (txtUsername.Text.Contains("") && txtPassword.Text.Contains(""))
            {
                LoggedIn player = new LoggedIn();
                player.Show();
                player.FormClosed += (s, ev) => Application.Exit();
                this.Hide();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
