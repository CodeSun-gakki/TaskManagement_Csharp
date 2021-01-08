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
    public partial class TaskManagementWindow : Form
    {
        public TaskManagementWindow()
        {
            InitializeComponent(); 
        }

        private void TaskCreatetBtn_Click(object sender, EventArgs e)
        {
            TaskSettingWindow taskSettingWindow = new TaskSettingWindow();
            taskSettingWindow.Show();
        }

        private void TaskManagementWindow_Load(object sender, EventArgs e)
        {
            this.TaskInfoGrid.ClearSelection();
        }
    }
}
