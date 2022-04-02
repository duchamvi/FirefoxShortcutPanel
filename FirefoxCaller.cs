using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirefoxShortcutPanel
{
    class FirefoxCaller
    {
        //opens the target in a new firefox tab (options are possible)
        public static void firefoxCall(string target)
        {
            //// Got this here: https://docs.microsoft.com/en-us/troubleshoot/dotnet/csharp/start-internet-browser
            

            try
            {
                System.Diagnostics.Process.Start("firefox.exe", target);
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }

        }
    }
}
