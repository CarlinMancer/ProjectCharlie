using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace ProjectCharlie
{
    public partial class MainForm : Form
    {
        string conn = @"Data Source=LAPTOP-FFUVD77F\SQLEXPRESS;
                       Initial Catalog = VisitorInfo; Integrated Security = True;
                       Connect Timeout = 30; Encrypt=False;
                       TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                       MultiSubnetFailover=False";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e) 
        {
            //fill Meeting With ComboBox from the database
            MeetingWithLoad();
            //draw the visitors box
            OnsiteLoad();
        }

        public void MeetingWithLoad()
        {
            //function to fill Meeting With ComboBox from database
            SqlConnection newConn = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand("Select Meeting_With from Staff", newConn);
            newConn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Field_MeetingWith.Items.Add(reader["Meeting_With"]);
            }
            reader.Close();
            newConn.Close();
        }

        public void OnsiteLoad()
        {
            //ListBox loader
            SqlConnection newConn = new SqlConnection(conn);
            //Join below allows us to get staff name with minimal effort.
            //It's a left join b/c at one point I was working without the MeetingWith apparatus
            //and allowing nulls for Staff_ID
            SqlCommand cmd = new SqlCommand(@"Select FirstName, Surname, Meeting_Time, 
                                                Meeting_With, Meeting_Aim, Visitor_ID
                                                from Visitor left join Staff on 
                                                Visitor.Staff_ID=Staff.Staff_ID", newConn);
            newConn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            //To match Charlie speifications, we need these as separate lines,
            //even though it makes editing more difficult. I've added the Visitor_ID
            //to the publically displayed information to make updating easier/more reliable.
            while(reader.Read())
            {
                Field_Visitors.Items.Add((reader["Visitor_ID"].ToString() + 
                    ": Meeting of " + reader["FirstName"] + " " + reader["Surname"]));
                Field_Visitors.Items.Add("\nMeeting at: " + reader["Meeting_Time"]);
                Field_Visitors.Items.Add("\nMeeting With: " + reader["Meeting_With"]);
                Field_Visitors.Items.Add("\nMeeting Aim: " + reader["Meeting_Aim"]);
                Field_Visitors.Items.Add("\n----------------------------") ;
            }
            reader.Close(); newConn.Close();
        }
        private void SignInButton_Click(object sender, EventArgs e)
        {
            List<string> results = new List<string>();

            //Using list building, recursively trawls the fields to see if we need
            //to give an error message. VaidationCheck returns "" if the fields validate.
            string message = ValidationCheck(SignInButton.Parent, ref results);
            if (message != "")
            {
                MessageBox.Show(message);
            }
            else
            {
                SqlConnection newConn = new SqlConnection(conn);
                SqlCommand cmd = new SqlCommand(@"Insert into Visitor (FirstName, Surname, Mobile, 
                                     Email, Meeting_Date, Meeting_Aim, Meeting_Time, Staff_ID) values 
                                     ('" + Field_Name.Text + "','" + Field_Surname.Text + "','"
                                     + Field_Mobile.Text + "','" + Field_Email.Text + "','" +
                                     Field_Date.Value.ToString("yyyy-MM-dd") + "','" + AimButton.Text + "','" +
                                     Field_Time_Hrs.Value.ToString() + ":" +
                                     Field_Time_Mins.Value.ToString()
                                     + ":00'," + CurrentStaffID + " )", newConn);
                //Hopefully the above is self-explanatory
                //CurrentStaffID is an integer we keep correpsonding to the selected Staff member
                newConn.Open();
                cmd.ExecuteNonQuery();
                newConn.Close();
                //method to clear fields
                ClearFields(SignInButton.Parent);
                //redraw the ListBox
                OnsiteLoad();
            }
        }

        //These are messages for the ValidationCheck method
        public const string emptyMsg = "Please fill in all fields";
        public const string mobileMsg = "Please only input a phone number under \"Mobile\"";

        private String ValidationCheck(Control field, ref List<string> results)
        {
            //A recursive function. Call with the main form as 'field' to validate all fields.
            //Builds a list of possible alert messages
            if(field is Form || field is GroupBox)
            {
                foreach(Control subfield in field.Controls)
                {
                    //discard the string return when using recursively:
                    //the list is what we want
                    ValidationCheck(subfield, ref results);
                }
            }
            //Find empty text fields
            if(field is TextBox || field is ComboBox)
            {
                if (string.IsNullOrWhiteSpace(field.Text)) 
                {
                    results.Add(emptyMsg); //string defined above
                }
            }
            //check the button
            if(field == AimButton)
            {
                if (field.Text == "Meeting Aim")
                {
                    results.Add(emptyMsg);
                }
            }
            //regex check for numbers
            if(field == Field_Mobile)
            {
                //look for any string of digits and whitespace
                Regex isItAPhoneNumber = new Regex(@"[ \d]+");
                if (!isItAPhoneNumber.IsMatch(field.Text))
                {
                    results.Add(mobileMsg);
                }
            }
            //We had to let the datetimepicker and the numericupdowns go, because there'll
            //always be something in them.
            //Now we have a list, see what's in it. EmptyMsg takes priority.
            string message = "";
            if (results.Exists(x => x == mobileMsg))
                { message = mobileMsg; }
            if (results.Exists( x => x == emptyMsg)) //emptymsg takes priority
                { message = emptyMsg; }
            return message;
        }
        public void ClearFields(Control field)
        {
            //field clearing method. Like ValidationCheck, this is called recursively
            //starting with the main form.
            if (field is Form || field is GroupBox)
            {
                foreach (Control subfield in field.Controls)
                {
                    ClearFields(subfield);
                }
            }
            //What 'clearing' actually means varies by field.
            if (field is TextBox || field is DateTimePicker || field is ComboBox)
            {
                field.Text = "";
            }
//          if (field is ComboBox)
//          {
 //             ComboBox cb = field as ComboBox;
//              cb.SelectedText = "";           
//          }
            if (field is ListBox)
            {
                this.Field_Visitors.Items.Clear();
            }
            if (field is NumericUpDown)
            {
                field.Text = "0";
            }
            if (field == AimButton)
            {
                field.Text = "Meeting Aim";
            }
        }
        //Public variable so we can use this in another form.
        public static MainForm BaseForm;

        private void AimButton_Click(object sender, EventArgs e)
        {
            //summon the aim form
            AimForm popup = new AimForm();
            //set BaseForm to this form so we can affect AimButton.Text from the Aim form.
            BaseForm = this;
            popup.Show();
        }

        //This function keeps the CurrentStaffID in sync with the Meeting With field
        private void MeetingWithSelect(object sender, EventArgs e)
        {
            SqlConnection newConn = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand("select Staff_ID from Staff where Meeting_With ='"
                + Field_MeetingWith.SelectedItem+ "'", newConn);
            newConn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            //We're only getting one ID anyway, so let it be the first.
            //No need for a loop
            reader.Read();
            CurrentStaffID = (int)reader["Staff_ID"];
            reader.Close();
            newConn.Close();
        }

        //CurrentStaffID should be changed every time the Meeting_With field is changed
        private int CurrentStaffID = 0;
        //CurrentVisitorID remembers which entry the user is editing
        private int CurrentVisitorID = 0;

        static List<string[]> ChunkList(List<string> unsplit)
        {
            //function to split list of strings into list of string arrays
            //by fives. Copied from Project Bravo
            List<string[]> split = new List<string[]>();
            for (int i = 0; unsplit.Count > 0; i = i + 5)
            {
                split.Add(unsplit.Take<string>(5).ToArray<string>());
                unsplit = unsplit.Skip<string>(5).ToList();
            }
            return split;
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (Field_Visitors.SelectedIndex >= 0)
            {
                //The effect of this button is a) to fill out the fields from the entry
                //selected and b) to tell the program which entry is being updated,
                //so the correct database entry is updated when the Save button is hit.

                //We need to work around the fact that each entry
                //is represented as five items in the listbox
                int roundIndex = (int)Math.Floor((double)Field_Visitors.SelectedIndex / 5) * 5;
                //extract the unique meeting ID from the relevant entry
                int id = Int16.Parse(Field_Visitors.Items[roundIndex].ToString().Split(':'
                    )[0]);

                SqlConnection newConn = new SqlConnection(conn);
                SqlCommand cmd = new SqlCommand(@"select * from Visitor join Staff on 
                    Visitor.Staff_ID=Staff.Staff_ID where Visitor_ID ="
                    + id.ToString(), newConn);
                newConn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                //we only expect one result, so only read once - no loop 
                reader.Read();
                Field_Name.Text = reader["FirstName"].ToString();
                Field_Surname.Text = reader["Surname"].ToString();
                Field_Mobile.Text = reader["Mobile"].ToString();
                Field_Email.Text = reader["Email"].ToString();
                Field_Date.Text = reader["Meeting_Date"].ToString();
                string[] timestring = reader["Meeting_Time"].ToString().Split(':');
                Field_Time_Hrs.Text = timestring[0];
                Field_Time_Mins.Text = timestring[1];
                Field_MeetingWith.SelectedItem = reader["Meeting_With"].ToString();
                //the above should also change SelectedIndex and fire MeetingWithSelect,
                //keeping CurrentStaffID up to date
                AimButton.Text = reader["Meeting_Aim"].ToString();
                //remember we're updating this record, not any other
                CurrentVisitorID = id;
                reader.Close();
                newConn.Close();
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (CurrentVisitorID < 1) { return; }
            //This code is reused from SignInButton_Click.
            List<string> results = new List<string>();
            string message = ValidationCheck(SignInButton.Parent, ref results);
            if (message != "")
            {
                MessageBox.Show(message);
            }
            else
            {
                //This query is closely analagous to the one in SignInButton_Click,
                //though it's a different sort of query.
                //We update whichever ID we've recorded as the one we're editing.
                SqlConnection newConn = new SqlConnection(conn);
                SqlCommand cmd = new SqlCommand("Update Visitor set FirstName = '"
                    + Field_Name.Text + "', Surname = '" + Field_Surname.Text
                    + "', Mobile = '" + Field_Mobile.Text
                    + "', Email = '" + Field_Email.Text
                    + "', Meeting_Date = '" + Field_Date.Value.ToString("yyyy-MM-dd")
                    + "', Meeting_Aim = '" + AimButton.Text
                    + "', Meeting_Time = '" + Field_Time_Hrs.Value.ToString() + ":" +
                                     Field_Time_Mins.Value.ToString()
                    + ":00', Staff_ID = " + CurrentStaffID
                    + " where Visitor_ID = " + CurrentVisitorID, newConn);
                newConn.Open();
                cmd.ExecuteNonQuery();
                newConn.Close();
                //method to clear fields
                ClearFields(SignInButton.Parent);
                //redraw the listbox
                OnsiteLoad();
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (Field_Visitors.SelectedIndex >= 0)
            {
                //We need to work around the fact that each entry
                //is represented as five items in the listbox
                int roundIndex = (int)Math.Floor((double)Field_Visitors.SelectedIndex / 5) * 5;
                //extract the unique meeting ID from the relevant entry
                int id = Int16.Parse(Field_Visitors.Items[roundIndex].ToString().Split(':'
                    )[0]);

                SqlConnection newConn = new SqlConnection(conn);
                SqlCommand cmd = new SqlCommand(@"delete from Visitor where Visitor_ID ="
                    + id.ToString(), newConn);
                newConn.Open();
                cmd.ExecuteNonQuery();
                newConn.Close();
                ClearFields(SignInButton.Parent);
                OnsiteLoad();
            }   
        }
            /*   public override void ClearFields(TextBox field)
    {
    field.Clear();
    }
    public override void ClearFields(ComboBox field)
    {
    field.SelectedText = "";
    }
    public override void ClearFields(NumericUpDown field)
    {
    field.Text = "0";
    }
    public override void ClearFields(DateTimePicker field)
    {
    field.Text = "";
    }
    public override void ClearFields(Button field)
    {
    if(field == AimButton)
    {
     field.Text = "Meeting Aim";
    }
    } */
        }
}
