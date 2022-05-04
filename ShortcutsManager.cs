using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirefoxShortcutPanel
{
    public class Shortcut
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public int Index { get; set; }
    }
    
    class ShortcutsManager
    {

        public int shortcutsAmount = 10;
        public List<Shortcut> elements;


        public ShortcutsManager()
        {
            elements = new List<Shortcut>();
            for (int i = 0; i < shortcutsAmount; i++)
            {
                Shortcut newShortcut = new Shortcut();
                newShortcut.Title = $"Shortcut {i}";
                newShortcut.Link = $"-p {i}";
                newShortcut.Index = i;
                elements.Add(newShortcut);
            }
        }

    }
}
