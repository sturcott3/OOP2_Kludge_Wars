using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2_Major_mockup_PRJ
{
    public partial class InputDialog : Form
    {
        Timer t = new Timer();

        public InputDialog()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetTitle(string title)
        {
            Text = title;
        }

        public void SetDirections(string directions, string directions2 = "")
        {
            lblDirections1.Text = directions;
            lblDirections2.Text = directions2;
        }

        public string GetResult()
        {
            return tbxInput1.Text;
        }
        public string[] GetResults()
        {
            return new string[] { tbxInput1.Text, tbxInput2.Text };
        }

        public void SetButton(string buttonText)
        {
            btnConfirm.Text = buttonText;
        }

        private void InputDialog_Load(object sender, EventArgs e)
        {
            //Clear textbox each time
            tbxInput1.Clear();
            tbxInput2.Clear();
        }

        public void ShowWarning(string warning, double seconds)
        {
            sblWarning.Text = warning;
            sblWarning.Visible = true;

            t.Stop();
            t.Interval = Convert.ToInt32(seconds * 1000);
            
            t.Tick += (s, e) =>
            {
                sblWarning.Visible = false;
                t.Stop();
            };

            t.Start();
        }

        public void SetStyle(int style)
        {
            //1. Single string input
            //2. Dual string input
            //3. Startup Screen
            switch (style)
            {
                case 1:
                    this.Height = 160;
                    lblDirections2.Visible = false;
                    tbxInput2.Visible = false;
                    pbxStartup.Visible = false;
                    break;
                case 2:
                    this.Height = 240;
                    lblDirections2.Visible = true;
                    tbxInput2.Visible = true;
                    pbxStartup.Visible = false;
                    break;
                case 3:
                    this.Height = 420;
                    lblDirections2.Visible = true;
                    tbxInput2.Visible = true;
                    pbxStartup.Visible = true;
                    break;
                default:
                    throw new Exception("Invalid Form Style");
            }
        }
    }
}
