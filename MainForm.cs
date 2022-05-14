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
        List<Button> modifyButtonsList;

        public MainForm()
        {
            //initialize with designer.cs
            InitializeComponent();

            //initialize shortcuts 
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

            //initialize shortcut modifier buttons
            modifyButtonsList = new List<Button>();
            modifyButtonsList.Add(shortcutButtonModify1);
            modifyButtonsList.Add(shortcutButtonModify2);
            modifyButtonsList.Add(shortcutButtonModify3);
            modifyButtonsList.Add(shortcutButtonModify4);
            modifyButtonsList.Add(shortcutButtonModify5);
            for (int i = 0; i < modifyButtonsList.Count; i++)
            {
                modifyButtonsList[i].Tag = i; // This tag helps identifying the buttons, I use it as int
                modifyButtonsList[i].Click += new System.EventHandler(modifyButton_Click);
            }
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
            int clickedIndex = (int)clickedButton.Tag; //the correct button is identified with the tag   
            FirefoxCaller.firefoxCall(shortcutsManager.elements[clickedIndex].Link);        
        }

        //display the Input Form
        private void modifyButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int clickedIndex = (int)clickedButton.Tag; //the correct button is identified with the tag
            using (InputForm f = new InputForm(shortcutsManager.elements[clickedIndex]))
            {
                f.Text = $"Modify shortcut {clickedIndex}";
                f.ShowDialog();
            }
            updateShortcutButtons();    
        }

    }

}
