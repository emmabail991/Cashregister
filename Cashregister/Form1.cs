//Emmanuel Bailey
//2021-05-06
//Cash register project
//Mr.T 3U computer sience


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;



namespace Cashregister
{
    public partial class Form1 : Form
    {

        //hair cut cost and amounts variables
        int baldFadeCost = 25, buzzCutCost = 15, BowlCutCost = 60;
        int baldFadeAmount, buzzCutAmount, BowlCutAmount;
        int subTotal;

        //Tax variables 
        double tax = 0.13;
        double taxTotal;

        //total variables
        double total;

        //Change variables
        double amountPayed;
        double change;

        public Form1()
        {
            InitializeComponent();


            //button dissable 
            calculateChangeButton.Enabled = false;
            PrintReceiptButton.Enabled = false;
        }

        //calculate total button 
        private void calculateTotalbutton2_Click(object sender, EventArgs e)
        {

            //click sound for calculation button press 
            SoundPlayer click = new SoundPlayer(Properties.Resources.clickSound);
            click.Play();

            // try and catch blocks user from using letters
            try
            {
                //convert hair cut amounts to intagers 
                baldFadeAmount = Convert.ToInt32(baldefadeInput.Text);
                buzzCutAmount = Convert.ToInt32(BuzzcutInput.Text);
                BowlCutAmount = Convert.ToInt32(BowlcutInput.Text);

                //total calculations
                subTotal = baldFadeAmount * baldFadeCost + buzzCutAmount * buzzCutCost + BowlCutAmount * BowlCutCost;

                taxTotal = subTotal * tax;
                total = taxTotal + subTotal;

                // if statment blocks user from going on without buying anyhting
                if (total > 0)
                {
                    //botton state 
                    calculateChangeButton.Enabled = true;
                    PrintReceiptButton.Enabled = false;

                    //sub total,tax and total display output text
                    totalOutput.Text = $"\n\n Sub total          {subTotal.ToString("c")}";
                    totalOutput.Text += $"\n\n Tax                {taxTotal.ToString("c")}";
                    Thread.Sleep(500);
                    Refresh();
                    totalOutput.Text += $"\n\n Total              {total.ToString("c")}";
                    Thread.Sleep(500);
                    Refresh();
                }
                else
                {
                    //error message output 
                    totalOutput.Text = "please make a purchase to continue";

                    //does not let user press buttons when there is a error with thecalculating prossess 
                    calculateChangeButton.Enabled = false;
                    PrintReceiptButton.Enabled = false;

                }
            }

            catch
            {
                //error message output text
                totalOutput.Text = "Please put in whole numbers to get a total.";

                //does not let user press buttons when there is a error with thecalculating prosses 
                calculateChangeButton.Enabled = false;
                PrintReceiptButton.Enabled = false;
            }


        }

        //change button output
        private void calculateChangeButton_Click(object sender, EventArgs e)
        {

            //try and catch blocks user from using letters
            try
            {
                //amount payed and change variables 
                amountPayed = Convert.ToDouble(amountpayedInput.Text);
                change = amountPayed - total;

                //if statment stops to user from going past the calculate change button without paying a price above the cost needed 
                if (change > 0)
                {
                    //button states
                    calculateChangeButton.Enabled = true;
                    PrintReceiptButton.Enabled = true;

                    //amount payed and change output text
                    changeAmountOutput.Text = $"Change               {change.ToString("c")}";
                }

                else
                {
                    //error message
                    changeAmountOutput.Text = "insufficient funds";

                    //stops user from preesing button when there is a error with the payment
                    calculateChangeButton.Enabled = true;
                    PrintReceiptButton.Enabled = false;
                }
            }
            catch
            {
                //stops user from preesing button when there is a error with the payment
                calculateChangeButton.Enabled = true;
                PrintReceiptButton.Enabled = false;

                //error message
                changeAmountOutput.Text = "please use numbers";
            }

            //coin sound on button change press
            SoundPlayer coin = new SoundPlayer(Properties.Resources.coinSound);
            coin.Play();
        }


        //Receipt Print
        private void PrintReceiptButton_Click(object sender, EventArgs e)

        {
            //Printer sound on recipt button press
            SoundPlayer printer = new SoundPlayer(Properties.Resources.printerSound);
            printer.Play();

            //random number variables for receipt number
            Random rnd = new Random();
            int randomNum = rnd.Next(0, 999);

            //variables for date
            string time = System.DateTime.UtcNow.ToLocalTime().ToString("hh:mm:ss");
            string day = System.DateTime.UtcNow.ToLocalTime().ToString("yyyy-MM-dd");

            //receipt store name output text
            outputReceipt.Text = "                      Online Barber Shop";

            //random order number output text
            outputReceipt.Text += $"\n\nOrder Number: {randomNum}";

            //date and time output text
            outputReceipt.Text += $"\n\nOrder Day:                 {day}";
            Thread.Sleep(500);
            Refresh();
            outputReceipt.Text += $"\nOrder Time:               {time}";
            Thread.Sleep(500);
            Refresh();

            //iteams purchase and item prices output ext
            outputReceipt.Text += $"\n\nBald fade    x{baldFadeAmount}        @ {baldFadeCost.ToString("c")}";
            Thread.Sleep(500);
            Refresh();
            outputReceipt.Text += $"\nBuzz cut    x{buzzCutAmount}          @ {buzzCutCost.ToString("c")}";
            Thread.Sleep(500);
            Refresh();
            outputReceipt.Text += $"\nBowl cut    x{BowlCutAmount}          @ {BowlCutCost.ToString("c")}";
            Thread.Sleep(500);
            Refresh();

            //tax and total output text 
            outputReceipt.Text += $"\n\nSubtotal                       {subTotal.ToString("c")}";
            Thread.Sleep(500);
            Refresh();
            outputReceipt.Text += $"\nTax                               {taxTotal.ToString("c")}";
            Thread.Sleep(500);
            Refresh();
            outputReceipt.Text += $"\nTotal                             {total.ToString("c")}";
            Thread.Sleep(500);
            Refresh();

            //payed amount and change output text
            outputReceipt.Text += $"\n\nTendered                    {amountPayed.ToString("c")}";
            Thread.Sleep(500);
            Refresh();
            outputReceipt.Text += $"\nChange                       {change.ToString("c")}";
            Thread.Sleep(500);
            Refresh();

            //thank you message 
            outputReceipt.Text += "\n\n Thank you for coming to the Online Barber Shop!!!";
            Thread.Sleep(500);
            Refresh();
        }


        //Reset screen
        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer paperRip = new SoundPlayer(Properties.Resources.paperRipSound);
            paperRip.Play();

            //clears everything
            outputReceipt.Text = "";
            totalOutput.Text = "";
            changeAmountOutput.Text = "";
            BowlcutInput.Clear();
            BuzzcutInput.Clear();
            baldefadeInput.Clear();
            amountpayedInput.Clear();

            //Sets amount to zero
            BowlcutInput.Text = "0";
            BuzzcutInput.Text = "0";
            baldefadeInput.Text = "0";

        }
    }

}

