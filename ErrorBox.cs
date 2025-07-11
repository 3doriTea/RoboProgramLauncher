using System.IO;
using System.Text;
using System.Windows.Forms;

namespace RoboProgramLauncher
{
    public partial class ErrorBox : Form
    {
        public ErrorBox()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;  // 最大化拒否
            MinimizeBox = false;  // 最小化拒否
            InitializeComponent();
            messageBox.Text = Encoding.GetEncoding("Shift-JIS").GetString(File.ReadAllBytes(Main.ErrorLogFileName));
        }
    }
}
