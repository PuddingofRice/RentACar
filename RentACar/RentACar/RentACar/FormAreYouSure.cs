using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RentACar.FormUserDetails;

namespace RentACar
{
    public partial class FormAreYouSure : Form
    {
        public FormAreYouSure()
        {
            InitializeComponent();

            // Variables for the price + VAT(20%)
            int oneDayPayment = Global.oneDayPrice += 6;
            int oneWeekPayment = Global.oneWeekPrice += 19;
            int oneMonthPayment = Global.oneMonthPrice += 54;

            lblCorrectName.Text = Global.userName;
            lblCorrectAge.Text = Global.userAge.ToString();
            lblCorrectNationality.Text = Global.userNationality;
            lblCorrectGotLicenceDate.Text = Global.userDateGotLisence;
            lblDurationPicked.Text = Global.userRentDuration;

            #region RentDuration&CarSize
            // displays correct price +VAT on the AreYouSure form.
            if (Global.userRentDuration == "One Day")
            {
                String stroneDayPayment = Convert.ToString(oneDayPayment);
                lblPriceOfDuration.Text = "£" + stroneDayPayment;
            }
            if (Global.userRentDuration == "One Week")
            {
                String stoneWeekPayment = Convert.ToString(oneWeekPayment);
                lblPriceOfDuration.Text = "£" + stoneWeekPayment;
            }
            if (Global.userRentDuration == "One Month")
            {
                String srtoneMonthPayment = Convert.ToString(oneMonthPayment);
                lblPriceOfDuration.Text = "£" + srtoneMonthPayment;
            }

            // Displays correct size car image
            if (Global.userCarSize == "Small")
            {
                picboxCarSize.BackgroundImage = Properties.Resources.Small;
                lblCartypeChosen.Text = "Car Size: Small";
            }
            if (Global.userCarSize == "Medium")
            {
                picboxCarSize.BackgroundImage = Properties.Resources.newRegular;
                lblCartypeChosen.Text = "Car Size: Meduim";
            }
            if (Global.userCarSize == "Large")
            {
                picboxCarSize.BackgroundImage = Properties.Resources.newLarge;
                lblCartypeChosen.Text = "Car Size: Large";
            }
            #endregion 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var userDetails = new FormUserDetails();
            userDetails.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var resultForm = new FormResult();
            resultForm.Show();
            this.Close();
        }
    }
}
