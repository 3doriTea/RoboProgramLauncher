using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboProgramLauncher
{
    public partial class ErrorBox : Form
    {
        private static string _errorMessage;

        public ErrorBox()
        {
            InitializeComponent();
            messageBox.Text = Encoding.GetEncoding("Shift-JIS").GetString(File.ReadAllBytes(Main.ErrorLogFileName));
        }
    }
}
