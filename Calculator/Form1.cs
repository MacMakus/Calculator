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
        private string save_NumberList1;

        string setOperator;

        private bool set_Plus;
        private bool set_Minus;
        private bool set_Multiple;
        private bool set_Divide;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Numb1_Button_Click(object sender, EventArgs e)
        {
            CalTextBox.Text += "1";
        }

        private void Numb2_Button_Click(object sender, EventArgs e)
        {
            CalTextBox.Text += "2";
        }

        private void Numb3_Button_Click(object sender, EventArgs e)
        {
            CalTextBox.Text += "3";
        }

        private void Numb4_Button_Click(object sender, EventArgs e)
        {
            CalTextBox.Text += "4";
        }

        private void Numb5_Button_Click(object sender, EventArgs e)
        {
            CalTextBox.Text += "5";
        }

        private void Numb6_Button_Click(object sender, EventArgs e)
        {
            CalTextBox.Text += "6";
        }

        private void Numb7_Button_Click(object sender, EventArgs e)
        {
            CalTextBox.Text += "7";
        }

        private void Numb8_Button_Click(object sender, EventArgs e)
        {
            CalTextBox.Text += "8";
        }

        private void Numb9_Button_Click(object sender, EventArgs e)
        {
            CalTextBox.Text += "9";
        }

        private void Numb0_Button_Click(object sender, EventArgs e)
        {
            CalTextBox.Text += "0";
        }

        private void Plus_Button_Click(object sender, EventArgs e)
        {
            setOperator = "+";
            save_NumberList1 = CalTextBox.Text;
            CalTextBox.Text = "";
        }

        private void Minus_Button_Click(object sender, EventArgs e)
        {
            setOperator = "-";
            save_NumberList1 = CalTextBox.Text;
            CalTextBox.Text = "";
        }

        private void Multiple_Button_Click(object sender, EventArgs e)
        {
            setOperator = "*";
            save_NumberList1 = CalTextBox.Text;
            CalTextBox.Text = "";
        }

        private void Divide_Button_Click(object sender, EventArgs e)
        {
            setOperator = "/";
            save_NumberList1 = CalTextBox.Text;
            CalTextBox.Text = "";
        }

        private void Result_Button_Click(object sender, EventArgs e)
        {
            int convert_List1;
            int convert_List2;
            switch (setOperator)
            {
                case "+":
                    convert_List1 = Convert.ToInt32(save_NumberList1);
                    convert_List2 = Convert.ToInt32(CalTextBox.Text);
                    CalTextBox.Text = (convert_List1 + convert_List2).ToString();
                    break;
                case "-":
                    convert_List1 = Convert.ToInt32(save_NumberList1);
                    convert_List2 = Convert.ToInt32(CalTextBox.Text);
                    CalTextBox.Text = (convert_List1 - convert_List2).ToString();
                    break;
                case "*":
                    convert_List1 = Convert.ToInt32(save_NumberList1);
                    convert_List2 = Convert.ToInt32(CalTextBox.Text);
                    CalTextBox.Text = (convert_List1 * convert_List2).ToString();
                    break;
                case "/":
                    convert_List1 = Convert.ToInt32(save_NumberList1);
                    convert_List2 = Convert.ToInt32(CalTextBox.Text);
                    CalTextBox.Text = (convert_List1 / convert_List2).ToString();
                    break;
            }


        }

        private void Key_Press(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) 
            {
                CalTextBox.Text += e.KeyChar;
            }

            
        }

        private void CalBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
