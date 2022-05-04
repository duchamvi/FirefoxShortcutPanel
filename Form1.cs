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

        public Form1()
        {
            InitializeComponent();
            shortcutsManager = new ShortcutsManager();
            updateShortcutButtons();
        }

        private void updateShortcutButtons()
        {
            shortcutButton1.Text = shortcutsManager.getShortcut(0);
            shortcutButton2.Text = shortcutsManager.getShortcut(1);
            shortcutButton3.Text = shortcutsManager.getShortcut(2);
            shortcutButton4.Text = shortcutsManager.getShortcut(3);
            shortcutButton5.Text = shortcutsManager.getShortcut(4);
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

        private void shortcutButton1_Click(object sender, EventArgs e)
        {
            FirefoxCaller.firefoxCall(shortcutsManager.getShortcut(0));
        }

        private void shortcutButton2_Click(object sender, EventArgs e)
        {
            FirefoxCaller.firefoxCall(shortcutsManager.getShortcut(1));
        }

        private void shortcutButton3_Click(object sender, EventArgs e)
        {
            FirefoxCaller.firefoxCall(shortcutsManager.getShortcut(2));
        }

        private void shortcutButton4_Click(object sender, EventArgs e)
        {
            FirefoxCaller.firefoxCall(shortcutsManager.getShortcut(3));
        }

        private void shortcutButton5_Click(object sender, EventArgs e)
        {
            FirefoxCaller.firefoxCall(shortcutsManager.getShortcut(4));
        }
    }

}
