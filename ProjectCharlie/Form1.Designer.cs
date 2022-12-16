namespace ProjectCharlie
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SignInButton = new System.Windows.Forms.Button();
            this.Box_Visitor = new System.Windows.Forms.GroupBox();
            this.Field_Email = new System.Windows.Forms.TextBox();
            this.Label_Email = new System.Windows.Forms.Label();
            this.Field_Mobile = new System.Windows.Forms.TextBox();
            this.Label_Mobile = new System.Windows.Forms.Label();
            this.Field_Surname = new System.Windows.Forms.TextBox();
            this.Label_Surname = new System.Windows.Forms.Label();
            this.Field_Name = new System.Windows.Forms.TextBox();
            this.Label_Name = new System.Windows.Forms.Label();
            this.Box_Meeting = new System.Windows.Forms.GroupBox();
            this.AimButton = new System.Windows.Forms.Button();
            this.Label_Aim = new System.Windows.Forms.Label();
            this.Label_MeetingWith = new System.Windows.Forms.Label();
            this.Field_MeetingWith = new System.Windows.Forms.ComboBox();
            this.Field_Time_Mins = new System.Windows.Forms.NumericUpDown();
            this.Colon = new System.Windows.Forms.Label();
            this.Field_Time_Hrs = new System.Windows.Forms.NumericUpDown();
            this.Label_Time = new System.Windows.Forms.Label();
            this.Field_Date = new System.Windows.Forms.DateTimePicker();
            this.Label_Date = new System.Windows.Forms.Label();
            this.Field_Visitors = new System.Windows.Forms.ListBox();
            this.Box_Onsite = new System.Windows.Forms.GroupBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.Box_Visitor.SuspendLayout();
            this.Box_Meeting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Field_Time_Mins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Field_Time_Hrs)).BeginInit();
            this.Box_Onsite.SuspendLayout();
            this.SuspendLayout();
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(25, 350);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(170, 66);
            this.SignInButton.TabIndex = 0;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // Box_Visitor
            // 
            this.Box_Visitor.Controls.Add(this.Field_Email);
            this.Box_Visitor.Controls.Add(this.Label_Email);
            this.Box_Visitor.Controls.Add(this.Field_Mobile);
            this.Box_Visitor.Controls.Add(this.Label_Mobile);
            this.Box_Visitor.Controls.Add(this.Field_Surname);
            this.Box_Visitor.Controls.Add(this.Label_Surname);
            this.Box_Visitor.Controls.Add(this.Field_Name);
            this.Box_Visitor.Controls.Add(this.Label_Name);
            this.Box_Visitor.Location = new System.Drawing.Point(25, 12);
            this.Box_Visitor.Name = "Box_Visitor";
            this.Box_Visitor.Size = new System.Drawing.Size(293, 332);
            this.Box_Visitor.TabIndex = 1;
            this.Box_Visitor.TabStop = false;
            this.Box_Visitor.Text = "Visitor Details";
            // 
            // Field_Email
            // 
            this.Field_Email.Location = new System.Drawing.Point(35, 300);
            this.Field_Email.Name = "Field_Email";
            this.Field_Email.Size = new System.Drawing.Size(238, 26);
            this.Field_Email.TabIndex = 6;
            // 
            // Label_Email
            // 
            this.Label_Email.AutoSize = true;
            this.Label_Email.Location = new System.Drawing.Point(31, 269);
            this.Label_Email.Name = "Label_Email";
            this.Label_Email.Size = new System.Drawing.Size(53, 20);
            this.Label_Email.TabIndex = 5;
            this.Label_Email.Text = "Email";
            // 
            // Field_Mobile
            // 
            this.Field_Mobile.Location = new System.Drawing.Point(35, 225);
            this.Field_Mobile.Name = "Field_Mobile";
            this.Field_Mobile.Size = new System.Drawing.Size(238, 26);
            this.Field_Mobile.TabIndex = 4;
            // 
            // Label_Mobile
            // 
            this.Label_Mobile.AutoSize = true;
            this.Label_Mobile.Location = new System.Drawing.Point(31, 189);
            this.Label_Mobile.Name = "Label_Mobile";
            this.Label_Mobile.Size = new System.Drawing.Size(61, 20);
            this.Label_Mobile.TabIndex = 2;
            this.Label_Mobile.Text = "Mobile";
            // 
            // Field_Surname
            // 
            this.Field_Surname.Location = new System.Drawing.Point(35, 144);
            this.Field_Surname.Name = "Field_Surname";
            this.Field_Surname.Size = new System.Drawing.Size(238, 26);
            this.Field_Surname.TabIndex = 3;
            // 
            // Label_Surname
            // 
            this.Label_Surname.AutoSize = true;
            this.Label_Surname.Location = new System.Drawing.Point(31, 110);
            this.Label_Surname.Name = "Label_Surname";
            this.Label_Surname.Size = new System.Drawing.Size(81, 20);
            this.Label_Surname.TabIndex = 2;
            this.Label_Surname.Text = "Surname";
            // 
            // Field_Name
            // 
            this.Field_Name.Location = new System.Drawing.Point(35, 66);
            this.Field_Name.Name = "Field_Name";
            this.Field_Name.Size = new System.Drawing.Size(238, 26);
            this.Field_Name.TabIndex = 1;
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Location = new System.Drawing.Point(31, 32);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(55, 20);
            this.Label_Name.TabIndex = 0;
            this.Label_Name.Text = "Name";
            // 
            // Box_Meeting
            // 
            this.Box_Meeting.Controls.Add(this.AimButton);
            this.Box_Meeting.Controls.Add(this.Label_Aim);
            this.Box_Meeting.Controls.Add(this.Label_MeetingWith);
            this.Box_Meeting.Controls.Add(this.Field_MeetingWith);
            this.Box_Meeting.Controls.Add(this.Field_Time_Mins);
            this.Box_Meeting.Controls.Add(this.Colon);
            this.Box_Meeting.Controls.Add(this.Field_Time_Hrs);
            this.Box_Meeting.Controls.Add(this.Label_Time);
            this.Box_Meeting.Controls.Add(this.Field_Date);
            this.Box_Meeting.Controls.Add(this.Label_Date);
            this.Box_Meeting.Location = new System.Drawing.Point(336, 12);
            this.Box_Meeting.Name = "Box_Meeting";
            this.Box_Meeting.Size = new System.Drawing.Size(287, 332);
            this.Box_Meeting.TabIndex = 2;
            this.Box_Meeting.TabStop = false;
            this.Box_Meeting.Text = "Meeting Details";
            // 
            // AimButton
            // 
            this.AimButton.Location = new System.Drawing.Point(37, 292);
            this.AimButton.Name = "AimButton";
            this.AimButton.Size = new System.Drawing.Size(224, 31);
            this.AimButton.TabIndex = 3;
            this.AimButton.Text = "Meeting Aim";
            this.AimButton.UseVisualStyleBackColor = true;
            this.AimButton.Click += new System.EventHandler(this.AimButton_Click);
            // 
            // Label_Aim
            // 
            this.Label_Aim.AutoSize = true;
            this.Label_Aim.Location = new System.Drawing.Point(33, 269);
            this.Label_Aim.Name = "Label_Aim";
            this.Label_Aim.Size = new System.Drawing.Size(108, 20);
            this.Label_Aim.TabIndex = 3;
            this.Label_Aim.Text = "Meeting Aim";
            // 
            // Label_MeetingWith
            // 
            this.Label_MeetingWith.AutoSize = true;
            this.Label_MeetingWith.Location = new System.Drawing.Point(33, 189);
            this.Label_MeetingWith.Name = "Label_MeetingWith";
            this.Label_MeetingWith.Size = new System.Drawing.Size(114, 20);
            this.Label_MeetingWith.TabIndex = 6;
            this.Label_MeetingWith.Text = "Meeting With";
            // 
            // Field_MeetingWith
            // 
            this.Field_MeetingWith.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Field_MeetingWith.FormattingEnabled = true;
            this.Field_MeetingWith.Location = new System.Drawing.Point(37, 224);
            this.Field_MeetingWith.Name = "Field_MeetingWith";
            this.Field_MeetingWith.Size = new System.Drawing.Size(224, 28);
            this.Field_MeetingWith.TabIndex = 3;
            this.Field_MeetingWith.SelectedIndexChanged += new System.EventHandler(this.MeetingWithSelect);
            // 
            // Field_Time_Mins
            // 
            this.Field_Time_Mins.Location = new System.Drawing.Point(160, 145);
            this.Field_Time_Mins.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.Field_Time_Mins.Name = "Field_Time_Mins";
            this.Field_Time_Mins.Size = new System.Drawing.Size(101, 26);
            this.Field_Time_Mins.TabIndex = 5;
            // 
            // Colon
            // 
            this.Colon.AutoSize = true;
            this.Colon.Location = new System.Drawing.Point(140, 144);
            this.Colon.Name = "Colon";
            this.Colon.Size = new System.Drawing.Size(14, 20);
            this.Colon.TabIndex = 4;
            this.Colon.Text = ":";
            // 
            // Field_Time_Hrs
            // 
            this.Field_Time_Hrs.Location = new System.Drawing.Point(37, 145);
            this.Field_Time_Hrs.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.Field_Time_Hrs.Name = "Field_Time_Hrs";
            this.Field_Time_Hrs.Size = new System.Drawing.Size(97, 26);
            this.Field_Time_Hrs.TabIndex = 3;
            // 
            // Label_Time
            // 
            this.Label_Time.AutoSize = true;
            this.Label_Time.Location = new System.Drawing.Point(33, 110);
            this.Label_Time.Name = "Label_Time";
            this.Label_Time.Size = new System.Drawing.Size(47, 20);
            this.Label_Time.TabIndex = 2;
            this.Label_Time.Text = "Time";
            // 
            // Field_Date
            // 
            this.Field_Date.CustomFormat = "yyyy-mm-dd";
            this.Field_Date.Location = new System.Drawing.Point(37, 66);
            this.Field_Date.Name = "Field_Date";
            this.Field_Date.Size = new System.Drawing.Size(224, 26);
            this.Field_Date.TabIndex = 1;
            // 
            // Label_Date
            // 
            this.Label_Date.AutoSize = true;
            this.Label_Date.Location = new System.Drawing.Point(33, 32);
            this.Label_Date.Name = "Label_Date";
            this.Label_Date.Size = new System.Drawing.Size(48, 20);
            this.Label_Date.TabIndex = 0;
            this.Label_Date.Text = "Date";
            // 
            // Field_Visitors
            // 
            this.Field_Visitors.FormattingEnabled = true;
            this.Field_Visitors.ItemHeight = 20;
            this.Field_Visitors.Location = new System.Drawing.Point(6, 32);
            this.Field_Visitors.Name = "Field_Visitors";
            this.Field_Visitors.Size = new System.Drawing.Size(274, 364);
            this.Field_Visitors.TabIndex = 3;
            // 
            // Box_Onsite
            // 
            this.Box_Onsite.Controls.Add(this.Field_Visitors);
            this.Box_Onsite.Location = new System.Drawing.Point(640, 12);
            this.Box_Onsite.Name = "Box_Onsite";
            this.Box_Onsite.Size = new System.Drawing.Size(286, 404);
            this.Box_Onsite.TabIndex = 4;
            this.Box_Onsite.TabStop = false;
            this.Box_Onsite.Text = "Visitors Onsite";
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(211, 350);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(132, 66);
            this.EditButton.TabIndex = 5;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(358, 350);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(132, 66);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(508, 350);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(115, 66);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 428);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.Box_Onsite);
            this.Controls.Add(this.Box_Meeting);
            this.Controls.Add(this.Box_Visitor);
            this.Controls.Add(this.SignInButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "Visitor Registration";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Box_Visitor.ResumeLayout(false);
            this.Box_Visitor.PerformLayout();
            this.Box_Meeting.ResumeLayout(false);
            this.Box_Meeting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Field_Time_Mins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Field_Time_Hrs)).EndInit();
            this.Box_Onsite.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.GroupBox Box_Visitor;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.TextBox Field_Name;
        private System.Windows.Forms.Label Label_Surname;
        private System.Windows.Forms.TextBox Field_Email;
        private System.Windows.Forms.Label Label_Email;
        private System.Windows.Forms.TextBox Field_Mobile;
        private System.Windows.Forms.Label Label_Mobile;
        private System.Windows.Forms.TextBox Field_Surname;
        private System.Windows.Forms.GroupBox Box_Meeting;
        private System.Windows.Forms.Label Label_Date;
        private System.Windows.Forms.DateTimePicker Field_Date;
        private System.Windows.Forms.NumericUpDown Field_Time_Hrs;
        private System.Windows.Forms.Label Label_Time;
        private System.Windows.Forms.Label Colon;
        private System.Windows.Forms.NumericUpDown Field_Time_Mins;
        private System.Windows.Forms.Label Label_MeetingWith;
        private System.Windows.Forms.ComboBox Field_MeetingWith;
        public System.Windows.Forms.Button AimButton;
        private System.Windows.Forms.Label Label_Aim;
        private System.Windows.Forms.ListBox Field_Visitors;
        private System.Windows.Forms.GroupBox Box_Onsite;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}

