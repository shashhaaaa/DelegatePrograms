using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SampleProgramDelegate.Classes;

namespace SampleProgramDelegate
{
    public partial class Form1: Form
    {
        GetAnswer delegateAddition;
        DisplayOutput<string> DisplayOutput;
        private int num1, num2;
        private string message;
        public Form1()
        {
            InitializeComponent();
            delegateAddition = new GetAnswer(Formula.getSum);
            DisplayOutput = new DisplayOutput<string>(GenericDelegates.getMessage);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty($"{textBox1.Text}") && string.IsNullOrEmpty($"{textBox2.Text}"))
            {
                MessageBox.Show("Empty");
                return;
            }
            
            num1 = Int32.Parse(textBox1.Text);
            num2 = Int32.Parse(textBox2.Text);
            MessageBox.Show($"{delegateAddition(num1, num2)}");
        
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            message = textBox3.Text; 
            MessageBox.Show(DisplayOutput(message));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
