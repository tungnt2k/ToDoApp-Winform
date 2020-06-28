namespace BTL.Forms
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
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.tbContent = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.cbbCategory = new Guna.UI.WinForms.GunaComboBox();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.pnlListTask = new Guna.UI.WinForms.GunaPanel();
            this.tbTitle = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.numEstimateTime = new Guna.UI.WinForms.GunaNumeric();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.gunaPanel1.Controls.Add(this.numEstimateTime);
            this.gunaPanel1.Controls.Add(this.gunaLabel4);
            this.gunaPanel1.Controls.Add(this.gunaButton2);
            this.gunaPanel1.Controls.Add(this.tbContent);
            this.gunaPanel1.Controls.Add(this.gunaLabel2);
            this.gunaPanel1.Controls.Add(this.gunaLabel3);
            this.gunaPanel1.Controls.Add(this.cbbCategory);
            this.gunaPanel1.Controls.Add(this.gunaPanel2);
            this.gunaPanel1.Controls.Add(this.tbTitle);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(800, 541);
            this.gunaPanel1.TabIndex = 0;
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(166)))), ((int)(((byte)(69)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Transparent;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = null;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(642, 460);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(164)))), ((int)(((byte)(68)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Transparent;
            this.gunaButton2.Radius = 5;
            this.gunaButton2.Size = new System.Drawing.Size(120, 42);
            this.gunaButton2.TabIndex = 10;
            this.gunaButton2.Text = "Add task";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // tbContent
            // 
            this.tbContent.BackColor = System.Drawing.Color.Transparent;
            this.tbContent.BaseColor = System.Drawing.Color.White;
            this.tbContent.BorderColor = System.Drawing.Color.Silver;
            this.tbContent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbContent.FocusedBaseColor = System.Drawing.Color.White;
            this.tbContent.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbContent.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbContent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbContent.Location = new System.Drawing.Point(445, 270);
            this.tbContent.Name = "tbContent";
            this.tbContent.PasswordChar = '\0';
            this.tbContent.Radius = 3;
            this.tbContent.SelectedText = "";
            this.tbContent.Size = new System.Drawing.Size(317, 86);
            this.tbContent.TabIndex = 3;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(441, 219);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(61, 20);
            this.gunaLabel2.TabIndex = 5;
            this.gunaLabel2.Text = "Content";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(441, 121);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(69, 20);
            this.gunaLabel3.TabIndex = 7;
            this.gunaLabel3.Text = "Category";
            // 
            // cbbCategory
            // 
            this.cbbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbbCategory.BaseColor = System.Drawing.Color.White;
            this.cbbCategory.BorderColor = System.Drawing.Color.Silver;
            this.cbbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategory.FocusedColor = System.Drawing.Color.Empty;
            this.cbbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbCategory.ForeColor = System.Drawing.Color.Black;
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(445, 161);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbCategory.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbCategory.Size = new System.Drawing.Size(317, 31);
            this.cbbCategory.TabIndex = 6;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.pnlListTask);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(406, 541);
            this.gunaPanel2.TabIndex = 0;
            // 
            // pnlListTask
            // 
            this.pnlListTask.Location = new System.Drawing.Point(32, 29);
            this.pnlListTask.Name = "pnlListTask";
            this.pnlListTask.Size = new System.Drawing.Size(336, 485);
            this.pnlListTask.TabIndex = 2;
            // 
            // tbTitle
            // 
            this.tbTitle.BackColor = System.Drawing.Color.Transparent;
            this.tbTitle.BaseColor = System.Drawing.Color.White;
            this.tbTitle.BorderColor = System.Drawing.Color.Silver;
            this.tbTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTitle.FocusedBaseColor = System.Drawing.Color.White;
            this.tbTitle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbTitle.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbTitle.Location = new System.Drawing.Point(445, 70);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.PasswordChar = '\0';
            this.tbTitle.Radius = 3;
            this.tbTitle.SelectedText = "";
            this.tbTitle.Size = new System.Drawing.Size(317, 32);
            this.tbTitle.TabIndex = 0;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(441, 29);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(38, 20);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "Title";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Location = new System.Drawing.Point(441, 388);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(100, 20);
            this.gunaLabel4.TabIndex = 11;
            this.gunaLabel4.Text = "Estimate time";
            // 
            // numEstimateTime
            // 
            this.numEstimateTime.BaseColor = System.Drawing.Color.White;
            this.numEstimateTime.BorderColor = System.Drawing.Color.Silver;
            this.numEstimateTime.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.numEstimateTime.ButtonForeColor = System.Drawing.Color.White;
            this.numEstimateTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numEstimateTime.ForeColor = System.Drawing.Color.Black;
            this.numEstimateTime.Location = new System.Drawing.Point(595, 378);
            this.numEstimateTime.Maximum = ((long)(9999999));
            this.numEstimateTime.Minimum = ((long)(0));
            this.numEstimateTime.Name = "numEstimateTime";
            this.numEstimateTime.Size = new System.Drawing.Size(75, 30);
            this.numEstimateTime.TabIndex = 12;
            this.numEstimateTime.Text = "gunaNumeric1";
            this.numEstimateTime.Value = ((long)(0));
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.gunaPanel1);
            this.Name = "TaskForm";
            this.Text = "TaskForm";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaTextBox tbTitle;
        private Guna.UI.WinForms.GunaPanel pnlListTask;
        private Guna.UI.WinForms.GunaTextBox tbContent;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaComboBox cbbCategory;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaNumeric numEstimateTime;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
    }
}