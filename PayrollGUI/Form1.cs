using System;
using static System.Console;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //Added new .ico image for on the taskbar and open window 
            //Variables
            decimal totGPay, fedHeld, statHeld, netPay;

            //converting
            decimal perFedHeld = Convert.ToDecimal(.15);
            decimal perStatHeld = Convert.ToDecimal(.05);
            decimal payRate = Convert.ToDecimal(txtPayRate.Text);
            decimal hrsWork = Convert.ToDecimal(txtHoursWorked.Text);

            //calculations
            totGPay = Math.Round(payRate * hrsWork, 2);
            fedHeld = Math.Round(totGPay * perFedHeld, 2);
            statHeld = Math.Round(totGPay * perStatHeld, 2);
            netPay = Math.Round(totGPay - (fedHeld + statHeld), 2);
            
            /*I was going to make 3-4 different labels to display the information to the user
            but thought one label with line breaks would be more efficent in this case*/
            lblResult.Text = string.Format("Payroll Summary for: " + txtName.Text + "   SSN: " + txtNumber.Text +
            "\nYou worked " + txtHoursWorked.Text + " hours @ $" + txtPayRate.Text +
            "\n\n\nGross Pay:       $" + totGPay +
            "\n\n\nFederal withholding:   $" + fedHeld +
            "\nState withholdings:    $" + statHeld +
            "\n--------------------------------------------\n" +
            "Net Pay:       $" + netPay);

            
        }

        //I just watched the first matrix movie, again! lol So I call this my "fresh start protocol" (The red pill) :)
        private void lblClear_Click(object sender, EventArgs e)
        {
            lblResult.Text = ""; 
            txtHoursWorked.Text = String.Empty; 
            txtName.Text = String.Empty; 
            txtNumber.Text = String.Empty; 
            txtPayRate.Text = String.Empty;
        }


    }
}
