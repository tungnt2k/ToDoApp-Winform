using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL.Properties;

namespace BTL.Forms
{
    public partial class AlertForm : Form
    {
        public AlertForm()
        {
            InitializeComponent();
        }

        public enum alertTypeEnum
        {
            Warning,
            Info
        }

        private int x, y;
        public void setAlert(string msg, AlertForm.alertTypeEnum type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                AlertForm f = (AlertForm)Application.OpenForms[fname];

                if (f == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }

            }

            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
            switch (type)
            {
                case AlertForm.alertTypeEnum.Warning:
                    this.gunaPictureBox1.Image = Resources.Warning_28px;
                    this.BackColor = Color.FromArgb(255, 179, 2);
                    break;
                
                case AlertForm.alertTypeEnum.Info:
                    this.gunaPictureBox1.Image = Resources.Info_28px;
                    this.BackColor = Color.FromArgb(71, 169, 248);
                    break;
            }
            this.lbText.Text = msg;

            //this.TopMost = false;
            //this.ShowIcon = false;
            //this.ShowInTaskbar = false;

            this.Show();
            this.action = actionEnum.start;
            this.timer1.Interval = 1;
            this.timer1.Start();


        }

        public enum actionEnum
        {
            wait,
            start,
            close
        }

        private AlertForm.actionEnum action;

        private void gunaPictureBox2_Click_1(object sender, EventArgs e)
        {
            this.timer1.Interval = 1;
            this.action = AlertForm.actionEnum.close;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case AlertForm.actionEnum.wait:
                    this.timer1.Interval = 5000;
                    this.action = AlertForm.actionEnum.close;
                    break;
                case AlertForm.actionEnum.start:
                    this.timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            this.action = AlertForm.actionEnum.wait;
                        }
                    }
                    break;
                case AlertForm.actionEnum.close:
                    this.timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

    }
}
