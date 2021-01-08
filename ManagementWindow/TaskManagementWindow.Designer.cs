namespace ManagementWindow
{
    partial class TaskManagementWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TaskCreatetBtn = new System.Windows.Forms.Button();
            this.TaskDeleteBtn = new System.Windows.Forms.Button();
            this.APPName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskProgress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.APPName,
            this.deviceName,
            this.DataSource,
            this.CreateTime,
            this.TaskProgress});
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1036, 578);
            this.dataGridView1.TabIndex = 0;
            // 
            // TaskCreatetBtn
            // 
            this.TaskCreatetBtn.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TaskCreatetBtn.Location = new System.Drawing.Point(213, 584);
            this.TaskCreatetBtn.Name = "TaskCreatetBtn";
            this.TaskCreatetBtn.Size = new System.Drawing.Size(94, 28);
            this.TaskCreatetBtn.TabIndex = 1;
            this.TaskCreatetBtn.Text = "创建任务";
            this.TaskCreatetBtn.UseVisualStyleBackColor = true;
            // 
            // TaskDeleteBtn
            // 
            this.TaskDeleteBtn.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TaskDeleteBtn.Location = new System.Drawing.Point(687, 586);
            this.TaskDeleteBtn.Name = "TaskDeleteBtn";
            this.TaskDeleteBtn.Size = new System.Drawing.Size(94, 26);
            this.TaskDeleteBtn.TabIndex = 2;
            this.TaskDeleteBtn.Text = "删除任务";
            this.TaskDeleteBtn.UseVisualStyleBackColor = true;
            // 
            // APPName
            // 
            this.APPName.HeaderText = "APP名称";
            this.APPName.Name = "APPName";
            // 
            // deviceName
            // 
            this.deviceName.HeaderText = "设备名称";
            this.deviceName.Name = "deviceName";
            // 
            // DataSource
            // 
            this.DataSource.HeaderText = "数据源";
            this.DataSource.Name = "DataSource";
            // 
            // CreateTime
            // 
            this.CreateTime.HeaderText = "创建时间";
            this.CreateTime.Name = "CreateTime";
            // 
            // TaskProgress
            // 
            this.TaskProgress.HeaderText = "任务进度";
            this.TaskProgress.Name = "TaskProgress";
            // 
            // TaskManagementWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 624);
            this.Controls.Add(this.TaskDeleteBtn);
            this.Controls.Add(this.TaskCreatetBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TaskManagementWindow";
            this.Text = "任务管理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button TaskCreatetBtn;
        private System.Windows.Forms.Button TaskDeleteBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn APPName;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskProgress;
    }
}

