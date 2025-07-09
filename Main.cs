using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboProgramLauncher
{
    public partial class Main : Form
    {
        //const string FileName = "./ShipEnginner.exe";
        const string FileName = "D://GE2A40/workspace/Yokosuku/x64/Debug/ShipEnginner.exe";
        private Process _gameProcess = null;  // RoboProgram のゲームプロセス
        private delegate void UpdateButton();
        private delegate void ShowErrorMessage();
        private Size _prevSize;
        private ErrorBox _errorBox = null;

        public Main()
        {
            AutoScaleMode = AutoScaleMode.None;
            InitializeComponent();
        }

        /// <summary>
        /// ゲームを起動する
        /// </summary>
        private void BootGame()
        {
            if (_gameProcess != null)
            {
                _gameProcess.Dispose();
                _gameProcess = null;
            }

            _gameProcess = new Process();
            try
            {
                _gameProcess.StartInfo.FileName = FileName;
                _gameProcess.Exited += new EventHandler(OnGameExited);
                _gameProcess.EnableRaisingEvents = true;

                _gameProcess.Start();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return;
            }
        }

        /// <summary>
        /// 起動ボタンがクリックされたときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BootButton_Click(object sender, EventArgs e)
        {
            bootButton.Enabled = false;
            WindowState = FormWindowState.Minimized;
            BootGame();
        }

        /// <summary>
        /// ゲームが終了したときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void OnGameExited(object sender, EventArgs eventArgs)
        {
            Invoke(new UpdateButton(() =>
            {
                RefreshButtons();
                bootButton.Enabled = true;
                WindowState = FormWindowState.Normal;
                Size = _prevSize;
            }));

            if (_gameProcess.ExitCode == 0)
            {
                Console.WriteLine("Proc Exit OK.");
                //BootGame();
                return;
            }

            Console.WriteLine("Proc Exit NOOOOOOOO.");

            Invoke(new ShowErrorMessage(() =>
            {
                if (_errorBox != null)
                {
                    _errorBox.Close();
                    _errorBox.Dispose();
                }
                _errorBox = new ErrorBox();
                _errorBox.Show(this);
            }));
        }

        private void Main_Load(object sender, EventArgs e)
        {
            _prevSize = Size;
            RefreshButtons();
        }

        private void RefreshButtons()
        {
            docButton.Enabled = Program.ExisFileDoc();
            codeButton.Enabled = Program.ExisFileSrc();
        }

        private void DocButton_Click(object sender, EventArgs e)
        {
            Program.TryOpenDoc();
        }

        private void CodeButton_Click(object sender, EventArgs e)
        {
            Program.TryOpenSrc();
        }
    }
}
