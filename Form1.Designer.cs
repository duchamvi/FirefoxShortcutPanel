
namespace FirefoxShortcutPanel
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.customLinkTab = new System.Windows.Forms.TabPage();
            this.goCustomLinkButton = new System.Windows.Forms.Button();
            this.customLinkTextBox = new System.Windows.Forms.TextBox();
            this.shortcutsTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.shortcutButtonModify5 = new System.Windows.Forms.Button();
            this.shortcutButton5 = new System.Windows.Forms.Button();
            this.shortcutButtonModify4 = new System.Windows.Forms.Button();
            this.shortcutButton4 = new System.Windows.Forms.Button();
            this.shortcutButtonModify3 = new System.Windows.Forms.Button();
            this.shortcutButton3 = new System.Windows.Forms.Button();
            this.shortcutButtonModify2 = new System.Windows.Forms.Button();
            this.shortcutButton2 = new System.Windows.Forms.Button();
            this.shortcutButtonModify1 = new System.Windows.Forms.Button();
            this.shortcutButton1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.customLinkTab.SuspendLayout();
            this.shortcutsTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.customLinkTab);
            this.tabControl1.Controls.Add(this.shortcutsTab);
            this.tabControl1.Location = new System.Drawing.Point(6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(756, 264);
            this.tabControl1.TabIndex = 1;
            // 
            // customLinkTab
            // 
            this.customLinkTab.BackColor = System.Drawing.Color.DarkGray;
            this.customLinkTab.Controls.Add(this.goCustomLinkButton);
            this.customLinkTab.Controls.Add(this.customLinkTextBox);
            this.customLinkTab.Location = new System.Drawing.Point(4, 22);
            this.customLinkTab.Name = "customLinkTab";
            this.customLinkTab.Padding = new System.Windows.Forms.Padding(40);
            this.customLinkTab.Size = new System.Drawing.Size(748, 238);
            this.customLinkTab.TabIndex = 4;
            this.customLinkTab.Text = "Custom Link";
            // 
            // goCustomLinkButton
            // 
            this.goCustomLinkButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.goCustomLinkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.goCustomLinkButton.Location = new System.Drawing.Point(40, 83);
            this.goCustomLinkButton.Margin = new System.Windows.Forms.Padding(10);
            this.goCustomLinkButton.Name = "goCustomLinkButton";
            this.goCustomLinkButton.Size = new System.Drawing.Size(668, 115);
            this.goCustomLinkButton.TabIndex = 1;
            this.goCustomLinkButton.Text = "Go !";
            this.goCustomLinkButton.UseVisualStyleBackColor = true;
            this.goCustomLinkButton.Click += new System.EventHandler(this.goCustomLinkButton_Click);
            // 
            // customLinkTextBox
            // 
            this.customLinkTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.customLinkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.customLinkTextBox.Location = new System.Drawing.Point(40, 40);
            this.customLinkTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.customLinkTextBox.Name = "customLinkTextBox";
            this.customLinkTextBox.Size = new System.Drawing.Size(668, 23);
            this.customLinkTextBox.TabIndex = 0;
            this.customLinkTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.customLinkTextBox_KeyDown);
            // 
            // shortcutsTab
            // 
            this.shortcutsTab.BackColor = System.Drawing.Color.DarkGray;
            this.shortcutsTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shortcutsTab.Controls.Add(this.tableLayoutPanel1);
            this.shortcutsTab.Location = new System.Drawing.Point(4, 22);
            this.shortcutsTab.Name = "shortcutsTab";
            this.shortcutsTab.Padding = new System.Windows.Forms.Padding(3);
            this.shortcutsTab.Size = new System.Drawing.Size(748, 238);
            this.shortcutsTab.TabIndex = 3;
            this.shortcutsTab.Text = "Shortcuts";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.shortcutButtonModify5, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.shortcutButton5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.shortcutButtonModify4, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.shortcutButton4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.shortcutButtonModify3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.shortcutButton3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.shortcutButtonModify2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.shortcutButton2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.shortcutButtonModify1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.shortcutButton1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(740, 230);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // shortcutButtonModify5
            // 
            this.shortcutButtonModify5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shortcutButtonModify5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.shortcutButtonModify5.Location = new System.Drawing.Point(599, 187);
            this.shortcutButtonModify5.Name = "shortcutButtonModify5";
            this.shortcutButtonModify5.Size = new System.Drawing.Size(138, 40);
            this.shortcutButtonModify5.TabIndex = 14;
            this.shortcutButtonModify5.Text = "Modify";
            this.shortcutButtonModify5.UseVisualStyleBackColor = true;
            // 
            // shortcutButton5
            // 
            this.shortcutButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shortcutButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.shortcutButton5.Location = new System.Drawing.Point(3, 187);
            this.shortcutButton5.Name = "shortcutButton5";
            this.shortcutButton5.Size = new System.Drawing.Size(570, 40);
            this.shortcutButton5.TabIndex = 12;
            this.shortcutButton5.Text = "???";
            this.shortcutButton5.UseVisualStyleBackColor = true;
            // 
            // shortcutButtonModify4
            // 
            this.shortcutButtonModify4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shortcutButtonModify4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.shortcutButtonModify4.Location = new System.Drawing.Point(599, 141);
            this.shortcutButtonModify4.Name = "shortcutButtonModify4";
            this.shortcutButtonModify4.Size = new System.Drawing.Size(138, 40);
            this.shortcutButtonModify4.TabIndex = 11;
            this.shortcutButtonModify4.Text = "Modify";
            this.shortcutButtonModify4.UseVisualStyleBackColor = true;
            // 
            // shortcutButton4
            // 
            this.shortcutButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shortcutButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.shortcutButton4.Location = new System.Drawing.Point(3, 141);
            this.shortcutButton4.Name = "shortcutButton4";
            this.shortcutButton4.Size = new System.Drawing.Size(570, 40);
            this.shortcutButton4.TabIndex = 9;
            this.shortcutButton4.Text = "???";
            this.shortcutButton4.UseVisualStyleBackColor = true;
            // 
            // shortcutButtonModify3
            // 
            this.shortcutButtonModify3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shortcutButtonModify3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.shortcutButtonModify3.Location = new System.Drawing.Point(599, 95);
            this.shortcutButtonModify3.Name = "shortcutButtonModify3";
            this.shortcutButtonModify3.Size = new System.Drawing.Size(138, 40);
            this.shortcutButtonModify3.TabIndex = 8;
            this.shortcutButtonModify3.Text = "Modify";
            this.shortcutButtonModify3.UseVisualStyleBackColor = true;
            // 
            // shortcutButton3
            // 
            this.shortcutButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shortcutButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.shortcutButton3.Location = new System.Drawing.Point(3, 95);
            this.shortcutButton3.Name = "shortcutButton3";
            this.shortcutButton3.Size = new System.Drawing.Size(570, 40);
            this.shortcutButton3.TabIndex = 6;
            this.shortcutButton3.Text = "???";
            this.shortcutButton3.UseVisualStyleBackColor = true;
            // 
            // shortcutButtonModify2
            // 
            this.shortcutButtonModify2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shortcutButtonModify2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.shortcutButtonModify2.Location = new System.Drawing.Point(599, 49);
            this.shortcutButtonModify2.Name = "shortcutButtonModify2";
            this.shortcutButtonModify2.Size = new System.Drawing.Size(138, 40);
            this.shortcutButtonModify2.TabIndex = 5;
            this.shortcutButtonModify2.Text = "Modify";
            this.shortcutButtonModify2.UseVisualStyleBackColor = true;
            // 
            // shortcutButton2
            // 
            this.shortcutButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shortcutButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.shortcutButton2.Location = new System.Drawing.Point(3, 49);
            this.shortcutButton2.Name = "shortcutButton2";
            this.shortcutButton2.Size = new System.Drawing.Size(570, 40);
            this.shortcutButton2.TabIndex = 3;
            this.shortcutButton2.Text = "???";
            this.shortcutButton2.UseVisualStyleBackColor = true;
            // 
            // shortcutButtonModify1
            // 
            this.shortcutButtonModify1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shortcutButtonModify1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.shortcutButtonModify1.Location = new System.Drawing.Point(599, 3);
            this.shortcutButtonModify1.Name = "shortcutButtonModify1";
            this.shortcutButtonModify1.Size = new System.Drawing.Size(138, 40);
            this.shortcutButtonModify1.TabIndex = 2;
            this.shortcutButtonModify1.Text = "Modify";
            this.shortcutButtonModify1.UseVisualStyleBackColor = true;
            // 
            // shortcutButton1
            // 
            this.shortcutButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shortcutButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.shortcutButton1.Location = new System.Drawing.Point(3, 3);
            this.shortcutButton1.Name = "shortcutButton1";
            this.shortcutButton1.Size = new System.Drawing.Size(570, 40);
            this.shortcutButton1.TabIndex = 0;
            this.shortcutButton1.Text = "???";
            this.shortcutButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(917, 688);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Firefox Command Panel";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.escape_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.customLinkTab.ResumeLayout(false);
            this.customLinkTab.PerformLayout();
            this.shortcutsTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage shortcutsTab;
        private System.Windows.Forms.TabPage customLinkTab;
        private System.Windows.Forms.TextBox customLinkTextBox;
        private System.Windows.Forms.Button goCustomLinkButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button shortcutButton1;
        private System.Windows.Forms.Button shortcutButtonModify5;
        private System.Windows.Forms.Button shortcutButton5;
        private System.Windows.Forms.Button shortcutButtonModify4;
        private System.Windows.Forms.Button shortcutButton4;
        private System.Windows.Forms.Button shortcutButtonModify3;
        private System.Windows.Forms.Button shortcutButton3;
        private System.Windows.Forms.Button shortcutButtonModify2;
        private System.Windows.Forms.Button shortcutButton2;
        private System.Windows.Forms.Button shortcutButtonModify1;
    }
}

