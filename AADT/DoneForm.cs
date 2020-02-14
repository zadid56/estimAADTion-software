using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AADT
{
    public partial class DoneForm : Form
    {
        public DoneForm()
        {
            InitializeComponent();
        }

        public string exitCode
        {
            get;
            set;
        }

        private void okButton_Click(object sender, EventArgs e) => Application.Exit();

        private void outputLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => System.Diagnostics.Process.Start(outputLinkLabel.Text);
    }
}
