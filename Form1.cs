using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JessaGuanzonCalculator
{
    public partial class Form1 : Form
        
    {
        public Form1()
        {
            InitializeComponent();
        }
        float num, ans;
        int count;
        private void button19_Click(object sender, EventArgs e)
        {
            

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void Number_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; //clear 
        }

        private void button17_Click_1(object sender, EventArgs e) //subtraction button
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear(); //clear the textbox
            textBox1.Focus(); //focus on clearbox
            count = 2;
            label2.Text = num.ToString() + "-"; //display text on the table
        }

        private void Standard_Click(object sender, EventArgs e)
        {

        }

        private void Numbers_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            Button Numbers=(Button)sender;
            textBox1.Text = textBox1.Text + Numbers.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void compute()
        {
            switch (count)//creating swith statement
            {
                case 1:
                    ans = num + float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 2:
                    ans = num - float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 3:
                    ans = num * float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 4:
                    ans = num / float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;

                default:
                    break;




 
            }
        }

        private void button19_Click_1(object sender, EventArgs e) //addition button
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear(); //clear the textbox
            textBox1.Focus(); //focus on clearbox
            count = 1;
            label2.Text = num.ToString() + "+"; //display text on the table


        }

        private void button18_Click_1(object sender, EventArgs e) // multiplication button
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear(); //clear the textbox
            textBox1.Focus(); //focus on clearbox
            count = 3;
            label2.Text = num.ToString() + "*"; //display text on the table
        }

        private void button20_Click_1(object sender, EventArgs e) //division button
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear(); //clear the textbox
            textBox1.Focus(); //focus on clearbox
            count = 4;
            label2.Text = num.ToString() + "÷"; //display text on the table
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            compute(); //call compute function
            label2.Text = ""; // clear the text
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; //clear 
        }

        private void button22_Click_2(object sender, EventArgs e)
        {
            compute();
            label2.Text = "";
        }

        private void button6_Click(object sender, EventArgs e) //backspace button
        {
            int length = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i< length; i++);

            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = ""; //clear 
        }
    }
}
