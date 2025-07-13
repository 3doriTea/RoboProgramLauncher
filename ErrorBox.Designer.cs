namespace RoboProgramLauncher
{
    partial class ErrorBox
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorBox));
			this.messageBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.bugReportButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// messageBox
			// 
			this.messageBox.BackColor = System.Drawing.SystemColors.Info;
			this.messageBox.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.messageBox.Location = new System.Drawing.Point(12, 56);
			this.messageBox.Multiline = true;
			this.messageBox.Name = "messageBox";
			this.messageBox.ReadOnly = true;
			this.messageBox.Size = new System.Drawing.Size(576, 292);
			this.messageBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Cascadia Code", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(349, 44);
			this.label1.TabIndex = 1;
			this.label1.Text = "以下のエラーを修正してください。\r\n編集後は起動して確かめてください。\r\n";
			// 
			// bugReportButton
			// 
			this.bugReportButton.Image = global::RoboProgramLauncher.Properties.Resources.BugReport;
			this.bugReportButton.Location = new System.Drawing.Point(418, 9);
			this.bugReportButton.Name = "bugReportButton";
			this.bugReportButton.Size = new System.Drawing.Size(170, 40);
			this.bugReportButton.TabIndex = 2;
			this.bugReportButton.UseVisualStyleBackColor = true;
			this.bugReportButton.Click += new System.EventHandler(this.BugReportButton_Click);
			// 
			// ErrorBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(600, 360);
			this.Controls.Add(this.bugReportButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.messageBox);
			this.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "ErrorBox";
			this.Text = "コードエラー";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.TextBox messageBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button bugReportButton;
	}
}