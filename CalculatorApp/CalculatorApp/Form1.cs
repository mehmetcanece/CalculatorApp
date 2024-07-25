using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double num1;
        double num2;
        string option;
        double result = 0;


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

            displayText.Text = displayText.Text + "6";
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            displayText.Text = displayText.Text + "1";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            displayText.Text = displayText.Text + "2";
        }


        private void button3_Click(object sender, EventArgs e)
        {
            displayText.Text = displayText.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            displayText.Text = displayText.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            displayText.Text = displayText.Text + "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            displayText.Text = displayText.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            displayText.Text = displayText.Text + "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            displayText.Text = displayText.Text + "9";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (displayText.Text == "" && option != "+" && option != "-" && option != "*" && option != "/")
            {
                displayText.Text = displayText.Text + "0.";
            }
            else 
            {
                displayText.Text = displayText.Text + "0";
            }
            
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }



        private void button15_Click(object sender, EventArgs e)
        {
            option = "+";
            if (displayText.Text != "" && displayText.Text != null && displayText.Text != "-")
            {
                num1 = double.Parse(displayText.Text);
            }
            else
            {

            }
            displayText.Clear();
        }


        private void button14_Click_1(object sender, EventArgs e)
        {
            if(option==null)
            {
                option = "-";
            }
            


            if (displayText.Text.Length == 0)
            {
                displayText.Text += "-";
            }

            if (displayText.Text != "" && displayText.Text != null && displayText.Text != "-")
            {
                num1 = double.Parse(displayText.Text);
                displayText.Clear();
            }           


        }

       


        private void button13_Click(object sender, EventArgs e)
        {
            option = "*";
            if (displayText.Text != "" && displayText.Text != null && displayText.Text != "-")
            {
                num1 = double.Parse(displayText.Text);
            }
            displayText.Clear();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            option = "/";
            if (displayText.Text != "" && displayText.Text != null)
            {
                num1 = double.Parse(displayText.Text);
            }           
            displayText.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (displayText.Text != "" && displayText.Text != null)
            {
                num2 = double.Parse(displayText.Text);
            }
            if (option == "+")
            {
                displayText.Clear();
                result = num1 + num2;
                displayText.Text = result + " ";
                displayText.Clear();

            }
            if (option == "-")
            {
                displayText.Clear();

                result = num1 - num2;
                displayText.Text = result + " ";
                displayText.Clear();


            }
            if (option == "*")
            {
                displayText.Clear();

                result = num1 * num2;
                displayText.Text = result + " ";
                displayText.Clear();

            }
            if (option == "^")
            {
                displayText.Clear();
                result = Math.Pow(num1, num2);
                displayText.Text = result + "";
                displayText.Clear();
            }
            if (option == "/")
            {
                displayText.Clear();
                try
                {
                    result = num1 / num2;
                    displayText.Text = result + " ";
                    displayText.Clear();


                }
                catch (DivideByZeroException)
                {
                    displayText.Text = "ERROR";
                    displayText.Clear();

                }
            }
            if (option == null)
            {
                result = num2;

            }

          
               displayText.Text = result + " ";   
           
                   
        }

        private void button11_Click(object sender, EventArgs e)
        {
            displayText.Clear();
            result = 0;
            num1 = 0;
            num2 = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void displayText_TextChanged(object sender, EventArgs e)
        {

        }

        private void dipslayText_KeyPress(object sender, KeyEventArgs e)
        {
            

      
         
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(displayText.Text.Length) > 0)
            {
                double karekok = Convert.ToDouble(displayText.Text);
                karekok = Math.Sqrt(karekok);
                displayText.Text = Convert.ToString(karekok);
            }
            else
            {

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(displayText.Text.Length) > 0)
            {
                double yuzde = Convert.ToDouble(displayText.Text);
                yuzde = yuzde / 100;
                displayText.Text = Convert.ToString(yuzde);
            }
            else
            {

            }
        }

        private void button19_Click(object sender, EventArgs e)
        {

            option = "^";
            if (displayText.Text != "" && displayText.Text != null)
            {
                num1 = double.Parse(displayText.Text);
            }
            displayText.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(displayText.Text.Length) > 0)
            {
                double kare = Convert.ToDouble(displayText.Text);
                kare = Math.Pow(kare, 2);
                displayText.Text = Convert.ToString(kare);
            }
            else
            {

            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(displayText.Text.Length) > 0)
            {
                displayText.Text = displayText.Text.Remove(displayText.Text.Length - 1, 1);
            }
            else
            {

            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(displayText.Text.Length) > 0 && displayText.Text.Contains(".") == false)
            {
                displayText.Text += ".";
            }
            else
            {

            }
        }
    }
}



