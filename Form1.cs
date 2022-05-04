using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirefoxShortcutPanel
{
    public partial class Form1 : Form
    {

        ShortcutsManager shortcutsManager;
        List<Button> shortcutButtonsList;

        public Form1()
        {
            //initialize with designer.cs
            InitializeComponent();

            // initialize shortcuts 
            shortcutsManager = new ShortcutsManager();
            shortcutButtonsList = new List<Button>();
            shortcutButtonsList.Add(shortcutButton1);
            shortcutButtonsList.Add(shortcutButton2);
            shortcutButtonsList.Add(shortcutButton3);
            shortcutButtonsList.Add(shortcutButton4);
            shortcutButtonsList.Add(shortcutButton5);
            foreach (var button in shortcutButtonsList)
            {
                button.Click += new System.EventHandler(shortcutButton_Click);
            }
            updateShortcutButtons();
        }

        private void updateShortcutButtons()
        {
            for (int i = 0; i < shortcutButtonsList.Count; i++)
            {
                shortcutButtonsList[i].Text = shortcutsManager.elements[i].Title;
            }
        }

        //go to the custom link
        private void goCustomLinkButton_Click(object sender, EventArgs e)
        {
            FirefoxCaller.firefoxCall(customLinkTextBox.Text);
        }

        private void customLinkTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                goCustomLinkButton.PerformClick();
        }

        private void escape_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void shortcutButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < shortcutButtonsList.Count; i++)
            {
                if (sender == shortcutButtonsList[i])
                {
                    FirefoxCaller.firefoxCall(shortcutsManager.elements[i].Link);
                }
            }
        }
        
    }

}
