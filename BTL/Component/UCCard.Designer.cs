namespace BTL.UserControl
{
    partial class UCCollection
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbName = new Guna.UI.WinForms.GunaLabel();
            this.gunaLb = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.lbStartDate = new Guna.UI.WinForms.GunaLabel();
            this.lbEndDate = new Guna.UI.WinForms.GunaLabel();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.cbIsDone = new Guna.UI.WinForms.GunaCheckBox();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(73, 28);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(81, 20);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "Card name";
            // 
            // gunaLb
            // 
            this.gunaLb.AutoSize = true;
            this.gunaLb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLb.ForeColor = System.Drawing.Color.Gainsboro;
            this.gunaLb.Location = new System.Drawing.Point(27, 68);
            this.gunaLb.Name = "gunaLb";
            this.gunaLb.Size = new System.Drawing.Size(76, 20);
            this.gunaLb.TabIndex = 6;
            this.gunaLb.Text = "Start Date";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel1.Location = new System.Drawing.Point(360, 68);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(70, 20);
            this.gunaLabel1.TabIndex = 7;
            this.gunaLabel1.Text = "End Date";
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbStartDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbStartDate.Location = new System.Drawing.Point(122, 68);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(143, 20);
            this.lbStartDate.TabIndex = 8;
            this.lbStartDate.Text = "2008-11-11 13:23:44";
            // 
            // lbEndDate
            // 
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbEndDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbEndDate.Location = new System.Drawing.Point(460, 68);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(143, 20);
            this.lbEndDate.TabIndex = 9;
            this.lbEndDate.Text = "2008-11-11 13:23:44";
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnEdit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEdit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnEdit.IconSize = 32;
            this.btnEdit.Location = new System.Drawing.Point(578, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Rotation = 0D;
            this.btnEdit.Size = new System.Drawing.Size(59, 36);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbIsDone
            // 
            this.cbIsDone.BaseColor = System.Drawing.Color.White;
            this.cbIsDone.CheckedOffColor = System.Drawing.Color.Gray;
            this.cbIsDone.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.cbIsDone.FillColor = System.Drawing.Color.White;
            this.cbIsDone.Location = new System.Drawing.Point(31, 28);
            this.cbIsDone.Name = "cbIsDone";
            this.cbIsDone.Size = new System.Drawing.Size(20, 20);
            this.cbIsDone.TabIndex = 11;
            this.cbIsDone.CheckedChanged += new System.EventHandler(this.cbIsDone_CheckedChanged_1);
            // 
            // UCCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.cbIsDone);
            this.Controls.Add(this.lbEndDate);
            this.Controls.Add(this.lbStartDate);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaLb);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnEdit);
            this.Name = "UCCollection";
            this.Size = new System.Drawing.Size(640, 100);
            this.Click += new System.EventHandler(this.UCCollection_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnEdit;
        private Guna.UI.WinForms.GunaLabel lbName;
        private Guna.UI.WinForms.GunaLabel gunaLb;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel lbStartDate;
        private Guna.UI.WinForms.GunaLabel lbEndDate;
        private Guna.UI.WinForms.GunaCheckBox cbIsDone;
    }
}
