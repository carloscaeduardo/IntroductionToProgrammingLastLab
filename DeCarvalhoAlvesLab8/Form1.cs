using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeCarvalhoAlvesLab8
{
    public partial class Form1 : Form
    {   
        //Create constant for the value "my name"
        const string MYNAME = "Carlos Eduardo De Carvalho Alves";
        //create class variables to count when calculations and generations run correctly
        int SuccededCalculation = 0, SuccededGeneration= 0;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            //Gide the groupbox Formula and groupbox Analysis.
            //Add constant MYNAME to the form title.
            grpFormula.Hide();
            grpAnalysis.Hide();
            this.Text += " " + MYNAME;
        }

        
                                                                 
        private void chkFormula_CheckedChanged(object sender, EventArgs e)
        {
           //Using a switch, show the group box if the checkbox is chacked.
           // Reset the data in the group box shown, using the functions ResetFormula
           switch (chkFormula.Checked == true)
            {
                case true:
                    grpFormula.Show();
                    ResetFormula();
                    break;
                default:
                    grpFormula.Hide();
                    break;
                    
            }
            

        }



        /*Name: ResetFormula
         * Description: Select the permutation radio button, blank out the answer and set the numeric
         * up downs to their minimum value.
         * Sent: Nothing
         * Return: Nothing */
        private void ResetFormula()
        {
            //MessageBox.Show("Calling the ResetFormula function!", MYNAME);
            radPermutation.Checked = true;
            lblAnswer.Text = "";
            nudTotal.Value = 3;
            nudSelect.Value = 3;
            

        }

        /*Name: ResetAnalysis
         * DESCRIPTTION: Clear the listbox, blank out the textbox and labes (sum, average), and put the cursor
         * on the top textbox.
         * Sent: nothing
         * Return: nothing */
        private void ResetAnalysis()
        {
            //MessageBox.Show("The ResetAnalysis function is being called", MYNAME);
            lstClassSize.Items.Clear();
            txtClassroom.Text = "";
            lblAverage.Text = "";
            lblSum.Text = "";
            txtClassroom.Focus();

        }
        private void chkAnalysis_CheckedChanged(object sender, EventArgs e)
        {
            //Using a switch, if the Analysis checkbox is checked, show the group, else, hide the group.
            //When showing the group, reset the data using the function ResetAnalysis.
            switch(chkAnalysis.Checked == true)
            {
                case true:
                    grpAnalysis.Show();
                    ResetAnalysis();
                    break;
                default:
                    grpAnalysis.Hide();
                    break;
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Call the ResetFormula Function.
            ResetFormula();
        }

        private void radPermutation_CheckedChanged(object sender, EventArgs e)
        {   
            //if the Permutation radio button is checked, show the permutation formula image.
            picCombinationPermutation.Image = Image.FromFile("Perm Formula.jpg");
            picCombinationPermutation.Visible = true;
        }

        private void radCombination_CheckedChanged(object sender, EventArgs e)
        {
            //if the combiantion radio button is checked, show the combination formula image.
            picCombinationPermutation.Image = Image.FromFile("Comb Formula.jpg");
            picCombinationPermutation.Visible = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Store the numeric up down selections in variables.
            //if the select numeric up down is more than the total numeric up down, display message:
            //"Number selected cannot be more than total"
            //Otherwise, calculate the answer and display with commas, 0 decimal places.
            //total is n and select is r.
            // use the Multiply function.
            int n = (int)nudTotal.Value;
            int r = (int)nudSelect.Value;
            int finalAnswer;
            
            if (n < r)
            {
                MessageBox.Show("Number selected cannot be more than total", MYNAME);
                ResetFormula();
            }
            else
            {
                if(radCombination.Checked)
                {
                    //make the calculation with the combination formula
                    finalAnswer = Multiply(n) / (Multiply(r) * Multiply(n - r));
                    
                }
                else
                {
                    //make the calculation with the Permutation formula
                    finalAnswer = Multiply(n) / Multiply((n - r));
                    

                }
                SuccededCalculation++;
                lblAnswer.Text = finalAnswer.ToString("N0");
            }
        }
        /*Name: Multiply
         * Description: Calculates the factorial of the number sent.
         * Sent: int
         * Returned: int */
        private int Multiply(int number)
        {
            int result = 1 ;
            int counter = number;
           
            if (number == 0)
            {
                result = 1;
            }
            else
            {
                while (counter > 1)
                {
                    result *= counter;
                    counter--;

                }
                
            }
            return result;

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //The user enters how many classrooms to analyze in the textbox.
            //The number entered must be an integer between 5 and 12. 
            //Validate for both using the function DisplayError.
            //if no errors, generate random numbers using the GenerateNumbers function.
            //Then sum the numbers in the list box using GetSum function.
            // Calculate the average (double with 1 decimal) and Display the sum and average.

            bool classroomIsNum;
            int classroomNum, calculatedSum;
            int counter = 0;
            double calculatedAverage;

            classroomIsNum = int.TryParse(txtClassroom.Text, out classroomNum);
            if(classroomIsNum)
            {
                if (classroomNum >= 5 && classroomNum <= 12)
                {
                    while(counter <classroomNum)
                    {
                        GenerateNumbers(classroomNum);
                        counter++;
                    }
                    calculatedSum = GetSum();
                    calculatedAverage = (double)calculatedSum / classroomNum;
                    lblSum.Text = calculatedSum.ToString();
                    lblAverage.Text = calculatedAverage.ToString("N1");
                    SuccededGeneration++;
                }
                else
                {
                    DisplayError("Classrooms entry must be between 5-12");
                }
            }
            else
            {
                DisplayError("Classrooms entry must be a whole number");
            }
           

        }

        /*Name: DisplayError
         * Description: Display the string sent as the message in the message box.
         * Select the data entered by the user to the textbox and put cursor there.
         * Sent: string
         * Returned: None */
        private void DisplayError(string stringToShow)
        {
            MessageBox.Show(stringToShow, MYNAME);
            txtClassroom.Text = "";
            txtClassroom.Focus();
        }

        /*Name: GenerateNumbers
         * Description: Create a random object using a seed value of 55. 
         * Clear the listbox before generating numbers. generate integers between 15-30
         * Place the number in the listbox.
         * Sent: int
         * Returned: None */
        private void GenerateNumbers(int numbers)
        {
            const int SEEDVALUE = 55, MININTEGER = 15, MAXINTEGER = 30;
            int  counter=0, newRandom;
            lstClassSize.Items.Clear();
            Random randNum = new Random(SEEDVALUE);
            while (counter < numbers)
            {
                newRandom = randNum.Next(MININTEGER, MAXINTEGER+1);
                lstClassSize.Items.Add(newRandom);
                counter++;

            }
            
            
        }
        
        /* Name: GetSum
         * Description: Loop through the listbox summing all numbers. Return the sum.
         * Sent: nothing
         * Returned: int */
        private int GetSum()
        {
            int counter = 0, sum=0;
            while(counter < lstClassSize.Items.Count)
            {
                sum += Convert.ToInt32(lstClassSize.Items[counter]);
                counter++;
            }
            return sum;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Display a Messagebox listing how many times Calculate and Generate were successfully performed while the program ran.
            MessageBox.Show("Calculations: " + SuccededCalculation + "\n" + "Generations: " + SuccededGeneration, MYNAME);
        }
    }   
}
