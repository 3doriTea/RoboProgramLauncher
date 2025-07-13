using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace RoboProgramLauncher
{
	public partial class ErrorBox : Form
	{
		public ErrorBox(bool showingBugReportButton)
		{
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;  // 最大化拒否
			MinimizeBox = false;  // 最小化拒否
			InitializeComponent();
			messageBox.Text = Encoding.GetEncoding("Shift-JIS").GetString(File.ReadAllBytes(Main.ErrorLogFileName));
			if (showingBugReportButton)
			{
				messageBox.Text = "実行中のエラーですが、開発者が把握していないエラー(バグ)です。\r\n"
					+ "このメッセージをすべてコピーし、バグ報告にご協力お願いいたします。\r\n"
					+ messageBox.Text;
				bugReportButton.Visible = true;
				bugReportButton.Focus();
			}
			else
			{
				bugReportButton.Visible = false;
			}
		}

		private void BugReportButton_Click(object sender, System.EventArgs e)
		{
			Process.Start("https://forms.gle/WKzBGh1kFB36Q8dp8");
		}
	}
}
