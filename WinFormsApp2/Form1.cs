using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public double FirstNumber;
        public double SecondNumber;
        public bool znak = true;
        string Operation;


        private int incrementNumber { get; set; } = 0;

        public Form1()
        {
            InitializeComponent();
            txbNumber1.Text = "0";
        }

        //private async void btnIncrement_Click(object sender, EventArgs e)
        //{
        //    await Task.Run(() =>
        //    {
        //        incrementNumber++;
        //    });
        //    btnIncrement.Text = $"Click Me - {incrementNumber}";
        //}

        //private void btnIncrement_MouseHover(object sender, EventArgs e)
        //{
        //    btnIncrement.BackColor = Color.Red;
        //}

        //private void btnIncrement_MouseLeave(object sender, EventArgs e)
        //{
        //    btnIncrement.BackColor = Color.White;
        //}

        //private void btnMathOpr_Click(object sender, EventArgs e)
        //{
        //    var btn = sender as Button;
        //    //btn.Enabled = false;
        //    FirstNumber = Convert.ToDouble(txbNumber1.Text);
        //    txbNumber1.Text = "0";

        //    double.TryParse(txbNumber1.Text, out var SecondNumber);
        //    //decimal.TryParse(txbNumber2.Text, out var num2);

        //    //double.TryParse(txbNumber1.Text, out FirstNumber);
        //    //txbNumber1.Text = "0";
        //    //Operation = "+";

        //    //if (btn.Text == "/" && (num1 == 0 || num2 == 0))
        //    //{
        //    //    lblResult.Text = "Cannot divide to zero";
        //    //}
        //    if (btn.Text == "+") 
        //    {
        //        double.TryParse(txbNumber1.Text, out SecondNumber);
        //    }

        //    try
        //    {
        //        var sum = 0.0;
        //        var result = btn.Text;
        //        switch (result)
        //        {
        //            case "+":
        //                {
        //                    double.TryParse(txbNumber1.Text, out SecondNumber);
        //                    //num1 = 0;
        //                    sum = FirstNumber + SecondNumber;
        //                };
        //                break;
        //            case "-":
        //                {
        //                    sum = FirstNumber - SecondNumber;
        //                    //double.TryParse(txbNumber1.Text, out FirstNumber);
        //                    //num1 = 0;
        //                };
        //                break;
        //            case "*":
        //                {
        //                    sum = FirstNumber * SecondNumber;
        //                    //double.TryParse(txbNumber1.Text, out FirstNumber);
        //                    //num1 = 0;
        //                };
        //                break;
        //            case "/":
        //                {
        //                    sum = FirstNumber / SecondNumber;
        //                    //double.TryParse(txbNumber1.Text, out FirstNumber);
        //                    //num1 = 0;
        //                };
        //                break;
        //            default:
        //                break;
        //        }
        //        //var result = btn.Text switch
        //        //{
        //        //    "+" => txbNumber1.Text = "0", //(num1 + num1),
        //        //    "-" => (num1 - num1),
        //        //    "/" => (num1 / num1),
        //        //    "*" => (num1 * num1),
        //        //    _ => throw new NotImplementedException()
        //        //};
        //        txbNumber1.Text = FirstNumber.ToString(); 
        //        var button = (Button)sender; txbNumber1.Text  += button.Text;
        //        //txbNumber1.Text = txbNumber1.Text.ToString();
        //    }
        //    catch (DivideByZeroException ex)
        //    {
        //        txbNumber1.Text = ex.Message;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //}
       
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txbNumber1.Text == FirstNumber.ToString() || txbNumber1.Text == "0")
            {
                txbNumber1.Text = "1";
            }
            else
            {
                txbNumber1.Text += "1";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (txbNumber1.Text == FirstNumber.ToString() || txbNumber1.Text == "0")
            {
                txbNumber1.Text = "2";
            }
            else
            {
                txbNumber1.Text += "2";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (txbNumber1.Text == FirstNumber.ToString() || txbNumber1.Text == "0")
            {
                txbNumber1.Text = "3";
            }
            else
            {
                txbNumber1.Text += "3";
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (txbNumber1.Text == FirstNumber.ToString() || txbNumber1.Text == "0")
            {
                txbNumber1.Text = "4";
            }
            else
            {
                txbNumber1.Text += "4";
            }

        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (txbNumber1.Text == FirstNumber.ToString() || txbNumber1.Text == "0")
            {
                txbNumber1.Text = "5";
            }
            else
            {
                txbNumber1.Text += "5";
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (txbNumber1.Text == FirstNumber.ToString() || txbNumber1.Text == "0")
            {
                txbNumber1.Text = "6";
            }
            else
            {
                txbNumber1.Text += "6";
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (txbNumber1.Text == FirstNumber.ToString() || txbNumber1.Text == "0")
            {
                txbNumber1.Text = "7";
            }
            else
            {
                txbNumber1.Text += "7";
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (txbNumber1.Text == FirstNumber.ToString() || txbNumber1.Text == "0")
            {
                txbNumber1.Text = "8";
            }
            else
            {
                txbNumber1.Text += "8";
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (txbNumber1.Text == FirstNumber.ToString() || txbNumber1.Text == "0")
            {
                txbNumber1.Text = "9";
            }
            else
            {
                txbNumber1.Text += "9";
            }
        }
        private void button0_Click(object sender, EventArgs e)
        {
            if (txbNumber1.Text == FirstNumber.ToString() || txbNumber1.Text == "0")
            {
                txbNumber1.Text = "0";
            }
            else
            {
                txbNumber1.Text += "0";
            }
        }
        
        private void buttonDot_Click(object sender, EventArgs e)
        {
            txbNumber1.Text += ".";
        }
        private void txbNumber1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void buttonSum_Click(object sender, EventArgs e)
        {
            double Result;
            var btn = (Button)sender;
            //txbNumber1.Text += btn.Text;
            //txbNumber2.Text = txbNumber1.Text.ToString();
            //txbNumber1.Text = "0";
            double.TryParse(txbNumber1.Text, out SecondNumber);
            rem.Text += SecondNumber.ToString();
            rem.Text += btn.Text;
            try
            {


                //if (Operation == "+")
                //{
                //    Result = FirstNumber + SecondNumber;
                //    txbNumber1.Text = Convert.ToString(Result);
                //}
                //if (Operation == "-")
                //{
                //    Result = FirstNumber - SecondNumber;
                //    txbNumber1.Text = Convert.ToString(Result);
                //}
                //if (Operation == "*")
                //{
                //    Result = FirstNumber * SecondNumber;
                //    txbNumber1.Text = Convert.ToString(Result);
                //}
                //if (Operation == "/" && (SecondNumber > 0)) 
                //{
                //    Result = FirstNumber / SecondNumber;
                //    txbNumber1.Text = Convert.ToString(Result);
                //}
                //else
                //{
                //    txbNumber1.Text = "Cannot divide by zero";
                //    //MessageBox.Show("Cannot divide by zero");
                //}

                //catch (Exception)
                //{

                //    throw;
                //}
                if (SecondNumber > 0)
                {


                    _ = Operation switch
                    {
                        "+" => Result = FirstNumber + SecondNumber,
                        "-" => Result = (FirstNumber - SecondNumber),
                        "/" => Result = (FirstNumber / SecondNumber),
                        "*" => Result = (FirstNumber * SecondNumber),
                        _ => throw new NotImplementedException()
                    };
                    txbNumber1.Text = Result.ToString();
                }
                else
                {
                    txbNumber1.Text = "Cannot divide by zero";
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            var Newline = System.Environment.NewLine;
            if (history.Text == "There is no history yet")
            {
                history.Text = "";
                history.Text += rem.Text += txbNumber1.Text;
                history.Text += Newline;
            }
            else
            {
                history.Text += rem.Text += txbNumber1.Text;
                history.Text += Newline;
            }  
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            double.TryParse(txbNumber1.Text, out FirstNumber);
            rem.Text = FirstNumber.ToString();
            rem.Text += btn.Text;
            txbNumber1.Text = FirstNumber.ToString();
            Operation = "+";
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            double.TryParse(txbNumber1.Text, out FirstNumber);
            rem.Text = FirstNumber.ToString();
            rem.Text += btn.Text;
            txbNumber1.Text = FirstNumber.ToString();
            Operation = "-";
        }
        private void btnMult_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            //if (FirstNumber > 0 && SecondNumber > 0)
            //{
            //    double.TryParse(txbNumber1.Text, out FirstNumber);
            //    rem.Text = FirstNumber.ToString();
            //    rem.Text += btn.Text;
            //    txbNumber1.Text = FirstNumber.ToString();
            //    Operation = "*";
            //}
            //var btn = sender as Button;
            double.TryParse(txbNumber1.Text, out FirstNumber);
            rem.Text = FirstNumber.ToString();
            rem.Text += btn.Text;
            txbNumber1.Text = "0";
            //txbNumber1.Text = FirstNumber.ToString();
            Operation = "*";
        }
        private void btnDiv_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            double.TryParse(txbNumber1.Text, out FirstNumber);
            rem.Text = FirstNumber.ToString();
            rem.Text += btn.Text;
            txbNumber1.Text = FirstNumber.ToString();
            Operation = "/";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonC_Click(object sender, EventArgs e)
        {
            txbNumber1.Text = "0";
            SecondNumber = 0;
            FirstNumber = 0;
            rem.Text = "";
        }
        private void buttonCE_Click(object sender, EventArgs e)
        {
            if (SecondNumber > 0)
            {
                rem.Text = "";
                txbNumber1.Text = "0";
                SecondNumber = 0;
            }
            else
            {
                txbNumber1.Text = "0";
            }
        }
        private void buttonX_Click(object sender, EventArgs e)
        {
            string sSub = txbNumber1.Text.Trim();
            if (sSub.Length > 1)
            {
                txbNumber1.Text = sSub.Substring(0, sSub.Length - 1);
            }
            else
            {
                txbNumber1.Text = "0";
            }
            //txbNumber1.Text =  "1"; 
        }
        private void buttonPercent_Click(object sender, EventArgs e)
        {
            double.TryParse(txbNumber1.Text, out FirstNumber);
            txbNumber1.Text = (FirstNumber / 100).ToString(); 
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double.TryParse(txbNumber1.Text, out FirstNumber);
            txbNumber1.Text = Math.Sqrt(FirstNumber).ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //rem.Text = "";
            //txbNumber1.Text = "0";
            //SecondNumber = 0;
            double.TryParse(txbNumber1.Text, out FirstNumber);
            //double.TryParse(txbNumber1.Text, out SecondNumber);
            txbNumber1.Text = Math.Pow(FirstNumber, 2).ToString();
        }

        private void button1x_Click(object sender, EventArgs e)
        {
            double.TryParse(txbNumber1.Text, out FirstNumber);
            txbNumber1.Text = (1 / FirstNumber).ToString();
        }
        private void buttonMinusPlus_Click(object sender, EventArgs e)
        {
            //double.TryParse(txbNumber1.Text, out FirstNumber);
            ////FirstNumber = +-
            //txbNumber1.Text += "-";
            //var btn = sender as Button;
            if (znak == true)
            {
                txbNumber1.Text = "-" + txbNumber1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                txbNumber1.Text = txbNumber1.Text.Replace("-", "");
                znak = true;
            }
        }

        private void history_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void History1_Click(object sender, EventArgs e)
        {
            history.Text = "There is no history yet";
        }
    }
}
