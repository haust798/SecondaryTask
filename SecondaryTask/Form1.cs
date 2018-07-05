using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace SecondaryTask
{
    public partial class Form1 : Form
    {
        System.Timers.Timer t;
        Stopwatch watch = Stopwatch.StartNew();
        int[] intervals = {5000,10000,50000,100000};
        int index = 0;
        StreamWriter writer = new StreamWriter("C:\\Users\\MS SocialNUI\\Desktop\\Downloads\\KBTest.txt");
        public Form1()
        {
            InitializeComponent();
            serialPort1.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            writer.WriteLine(GetTimestamp(DateTime.UtcNow) + "   " + "Test started");
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            txtLetter.ForeColor = Color.Red;
            writer.WriteLine(GetTimestamp(DateTime.UtcNow) + "   " + "Text color changed");
        }

        private void txtLetter_Click(object sender, EventArgs e)
        {
            writer.WriteLine(GetTimestamp(DateTime.UtcNow) + "   " + "Clicked");

            // To make the focus disappear
            txtLetter.Enabled = false;
            txtLetter.Enabled = true;

            t = new System.Timers.Timer();
            if (index < intervals.Length)
            {
                t.Interval = intervals[index];
                Console.WriteLine("Interval is: "+ intervals[index]);
                index += 1;
            }
            t.Start();
            t.Elapsed += OnTimeEvent;
            txtLetter.ForeColor = Color.Black;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (t != null) { t.Stop(); }
            writer.WriteLine(GetTimestamp(DateTime.UtcNow) + "   " + "Test completed");
            Application.DoEvents();
            writer.Close();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Console.WriteLine("Diff: " + serialPort1.ReadLine());
            try
            {
                writer.WriteLine(GetTimestamp(DateTime.UtcNow) + "   " + serialPort1.ReadLine());
            }
            catch (System.Exception ex){}
        }

        private long GetTimestamp(DateTime dateTime)
        {
            DateTime dt1970 = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return (dateTime.Ticks - dt1970.Ticks) / 10000;
        }
    }
}
