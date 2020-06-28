namespace BTL.Forms
{
    partial class CategoryForm
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
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.tbNameCate = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.pnlListCategory = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel3.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.gunaPanel1.Controls.Add(this.gunaPanel3);
            this.gunaPanel1.Controls.Add(this.gunaPanel2);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(800, 450);
            this.gunaPanel1.TabIndex = 0;
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.Controls.Add(this.gunaButton2);
            this.gunaPanel3.Controls.Add(this.tbNameCate);
            this.gunaPanel3.Controls.Add(this.gunaLabel1);
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel3.Location = new System.Drawing.Point(375, 0);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(425, 450);
            this.gunaPanel3.TabIndex = 1;
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
            this.gunaButton2.Location = new System.Drawing.Point(115, 189);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(164)))), ((int)(((byte)(68)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Transparent;
            this.gunaButton2.Radius = 5;
            this.gunaButton2.Size = new System.Drawing.Size(160, 42);
            this.gunaButton2.TabIndex = 11;
            this.gunaButton2.Text = "Add category";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // tbNameCate
            // 
            this.tbNameCate.BackColor = System.Drawing.Color.Transparent;
            this.tbNameCate.BaseColor = System.Drawing.Color.White;
            this.tbNameCate.BorderColor = System.Drawing.Color.Silver;
            this.tbNameCate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNameCate.FocusedBaseColor = System.Drawing.Color.White;
            this.tbNameCate.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbNameCate.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbNameCate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbNameCate.Location = new System.Drawing.Point(45, 87);
            this.tbNameCate.Name = "tbNameCate";
            this.tbNameCate.PasswordChar = '\0';
            this.tbNameCate.Radius = 3;
            this.tbNameCate.SelectedText = "";
            this.tbNameCate.Size = new System.Drawing.Size(317, 32);
            this.tbNameCate.TabIndex = 5;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(41, 46);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(49, 20);
            this.gunaLabel1.TabIndex = 6;
            this.gunaLabel1.Text = "Name";
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.pnlListCategory);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(375, 450);
            this.gunaPanel2.TabIndex = 0;
            // 
            // pnlListCategory
            // 
            this.pnlListCategory.Location = new System.Drawing.Point(30, 28);
            this.pnlListCategory.Name = "pnlListCategory";
            this.pnlListCategory.Size = new System.Drawing.Size(313, 388);
            this.pnlListCategory.TabIndex = 0;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gunaPanel1);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel3.ResumeLayout(false);
            this.gunaPanel3.PerformLayout();
            this.gunaPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaTextBox tbNameCate;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaPanel pnlListCategory;
    }
}