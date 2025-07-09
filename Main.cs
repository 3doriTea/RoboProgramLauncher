using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using System.IO.Compression;

namespace RoboProgramLauncher
{
	public partial class Main : Form
	{
		const string FileName = "./Debug/ShipEnginner.exe";
		const string CurrentDir = "./Debug/";
		//const string FileName = "D://GE2A40/workspace/Yokosuku/x64/Debug/ShipEnginner.exe";
		//const string FileName = "N:/workhome/ShipEnginner/x64/Debug/ShipEnginner.exe";
		const string ErrorLogFileName = "ErrorLog.txt";
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
				_gameProcess.StartInfo.FileName = Path.GetFullPath(FileName);
				_gameProcess.StartInfo.WorkingDirectory = Path.GetFullPath(CurrentDir);
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
			if (!File.Exists(FileName))
			{
				string zipTmpDest = Path.GetFullPath("./tmp.zip");
				string zipOpenDest = Path.GetFullPath("./");
				using (var clinet = new WebClient())
				{
					clinet.DownloadFile(
						"https://github.com/3doriTea/RoboProgram/raw/master/Public/RoboProgram.zip",
						zipTmpDest);
				}

				ZipFile.ExtractToDirectory(zipTmpDest, zipOpenDest);

				File.Delete(zipTmpDest);

				RefreshButtons();
			}

			bootButton.Enabled = false;
			WindowState = FormWindowState.Minimized;
			BootGame();
			//if (File.Exists(ErrorLogFileName))
			//{
			//    File.Delete(ErrorLogFileName);
			//}
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
			if (File.Exists(FileName))
			{
				bootButton.Image = Properties.Resources.BootButton;
			}
			else
			{
				bootButton.Image = Properties.Resources.DownloadButton;
			}
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
