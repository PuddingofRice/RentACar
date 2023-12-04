using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    
        
    public partial class FormUserDetails : Form
    {
        // Houses all the variables used in the forms
        public class Global
        {
            public static string userName;
            public static int userDOB;
            public static string userNationality;
            public static string userDateGotLisence;
            public static string userCarSize;
            public static string userRentDuration;
            public static int userAge;
            public static int oneDayPrice = 30;
            public static int oneWeekPrice = 95;
            public static int oneMonthPrice = 270;
        }
        
        public FormUserDetails()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            

            #region validation
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please enter you name.");
                return;
            }
            if (String.IsNullOrEmpty(txtDOB.Text))
            {
                MessageBox.Show("Please enter a valid year of Birth.");
                return;
            }
            Global.userDOB = Convert.ToInt32(txtDOB.Text);
            Global.userAge = 2023 - Global.userDOB;
            if (String.IsNullOrEmpty(txtNationality.Text))
            {
                MessageBox.Show("Please enter your nationality.");
                return;
            }
            if (String.IsNullOrEmpty(txtDateGotLicense.Text))
            {
                MessageBox.Show("Please enter the date you got your license.");
                return;
            }
            if (cmbCarSize.Text != "Small" && cmbCarSize.Text != "Medium" && cmbCarSize.Text != "Large")
            {
                MessageBox.Show("Please enter a valid Car Size.");
                return;
            }
            if (cmbTimeForRent.Text != "One Day" && cmbTimeForRent.Text != "One Week" && cmbTimeForRent.Text !="One Month")
            {
                MessageBox.Show("Please enter a valid rental Duration.");
                return;
            }
            if (Global.userAge < 24)
            {
                MessageBox.Show("You are either too young to rent a vehicle or have not entered a valid year of birth.");
                return;
            }
            #endregion
            
            Global.userName = txtName.Text;
            Global.userNationality = txtNationality.Text;
            Global.userDateGotLisence = txtDateGotLicense.Text;
            Global.userCarSize = cmbCarSize.Text;
            Global.userRentDuration = cmbTimeForRent.Text;

            var areYouSure = new FormAreYouSure();
            areYouSure.Show();

            this.Hide();
        }
    }
}
