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
            // Send the control code for Red then wait for response
            string RED;
            serialPort1.DiscardInBuffer();
            serialPort1.Write("r");
            RED = serialPort1.ReadTo("@");
            textBox1.Text = RED;
            textBox1.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string RED;
            serialPort1.DiscardInBuffer();
            serialPort1.Write("o");
            
            RED = serialPort1.ReadTo("@");
            textBox1.Text = RED;
            textBox1.BackColor = Color.Orange;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string RED;
            serialPort1.DiscardInBuffer();
            serialPort1.Write("g");
            RED = serialPort1.ReadTo("@");
            textBox1.Text = RED;
            textBox1.BackColor = Color.LightGreen;
        }
    }
}
