using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuantumConcepts.Common.Extensions;
using System.Diagnostics;

namespace QuantumConcepts.Common.WindowsService.UI.Forms
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.Text = this.Text.FormatString(BaseService.ApplicationTitle);
            titleLabel.Text = titleLabel.Text.FormatString(BaseService.ApplicationTitle, BaseService.Version);
            copyrightLabel.Text = copyrightLabel.Text.FormatString(DateTime.Now.Year);
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://{0}".FormatString(((LinkLabel)sender).Text));
        }
    }
}
