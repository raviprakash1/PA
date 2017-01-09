using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace MyPA
{
     
    public partial class Form1 : Form
    {
        static internal bool _isSpeaking = false;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 2000;

            SystemInformationSpeech();
           // string sysInfo = SystemInformation();
           //// Thread childThread = new Thread(CallToChildThread);
           // SpeakText.Speak("Initializing the system. " + sysInfo);
           // if (!_isSpeak)
           // {
           //     SpeakText.Speak("Initializing the system. " + sysInfo);
           // }
        }
       
        
        private string SystemInformationSpeech()//Getting system info
        {
            StringBuilder StringBuilder1 = new StringBuilder(string.Empty);
            try
            {
                SpeakText.Speak("Initializing. Activating Biometric and face recognization process. Activation Succeed.");
               
                SpeakText.Speak("Currently loading system files from drive.");
                progressBar1.Value = 10;
                SpeakText.Speak(string.Format("Operation System:  {0}", Environment.OSVersion));
                if (Environment.Is64BitOperatingSystem)
                    SpeakText.Speak(string.Format("64 Bit Operating System."));
                else
                    SpeakText.Speak(string.Format("32 Bit Operating System."));
                SpeakText.Speak(string.Format("SystemDirectory:  {0}", Environment.SystemDirectory));
                SpeakText.Speak(string.Format("ProcessorCount:  {0}", Environment.ProcessorCount));
                progressBar1.Value = 20;
                SpeakText.Speak(string.Format("UserDomainName:  {0}", Environment.UserDomainName));
                SpeakText.Speak(string.Format("UserName: {0}", Environment.UserName));
                //Drives
                SpeakText.Speak(string.Format("LogicalDrives "));
                foreach (System.IO.DriveInfo DriveInfo1 in System.IO.DriveInfo.GetDrives())
                {
                    try
                    {
                        SpeakText.Speak(string.Format("Drive: {0} VolumeLabel: " +
                          "{1}. DriveType: {2}. DriveFormat: {3}." +
                          "TotalSize: {4}. AvailableFreeSpace: {5}",
                          DriveInfo1.Name, DriveInfo1.VolumeLabel, DriveInfo1.DriveType,
                          DriveInfo1.DriveFormat, DriveInfo1.TotalSize, DriveInfo1.AvailableFreeSpace));
                    }
                    catch
                    {
                    }
                }
                SpeakText.Speak(string.Format("SystemPageSize:  {0}\n", Environment.SystemPageSize));
                SpeakText.Speak(string.Format("Version:  {0}", Environment.Version));
            }
            catch
            {
            }
            return StringBuilder1.ToString();
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
