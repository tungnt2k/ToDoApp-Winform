namespace BTL.Forms
{
    partial class SettingForm
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
            this.switchNoti = new Guna.UI.WinForms.GunaWinSwitch();
            this.switchStartWithWindow = new Guna.UI.WinForms.GunaWinSwitch();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // switchNoti
            // 
            this.switchNoti.BaseColor = System.Drawing.SystemColors.Control;
            this.switchNoti.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.switchNoti.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.switchNoti.FillColor = System.Drawing.Color.White;
            this.switchNoti.Location = new System.Drawing.Point(346, 51);
            this.switchNoti.Name = "switchNoti";
            this.switchNoti.Size = new System.Drawing.Size(40, 22);
            this.switchNoti.TabIndex = 0;
            this.switchNoti.CheckedChanged += new System.EventHandler(this.switchNoti_CheckedChanged);
            // 
            // switchStartWithWindow
            // 
            this.switchStartWithWindow.BaseColor = System.Drawing.SystemColors.Control;
            this.switchStartWithWindow.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.switchStartWithWindow.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.switchStartWithWindow.FillColor = System.Drawing.Color.White;
            this.switchStartWithWindow.Location = new System.Drawing.Point(346, 116);
            this.switchStartWithWindow.Name = "switchStartWithWindow";
            this.switchStartWithWindow.Size = new System.Drawing.Size(40, 22);
            this.switchStartWithWindow.TabIndex = 1;
            this.switchStartWithWindow.CheckedChanged += new System.EventHandler(this.switchStartWithWindow_CheckedChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel1.Location = new System.Drawing.Point(117, 53);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(88, 20);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Notification";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel2.Location = new System.Drawing.Point(117, 116);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(131, 20);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "Start with Window";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.switchStartWithWindow);
            this.Controls.Add(this.switchNoti);
            this.Name = "SettingForm";
            this.Text = "SettingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaWinSwitch switchNoti;
        private Guna.UI.WinForms.GunaWinSwitch switchStartWithWindow;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}