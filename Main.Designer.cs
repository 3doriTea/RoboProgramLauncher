namespace RoboProgramLauncher
{
    partial class Main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.resetButton = new System.Windows.Forms.Button();
			this.docButton = new System.Windows.Forms.Button();
			this.codeButton = new System.Windows.Forms.Button();
			this.bootButton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.homeBugReportButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// resetButton
			// 
			this.resetButton.Image = global::RoboProgramLauncher.Properties.Resources.ResetButton;
			this.resetButton.Location = new System.Drawing.Point(1112, 659);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(140, 50);
			this.resetButton.TabIndex = 4;
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
			// 
			// docButton
			// 
			this.docButton.Image = global::RoboProgramLauncher.Properties.Resources.DocButton;
			this.docButton.Location = new System.Drawing.Point(700, 600);
			this.docButton.Margin = new System.Windows.Forms.Padding(2);
			this.docButton.Name = "docButton";
			this.docButton.Size = new System.Drawing.Size(350, 80);
			this.docButton.TabIndex = 3;
			this.docButton.UseVisualStyleBackColor = true;
			this.docButton.Click += new System.EventHandler(this.DocButton_Click);
			// 
			// codeButton
			// 
			this.codeButton.Image = global::RoboProgramLauncher.Properties.Resources.EditButton;
			this.codeButton.Location = new System.Drawing.Point(230, 600);
			this.codeButton.Margin = new System.Windows.Forms.Padding(2);
			this.codeButton.Name = "codeButton";
			this.codeButton.Size = new System.Drawing.Size(350, 80);
			this.codeButton.TabIndex = 2;
			this.codeButton.UseVisualStyleBackColor = true;
			this.codeButton.Click += new System.EventHandler(this.CodeButton_Click);
			// 
			// bootButton
			// 
			this.bootButton.Image = global::RoboProgramLauncher.Properties.Resources.BootButton;
			this.bootButton.Location = new System.Drawing.Point(410, 440);
			this.bootButton.Margin = new System.Windows.Forms.Padding(2);
			this.bootButton.Name = "bootButton";
			this.bootButton.Size = new System.Drawing.Size(460, 110);
			this.bootButton.TabIndex = 0;
			this.bootButton.UseVisualStyleBackColor = true;
			this.bootButton.Click += new System.EventHandler(this.BootButton_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::RoboProgramLauncher.Properties.Resources.Background;
			this.pictureBox1.Location = new System.Drawing.Point(-6, -1);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1280, 720);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// homeBugReportButton
			// 
			this.homeBugReportButton.Image = global::RoboProgramLauncher.Properties.Resources.BugReport;
			this.homeBugReportButton.Location = new System.Drawing.Point(1082, 12);
			this.homeBugReportButton.Name = "homeBugReportButton";
			this.homeBugReportButton.Size = new System.Drawing.Size(170, 40);
			this.homeBugReportButton.TabIndex = 5;
			this.homeBugReportButton.UseVisualStyleBackColor = true;
			this.homeBugReportButton.Click += new System.EventHandler(this.HomeBugReportButton_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 721);
			this.Controls.Add(this.homeBugReportButton);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.docButton);
			this.Controls.Add(this.codeButton);
			this.Controls.Add(this.bootButton);
			this.Controls.Add(this.pictureBox1);
			this.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Main";
			this.Text = "RoboProgram Launcher";
			this.Load += new System.EventHandler(this.Main_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bootButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button codeButton;
        private System.Windows.Forms.Button docButton;
		private System.Windows.Forms.Button resetButton;
		private System.Windows.Forms.Button homeBugReportButton;
	}
}

