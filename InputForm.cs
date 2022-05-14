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
    public partial class InputForm : Form
    {

        public Shortcut shortcut;
        
        public InputForm(Shortcut shortcutInput)
        {
            InitializeComponent();
            this.shortcut = shortcutInput;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //change the shortcut
        private void validateButton_Click(object sender, EventArgs e)
        {
            this.shortcut.Link = inputTextBox.Text;
            this.shortcut.Title = inputTextBox.Text;
            this.Close();
        }

        private void escape_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void enter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                validateButton.PerformClick();
        }
    }
}
