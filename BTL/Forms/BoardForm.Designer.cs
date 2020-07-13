namespace BTL.Forms
{
    partial class BoardForm
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
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.flpListBoard = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMargin = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.gunaPanel1.Controls.Add(this.flpListBoard);
            this.gunaPanel1.Controls.Add(this.pnlMargin);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(800, 560);
            this.gunaPanel1.TabIndex = 0;
            // 
            // flpListBoard
            // 
            this.flpListBoard.AutoScroll = true;
            this.flpListBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpListBoard.Location = new System.Drawing.Point(50, 0);
            this.flpListBoard.Name = "flpListBoard";
            this.flpListBoard.Size = new System.Drawing.Size(750, 560);
            this.flpListBoard.TabIndex = 1;
            // 
            // pnlMargin
            // 
            this.pnlMargin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMargin.Location = new System.Drawing.Point(0, 0);
            this.pnlMargin.Name = "pnlMargin";
            this.pnlMargin.Size = new System.Drawing.Size(50, 560);
            this.pnlMargin.TabIndex = 0;
            // 
            // BoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.gunaPanel1);
            this.Name = "BoardForm";
            this.Text = "BoardForm";
            this.gunaPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel pnlMargin;
        private System.Windows.Forms.FlowLayoutPanel flpListBoard;
    }
}