/**
 *  Grading ID:  L8486
 *  Class:       CIS 199-75
 *  Program:     2
 *  Due date:    10/17/19
 *  Description: Determines the earliest time that a continuing UofL undergraduate student may register for Spring 2020 courses using the priority registration schedule available from the Registrar's site.
 * **/

using System;
using System.Windows.Forms;

namespace Program2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        // Constants
        private const int   SENIOR_CREDITS   = 90,  // Senior credit hour minimum limit
                            JUNIOR_CREDITS   = 60,  // Junior credit hour minimum limit
                            SOPHMORE_CREDITS = 30;  // Sophmore credit hour minimum limit
        private const string HR_1 = "8:30",  // Eight-thirty time as string
                             HR_2 = "10:00", // Ten time as string
                             HR_3 = "11:30", // Eleven-thirty time as string
                             HR_4 = "2:00",  // Two time as string
                             HR_5 = "4:00";  // Four time as string
        private const string DATE_1 = "MONDAY, NOV. 4",     // Senior registration date
                             DATE_2 = "TUESDAY, NOV. 5",    // Junior registration date
                             DATE_3 = "WEDNESDAY, NOV. 6",  // Early sophmore registration date
                             DATE_4 = "THURSDAY, NOV. 7",   // Late sophmore registration date
                             DATE_5 = "FRIDAY, NOV. 8",     // Early freshman registration date
                             DATE_6 = "MONDAY, NOV. 11";    // Late freshman registration date

        // Clear button resets text in both input textboxes and result label. Then selects first textbox.
        private void clearButton_Click(object sender, EventArgs e)
        {
            firstCharTextBox.Text = "";
            creditHoursTextBox.Text = "";
            resultLabel.Text = "";
            firstCharTextBox.Select();
        }

        // Variables
        double credits;          // Total credit hours input
        char lastName;           // First letter of last name input
        string time;             // Time of registration
        string date;             // Date of registration
        bool altSetUsed = false; // Flag for indecating 'Time set 2' was used

        // On submit button click: determine earliest time student may register for Spring 2020 classes by parsing input then using conditional if's to determine result label text.
        private void submitButton_Click(object sender, EventArgs e)
        {
            altSetUsed = false;   // Reset flag on click event
            // Parse and validate input
            if (char.TryParse(firstCharTextBox.Text, out lastName) && char.IsLetter(lastName))
            {
                lastName = char.ToUpper(lastName);  // Format input to uppercase only
                if (double.TryParse(creditHoursTextBox.Text, out credits) && credits >= 0)
                {
                    if (credits >= JUNIOR_CREDITS)
                    {
                        // Date set
                        if (credits >= SENIOR_CREDITS)  { date = DATE_1; }
                        else                            { date = DATE_2; }

                        // Time set
                        if      (lastName >= 'T') { time = HR_2; }
                        else if (lastName >= 'P') { time = HR_1; } 
                        else if (lastName >= 'J') { time = HR_5; }
                        else if (lastName >= 'E') { time = HR_4; }
                        else                      { time = HR_3; }
                    }
                    else // Else credits are either sophmore or freshman
                    {
                        // Date set
                        if (credits >= SOPHMORE_CREDITS) { date = DATE_3; }
                        else                             { date = DATE_5; }

                        // Time set 1/2
                        if      (lastName >= 'W')   { time = HR_4; }
                        else if (lastName >= 'T')   { time = HR_3; }
                        else if (lastName >= 'R')   { time = HR_2; }
                        else if (lastName >= 'P')   { time = HR_1; }
                        else if (lastName <= 'B')   { time = HR_5; }
                        // Time set 2/2
                        else
                        {
                            if      (lastName <= 'D')   { time = HR_1; }
                            else if (lastName <= 'F')   { time = HR_2; }
                            else if (lastName <= 'I')   { time = HR_3; }
                            else if (lastName <= 'L')   { time = HR_4; }
                            else                        { time = HR_5; }
                            altSetUsed = true;
                        }

                        // If alternative set was used, use secondary dates for sophmore and freshmen
                        if (altSetUsed == true)
                        {
                            if (credits >= SOPHMORE_CREDITS) { date = DATE_4; }
                            else                             { date = DATE_6; }
                        }
                    }
                    // Output
                    resultLabel.Text = $"{date} @ {time}";
                }
                else // Int credits TryParse = false
                {
                    MessageBox.Show("Invalid entry in Total credit hours");
                }
            }
            else // Char lastName TryParse = false
            {
                MessageBox.Show("Invalid entry in First character of Last Name");
            }
        }
    }
}
