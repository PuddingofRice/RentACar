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
    public partial class FormResult : Form
    {
        public FormResult()
        {
            InitializeComponent();

            if (Global.userCarSize == "Small")
            {
                picboxCarChosen.BackgroundImage = Properties.Resources.Small;
            }
            if (Global.userCarSize == "Medium")
            {
                picboxCarChosen.BackgroundImage = Properties.Resources.newRegular;
            }
            if (Global.userCarSize == "Large")
            {
                picboxCarChosen.BackgroundImage = Properties.Resources.newLarge;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();    
        }
    }
}
