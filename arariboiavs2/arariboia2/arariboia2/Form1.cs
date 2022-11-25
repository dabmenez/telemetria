using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arariboia2
{
    public partial class arduinoArariboia : Form
    {
        private string red, green, yellow;   //string to hold the red,green and yellow led intensity
        public delegate void d1(string indata);
        private static int counter;

        public arduinoArariboia()
        {
            InitializeComponent();
            serialPort.Open();
        }

        private void onButton_Click(object sender, EventArgs e)
        {
            //send command to arduino to turn pin 13 on
            serialPort.Write("A");
        }

        private void offButton_Click(object sender, EventArgs e)
        {
            //send command to arduino to turn pin 13 OFF
            serialPort.Write("a");
        }

        private void ServoAngle_Click(object sender, EventArgs e)
        {
            //Send angle value to Servo
            string m1 = 'S' + textBox1.Text;
            serialPort.Write(m1);
        }

        private void RedVal_Scroll(object sender, EventArgs e)
        {
            //Set RGB LED Red value
            red = "R" + RedVal.Value;
        }

        private void SendRedVal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(red))
            {
                red = "R0";
            }
            serialPort.Write(red);
        }

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string indata = serialPort.ReadLine();
            d1 writeit = new d1(Write2Form);
            Invoke(writeit, indata);

        }

        public void Write2Form(string indata)
        {
            //this fuction handle data sent from arduino
            char firstchar;
            Single numdata;
            Single volts;
            firstchar = indata[0];
            switch (firstchar)
            {
                case 'p':
                    counter++;
                    textBox2.Text = Convert.ToString(counter);
                    break;
                case 'v':
                    numdata = Convert.ToSingle(indata.Substring(1));
                    volts = numdata * 5 / 1024;
                    textBox3.Text = String.Format("{0:0.00}", volts);
                    progressBar1.Value = Convert.ToInt16(indata.Substring(1));
                    circularProgress.Text = String.Format("{0:0.00}%", (volts)*100/5);
                    circularProgress.Value = Convert.ToInt16(indata.Substring(1));
                    break;

            }
        }

        private void GreenVal_Scroll(object sender, EventArgs e)
        {
            //Set RGB LED Green value
            green = "G" + GreenVal.Value;
        }

        private void YellowVal_Scroll(object sender, EventArgs e)
        {
            //Set RGB LED Yellow value
            yellow = "Y" + YellowVal.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SendGreenVal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(green))
            {
                green = "0";
            }
            serialPort.Write(green);

        }

        private void SendYellowVal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(yellow))
            {
                yellow = "0";
            }
            serialPort.Write(yellow);
        }
    }
}