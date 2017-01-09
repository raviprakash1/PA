using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 200;

            for (i = 0; i <= 200; i++)
            {
                progressBar1.Value = i;
            }

            string sysInfo = SystemInformation();
        }

        private string SystemInformation()//Getting system info
        {
            StringBuilder StringBuilder1 = new StringBuilder(string.Empty);
            try
            {
                StringBuilder1.AppendFormat("Operation System:  {0}\n", Environment.OSVersion);
                if (Environment.Is64BitOperatingSystem)
                    StringBuilder1.AppendFormat("\t\t  64 Bit Operating System\n");
                else
                    StringBuilder1.AppendFormat("\t\t  32 Bit Operating System\n");
                StringBuilder1.AppendFormat("SystemDirectory:  {0}\n", Environment.SystemDirectory);
                StringBuilder1.AppendFormat("ProcessorCount:  {0}\n", Environment.ProcessorCount);
                StringBuilder1.AppendFormat("UserDomainName:  {0}\n", Environment.UserDomainName);
                StringBuilder1.AppendFormat("UserName: {0}\n", Environment.UserName);
                //Drives
                StringBuilder1.AppendFormat("LogicalDrives:\n");
                foreach (System.IO.DriveInfo DriveInfo1 in System.IO.DriveInfo.GetDrives())
                {
                    try
                    {
                        StringBuilder1.AppendFormat("\t Drive: {0}\n\t\t VolumeLabel: " +
                          "{1}\n\t\t DriveType: {2}\n\t\t DriveFormat: {3}\n\t\t " +
                          "TotalSize: {4}\n\t\t AvailableFreeSpace: {5}\n",
                          DriveInfo1.Name, DriveInfo1.VolumeLabel, DriveInfo1.DriveType,
                          DriveInfo1.DriveFormat, DriveInfo1.TotalSize, DriveInfo1.AvailableFreeSpace);
                    }
                    catch
                    {
                    }
                }
                StringBuilder1.AppendFormat("SystemPageSize:  {0}\n", Environment.SystemPageSize);
                StringBuilder1.AppendFormat("Version:  {0}", Environment.Version);
            }
            catch
            {
            }
            return StringBuilder1.ToString();
        }
    }
}
