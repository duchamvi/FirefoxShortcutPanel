using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FirefoxShortcutPanel
{
    public class Shortcut
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public int Index { get; set; }
    }

    // The shortcut manager contains the list of shortcuts and the methods to update them
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
                newShortcut.Link = $"https://www.google.com/search?client=firefox-b-d&q={i}";
                newShortcut.Index = i;
                elements.Add(newShortcut);
            }
        }

        public void WriteJson(string filePath)
        {
            string json = JsonConvert.SerializeObject(elements);

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(json);
            }
        }

        public void ReadJson(string filePath)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string json = sr.ReadToEnd();

                elements = JsonConvert.DeserializeObject<List<Shortcut>>(json);
            }
        }

    }
}
