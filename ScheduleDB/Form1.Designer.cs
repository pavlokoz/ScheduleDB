namespace ScheduleDB
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
            this.DayEntry = new System.Windows.Forms.TextBox();
            this.DayLabel = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.NumberEntry = new System.Windows.Forms.TextBox();
            this.TypeEntry = new System.Windows.Forms.TextBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.SubjectEntry = new System.Windows.Forms.TextBox();
            this.TutorLabel = new System.Windows.Forms.Label();
            this.TutorEntry = new System.Windows.Forms.TextBox();
            this.AuditoriumLabel = new System.Windows.Forms.Label();
            this.AuditoriumEntry = new System.Windows.Forms.TextBox();
            this.GroupLabel = new System.Windows.Forms.Label();
            this.GroupsEntry = new System.Windows.Forms.TextBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DayEntry
            // 
            this.DayEntry.Location = new System.Drawing.Point(15, 24);
            this.DayEntry.Name = "DayEntry";
            this.DayEntry.Size = new System.Drawing.Size(100, 20);
            this.DayEntry.TabIndex = 0;
            this.DayEntry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SimpleEntry_KeyPress);
            // 
            // DayLabel
            // 
            this.DayLabel.AutoSize = true;
            this.DayLabel.Location = new System.Drawing.Point(12, 8);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Size = new System.Drawing.Size(26, 13);
            this.DayLabel.TabIndex = 1;
            this.DayLabel.Text = "Day";
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(118, 8);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(65, 13);
            this.NumberLabel.TabIndex = 2;
            this.NumberLabel.Text = "Pair Number";
            // 
            // NumberEntry
            // 
            this.NumberEntry.Location = new System.Drawing.Point(121, 24);
            this.NumberEntry.Name = "NumberEntry";
            this.NumberEntry.Size = new System.Drawing.Size(100, 20);
            this.NumberEntry.TabIndex = 3;
            this.NumberEntry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberEntry_KeyPress);
            // 
            // TypeEntry
            // 
            this.TypeEntry.Location = new System.Drawing.Point(227, 24);
            this.TypeEntry.Name = "TypeEntry";
            this.TypeEntry.Size = new System.Drawing.Size(100, 20);
            this.TypeEntry.TabIndex = 4;
            this.TypeEntry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SimpleEntry_KeyPress);
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(224, 8);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(52, 13);
            this.TypeLabel.TabIndex = 5;
            this.TypeLabel.Text = "Pair Type";
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Location = new System.Drawing.Point(330, 8);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(43, 13);
            this.SubjectLabel.TabIndex = 6;
            this.SubjectLabel.Text = "Subject";
            // 
            // SubjectEntry
            // 
            this.SubjectEntry.Location = new System.Drawing.Point(333, 24);
            this.SubjectEntry.Name = "SubjectEntry";
            this.SubjectEntry.Size = new System.Drawing.Size(100, 20);
            this.SubjectEntry.TabIndex = 7;
            this.SubjectEntry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SimpleEntry_KeyPress);
            // 
            // TutorLabel
            // 
            this.TutorLabel.AutoSize = true;
            this.TutorLabel.Location = new System.Drawing.Point(13, 51);
            this.TutorLabel.Name = "TutorLabel";
            this.TutorLabel.Size = new System.Drawing.Size(37, 13);
            this.TutorLabel.TabIndex = 8;
            this.TutorLabel.Text = "Tutors";
            // 
            // TutorEntry
            // 
            this.TutorEntry.Location = new System.Drawing.Point(15, 68);
            this.TutorEntry.Name = "TutorEntry";
            this.TutorEntry.Size = new System.Drawing.Size(418, 20);
            this.TutorEntry.TabIndex = 9;
            this.TutorEntry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MultiplyEntry_KeyPress);
            // 
            // AuditoriumLabel
            // 
            this.AuditoriumLabel.AutoSize = true;
            this.AuditoriumLabel.Location = new System.Drawing.Point(16, 95);
            this.AuditoriumLabel.Name = "AuditoriumLabel";
            this.AuditoriumLabel.Size = new System.Drawing.Size(61, 13);
            this.AuditoriumLabel.TabIndex = 10;
            this.AuditoriumLabel.Text = "Auditoriums";
            // 
            // AuditoriumEntry
            // 
            this.AuditoriumEntry.Location = new System.Drawing.Point(15, 112);
            this.AuditoriumEntry.Name = "AuditoriumEntry";
            this.AuditoriumEntry.Size = new System.Drawing.Size(418, 20);
            this.AuditoriumEntry.TabIndex = 11;
            this.AuditoriumEntry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MultiplyEntry_KeyPress);
            // 
            // GroupLabel
            // 
            this.GroupLabel.AutoSize = true;
            this.GroupLabel.Location = new System.Drawing.Point(15, 139);
            this.GroupLabel.Name = "GroupLabel";
            this.GroupLabel.Size = new System.Drawing.Size(41, 13);
            this.GroupLabel.TabIndex = 12;
            this.GroupLabel.Text = "Groups";
            // 
            // GroupsEntry
            // 
            this.GroupsEntry.Location = new System.Drawing.Point(15, 156);
            this.GroupsEntry.Name = "GroupsEntry";
            this.GroupsEntry.Size = new System.Drawing.Size(418, 20);
            this.GroupsEntry.TabIndex = 13;
            this.GroupsEntry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MultiplyEntry_KeyPress);
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(357, 183);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(75, 23);
            this.InsertButton.TabIndex = 14;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 222);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.GroupsEntry);
            this.Controls.Add(this.GroupLabel);
            this.Controls.Add(this.AuditoriumEntry);
            this.Controls.Add(this.AuditoriumLabel);
            this.Controls.Add(this.TutorEntry);
            this.Controls.Add(this.TutorLabel);
            this.Controls.Add(this.SubjectEntry);
            this.Controls.Add(this.SubjectLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.TypeEntry);
            this.Controls.Add(this.NumberEntry);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.DayLabel);
            this.Controls.Add(this.DayEntry);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DayEntry;
        private System.Windows.Forms.Label DayLabel;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.TextBox NumberEntry;
        private System.Windows.Forms.TextBox TypeEntry;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.TextBox SubjectEntry;
        private System.Windows.Forms.Label TutorLabel;
        private System.Windows.Forms.TextBox TutorEntry;
        private System.Windows.Forms.Label AuditoriumLabel;
        private System.Windows.Forms.TextBox AuditoriumEntry;
        private System.Windows.Forms.Label GroupLabel;
        private System.Windows.Forms.TextBox GroupsEntry;
        private System.Windows.Forms.Button InsertButton;
    }
}

