using Squirrel;
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

namespace Veverica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            AddVErsionNUmber();

            CheckForUpdates();
        }

        private void AddVErsionNUmber()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);

            lblVersion.Text = fileVersionInfo.FileVersion;
        }

        private async Task CheckForUpdates()
        {
            using (var manager = new UpdateManager(Properties.Settings.Default.UpdateUrl))
            {
                await manager.UpdateApp();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
