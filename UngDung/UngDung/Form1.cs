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

namespace UngDung
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Process.Start("CMD");
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Process.Start("NOTEPAD");
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Process.Start("CHROME.EXE","youtube.com");
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Process.Start("CHROME.EXE", "facebook.com");
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            Process.Start("CHROME.EXE", "htql.vnkgu.edu.vn");
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            Process.Start("CHROME.EXE", "gmail.com");
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            Process.Start("CHROME.EXE", "google.com");
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            Process.Start("Chrome.exe", "http://www.vnkgu.edu.vn/wps/portal");
        }
        private int i = 3;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += i;
            if (label1.Left > 500 || label1.Left <= 0)
            {
                i = -i;
            }
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            MaillHangLoat f = new MaillHangLoat();
            f.ShowDialog();
        }
    }
}
