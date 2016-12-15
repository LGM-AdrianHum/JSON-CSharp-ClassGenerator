// Copyright © 2010 Xamasoft

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Xamasoft.JsonClassGenerator.UI
{
    [SuppressMessage("ReSharper", "VirtualMemberCallInConstructor")]
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
#if !APPSERVICES
            btnSendFeedback.Visible = false;
            btnCheckUpdates.Visible = false;
#endif
            Font = SystemFonts.MessageBoxFont;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.xamasoft.com/json-class-generator");
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            lblVersion.Text = string.Format(lblVersion.Text, Assembly.GetExecutingAssembly().GetName().Version);
        }

        private void btnSendFeedback_Click(object sender, EventArgs e)
        {
#if APPSERVICES
            Program.appServices.ShowFeedbackForm(this);
#endif
        }

        private void btnCheckUpdates_Click(object sender, EventArgs e)
        {
#if APPSERVICES
            Program.appServices.UpdateChecker.ManualUpdatesCheck(this);
#endif
        }
    }
}