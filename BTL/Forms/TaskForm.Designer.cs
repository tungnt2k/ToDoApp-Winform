﻿namespace BTL.Forms
{
    partial class TaskForm
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
            this.flpTasks = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel2.SuspendLayout();
            this.gunaPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpTasks
            // 
            this.flpTasks.AutoScroll = true;
            this.flpTasks.Location = new System.Drawing.Point(56, 42);
            this.flpTasks.Name = "flpTasks";
            this.flpTasks.Size = new System.Drawing.Size(797, 550);
            this.flpTasks.TabIndex = 0;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(50, 595);
            this.gunaPanel1.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBack.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnBack.IconColor = System.Drawing.Color.Gainsboro;
            this.btnBack.IconSize = 32;
            this.btnBack.Location = new System.Drawing.Point(1, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Rotation = 0D;
            this.btnBack.Size = new System.Drawing.Size(46, 30);
            this.btnBack.TabIndex = 1;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.btnBack);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaPanel2.Location = new System.Drawing.Point(859, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(50, 595);
            this.gunaPanel2.TabIndex = 3;
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.Controls.Add(this.gunaPanel4);
            this.gunaPanel3.Controls.Add(this.flpTasks);
            this.gunaPanel3.Controls.Add(this.gunaPanel1);
            this.gunaPanel3.Controls.Add(this.gunaPanel2);
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel3.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(909, 595);
            this.gunaPanel3.TabIndex = 4;
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel4.Location = new System.Drawing.Point(50, 0);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Size = new System.Drawing.Size(809, 36);
            this.gunaPanel4.TabIndex = 4;
            this.gunaPanel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gunaPanel4_MouseDown);
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(909, 598);
            this.ControlBox = false;
            this.Controls.Add(this.gunaPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskForm";
            this.Text = "TaskForm";
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpTasks;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private FontAwesome.Sharp.IconButton btnBack;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
    }
}