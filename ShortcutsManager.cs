using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirefoxShortcutPanel
{
    class ShortcutsManager
    {

        int shortcutsAmount = 10;
        List<string> shortcutList;


        public ShortcutsManager()
        {
            shortcutList = new List<string>();
            for (int i = 0; i < shortcutsAmount; i++)
            {
                shortcutList.Add($"-p {i}");
            }
        }

        public string getShortcut(int index)
        {
            return shortcutList[index];
        }
    }
}
