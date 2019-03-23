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

        public void SetDirections(string directions)
        {
            lblDirections.Text = directions;
        }

        public string GetResult()
        {
            return tbxInput.Text;
        }

        private void InputDialog_Load(object sender, EventArgs e)
        {
            //Clear textbox each time
            tbxInput.Clear();
        }

        public void ShowWarning(string warning)
        {
            MessageBox.Show(warning, "Warning");
        }
    }
}
