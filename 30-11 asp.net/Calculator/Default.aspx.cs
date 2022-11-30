using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator
{
    class math
    {


        public static double sum(double x, double y)
        {
            double result = x + y;
            return result;
        }

        public static double sub(double x, double y)
        {
            double result = x - y;
            return result;
        }

        public static double multi(double x, double y)
        {
            double result = x * y;
            return result;
        }
        public static double div(double x, double y)
        {
            double result = x / y;
            return result;
        }
        
    }
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text == "")
            {
                TextBox1.Text = TextBox1.Text + "1";
            }
            else
            {
                TextBox3.Text = TextBox3.Text + "1";
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text == "")
            {
                TextBox1.Text = TextBox1.Text + "2";
            }
            else
            {
                TextBox3.Text = TextBox3.Text + "2";
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text == "")
            {
                TextBox1.Text = TextBox1.Text + "3";
            }
            else
            {
                TextBox3.Text = TextBox3.Text + "3";
            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text == "")
            {
                TextBox1.Text = TextBox1.Text + "4";
            }
            else
            {
                TextBox3.Text = TextBox3.Text + "4";
            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text == "")
            {
                TextBox1.Text = TextBox1.Text + "5";
            }
            else
            {
                TextBox3.Text = TextBox3.Text + "5";
            }
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text == "")
            {
                TextBox1.Text = TextBox1.Text + "6";
            }
            else
            {
                TextBox3.Text = TextBox3.Text + "6";
            }
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text == "")
            {
                TextBox1.Text = TextBox1.Text + "7";
            }
            else
            {
                TextBox3.Text = TextBox3.Text + "7";
            }
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text == "")
            {
                TextBox1.Text = TextBox1.Text + "8";
            }
            else
            {
                TextBox3.Text = TextBox3.Text + "8";
            }
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text == "")
            {
                TextBox1.Text = TextBox1.Text + "9";
            }
            else
            {
                TextBox3.Text = TextBox3.Text + "9";
            }

        }

        protected void Button14_Click1(object sender, EventArgs e)
        {
            if (TextBox2.Text == "")
            {
                TextBox1.Text = TextBox1.Text + "0";
            }
            else
            {
                TextBox3.Text = TextBox3.Text + "0";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            TextBox2.Text = "+";
            

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            TextBox2.Text = "-";
          

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox2.Text = "*";
    
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            TextBox2.Text = "/";
            
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            double Num1 = Convert.ToDouble(TextBox1.Text);
            double Num2 = Convert.ToDouble(TextBox3.Text);
            switch (TextBox2.Text)
            {
                case "+":
                    TextBox2.Text = Convert.ToString(math.sum(Num1, Num2));
                    TextBox1.Text = "";
                    TextBox3.Text = "";
                    break;

                case "-":
                    TextBox2.Text = Convert.ToString(math.sub(Num1, Num2));
                    TextBox1.Text = "";
                    TextBox3.Text = "";
                    break;

                case "*":
                    TextBox2.Text = Convert.ToString(math.multi(Num1, Num2));
                    TextBox1.Text = "";
                    TextBox3.Text = "";
                    break;

                case "/":
                    TextBox2.Text = Convert.ToString(math.div(Num1, Num2));
                    TextBox1.Text = "";
                    TextBox3.Text = "";
                    break;
            }
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }
    }

}