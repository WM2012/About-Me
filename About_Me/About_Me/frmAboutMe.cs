using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace About_Me
{
    public partial class frmAboutMe : Form
    {
        public frmAboutMe()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            /*Name:William Miller|Date:9/6/2017|Project:About_Me|*/
            string Age;
            string Name;

            Name = txtName.Text;
            Age = txtAge.Text;

            lblResult.Text = Name + " " + "is" + Age + " " + "years old.";
        }

		private void frmAboutMe_Load(object sender, EventArgs e)
		{

		}
	}
}
