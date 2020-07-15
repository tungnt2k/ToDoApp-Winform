using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL.CustomEventArgs;
using BTL.Forms;
using BTL.Models;
using FontAwesome.Sharp;
using Color = System.Drawing.Color;

namespace BTL
{
    public partial class Main : Form
    {

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        private bool Noti;
        public Main()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(28, 28, 28);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                

            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(32, 34, 37);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            BoardForm bf = new BoardForm();
            bf.BoardClick += new EventHandler<BoardEventArgs>(BoardClick);
            OpenChildForm(bf);
        }

        protected void BoardClick(object sender, BoardEventArgs e)
        {
            CardForm cf = new CardForm(e.board);
            cf.BtnBackClick += new EventHandler(ListForm_btnBackClick);
            cf.CardClick += new EventHandler<CardEventArgs>(CardFrom_CardClick);
            OpenChildForm(cf);
        }

        protected void CardFrom_CardClick(object sender, CardEventArgs e)
        {
            TaskForm tf = new TaskForm(e.card);
            tf.Show();
        }

        protected void ListForm_btnBackClick(object sender, EventArgs e)
        {
            BoardForm bf = new BoardForm();
            bf.BoardClick += new EventHandler<BoardEventArgs>(BoardClick);
            OpenChildForm(bf);
        }



        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new SettingForm());
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();

        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            AlertForm af = new AlertForm();
            af.setAlert("Your program has been minimized to system tray",AlertForm.alertTypeEnum.Info);
            this.Hide();
            notifyIcon1.Visible = true;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState== FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            OpenChildForm(new SettingForm());
            notifyIcon1.Visible = false;
        }

        private void tODOAPPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            using (var dbContext = new TODOContext())
            {
                Noti = dbContext.UserSettings.Find(1).Noti;
            }
            if (Noti)
            {
                int num = CheckTask.checkOutOfDatelineCard();
                if (num > 0)
                {
                    AlertForm af = new AlertForm();
                    af.setAlert(String.Format("You have {0} unfinished cards !", num), AlertForm.alertTypeEnum.Warning);
                }
            }
            
        }
    }
}
