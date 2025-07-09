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
            this.docButton = new System.Windows.Forms.Button();
            this.codeButton = new System.Windows.Forms.Button();
            this.bootButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // docButton
            // 
            this.docButton.Image = global::RoboProgramLauncher.Properties.Resources.DocButton;
            this.docButton.Location = new System.Drawing.Point(674, 542);
            this.docButton.Name = "docButton";
            this.docButton.Size = new System.Drawing.Size(350, 80);
            this.docButton.TabIndex = 3;
            this.docButton.UseVisualStyleBackColor = true;
            this.docButton.Click += new System.EventHandler(this.DocButton_Click);
            // 
            // codeButton
            // 
            this.codeButton.Image = global::RoboProgramLauncher.Properties.Resources.EditButton;
            this.codeButton.Location = new System.Drawing.Point(204, 542);
            this.codeButton.Name = "codeButton";
            this.codeButton.Size = new System.Drawing.Size(350, 80);
            this.codeButton.TabIndex = 2;
            this.codeButton.UseVisualStyleBackColor = true;
            this.codeButton.Click += new System.EventHandler(this.CodeButton_Click);
            // 
            // bootButton
            // 
            this.bootButton.Image = global::RoboProgramLauncher.Properties.Resources.BootButton;
            this.bootButton.Location = new System.Drawing.Point(384, 382);
            this.bootButton.Name = "bootButton";
            this.bootButton.Size = new System.Drawing.Size(460, 110);
            this.bootButton.TabIndex = 0;
            this.bootButton.UseVisualStyleBackColor = true;
            this.bootButton.Click += new System.EventHandler(this.BootButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RoboProgramLauncher.Properties.Resources.Background;
            this.pictureBox1.Location = new System.Drawing.Point(-10, -37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1280, 780);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.docButton);
            this.Controls.Add(this.codeButton);
            this.Controls.Add(this.bootButton);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
    }
}

