namespace BTL.Forms
{
    partial class UserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.dtpBirthday = new Guna.UI.WinForms.GunaDateTimePicker();
            this.tbAddress = new Guna.UI.WinForms.GunaTextBox();
            this.tbPhone = new Guna.UI.WinForms.GunaTextBox();
            this.tbEmail = new Guna.UI.WinForms.GunaTextBox();
            this.tbFullname = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserForm";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.gunaPanel1.Controls.Add(this.btnSave);
            this.gunaPanel1.Controls.Add(this.dtpBirthday);
            this.gunaPanel1.Controls.Add(this.tbAddress);
            this.gunaPanel1.Controls.Add(this.tbPhone);
            this.gunaPanel1.Controls.Add(this.tbEmail);
            this.gunaPanel1.Controls.Add(this.tbFullname);
            this.gunaPanel1.Controls.Add(this.gunaLabel5);
            this.gunaPanel1.Controls.Add(this.gunaLabel4);
            this.gunaPanel1.Controls.Add(this.gunaLabel3);
            this.gunaPanel1.Controls.Add(this.gunaLabel2);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(800, 450);
            this.gunaPanel1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(157)))), ((int)(((byte)(65)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSave.IconColor = System.Drawing.Color.White;
            this.btnSave.IconSize = 32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(630, 353);
            this.btnSave.Name = "btnSave";
            this.btnSave.Rotation = 0D;
            this.btnSave.Size = new System.Drawing.Size(158, 53);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.BackColor = System.Drawing.Color.Transparent;
            this.dtpBirthday.BaseColor = System.Drawing.Color.White;
            this.dtpBirthday.BorderColor = System.Drawing.Color.Silver;
            this.dtpBirthday.CustomFormat = null;
            this.dtpBirthday.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpBirthday.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpBirthday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpBirthday.ForeColor = System.Drawing.Color.Black;
            this.dtpBirthday.Location = new System.Drawing.Point(175, 207);
            this.dtpBirthday.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBirthday.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpBirthday.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpBirthday.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpBirthday.OnPressedColor = System.Drawing.Color.Black;
            this.dtpBirthday.Radius = 5;
            this.dtpBirthday.Size = new System.Drawing.Size(263, 45);
            this.dtpBirthday.TabIndex = 9;
            this.dtpBirthday.Text = "Thursday, June 25, 2020";
            this.dtpBirthday.Value = new System.DateTime(2020, 6, 25, 9, 28, 22, 427);
            this.dtpBirthday.ValueChanged += new System.EventHandler(this.dtpBirthday_ValueChanged);
            // 
            // tbAddress
            // 
            this.tbAddress.BackColor = System.Drawing.Color.Transparent;
            this.tbAddress.BaseColor = System.Drawing.Color.White;
            this.tbAddress.BorderColor = System.Drawing.Color.Silver;
            this.tbAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAddress.FocusedBaseColor = System.Drawing.Color.White;
            this.tbAddress.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbAddress.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbAddress.Location = new System.Drawing.Point(175, 293);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.PasswordChar = '\0';
            this.tbAddress.Radius = 5;
            this.tbAddress.SelectedText = "";
            this.tbAddress.Size = new System.Drawing.Size(197, 42);
            this.tbAddress.TabIndex = 8;
            this.tbAddress.TextChanged += new System.EventHandler(this.tbAddress_TextChanged);
            // 
            // tbPhone
            // 
            this.tbPhone.BackColor = System.Drawing.Color.Transparent;
            this.tbPhone.BaseColor = System.Drawing.Color.White;
            this.tbPhone.BorderColor = System.Drawing.Color.Silver;
            this.tbPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhone.FocusedBaseColor = System.Drawing.Color.White;
            this.tbPhone.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbPhone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPhone.Location = new System.Drawing.Point(175, 371);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.PasswordChar = '\0';
            this.tbPhone.Radius = 5;
            this.tbPhone.SelectedText = "";
            this.tbPhone.Size = new System.Drawing.Size(181, 35);
            this.tbPhone.TabIndex = 7;
            this.tbPhone.TextChanged += new System.EventHandler(this.tbPhone_TextChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.Transparent;
            this.tbEmail.BaseColor = System.Drawing.Color.White;
            this.tbEmail.BorderColor = System.Drawing.Color.Silver;
            this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.FocusedBaseColor = System.Drawing.Color.White;
            this.tbEmail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbEmail.Location = new System.Drawing.Point(175, 127);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PasswordChar = '\0';
            this.tbEmail.Radius = 5;
            this.tbEmail.SelectedText = "";
            this.tbEmail.Size = new System.Drawing.Size(181, 35);
            this.tbEmail.TabIndex = 6;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // tbFullname
            // 
            this.tbFullname.BackColor = System.Drawing.Color.Transparent;
            this.tbFullname.BaseColor = System.Drawing.Color.White;
            this.tbFullname.BorderColor = System.Drawing.Color.Silver;
            this.tbFullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFullname.FocusedBaseColor = System.Drawing.Color.White;
            this.tbFullname.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbFullname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbFullname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbFullname.Location = new System.Drawing.Point(175, 60);
            this.tbFullname.Name = "tbFullname";
            this.tbFullname.PasswordChar = '\0';
            this.tbFullname.Radius = 5;
            this.tbFullname.SelectedText = "";
            this.tbFullname.Size = new System.Drawing.Size(181, 35);
            this.tbFullname.TabIndex = 5;
            this.tbFullname.TextChanged += new System.EventHandler(this.tbFullname_TextChanged);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gunaLabel5.ForeColor = System.Drawing.Color.White;
            this.gunaLabel5.Location = new System.Drawing.Point(24, 300);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(105, 35);
            this.gunaLabel5.TabIndex = 4;
            this.gunaLabel5.Text = "Address";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Location = new System.Drawing.Point(24, 217);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(106, 35);
            this.gunaLabel4.TabIndex = 3;
            this.gunaLabel4.Text = "Birthday";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(24, 371);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(85, 35);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "Phone";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(24, 127);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(75, 35);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Email";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(24, 60);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(115, 35);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Fullname";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.label1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaDateTimePicker dtpBirthday;
        private Guna.UI.WinForms.GunaTextBox tbAddress;
        private Guna.UI.WinForms.GunaTextBox tbPhone;
        private Guna.UI.WinForms.GunaTextBox tbEmail;
        private Guna.UI.WinForms.GunaTextBox tbFullname;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private FontAwesome.Sharp.IconButton btnSave;
    }
}