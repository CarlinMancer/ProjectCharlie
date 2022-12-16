namespace ProjectCharlie
{
    partial class AimForm
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
            this.PleaseSpecify = new System.Windows.Forms.Label();
            this.MeetingButton = new System.Windows.Forms.RadioButton();
            this.SalesButton = new System.Windows.Forms.RadioButton();
            this.VisitButton = new System.Windows.Forms.RadioButton();
            this.InterviewButton = new System.Windows.Forms.RadioButton();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PleaseSpecify
            // 
            this.PleaseSpecify.AutoSize = true;
            this.PleaseSpecify.Location = new System.Drawing.Point(12, 19);
            this.PleaseSpecify.Name = "PleaseSpecify";
            this.PleaseSpecify.Size = new System.Drawing.Size(293, 20);
            this.PleaseSpecify.TabIndex = 0;
            this.PleaseSpecify.Text = "Please specify the nature of the meeting";
            // 
            // MeetingButton
            // 
            this.MeetingButton.AutoSize = true;
            this.MeetingButton.Location = new System.Drawing.Point(74, 99);
            this.MeetingButton.Name = "MeetingButton";
            this.MeetingButton.Size = new System.Drawing.Size(91, 24);
            this.MeetingButton.TabIndex = 1;
            this.MeetingButton.TabStop = true;
            this.MeetingButton.Text = "Meeting";
            this.MeetingButton.UseVisualStyleBackColor = true;
            // 
            // SalesButton
            // 
            this.SalesButton.AutoSize = true;
            this.SalesButton.Location = new System.Drawing.Point(271, 99);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.Size = new System.Drawing.Size(169, 24);
            this.SalesButton.TabIndex = 2;
            this.SalesButton.TabStop = true;
            this.SalesButton.Text = "Sales Appointment";
            this.SalesButton.UseVisualStyleBackColor = true;
            // 
            // VisitButton
            // 
            this.VisitButton.AutoSize = true;
            this.VisitButton.Location = new System.Drawing.Point(74, 203);
            this.VisitButton.Name = "VisitButton";
            this.VisitButton.Size = new System.Drawing.Size(96, 24);
            this.VisitButton.TabIndex = 3;
            this.VisitButton.TabStop = true;
            this.VisitButton.Text = "Site Visit";
            this.VisitButton.UseVisualStyleBackColor = true;
            // 
            // InterviewButton
            // 
            this.InterviewButton.AutoSize = true;
            this.InterviewButton.Location = new System.Drawing.Point(271, 203);
            this.InterviewButton.Name = "InterviewButton";
            this.InterviewButton.Size = new System.Drawing.Size(158, 24);
            this.InterviewButton.TabIndex = 4;
            this.InterviewButton.TabStop = true;
            this.InterviewButton.Text = "Student Interview";
            this.InterviewButton.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(345, 276);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(105, 32);
            this.OKButton.TabIndex = 6;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelB
            // 
            this.CancelB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelB.Location = new System.Drawing.Point(185, 276);
            this.CancelB.Name = "CancelB";
            this.CancelB.Size = new System.Drawing.Size(105, 32);
            this.CancelB.TabIndex = 5;
            this.CancelB.Text = "Cancel";
            this.CancelB.UseVisualStyleBackColor = true;
            this.CancelB.Click += new System.EventHandler(this.CancelB_Click);
            // 
            // AimForm
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelB;
            this.ClientSize = new System.Drawing.Size(485, 320);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelB);
            this.Controls.Add(this.InterviewButton);
            this.Controls.Add(this.VisitButton);
            this.Controls.Add(this.SalesButton);
            this.Controls.Add(this.MeetingButton);
            this.Controls.Add(this.PleaseSpecify);
            this.Name = "AimForm";
            this.Text = "Aim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PleaseSpecify;
        private System.Windows.Forms.RadioButton MeetingButton;
        private System.Windows.Forms.RadioButton SalesButton;
        private System.Windows.Forms.RadioButton VisitButton;
        private System.Windows.Forms.RadioButton InterviewButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelB;
    }
}