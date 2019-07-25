using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;
using MathWorks.MATLAB.NET.Utility;
using MathWorks.MATLAB.NET.Arrays;
//using myPloter;
//using myPloterNative;
namespace GreenHouse02
{
    /// <summary>
    /// Serial Monitor Form 
    /// Reads from the desired serial port every "waitTime" seconds and displays to the monitor
    /// </summary>
    public partial class SerialMonitor : Form
    {
        private SerialPort Sender;                                                     //Desired serial port 
        private SerialPort Reciever;
        private string senderPort;                                                      //Input field from serial port
        private int stateSelection = 0;                                                  //State selection
        private DateTime date;                                                          //The current date time
        private string in_data;                                                         //The read data from the port
        private int currentSec;                                                         //The current second used for timing 
        private bool firstReading = false;                                              //Bool that monitor whether a reading has been taken
        private int waitTime = 5;                                                       //wait time in seconds
        private bool connected = false;
        private string recieverPort;
       // private Class1 myplot = new Class1();
        public SerialMonitor()
        {
            InitializeComponent();

        }

        private void Monitor_TextChanged(object sender, EventArgs e)
        {

        }

        /*Method executed when the start button is pressed
         * 
         */
        private void Start_Click(object sender, EventArgs e)
        {


            try
            {
                if (!connected)
                {
                    Sender = new SerialPort();                                                 //creates serial port
                    Sender.BaudRate = 9600;                                                    //sets baud rate
                    Sender.PortName = senderPort;                                                  //sets port number from device manager
                    Sender.Parity = Parity.None;                                               //sets parity
                    Sender.DataBits = 8;                                                       //sets data bit
                    Sender.Open();                                                        //tries to open serial port

                    Reciever = new SerialPort();                                                 //creates serial port
                    Reciever.BaudRate = 9600;                                                    //sets baud rate
                    Reciever.PortName = recieverPort;                                                  //sets port number from device manager
                    Reciever.Parity = Parity.None;                                               //sets parity
                    Reciever.DataBits = 8;                                                       //sets data bit
                    Reciever.StopBits = StopBits.One;                                            //sets stop bits
                    Reciever.DataReceived += Reciever_DataRecieved;
                    Reciever.Open();
                }

                Sender.WriteLine("12:13:14:15:");
                
                MessageBox.Show("Opened");                                             //confirms connection
                connected = true;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dumb");                                   //displays error with connection
            }

        }

        /*Method executes when data has been sent to the serial port
         * 
         */
        private void Reciever_DataRecieved(object sender, SerialDataReceivedEventArgs e)
        {
            if (connected)
            {
                try {
                    in_data = Reciever.ReadLine();                                                           //reads data from port
                    this.Invoke(new EventHandler(data_eventNoTimer));                                              //creates a new event using the data_event method
                }catch{

                }
            }
        }


        /*Method which handles data entry/decimation of data without a timmer
         * Use if the arduino will handle the timer delays
         * 
         */
        private void data_eventNoTimer(object sender, EventArgs e)
        {
            date = DateTime.Now;                                                                    //gets current time

            string time = date.Hour + ":" + date.Minute + ":" + date.Second;                        //creates a time string
            currentSec = date.Second;                                                               //gets the current seconds from the time  

           
            DataDisplay.AppendText(time + "\t\t\t " + in_data + "\n");                                              //display the time and reading in the textbox
          
        }


        /*Method which handles data entry/decimation of data
         * Use if the c# application will monitor the timer
         * 
         */
        private void data_event(object sender, EventArgs e)
        {
            date = DateTime.Now;                                                                    //gets current time

            string time = date.Hour + ":" + date.Minute + ":" + date.Second;                        //creates a time string
            currentSec = date.Second;                                                               //gets the current seconds from the time  
         
            if (currentSec % waitTime == 0 && firstReading)                                         //if its been waittime seconds and its the first reading within the second
            {
                DataDisplay.AppendText(time + "\t\t\t " + in_data+"\n");                                              //display the time and reading in the textbox
                firstReading = false;                                                               //the first reading has now happened 

            }
            else if(currentSec % waitTime != 0 && !firstReading)                                    //if it hasnt been waittime seconds and we already took the first reading
            {
                firstReading = true;                                                                //reset the firstreading bool to true so we can now take a reading when five seconds has passed
            }
           
        }

        /*Method that executes when the stop button is clicked
         * 
         */
        private void Stop_Click(object sender, EventArgs e)
        {
            connected = false;
            //save log
            //spam("s");
            Sender.WriteLine("s");
            Sender.Dispose();
            Sender.Close();
            
            Reciever.Dispose();
            Reciever.Close();
            //monitor.Close();                                                   //close monitor
            // this.Close();                                                      //close form
            /*Home x = new Home();
            x.Show();*/

        }

        /*Stores text in serial port text box to the serial port input field
         * 
         */
        private void PortInput_TextChanged(object sender, EventArgs e)
        {
            senderPort = PortInput.Text;                                       //stores the text in the port input field to the input field
        }

        private void Customize_CheckedChanged(object sender, EventArgs e)
        {
            stateSelection = 1;
        }

        private void Preset_CheckedChanged(object sender, EventArgs e)
        {
            stateSelection = 2;
        }

        private void CommunicationPort2_TextChanged(object sender, EventArgs e)
        {
            recieverPort = CommunicationPort2.Text;
            
        }
    }
}
