using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuantumConcepts.Common.Extensions;
using System.ServiceProcess;
using QuantumConcepts.Common.Forms.UI;
using QuantumConcepts.Common.Utils;
using System.Configuration.Install;
using System.Reflection;
using System.Threading;
using QuantumConcepts.Common.Forms.UI.Forms;

namespace QuantumConcepts.Common.WindowsService.UI.Forms
{
    public partial class ServiceControl : Form
    {
        private delegate void BackgroundProcessComplete();

        public bool ShowMenu { get { return menuStrip.Visible; } set { menuStrip.Visible = value; } }

        public ServiceControl()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.Text = this.Text.FormatString(BaseService.ApplicationTitle);
            configureButton.Visible = BaseService.EnableConfiguration;
            statusTimer.Start();
        }

        private void statusTimer_Tick(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void feedbackMenuItem_Click(object sender, EventArgs e)
        {
            using (Feedback dialog = new Feedback())
            {
                dialog.ShowDialog();
            }
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            using (About dialog = new About())
            {
                dialog.ShowDialog();
            }
        }

        private void configureButton_Click(object sender, EventArgs e)
        {
            if (BaseService.ServiceConfigurationFunction != null && BaseService.ServiceConfigurationFunction() && restartButton.Enabled && MessageBox.Show("In order for the updated configuration to take place, the service must be restarted. Would you like to restart the service now?", "Restart Service", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                Restart();
        }

        private void installButton_Click(object sender, EventArgs e)
        {
            RunInBackground("Installing...", BaseService.Install);
        }

        private void uninstallButton_Click(object sender, EventArgs e)
        {
            RunInBackground("Uninstalling...", BaseService.Uninstall);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            RunInBackground("Starting...", () => BaseService.Start());
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            RunInBackground("Stoping...", () => BaseService.Stop());
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void UpdateStatus()
        {
            using (ServiceController controller = new ServiceController(BaseService.ServiceName))
            {
                try
                {
                    serviceLabel.Text = controller.ServiceName;
                    statusLabel.Text = controller.Status.GetDescription();
                    installButton.Enabled = false;
                    uninstallButton.Enabled = (controller.Status == ServiceControllerStatus.Stopped);
                    startButton.Enabled = (controller.Status == ServiceControllerStatus.Stopped);
                    stopButton.Enabled = (controller.Status == ServiceControllerStatus.Running);
                    restartButton.Enabled = stopButton.Enabled;
                }
                catch
                {
                    serviceLabel.Text = "Not Installed";
                    statusLabel.Text = "Not Installed";
                    installButton.Enabled = true;
                    uninstallButton.Enabled = false;
                    startButton.Enabled = false;
                    stopButton.Enabled = false;
                    restartButton.Enabled = false;
                }
            }
        }

        private void Restart()
        {
            RunInBackground("Restarting...", () => BaseService.Restart());
        }

        private void RunInBackground(string status, Action action)
        {
            statusTimer.Stop();
            statusLabel.Text = status;
            this.Enabled = false;

            ThreadPool.QueueUserWorkItem(new WaitCallback(o =>
            {
                action();

                this.Invoke(new BackgroundProcessComplete(() =>
                {
                    statusTimer.Start();
                    this.Enabled = true;
                }));
            }));
        }
    }
}
