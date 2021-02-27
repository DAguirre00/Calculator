using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator0._1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
           
        }

        //Creating some global variable ill need for the program
        int index = 0; //is used for changing the place when inserting a chracter into the string pull
        string full = ""; // is used to diplay the full equation
        string num1 = ""; // is used to hold the first number
        string num2 = ""; // is used to hold the second number
        bool change = false; // used to change between the first and second number
        int num1Place = 0;
        int num2Place = 0;

        //Sets the text box to be blank
        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = full;
            
        }
        //All number buttons follow the same code so ill only comment on the first
        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            full = full.Insert(index, "1"); //Adds the number to the text bar at the top
            index++; // Adds 1 to the index
            textBox1.Text = full; //Updates the text box

            if(change != true) //Checks if its the first or second number
            {
                num1 = num1.Insert(num1Place, "1");//Adds to the actual number
            }
            else
            {
                num2 = num2.Insert(num2Place, "1");
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            full = full.Insert(index, "2");
            index++;
            textBox1.Text = full;

            if (change != true)
            {
                num1 = num1.Insert(num1Place, "2");
            }
            else
            {
                num2 = num2.Insert(num2Place, "2");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            full = full.Insert(index, "3");
            index++;
            textBox1.Text = full;

            if (change != true)
            {
                num1 = num1.Insert(num1Place, "3");
            }
            else
            {
                num2 = num2.Insert(num2Place, "3");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            full = full.Insert(index, "4");
            index++;
            textBox1.Text = full;

            if (change != true)
            {
                num1 = num1.Insert(num1Place, "4");
            }
            else
            {
                num2 = num2.Insert(num2Place, "4");
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            full = full.Insert(index, "5");
            index++;
            textBox1.Text = full;

            if (change != true)
            {
                num1 = num1.Insert(num1Place, "5");
            }
            else
            {
                num2 = num2.Insert(num2Place, "5");
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            full = full.Insert(index, "6");
            index++;
            textBox1.Text = full;

            if (change != true)
            {
                num1 = num1.Insert(num1Place, "6");
            }
            else
            {
                num2 = num2.Insert(num2Place, "6");
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            full = full.Insert(index, "7");
            index++;
            textBox1.Text = full;

            if (change != true)
            {
                num1 = num1.Insert(num1Place, "7");
            }
            else
            {
                num2 = num2.Insert(num2Place, "7");
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            full = full.Insert(index, "8");
            index++;
            textBox1.Text = full;

            if (change != true)
            {
                num1 = num1.Insert(num1Place, "8");
            }
            else
            {
                num2 = num2.Insert(num2Place, "8");
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            full = full.Insert(index, "9");
            index++;
            textBox1.Text = full;

            if (change != true)
            {
                num1 = num1.Insert(num1Place, "9");
            }
            else
            {
                num2 = num2.Insert(num2Place, "9");
            }
        }
        private void button0_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (change == false || num2 != "")
            {
                full = full.Insert(index, "0");
                index++;
                textBox1.Text = full;

                if (change != true)
                {
                    num1 = num1.Insert(num1Place, "0");
                }
                else
                {
                    num2 = num2.Insert(num2Place, "0");
                }
            }
            else
            {
                MessageBox.Show("You cant divide by 0 silly");
            }
        }
        private void buttonDot_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (change != true && !num1.Contains("."))//checks if its the first or second number then makes sure there isnt already a decimel
            {
                num1 = num1.Insert(num1Place, ".");//adds the decimel to the number

                full = full.Insert(index, ".");//adds the decimel to the text bar
                index++;
                textBox1.Text = full;

            }
            else if(change != false && !num2.Contains("."))//if its the second number it checks for it having a decimel
            {
                num2 = num2.Insert(num2Place, ".");

                full = full.Insert(index, ".");
                index++;
                textBox1.Text = full;
            }
            
            else//if all conditions fail alerts the user they are entering multiple decimels
            {
                MessageBox.Show("You can only have a single decimel");
            }
        }
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (!full.Contains("+") && !full.Contains("-") && !full.Contains("*") && !full.Contains("/")) //Checks if there is already an operator
            {
                full = full.Insert(index, "*");
                index++;
                textBox1.Text = full;


                change = true; //Used to change from the first to second number 
            }
            else
            {
                MessageBox.Show("You can only pick one operator (+,-,*,/)");//if an opertor already exists tells the user they can only have one
            }
        }
        private void buttonDivision_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (!full.Contains("+") && !full.Contains("-") && !full.Contains("*") && !full.Contains("/"))
            {
                full = full.Insert(index, "/");
                index++;
                textBox1.Text = full;


                change = true;
            }
            else
            {
                MessageBox.Show("You can only pick one operator (+,-,*,/)");
            }
        }
        private void buttonAddition_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (!full.Contains("+") && !full.Contains("-") && !full.Contains("*") && !full.Contains("/"))
            {
                full = full.Insert(index, "+");
                index++;
                textBox1.Text = full;


                change = true;
            }
            else
            {
                MessageBox.Show("You can only pick one operator (+,-,*,/)");
            }
        }
        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (!full.Contains("+") && !full.Contains("-") && !full.Contains("*") && !full.Contains("/"))
            {
                full = full.Insert(index, "-");
                index++;
                textBox1.Text = full;


                change = true;
            }
            else
            {
                MessageBox.Show("You can only pick one operator (+,-,*,/)");
            }
        }
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (!full.Contains("="))
            {
                //Turns off all the buttons except reset
                button0.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                buttonAddition.Enabled = false;
                buttonSubtraction.Enabled = false;
                buttonMultiply.Enabled = false;
                buttonDivision.Enabled = false;
                buttonDot.Enabled = false;
                buttonEqual.Enabled = false;

                full = full.Insert(index, "=");
                index++;
                textBox1.Text = full;

                if (num1 != "" && num2 != "")//Makes sure both numbers are filled
                {
                    //variables needed for the math
                    int i = 3;
                    int j = 5;
                    double x = 0.0;
                    double y = 0.0;
                    string reverse1 = Reverse(num1);//Issue with numbers being backwards so I implimeted a reverse function
                    string reverse2 = Reverse(num2);

                    if (num1.Contains(".") || num2.Contains("."))// converts the strings to the required number type
                    {
                        x = Convert.ToDouble(reverse1);
                        y = Convert.ToDouble(reverse2);
                    }
                    else
                    {
                        i = Convert.ToInt32(reverse1);
                        j = Convert.ToInt32(reverse2);
                    }
                    
                    int ans1 = 0;// fuller numbers
                    double ans2 = 0.0;

                    if (full.Contains("+"))//Starts the addition (is the same for Subtraction and multiplication
                    {
                        ans1 = Add(i, j);//calls the funtions for each number set
                        ans2 = Add(x, y);
                        if(!full.Contains("."))//Updates with the proper number
                        {
                            string ans = Convert.ToString(ans1);
                            full = full.Insert(index, ans);
                            index++;
                            textBox1.Text = full;
                        }
                        else
                        {
                            string ans = Convert.ToString(ans2);//Updates with the proper number
                            full = full.Insert(index, ans);
                            index++;
                            textBox1.Text = full;
                        }
                    }
                    if (full.Contains("-"))
                    {
                        ans1 = Subtract(i, j);
                        ans2 = Subtract(x, y);
                        if (!full.Contains("."))
                        {
                            string ans = Convert.ToString(ans1);
                            full = full.Insert(index, ans);
                            index++;
                            textBox1.Text = full;
                        }
                        else
                        {
                            string ans = Convert.ToString(ans2);
                            full = full.Insert(index, ans);
                            index++;
                            textBox1.Text = full;
                        }
                    }
                    if (full.Contains("*"))
                    {
                        ans1 = Multiply(i, j);
                        ans2 = Multiply(x, y);
                        if (!full.Contains("."))
                        {
                            string ans = Convert.ToString(ans1);
                            full = full.Insert(index, ans);
                            index++;
                            textBox1.Text = full;
                        }
                        else
                        {
                            string ans = Convert.ToString(ans2);
                            full = full.Insert(index, ans);
                            index++;
                            textBox1.Text = full;
                        }
                    }
                    if (full.Contains("/"))// starts the division
                    {
                        if (i % j == 0)//checks if the end result will end with a decimel or not
                        {
                            ans1 = Divide(i, j);
                        }
                        else//if the result ends in a decimel the numbers need to be converted to doubles for the math to be done properly
                        {
                            if (!reverse1.Contains("."))//makes sure the string doesnt already contain a decimel
                            {
                                reverse1 = reverse1.Insert(reverse1.Length, ".0");//adds .0 to the strings to conversion is done correctly
                            }
                            if (!reverse2.Contains("."))
                            { 
                            reverse2 = reverse2.Insert(reverse2.Length, ".0");
                            }
                            x = Convert.ToDouble(reverse1);//converts the numbers
                            y = Convert.ToDouble(reverse2);
                            ans2 = Divide(x, y);// runs the equation
                        }
                        
                        if (!full.Contains(".") && (i % j) == 0)//Adds the proper answer to the text box
                        {
                            string ans = Convert.ToString(ans1);
                            full = full.Insert(index, ans);
                            index++;
                            textBox1.Text = full;
                        }
                        else
                        {
                            string ans = Convert.ToString(ans2);
                            full = full.Insert(index, ans);
                            index++;
                            textBox1.Text = full;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You must have 2 numbers and an operator"); //Alerts the user if they dont meet proper conditions
                }
            }
            else
            {
                MessageBox.Show("Can only enter equals once.");//tells them they can only enter it once
            }


        }
        private void buttonReset_Click(object sender, EventArgs e) //Resets everything so the user can try another problem
        {
            Button btn = sender as Button;

            index = 0;
            full = "";
            num1 = "";
            num1Place = 0;
            num2 = "";
            num2Place = 0;
            change = false;
            textBox1.Text = full;

            button0.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            buttonAddition.Enabled = true;
            buttonSubtraction.Enabled = true;
            buttonMultiply.Enabled = true;
            buttonDivision.Enabled = true;
            buttonDot.Enabled = true;
            buttonEqual.Enabled = true;

        }
        private int Add(int i,int j) //adds the ints
        {
            
            return  i + j;
        }
        private Double Add(double x, double y)//adds the doubles
        {
            
            return x + y;
        }
        private int Subtract(int i, int j)//subtracts the ints
        {
            
            return i - j;
        }
        private Double Subtract(double x, double y)//subtracts the doubles
        {
           
            return x - y;
        }
        private int Multiply(int i, int j)// multiplies the ints
        {
         
            return  i * j;
        }
        private Double Multiply(double x, double y)// multiplies the doubles
        {
           
            return x * y;
        }
        private int Divide(int i, int j)//divides the ints
        {
           
            return i / j;
        }
        private Double Divide(double x, double y)//divides the doubles
        {
           
            return x / y;
        }
        public string Reverse(string ans) //Reveres the messed up strings
        {
            char[] cArray = ans.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }

    }
}
