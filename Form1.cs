using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{

    public partial class Form1 : Form
    {
        private double sum = 0;
        private double InputVal = 0;
        private bool isFirst = true;
        private bool isFirstChar = true;
        private string currentchar = "";
        private bool equal = true;
        public Form1()
        {
            InitializeComponent();
            lblout.Text = "";
            //char operatorCharacter = '';

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button selectedButton = (Button)sender;

            txtOut.Text += selectedButton.Text;

            if (isFirst == true)
            {
                InputVal = double.Parse(txtOut.Text);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtOut.Clear();
        }


        private void button12_Click(object sender, EventArgs e)
        {
            txtOut.Text += "=";
        }

        private void btnOperatorClick(object sender, EventArgs e)
        {
            Button operatorButton = (Button)sender;
            if (isFirst == true)
            {
                isFirst = false;
            }
            if (equal == true)
            {
                currentchar = operatorButton.Text;
                equal = false;
            }

            if (isFirstChar == true)
            {
                isFirstChar = false;

                switch (operatorButton.Text)
                {
                    case "+":


                        lblout.Text = txtOut.Text + operatorButton.Text;
                        sum = InputVal;
                        currentchar = "+";
                        txtOut.Clear();
                        break;
                    case "-":

                        lblout.Text = txtOut.Text + operatorButton.Text;
                        sum = InputVal;
                        currentchar = "-";
                        txtOut.Clear();
                        break;
                    case "x":

                        lblout.Text = txtOut.Text + operatorButton.Text;
                        sum = InputVal;
                        currentchar = "x";
                        txtOut.Clear();
                        break;
                    case "/":

                        lblout.Text = txtOut.Text + operatorButton.Text;
                        sum = InputVal;
                        currentchar = "/";
                        txtOut.Clear();
                        break;

                }
            }
            else
            {
           
                switch (currentchar)
                 {
                     case "+":
                         lblout.Text = "";
                         sum += double.Parse(txtOut.Text);
                         lblout.Text = sum.ToString() + operatorButton.Text;
                         currentchar = operatorButton.Text;
                         txtOut.Clear();
                         break;
                     case "-":
                        lblout.Text = "";
                        sum -= double.Parse(txtOut.Text);
                        lblout.Text = sum.ToString() + operatorButton.Text;
                        currentchar = operatorButton.Text;
                        txtOut.Clear();
                        break;
                     case "x":
                        lblout.Text = "";
                        sum *= double.Parse(txtOut.Text);
                        lblout.Text = sum.ToString() + operatorButton.Text;
                        currentchar = operatorButton.Text;
                        txtOut.Clear();
                        break;
                     case "/":
                        lblout.Text = "";
                        sum /= double.Parse(txtOut.Text);
                        lblout.Text = sum.ToString() + operatorButton.Text;
                        currentchar = operatorButton.Text;
                        txtOut.Clear();
                        break;

                 }
            }


        }

        private void btnEqualTo_Click(object sender, EventArgs e)
        {
            equal = true;
            switch (currentchar)
            {
                case "+":
                    lblout.Text = "";
                    sum += double.Parse(txtOut.Text);
                    lblout.Text = "="+sum.ToString();
                    
                    break;
                case "-":
                    lblout.Text = "";
                    sum -= double.Parse(txtOut.Text);
                    lblout.Text = "=" + sum.ToString();
                    
                    break;
                case "x":
                    lblout.Text = "";
                    sum *= double.Parse(txtOut.Text);
                    lblout.Text = "=" + sum.ToString();
                    
                    break;
                case "/":
                    lblout.Text = "";
                    sum /= double.Parse(txtOut.Text);
                    lblout.Text = "=" + sum.ToString();
                    
                    break;

            }
        }
    }
}
