using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino_Serial_LED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // Open the serial port and catch any exceptions  this will need a drop down to select com port at a later time
            InitializeComponent();
            try
            {
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Send the control code for Red which is an ASCII r then wait for response
           // string RED; not needed as directly written to
            serialPort1.DiscardInBuffer();
            serialPort1.Write("r");
            // Changed code so textBox1 written directly from serial port
            textBox1.Text = serialPort1.ReadTo("@");
            //Change textBox1 colour to match LED colour on Arduino
            textBox1.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Send the control code for Orange which is an ASCII o then wait for response
            serialPort1.DiscardInBuffer();
            serialPort1.Write("o");
            // Changed code so textBox1 written directly from serial port
            textBox1.Text = serialPort1.ReadTo("@");
            //Change textBox1 colour to match LED colour on Arduino
            textBox1.BackColor = Color.Orange;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Send the control code for Green which is an ASCII g then wait for response
            serialPort1.DiscardInBuffer();
            serialPort1.Write("g");
            // Changed code so textBox1 written directly from serial port
            textBox1.Text = serialPort1.ReadTo("@");
            //Change textBox1 colour to match LED colour on Arduino
            textBox1.BackColor = Color.LightGreen;
        }
    }
}
