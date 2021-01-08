using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementWindow
{
    public partial class TaskSettingWindow : Form
    {
        public TaskSettingWindow()
        {
            InitializeComponent();
        }

        private void PathSelectedBtn_Click(object sender, EventArgs e)
        {
            this.APKPathDialog.ShowDialog();
            this.APKPathDialog.Dispose();
            this.APKPathText.Text = this.APKPathDialog.FileName;
            
        }

        private void TaskStartBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void TaskCanceledBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TaskSettingWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
