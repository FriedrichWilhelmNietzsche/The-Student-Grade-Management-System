namespace WIN_成绩管理系统
{
    partial class UserInfo
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
            this.realName = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_Username = new System.Windows.Forms.TextBox();
            this.text_number = new System.Windows.Forms.TextBox();
            this.text_Sex = new System.Windows.Forms.TextBox();
            this.text_tel = new System.Windows.Forms.TextBox();
            this.text_email = new System.Windows.Forms.TextBox();
            this.text_explain = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // realName
            // 
            this.realName.AutoSize = true;
            this.realName.Font = new System.Drawing.Font("华文新魏", 13F);
            this.realName.Location = new System.Drawing.Point(94, 69);
            this.realName.Name = "realName";
            this.realName.Size = new System.Drawing.Size(98, 18);
            this.realName.TabIndex = 0;
            this.realName.Text = "真实姓名：";
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Font = new System.Drawing.Font("华文新魏", 13F);
            this.number.Location = new System.Drawing.Point(94, 112);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(62, 18);
            this.number.TabIndex = 0;
            this.number.Text = "学号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文新魏", 13F);
            this.label1.Location = new System.Drawing.Point(94, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "性别：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文新魏", 13F);
            this.label2.Location = new System.Drawing.Point(94, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "联系电话：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文新魏", 13F);
            this.label3.Location = new System.Drawing.Point(94, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "邮箱地址：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("华文新魏", 13F);
            this.label4.Location = new System.Drawing.Point(94, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "备注：";
            // 
            // text_Username
            // 
            this.text_Username.Location = new System.Drawing.Point(214, 66);
            this.text_Username.Name = "text_Username";
            this.text_Username.Size = new System.Drawing.Size(118, 21);
            this.text_Username.TabIndex = 1;
            // 
            // text_number
            // 
            this.text_number.Location = new System.Drawing.Point(214, 112);
            this.text_number.Name = "text_number";
            this.text_number.Size = new System.Drawing.Size(118, 21);
            this.text_number.TabIndex = 3;
            // 
            // text_Sex
            // 
            this.text_Sex.Location = new System.Drawing.Point(214, 162);
            this.text_Sex.Name = "text_Sex";
            this.text_Sex.Size = new System.Drawing.Size(85, 21);
            this.text_Sex.TabIndex = 3;
            // 
            // text_tel
            // 
            this.text_tel.Location = new System.Drawing.Point(214, 206);
            this.text_tel.Name = "text_tel";
            this.text_tel.Size = new System.Drawing.Size(118, 21);
            this.text_tel.TabIndex = 3;
            // 
            // text_email
            // 
            this.text_email.Location = new System.Drawing.Point(214, 258);
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(160, 21);
            this.text_email.TabIndex = 3;
            // 
            // text_explain
            // 
            this.text_explain.Location = new System.Drawing.Point(214, 302);
            this.text_explain.Multiline = true;
            this.text_explain.Name = "text_explain";
            this.text_explain.Size = new System.Drawing.Size(404, 148);
            this.text_explain.TabIndex = 3;
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.text_explain);
            this.Controls.Add(this.text_email);
            this.Controls.Add(this.text_tel);
            this.Controls.Add(this.text_Sex);
            this.Controls.Add(this.text_number);
            this.Controls.Add(this.text_Username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.number);
            this.Controls.Add(this.realName);
            this.Name = "UserInfo";
            this.Size = new System.Drawing.Size(720, 504);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label realName;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_Username;
        private System.Windows.Forms.TextBox text_number;
        private System.Windows.Forms.TextBox text_Sex;
        private System.Windows.Forms.TextBox text_tel;
        private System.Windows.Forms.TextBox text_email;
        private System.Windows.Forms.TextBox text_explain;
    }
}
