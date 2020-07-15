namespace BTL.Forms
{
    partial class EditCard
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
            this.cbIsDone = new Guna.UI.WinForms.GunaCheckBox();
            this.switchNoti = new Guna.UI.WinForms.GunaSwitch();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.tbCardName = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dateStartTime = new System.Windows.Forms.DateTimePicker();
            this.dateEndTime = new System.Windows.Forms.DateTimePicker();
            this.timeStartTime = new System.Windows.Forms.DateTimePicker();
            this.timeEndTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cbIsDone
            // 
            this.cbIsDone.BaseColor = System.Drawing.Color.White;
            this.cbIsDone.CheckedOffColor = System.Drawing.Color.Gray;
            this.cbIsDone.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbIsDone.FillColor = System.Drawing.Color.White;
            this.cbIsDone.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbIsDone.Location = new System.Drawing.Point(63, 288);
            this.cbIsDone.Name = "cbIsDone";
            this.cbIsDone.Size = new System.Drawing.Size(76, 20);
            this.cbIsDone.TabIndex = 0;
            this.cbIsDone.Text = "Is Done";
            // 
            // switchNoti
            // 
            this.switchNoti.BaseColor = System.Drawing.SystemColors.Control;
            this.switchNoti.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.switchNoti.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.switchNoti.FillColor = System.Drawing.Color.White;
            this.switchNoti.Location = new System.Drawing.Point(487, 288);
            this.switchNoti.Name = "switchNoti";
            this.switchNoti.Size = new System.Drawing.Size(28, 20);
            this.switchNoti.TabIndex = 1;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel1.Location = new System.Drawing.Point(59, 36);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(84, 20);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Card Name";
            // 
            // tbCardName
            // 
            this.tbCardName.BaseColor = System.Drawing.Color.White;
            this.tbCardName.BorderColor = System.Drawing.Color.Silver;
            this.tbCardName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCardName.FocusedBaseColor = System.Drawing.Color.White;
            this.tbCardName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbCardName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbCardName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbCardName.Location = new System.Drawing.Point(63, 72);
            this.tbCardName.Name = "tbCardName";
            this.tbCardName.PasswordChar = '\0';
            this.tbCardName.SelectedText = "";
            this.tbCardName.Size = new System.Drawing.Size(522, 52);
            this.tbCardName.TabIndex = 3;
            this.tbCardName.Text = "gunaTextBox1";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel2.Location = new System.Drawing.Point(59, 166);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(77, 20);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "Start Time";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel3.Location = new System.Drawing.Point(59, 230);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(71, 20);
            this.gunaLabel3.TabIndex = 5;
            this.gunaLabel3.Text = "End Time";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.ForeColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel4.Location = new System.Drawing.Point(381, 288);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(88, 20);
            this.gunaLabel4.TabIndex = 8;
            this.gunaLabel4.Text = "Notification";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(360, 357);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 39);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(487, 357);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 39);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(232, 357);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 39);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dateStartTime
            // 
            this.dateStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStartTime.Location = new System.Drawing.Point(172, 166);
            this.dateStartTime.Name = "dateStartTime";
            this.dateStartTime.Size = new System.Drawing.Size(147, 22);
            this.dateStartTime.TabIndex = 14;
            // 
            // dateEndTime
            // 
            this.dateEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEndTime.Location = new System.Drawing.Point(172, 230);
            this.dateEndTime.Name = "dateEndTime";
            this.dateEndTime.Size = new System.Drawing.Size(147, 22);
            this.dateEndTime.TabIndex = 15;
            // 
            // timeStartTime
            // 
            this.timeStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeStartTime.Location = new System.Drawing.Point(370, 166);
            this.timeStartTime.Name = "timeStartTime";
            this.timeStartTime.ShowUpDown = true;
            this.timeStartTime.Size = new System.Drawing.Size(145, 22);
            this.timeStartTime.TabIndex = 16;
            // 
            // timeEndTime
            // 
            this.timeEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeEndTime.Location = new System.Drawing.Point(370, 230);
            this.timeEndTime.Name = "timeEndTime";
            this.timeEndTime.ShowUpDown = true;
            this.timeEndTime.Size = new System.Drawing.Size(145, 22);
            this.timeEndTime.TabIndex = 17;
            // 
            // EditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(631, 450);
            this.ControlBox = false;
            this.Controls.Add(this.timeEndTime);
            this.Controls.Add(this.timeStartTime);
            this.Controls.Add(this.dateEndTime);
            this.Controls.Add(this.dateStartTime);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.tbCardName);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.switchNoti);
            this.Controls.Add(this.cbIsDone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EditCard";
            this.Text = "EditCard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaCheckBox cbIsDone;
        private Guna.UI.WinForms.GunaSwitch switchNoti;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox tbCardName;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DateTimePicker dateStartTime;
        private System.Windows.Forms.DateTimePicker dateEndTime;
        private System.Windows.Forms.DateTimePicker timeStartTime;
        private System.Windows.Forms.DateTimePicker timeEndTime;
    }
}