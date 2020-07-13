namespace BTL.Component
{
    partial class UCComment
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
            this.lbContentCmt = new Guna.UI.WinForms.GunaLabel();
            this.lbTime = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // lbContentCmt
            // 
            this.lbContentCmt.AutoSize = true;
            this.lbContentCmt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbContentCmt.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbContentCmt.Location = new System.Drawing.Point(28, 17);
            this.lbContentCmt.Name = "lbContentCmt";
            this.lbContentCmt.Size = new System.Drawing.Size(102, 20);
            this.lbContentCmt.TabIndex = 0;
            this.lbContentCmt.Text = "Comment abc";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbTime.Location = new System.Drawing.Point(524, 65);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(143, 20);
            this.lbTime.TabIndex = 1;
            this.lbTime.Text = "2008-11-11 13:23:44";
            // 
            // UCComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbContentCmt);
            this.Name = "UCComment";
            this.Size = new System.Drawing.Size(700, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lbContentCmt;
        private Guna.UI.WinForms.GunaLabel lbTime;
    }
}
