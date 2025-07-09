using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboProgramLauncher
{
    internal static class Program
    {
        const string NotePadExeName = "notepad.exe";
        const string FileNameSrc = "./Debug/SourceCode.txt";
        const string FileNameDoc = "./Debug/Document.txt";

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }

        /// <summary>
        /// 試しにドキュメントを開く
        /// </summary>
        /// <returns></returns>
        internal static bool TryOpenDoc()
        {
            try
            {
                Process.Start(NotePadExeName, "./Document.txt");
            }
            catch
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 試しにソースコードを開く
        /// </summary>
        /// <returns></returns>
        internal static bool TryOpenSrc()
        {
            try
            {
                Process.Start(NotePadExeName, FileNameSrc);
            }
            catch
            {
                return false;
            }
            return true;
        }

        internal static bool ExisFileSrc()
        {
            return File.Exists(FileNameSrc);
        }
        internal static bool ExisFileDoc()
        {
            return File.Exists(FileNameDoc);
        }
    }
}
