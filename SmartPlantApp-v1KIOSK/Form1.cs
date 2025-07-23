using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace APU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.WindowState = FormWindowState.Maximized;

        }
       

        private async void Form1_Load(object sender, EventArgs e)
        {
            await APUview.EnsureCoreWebView2Async(null);
            // APUview.CoreWebView2.Navigate("//office.com");
            // Smartplant Liv2 192.168.8.11 
            // SMartplant Liv1 192.168.5.11
            APUview.CoreWebView2.Navigate("https://lv2-smartplant.hutchinsonna.com:8443/LivingstonSmartPlantLIVE/celldashboard/celldashboardmenu.jsp?");
            //APUview.Dock = DockStyle.Fill;
            this.Controls.Add(APUview);
            //APUview.CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("example: ID cell16 passwd cl16");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ensure you are connected to the production wifi (Hutchinson) or HNA_Network wifi. If this device has disconnected and needs network password contact local IT");

        }
        private void APUview_Click(object sender, EventArgs e)
        {
            if (APUview.CoreWebView2 != null)
            {
                // APUview.CoreWebView2.Navigate("//office.com");
                APUview.CoreWebView2.Navigate("https://lv2-smartplant.hutchinsonna.com:8443/LivingstonSmartPlantLIVE/celldashboard/celldashboardmenu.jsp?");
            }
            else
            {
                MessageBox.Show("WebView2 is not initialized yet!");
            }
            APUview.Focus();
        }
        
        /*
        private void button3_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
        }
        */

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify the URL you want to navigate to
            string url = "https://app.getmaintainx.com/auth/login?~channel=Direct%20Traffic&~feature=organic&~campaign=%2Flogin&~last_page_seen=https%3A%2F%2Fwww.getmaintainx.com%2Flogin&gclid=EAIaIQobChMI7ZubrYKAjAMVcS7UAR0YWBlIEAAYASAAEgJskfD_BwE&_branch_match_id=1377659230372389608&utm_source=Direct%20Traffic&utm_campaign=%2Flogin&utm_medium=organic&_branch_referrer=H4sIAAAAAAAAA2XNTUvDQBSF4V%2BTLJtSoQVhkNs2QpQutGqJm3BnvPNRJzPhZsK4ym833QnCOZtn89qUhvG%2BqiSvDKUeXUjLf1Yq9tWFAtitVtdJPhjl3ZeoocHmJcqDPTW7z0ly%2BwxXOH2o8%2B4dXtftZe%2BbGqCFM0BtnsZvfez2uS5nj2PqBjTUjURB2Fu1uINi87gs5%2FwvvrCPxoVyVtgP6EwQf8hiCOTF0TGpVGzWb4xaO1XOmjBNTCKywXADJk3MLphOcswjsThYjj39AmyRneD4AAAA";

            // Use Process.Start to open the URL in the default web browser
            //System.Diagnostics.Process.Start(url);
            APUview.CoreWebView2.Navigate("https://app.getmaintainx.com/auth/login?~channel=Direct%20Traffic&~feature=organic&~campaign=%2Flogin&~last_page_seen=https%3A%2F%2Fwww.getmaintainx.com%2Flogin&gclid=EAIaIQobChMI7ZubrYKAjAMVcS7UAR0YWBlIEAAYASAAEgJskfD_BwE&_branch_match_id=1377659230372389608&utm_source=Direct%20Traffic&utm_campaign=%2Flogin&utm_medium=organic&_branch_referrer=H4sIAAAAAAAAA2XNTUvDQBSF4V%2BTLJtSoQVhkNs2QpQutGqJm3BnvPNRJzPhZsK4ym833QnCOZtn89qUhvG%2BqiSvDKUeXUjLf1Yq9tWFAtitVtdJPhjl3ZeoocHmJcqDPTW7z0ly%2BwxXOH2o8%2B4dXtftZe%2BbGqCFM0BtnsZvfez2uS5nj2PqBjTUjURB2Fu1uINi87gs5%2FwvvrCPxoVyVtgP6EwQf8hiCOTF0TGpVGzWb4xaO1XOmjBNTCKywXADJk3MLphOcswjsThYjj39AmyRneD4AAAA");
        }
        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            APUview.CoreWebView2.Navigate("https://lv2-smartplant.hutchinsonna.com:8443/LivingstonSmartPlantLIVE/celldashboard/celldashboardmenu.jsp?");
        }
        //stop those pesky people from exiting via Alt f4 # Forced Kiosk Mode 
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }

            base.OnFormClosing(e);
        }
    }
}
