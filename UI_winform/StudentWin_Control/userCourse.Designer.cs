namespace WIN_成绩管理系统
{
    partial class userCourse
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.courseTable = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.courseTable)).BeginInit();
            this.SuspendLayout();
            // 
            // courseTable
            // 
            this.courseTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(216)))), ((int)(((byte)(213)))));
            this.courseTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.courseTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseTable.Location = new System.Drawing.Point(35, 55);
            this.courseTable.Name = "courseTable";
            this.courseTable.RowTemplate.Height = 23;
            this.courseTable.Size = new System.Drawing.Size(651, 417);
            this.courseTable.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("华文新魏", 20F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.label5.Location = new System.Drawing.Point(279, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 27);
            this.label5.TabIndex = 5;
            this.label5.Text = "个 人 信 息";
            // 
            // userCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.courseTable);
            this.Name = "userCourse";
            this.Size = new System.Drawing.Size(720, 504);
            ((System.ComponentModel.ISupportInitialize)(this.courseTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView courseTable;
        private System.Windows.Forms.Label label5;
    }
}
