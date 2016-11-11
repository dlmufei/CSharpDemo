namespace sharp_event_delegate
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStartDataProvider = new System.Windows.Forms.Button();
            this.btnDataThread = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.txtDisplay200 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStartDataProvider
            // 
            this.btnStartDataProvider.Location = new System.Drawing.Point(359, 51);
            this.btnStartDataProvider.Name = "btnStartDataProvider";
            this.btnStartDataProvider.Size = new System.Drawing.Size(141, 23);
            this.btnStartDataProvider.TabIndex = 0;
            this.btnStartDataProvider.Text = "开启数据启动-主线程";
            this.btnStartDataProvider.UseVisualStyleBackColor = true;
            this.btnStartDataProvider.Click += new System.EventHandler(this.btnStartDataProvider_Click);
            // 
            // btnDataThread
            // 
            this.btnDataThread.Location = new System.Drawing.Point(359, 127);
            this.btnDataThread.Name = "btnDataThread";
            this.btnDataThread.Size = new System.Drawing.Size(141, 23);
            this.btnDataThread.TabIndex = 1;
            this.btnDataThread.Text = "开启数据启动-子线程";
            this.btnDataThread.UseVisualStyleBackColor = true;
            this.btnDataThread.Click += new System.EventHandler(this.btnDataThread_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(75, 73);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(175, 21);
            this.txtDisplay.TabIndex = 2;
            this.txtDisplay.Text = "100";
            // 
            // txtDisplay200
            // 
            this.txtDisplay200.Location = new System.Drawing.Point(75, 129);
            this.txtDisplay200.Name = "txtDisplay200";
            this.txtDisplay200.Size = new System.Drawing.Size(175, 21);
            this.txtDisplay200.TabIndex = 3;
            this.txtDisplay200.Text = "200";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 379);
            this.Controls.Add(this.txtDisplay200);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnDataThread);
            this.Controls.Add(this.btnStartDataProvider);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartDataProvider;
        private System.Windows.Forms.Button btnDataThread;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.TextBox txtDisplay200;
    }
}

