namespace ManagementWindow
{
    partial class TaskSettingWindow
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "米家"}, 0, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134))));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("360摄像头", 1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskSettingWindow));
            this.AppListView = new System.Windows.Forms.ListView();
            this.AppIconList = new System.Windows.Forms.ImageList(this.components);
            this.PathSelectedBtn = new System.Windows.Forms.Button();
            this.PathSelectedLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TaskStartBtn = new System.Windows.Forms.Button();
            this.TaskCanceledBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AppListView
            // 
            this.AppListView.HideSelection = false;
            this.AppListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.AppListView.LargeImageList = this.AppIconList;
            this.AppListView.Location = new System.Drawing.Point(4, 2);
            this.AppListView.Name = "AppListView";
            this.AppListView.Size = new System.Drawing.Size(740, 319);
            this.AppListView.TabIndex = 0;
            this.AppListView.UseCompatibleStateImageBehavior = false;
            // 
            // AppIconList
            // 
            this.AppIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("AppIconList.ImageStream")));
            this.AppIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.AppIconList.Images.SetKeyName(0, "米家.jpg");
            this.AppIconList.Images.SetKeyName(1, "360摄像头.png");
            // 
            // PathSelectedBtn
            // 
            this.PathSelectedBtn.Location = new System.Drawing.Point(669, 332);
            this.PathSelectedBtn.Name = "PathSelectedBtn";
            this.PathSelectedBtn.Size = new System.Drawing.Size(75, 23);
            this.PathSelectedBtn.TabIndex = 1;
            this.PathSelectedBtn.Text = "选择路径";
            this.PathSelectedBtn.UseVisualStyleBackColor = true;
            // 
            // PathSelectedLabel
            // 
            this.PathSelectedLabel.AutoSize = true;
            this.PathSelectedLabel.Location = new System.Drawing.Point(12, 337);
            this.PathSelectedLabel.Name = "PathSelectedLabel";
            this.PathSelectedLabel.Size = new System.Drawing.Size(47, 12);
            this.PathSelectedLabel.TabIndex = 2;
            this.PathSelectedLabel.Text = "APK路径";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 334);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(597, 21);
            this.textBox1.TabIndex = 3;
            // 
            // TaskStartBtn
            // 
            this.TaskStartBtn.Location = new System.Drawing.Point(177, 376);
            this.TaskStartBtn.Name = "TaskStartBtn";
            this.TaskStartBtn.Size = new System.Drawing.Size(75, 23);
            this.TaskStartBtn.TabIndex = 4;
            this.TaskStartBtn.Text = "开始执行";
            this.TaskStartBtn.UseVisualStyleBackColor = true;
            // 
            // TaskCanceledBtn
            // 
            this.TaskCanceledBtn.Location = new System.Drawing.Point(476, 376);
            this.TaskCanceledBtn.Name = "TaskCanceledBtn";
            this.TaskCanceledBtn.Size = new System.Drawing.Size(75, 23);
            this.TaskCanceledBtn.TabIndex = 5;
            this.TaskCanceledBtn.Text = "取消";
            this.TaskCanceledBtn.UseVisualStyleBackColor = true;
            // 
            // TaskSettingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 410);
            this.Controls.Add(this.TaskCanceledBtn);
            this.Controls.Add(this.TaskStartBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PathSelectedLabel);
            this.Controls.Add(this.PathSelectedBtn);
            this.Controls.Add(this.AppListView);
            this.Name = "TaskSettingWindow";
            this.Text = "任务设置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView AppListView;
        private System.Windows.Forms.ImageList AppIconList;
        private System.Windows.Forms.Button PathSelectedBtn;
        private System.Windows.Forms.Label PathSelectedLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button TaskStartBtn;
        private System.Windows.Forms.Button TaskCanceledBtn;
    }
}