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
    public partial class MainForm : Form
    {

        ShortcutsManager shortcutsManager;
        List<Button> shortcutButtonsList;

        public MainForm()
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
            for (int i = 0; i < shortcutButtonsList.Count; i++)
            {
                shortcutButtonsList[i].Tag = i; // This tag helps identifying the buttons, I use it as int
                shortcutButtonsList[i].Click += new System.EventHandler(shortcutButton_Click); 
            }
            updateShortcutButtons();
        }

        //updates the visual aspect of the shortcutButtons
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

        //go to the shortcut link
        private void shortcutButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            FirefoxCaller.firefoxCall(shortcutsManager.elements[(int) clickedButton.Tag].Link);   //the correct shortcut is identified with the tag        
        }
        
    }

}
