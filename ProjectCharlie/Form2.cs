using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCharlie
{
    public partial class AimForm : Form
    {
        public AimForm()
        {
            InitializeComponent();
        }

        private void CancelB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            string selected = "";

            //find out which button the user selected
            RadioButton[] buttons = { MeetingButton, SalesButton, VisitButton,
                InterviewButton};
            foreach(RadioButton button in buttons)
            {
                if(button.Checked)
                {
                    selected = button.Text;
                }
            }
            //change the aim button
            MainForm.BaseForm.AimButton.Text = selected;
            this.Close();
        }
    }
}
