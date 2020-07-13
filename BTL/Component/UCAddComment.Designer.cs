namespace BTL.Component
{
    partial class UCAddComment
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
            this.btnAddCmt = new FontAwesome.Sharp.IconButton();
            this.tbCmtContent = new Guna.UI.WinForms.GunaLineTextBox();
            this.SuspendLayout();
            // 
            // btnAddCmt
            // 
            this.btnAddCmt.FlatAppearance.BorderSize = 0;
            this.btnAddCmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCmt.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAddCmt.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddCmt.IconChar = FontAwesome.Sharp.IconChar.LocationArrow;
            this.btnAddCmt.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAddCmt.IconSize = 32;
            this.btnAddCmt.Location = new System.Drawing.Point(599, 12);
            this.btnAddCmt.Name = "btnAddCmt";
            this.btnAddCmt.Rotation = 0D;
            this.btnAddCmt.Size = new System.Drawing.Size(72, 62);
            this.btnAddCmt.TabIndex = 0;
            this.btnAddCmt.UseVisualStyleBackColor = true;
            this.btnAddCmt.Click += new System.EventHandler(this.btnAddCmt_Click);
            // 
            // tbCmtContent
            // 
            this.tbCmtContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.tbCmtContent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCmtContent.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbCmtContent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbCmtContent.LineColor = System.Drawing.Color.Transparent;
            this.tbCmtContent.Location = new System.Drawing.Point(29, 12);
            this.tbCmtContent.Name = "tbCmtContent";
            this.tbCmtContent.PasswordChar = '\0';
            this.tbCmtContent.SelectedText = "";
            this.tbCmtContent.Size = new System.Drawing.Size(533, 62);
            this.tbCmtContent.TabIndex = 1;
            // 
            // UCAddComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.tbCmtContent);
            this.Controls.Add(this.btnAddCmt);
            this.Name = "UCAddComment";
            this.Size = new System.Drawing.Size(700, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAddCmt;
        private Guna.UI.WinForms.GunaLineTextBox tbCmtContent;
    }
}
