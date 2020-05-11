using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices;
using InjectionLibrary;
using JLibrary.PortableExecutable;
using System.Threading;

namespace TPSLauncher2
{
    public partial class LoggedIn : Form
    {
        public LoggedIn()
        {
            InitializeComponent();
            PlayerStats();
            Settings();

        }

        private void Settings()
        {
            txtRed.Text = "25";
            txtGreen.Text = "255";
            txtBlue.Text = "255";

            cbFog.Checked = true;
            cbRunLock.Checked = true;
            cbTracers.Checked = true;
            cbvSync.Checked = true;
            cbWindowed.Checked = true;
        }

        void PlayerStats()
        {
            decimal Kills = 63;
            decimal Deaths = 22;
            decimal Ratio = Kills / Deaths;

            txtKills.Text = "Kills: " + Kills;
            txtDeaths.Text = "Deaths: " + Deaths;
            txtRatio.Text = "Ratio: " + Math.Round(Ratio, 2);
            Status.Text = "Status: Idle...";
        }

        void SingleGame()
        {
            ProcessStartInfo singleInfo = new ProcessStartInfo
            {
                FileName = "Lithtech.exe",
                Arguments = "-windowtitle TPS -rez GAME.rez -rez ENGINE.rez +windowed 1"
            };
            Process process = Process.Start(singleInfo);
            Status.Text = "Status: Playing Single TPS!";
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr OpenProcess(
        int dwDesiredAccess,
        bool bInheritHandle,
        int dwProcessId
        );


        void LaunchMultiGame()
        {
            int IP = Convert.ToInt32(txtIP.Text);
            int Port = Convert.ToInt32(txtPort.Text);

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "Lithtech.exe",
                Arguments = "-GOMULTIJOIN 1 +join " + IP + ":" + Port + "-windowtitle TPS -rez GAME.rez -rez ENGINE.rez +windowed 1"
            };
            Process process = Process.Start(startInfo);
            Status.Text = "Status: Playing Multi TPS!";
        }

        private void picAvi_Click(object sender, EventArgs e)
        {
            if (!File.Exists("Lithtech.exe"))
            {
                MessageBox.Show("You Must have Lithtech.EXE to launch the game! If you deleted it by accident, we can download the backup copy");
            }
            else { SingleGame(); }
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            if(!File.Exists("Lithtech.exe"))
            {
                MessageBox.Show("You Must have Lithtech.EXE to launch the game! If you deleted it by accident, we can download the backup copy");
            } else { LaunchMultiGame(); }
        }

        private void btnUpdates_Click(object sender, EventArgs e)
        {
            MessageBox.Show("coming soon");
        }

        private void btnLTB2LTA_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Path.GetTempPath(), "ltb2lta.exe");
            File.WriteAllBytes(path, TPSLauncher2.Properties.Resources.ltb2lta);
            Process.Start(path);
        }

        private void btnRezXtract_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Path.GetTempPath(), "rezxtract.exe");
            File.WriteAllBytes(path, TPSLauncher2.Properties.Resources.rezxtract);
            Process.Start(path);
        }

        private void btnRezInject_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Path.GetTempPath(), "rezinject.exe");
            File.WriteAllBytes(path, TPSLauncher2.Properties.Resources.rezinject);
            Process.Start(path);
        }

        private void btnDTXViewer_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Path.GetTempPath(), "dtxview.exe");
            File.WriteAllBytes(path, TPSLauncher2.Properties.Resources.dtxview);
            Process.Start(path);
        }

        private void btnDTXConvert_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Path.GetTempPath(), "dtxconvert.exe");
            File.WriteAllBytes(path, TPSLauncher2.Properties.Resources.dtxconvert);
            Process.Start(path);
        }

        private void btnDump_Click(object sender, EventArgs e)
        {
            if(!Directory.Exists("ModTools"))
            {
                Directory.CreateDirectory("ModTools");
            }

            string ltb2lta = Path.Combine(Path.GetFullPath("ModTools"), "lbt2lta.exe");
            File.WriteAllBytes(ltb2lta, TPSLauncher2.Properties.Resources.ltb2lta);
            string rezinject = Path.Combine(Path.GetFullPath("ModTools"), "rezinject.exe");
            File.WriteAllBytes(rezinject, TPSLauncher2.Properties.Resources.rezinject);
            string rezxtract = Path.Combine(Path.GetFullPath("ModTools"), "rezxtract.exe");
            File.WriteAllBytes(rezxtract, TPSLauncher2.Properties.Resources.rezxtract);
            string dtxview = Path.Combine(Path.GetFullPath("ModTools"), "dtxview.exe");
            File.WriteAllBytes(dtxview, TPSLauncher2.Properties.Resources.dtxview);
            string dtxconvert = Path.Combine(Path.GetFullPath("ModTools"), "dtxconvert.exe");
            File.WriteAllBytes(dtxconvert, TPSLauncher2.Properties.Resources.dtxconvert);
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists("ModTools\\Official"))
            {
                Directory.CreateDirectory("ModTools\\Official");
            }

            string zip = Path.Combine(Path.GetFullPath("ModTools\\Official"), "tps.zip");
            File.WriteAllBytes(zip, TPSLauncher2.Properties.Resources.TPSTools);
            ZipFile.ExtractToDirectory("ModTools\\Official\\tps.zip", "ModTools\\Official");
            File.Delete("ModTools\\Official\\tps.zip");
        }

        private void btn_castart_Click(object sender, EventArgs e)
        {
            ProcessStartInfo singleInfo = new ProcessStartInfo
            {
                FileName = "FixedEngine.exe",
                Arguments = "-windowtitle TPS -rez Test +windowed 1"
            };
            Process process = Process.Start(singleInfo);
            Status.Text = "Status: Playing CA!";

            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                Thread.Sleep(10000);
                if (File.Exists("hax.dll"))
                {
                    var injector = InjectionMethod.Create(InjectionMethodType.ManualMap);
                    var processId = Process.GetProcessesByName("FixedEngine")[0].Id;
                    var hModule = IntPtr.Zero;

                    using (var img = new PortableExecutable(TPSLauncher2.Properties.Resources.hax))
                        hModule = injector.Inject(img, processId);

                    if (hModule != IntPtr.Zero)
                    {
                        // injection was successful
                        MessageBox.Show("Injection Successful");
                    }
                    else
                    {
                        // injection failed
                        if (injector.GetLastError() != null)
                            MessageBox.Show(injector.GetLastError().Message);
                    }
                }
            }).Start();
        }
    }
}
