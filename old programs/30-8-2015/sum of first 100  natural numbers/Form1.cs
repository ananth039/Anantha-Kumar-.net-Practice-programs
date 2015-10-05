using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sum_of_first_100__natural_numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
          


        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
         //   String problem = "The sum of the square of the first 10 Natural Numbers is,\n(1)2 + (2)2 + .... + (10)2 = 385 \n" +
         //"\nThe  Square of the sum of the first 10 Natural Numbers is, \n (1 + 2 + .......... + 10)2 = (55)2 = 3025\n" +
         //"\n Hence the difference beween the sum of the squares of the first 10 Natural numbers and the sqaure of the sum is \n 3025 - 385 = 2640\n" +
         //" \nFind the Difference between the sum of the squares of the first one hundred natural numbers and the square of the sum";
         //   MessageBox.Show(this, problem, "Problem");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //long sumOfSquares = 0;
            //long SquareOfSum = 0;
            //long SquareOfSum2 = 0;
            //long difference = 0;
            //long NaturalNumbersLimit = 100;

            //for (long num = 1; num <= NaturalNumbersLimit; num++)
            //{
            //    sumOfSquares += num * num;
            //    SquareOfSum += num;
            //}
            //SquareOfSum2 = SquareOfSum * SquareOfSum;
            //difference = SquareOfSum2 - sumOfSquares;
            //lblSum.Text = sumOfSquares.ToString();
            //lblSum2.Text = SquareOfSum2.ToString();
            //string Answer = lblSum2.Text + " - " + lblSum.Text + " = " + difference.ToString();
            //lblAnswer.Text = Answer;

            DisplayProblem();
        }

        private void DisplayProblem()
        {
           
            string problem = "The sum of the square of the first 10 Natural Numbers is,\n \n(1)2 + (2)2 + .... + (10)2 = 385 \n" +
           "\nThe  Square of the sum of the first 10 Natural Numbers is, \n\n (1 + 2 + .......... + 10)2 = (55)2 = 3025\n" +
           "\n Hence the difference beween the sum of the squares of the first 10 Natural numbers and the sqaure of the sum is \n\n 3025 - 385 = 2640\n"+
           " \nFind the Difference between the sum of the squares of the first one " +label1.Text + " natural numbers and the square of the sum";
            lblProblem.Text = problem;
        }

        private void lblAnswer_Click(object sender, EventArgs e)
        {

        }

        private void lblSum_Click(object sender, EventArgs e)
        {

        }

        private void btnShowCode_Click(object sender, EventArgs e)
        {
            Show_Program sp = new Show_Program();
            sp.Show();

        }
        public void CalculateSum(long NaturalNumbersLimit)
        {
            long sumOfSquares = 0;
            long SquareOfSum = 0;
            long SquareOfSum2 = 0;
            long difference = 0;
          

            for (long num = 1; num <= NaturalNumbersLimit; num++)
            {
                sumOfSquares += num * num;
                SquareOfSum += num;
            }
            SquareOfSum2 = SquareOfSum * SquareOfSum;
            difference = SquareOfSum2 - sumOfSquares;
            lblSum.Text = sumOfSquares.ToString();
            lblSum2.Text = SquareOfSum2.ToString();
            string Answer = lblSum2.Text + " - " + lblSum.Text + " = " + difference.ToString();
            lblAnswer.Text = Answer;
            problem(NaturalNumbersLimit);
           
        }
        public void problem(long NaturalNumbersLimit)
        {

            string sosq = "Sum Of the square of The First " + txtInputNaturalNumber.Text + " Natural numbers is: " ;
            lblSumOftheSquare.Text = sosq;
            string sqos = "The  Square of the sum of the first " + txtInputNaturalNumber.Text + " Natural Numbers is:" ;
            lblSquareofthesum.Text = sqos;
            string diff = "The Difference between the sum of the squares of the first one " + txtInputNaturalNumber.Text + " natural numbers and the square of the sum: ";
            lblDiff.Text = diff;
            label1.Text = txtInputNaturalNumber.Text;
            DisplayProblem();
            
        }

        private void lblEnterLimitforNaturalNumbers_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
           string number = txtInputNaturalNumber.Text;
            long NaturalNumbersLimit;
            if(txtInputNaturalNumber.Text=="")
            {
                MessageBox.Show("please enter number");
                txtInputNaturalNumber.Clear();
            }
           
            else
            {
                NaturalNumbersLimit = long.Parse(txtInputNaturalNumber.Text);
                 if (NaturalNumbersLimit==0)
                  {
                MessageBox.Show("please enter numbers greater than zero");
                txtInputNaturalNumber.Clear();
                  }
                 else
                 {
                     CalculateSum(NaturalNumbersLimit);
                     txtInputNaturalNumber.Clear();
                 }
                
            }
        }

        private void lblQusestion_Click(object sender, EventArgs e)
        {

        }
      }
  }

