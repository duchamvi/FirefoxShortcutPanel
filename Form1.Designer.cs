
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
            this.button15 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Controls.Add(this.button15, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.button13, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button12, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button10, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
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
            // button15
            // 
            this.button15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button15.Location = new System.Drawing.Point(599, 187);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(138, 40);
            this.button15.TabIndex = 14;
            this.button15.Text = "Modify";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button13.Location = new System.Drawing.Point(3, 187);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(570, 40);
            this.button13.TabIndex = 12;
            this.button13.Text = "???";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button12.Location = new System.Drawing.Point(599, 141);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(138, 40);
            this.button12.TabIndex = 11;
            this.button12.Text = "Modify";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button10.Location = new System.Drawing.Point(3, 141);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(570, 40);
            this.button10.TabIndex = 9;
            this.button10.Text = "???";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button9.Location = new System.Drawing.Point(599, 95);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(138, 40);
            this.button9.TabIndex = 8;
            this.button9.Text = "Modify";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button7.Location = new System.Drawing.Point(3, 95);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(570, 40);
            this.button7.TabIndex = 6;
            this.button7.Text = "???";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button6.Location = new System.Drawing.Point(599, 49);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(138, 40);
            this.button6.TabIndex = 5;
            this.button6.Text = "Modify";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button4.Location = new System.Drawing.Point(3, 49);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(570, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "???";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.Location = new System.Drawing.Point(599, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "Modify";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(570, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "???";
            this.button1.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}

