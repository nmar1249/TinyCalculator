/* ****************************************
 * Program:     TINY CALCULATOR
 * Programmer:  Nick Marine
 * Version:     0.8
 * 
 * Description:
 * This is just a small project I wanted to do for some time. The first
 * in a series of useless utility programs, the goal here is to practice C#
 * development in a Windows environment.
 * 
 */
 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinyCalculator
{
    public partial class Form1 : Form
    {
        //input
        public string s_input = "";
        public string total = "";
        public string temp = "", storage = "";
        bool flag_eq = false, flag_dec = false, flag_c = false;

        //current operation (addition, subtraction etc.)
        public string currentOp = "", lastOp = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            s_input += "1";
            Print();
        }

        private void B2_Click(object sender, EventArgs e)
        {
            s_input += "2";
            Print();
        }

        private void B3_Click(object sender, EventArgs e)
        {
            s_input += "3";
            Print();
        }

        private void B4_Click(object sender, EventArgs e)
        {
            s_input += "4";
            Print();
        }

        private void B5_Click(object sender, EventArgs e)
        {
            s_input += "5";
            Print();
        }

        private void B6_Click(object sender, EventArgs e)
        {
            s_input += "6";
            Print();
        }

        private void B7_Click(object sender, EventArgs e)
        {
            s_input += "7";
            Print();
        }

        private void B8_Click(object sender, EventArgs e)
        {
            s_input += "8";
            Print();
        }

        private void B9_Click(object sender, EventArgs e)
        {
            s_input += "9";
            Print();
        }

        private void B0_Click(object sender, EventArgs e)
        {
            s_input += "0";
            Print();
        }

        private void Solve_Click(object sender, EventArgs e)
        {
            flag_eq = true;
            Calculate();
            s_input = "";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            ClickOperations("+");
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            ClickOperations("-");
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            ClickOperations("*");
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            ClickOperations("/");
        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            if(flag_dec != true)
                s_input += ".";

            flag_dec = true;    //set decimal flag 

            Print();
        }

        private void Negate_Click(object sender, EventArgs e)
        {
            if (temp != "")
            {
                if (temp[0] == '-')
                {
                    temp = temp.Remove(0, 1);
                }
                else
                {
                    temp = temp.Insert(0, "-");
                }

                Display.Text = temp;
            }
            else if(s_input != "")
            {
                if (s_input[0] == '-')
                {
                    s_input = s_input.Remove(0, 1);
                }
                else
                {
                    s_input = s_input.Insert(0, "-");
                }

                Display.Text = s_input;
            }

            
        }

        private void DeleteLastNumber_Click(object sender, EventArgs e)
        {
            int l = s_input.Length - 1;
            if (s_input != "" && flag_eq == false) 
            {
                s_input = s_input.Remove(l);
                Print();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            //reset vars to default
            s_input = "";
            temp = "";
            flag_eq = false;
            flag_dec = false;
            Print();
        }

        private void ClearE_Click(object sender, EventArgs e)
        {
            if (s_input != "")
            {
                s_input = "";
                Print();
            }
        }

        private void Print()
        {
            if (s_input != "")
                Display.Text = s_input;
            else
                Display.Text = "0";
            

            if(flag_eq == true)
            {
                s_input = "";
                flag_eq = false;
            }
        }

        public void getInput()
        {
            if (temp == "")
                temp = s_input;
            else if (s_input != "")
                Calculate();

            s_input = "";
        }

        //determines whether to do a calculation based on a previously entered
        //operation (e.g. user enters 5 + 5 then -, this computes 5 + 5. If there is no
        //current operation, further input is prompted.
        private void ClickOperations(string op)
        {
            flag_c = false;

            if (currentOp != "")
            {
                Calculate();
                flag_c = true;
                s_input = "";
            }

            currentOp = op;

            if (flag_c != true)
                getInput();
        }
        private void Calculate()
        {
            Console.WriteLine("temp = " + temp + "s_input: " + s_input);
            if(temp != "" && s_input != "")
                if(currentOp == "+")
                    s_input = (Double.Parse(temp) + Double.Parse(s_input)).ToString();
                else if(currentOp == "*")
                    s_input = (Double.Parse(temp) * Double.Parse(s_input)).ToString();
                else if (currentOp == "-")
                    s_input = (Double.Parse(temp) - Double.Parse(s_input)).ToString();
                else if (currentOp == "/")
                    s_input = (Double.Parse(temp) / Double.Parse(s_input)).ToString();

            temp = s_input;     //store input as temp
            flag_dec = false;   //reset decimal flag
            currentOp = "";
            Print();
        }
    }
}
