using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson03
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
      
            if (File.Exists("MySql.Data.Dll"))

            {
                Application.Run(new FRM_Tantosha());
            }
            else
            {
                MessageBox.Show("MySql.Data.Dll does not exist.");
            }
        }
    }
}
