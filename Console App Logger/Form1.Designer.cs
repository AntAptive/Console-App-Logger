namespace Console_App_Logger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label1 = new Label();
            commandLineTxtBox = new TextBox();
            saveLogToFileBtn = new Button();
            copyLogToClipboardBtn = new Button();
            minimizeToTrayLabel = new Label();
            minimizeToTrayCheckBox = new CheckBox();
            timestampCheckBox = new CheckBox();
            startProcessBtn = new Button();
            stopProcessBtn = new Button();
            dumpLogCheckBox = new CheckBox();
            openFileButton = new Button();
            botFileTextBox = new TextBox();
            botFileLabel = new Label();
            outputLabel = new Label();
            botOutputTextBox = new RichTextBox();
            deleteProcessBtn = new Button();
            botNameTextBox = new TextBox();
            botNameLabel = new Label();
            newTab = new TabPage();
            deleteProcessBtn1 = new Button();
            durkaDork = new Label();
            toolTip = new ToolTip(components);
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showToolStripMenuItem = new ToolStripMenuItem();
            processesToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            notifyIcon1 = new NotifyIcon(components);
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            test2ToolStripMenuItem = new ToolStripMenuItem();
            aboutConsoleAppLoggerToolStripMenuItem = new ToolStripMenuItem();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            newTab.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(newTab);
            tabControl1.Location = new Point(12, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 442);
            tabControl1.TabIndex = 0;
            tabControl1.Selecting += tabControl1_Selecting;
            tabControl1.MouseDown += tabControl1_MouseDown;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(commandLineTxtBox);
            tabPage1.Controls.Add(saveLogToFileBtn);
            tabPage1.Controls.Add(copyLogToClipboardBtn);
            tabPage1.Controls.Add(minimizeToTrayLabel);
            tabPage1.Controls.Add(minimizeToTrayCheckBox);
            tabPage1.Controls.Add(timestampCheckBox);
            tabPage1.Controls.Add(startProcessBtn);
            tabPage1.Controls.Add(stopProcessBtn);
            tabPage1.Controls.Add(dumpLogCheckBox);
            tabPage1.Controls.Add(openFileButton);
            tabPage1.Controls.Add(botFileTextBox);
            tabPage1.Controls.Add(botFileLabel);
            tabPage1.Controls.Add(outputLabel);
            tabPage1.Controls.Add(botOutputTextBox);
            tabPage1.Controls.Add(deleteProcessBtn);
            tabPage1.Controls.Add(botNameTextBox);
            tabPage1.Controls.Add(botNameLabel);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 414);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "New Process";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(19, 329);
            label1.Name = "label1";
            label1.Size = new Size(196, 15);
            label1.TabIndex = 20;
            label1.Text = "Command line (Press Enter to send)";
            // 
            // commandLineTxtBox
            // 
            commandLineTxtBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            commandLineTxtBox.BackColor = SystemColors.InfoText;
            commandLineTxtBox.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            commandLineTxtBox.ForeColor = SystemColors.Menu;
            commandLineTxtBox.Location = new Point(19, 347);
            commandLineTxtBox.Name = "commandLineTxtBox";
            commandLineTxtBox.Size = new Size(731, 22);
            commandLineTxtBox.TabIndex = 19;
            commandLineTxtBox.KeyDown += commandLineTxtBox_KeyDown;
            // 
            // saveLogToFileBtn
            // 
            saveLogToFileBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            saveLogToFileBtn.Location = new Point(345, 376);
            saveLogToFileBtn.Name = "saveLogToFileBtn";
            saveLogToFileBtn.Size = new Size(125, 23);
            saveLogToFileBtn.TabIndex = 17;
            saveLogToFileBtn.Text = "Save log to file";
            saveLogToFileBtn.UseVisualStyleBackColor = true;
            saveLogToFileBtn.Click += saveLogToFileBtn_Click;
            // 
            // copyLogToClipboardBtn
            // 
            copyLogToClipboardBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            copyLogToClipboardBtn.Location = new Point(131, 376);
            copyLogToClipboardBtn.Name = "copyLogToClipboardBtn";
            copyLogToClipboardBtn.Size = new Size(208, 23);
            copyLogToClipboardBtn.TabIndex = 16;
            copyLogToClipboardBtn.Text = "Copy current log to clipboard";
            copyLogToClipboardBtn.UseVisualStyleBackColor = true;
            copyLogToClipboardBtn.Click += copyLogToClipboardBtn_Click;
            // 
            // minimizeToTrayLabel
            // 
            minimizeToTrayLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimizeToTrayLabel.AutoSize = true;
            minimizeToTrayLabel.Location = new Point(420, 72);
            minimizeToTrayLabel.Name = "minimizeToTrayLabel";
            minimizeToTrayLabel.Size = new Size(209, 15);
            minimizeToTrayLabel.TabIndex = 15;
            minimizeToTrayLabel.Text = "Close this window to minimize to tray.";
            minimizeToTrayLabel.Visible = false;
            // 
            // minimizeToTrayCheckBox
            // 
            minimizeToTrayCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimizeToTrayCheckBox.AutoSize = true;
            minimizeToTrayCheckBox.Location = new Point(638, 63);
            minimizeToTrayCheckBox.Name = "minimizeToTrayCheckBox";
            minimizeToTrayCheckBox.Size = new Size(112, 19);
            minimizeToTrayCheckBox.TabIndex = 14;
            minimizeToTrayCheckBox.Text = "Minimize to tray";
            minimizeToTrayCheckBox.UseVisualStyleBackColor = true;
            minimizeToTrayCheckBox.CheckedChanged += minimizeToTrayCheckBox_CheckedChanged;
            // 
            // timestampCheckBox
            // 
            timestampCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            timestampCheckBox.AutoSize = true;
            timestampCheckBox.Location = new Point(587, 38);
            timestampCheckBox.Name = "timestampCheckBox";
            timestampCheckBox.Size = new Size(163, 19);
            timestampCheckBox.TabIndex = 13;
            timestampCheckBox.Text = "Include timestamps in log";
            timestampCheckBox.UseVisualStyleBackColor = true;
            timestampCheckBox.CheckedChanged += timestampCheckBox_CheckedChanged;
            // 
            // startProcessBtn
            // 
            startProcessBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            startProcessBtn.Location = new Point(19, 376);
            startProcessBtn.Name = "startProcessBtn";
            startProcessBtn.Size = new Size(106, 23);
            startProcessBtn.TabIndex = 12;
            startProcessBtn.Text = "Start Process";
            startProcessBtn.UseVisualStyleBackColor = true;
            startProcessBtn.Click += startBotButton_Click;
            // 
            // stopProcessBtn
            // 
            stopProcessBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            stopProcessBtn.Enabled = false;
            stopProcessBtn.Location = new Point(532, 376);
            stopProcessBtn.Name = "stopProcessBtn";
            stopProcessBtn.Size = new Size(106, 23);
            stopProcessBtn.TabIndex = 11;
            stopProcessBtn.Text = "Stop Process";
            stopProcessBtn.UseVisualStyleBackColor = true;
            stopProcessBtn.MouseClick += stopProcessBtn_MouseClick;
            // 
            // dumpLogCheckBox
            // 
            dumpLogCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dumpLogCheckBox.AutoSize = true;
            dumpLogCheckBox.Checked = true;
            dumpLogCheckBox.CheckState = CheckState.Checked;
            dumpLogCheckBox.Location = new Point(638, 13);
            dumpLogCheckBox.Name = "dumpLogCheckBox";
            dumpLogCheckBox.Size = new Size(112, 19);
            dumpLogCheckBox.TabIndex = 10;
            dumpLogCheckBox.Text = "Dump log to file";
            dumpLogCheckBox.UseVisualStyleBackColor = true;
            dumpLogCheckBox.CheckedChanged += dumpLogCheckBox_CheckedChanged;
            // 
            // openFileButton
            // 
            openFileButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            openFileButton.Location = new Point(480, 43);
            openFileButton.Name = "openFileButton";
            openFileButton.Size = new Size(78, 23);
            openFileButton.TabIndex = 7;
            openFileButton.Text = "Open File...";
            openFileButton.UseVisualStyleBackColor = true;
            openFileButton.Click += openFile_Click;
            // 
            // botFileTextBox
            // 
            botFileTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            botFileTextBox.Enabled = false;
            botFileTextBox.Location = new Point(88, 43);
            botFileTextBox.Name = "botFileTextBox";
            botFileTextBox.PlaceholderText = "Process File Not Loaded!";
            botFileTextBox.ReadOnly = true;
            botFileTextBox.Size = new Size(382, 23);
            botFileTextBox.TabIndex = 6;
            // 
            // botFileLabel
            // 
            botFileLabel.AutoSize = true;
            botFileLabel.Cursor = Cursors.Help;
            botFileLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            botFileLabel.Location = new Point(11, 46);
            botFileLabel.Name = "botFileLabel";
            botFileLabel.Size = new Size(71, 15);
            botFileLabel.TabIndex = 5;
            botFileLabel.Text = "Process File:";
            toolTip.SetToolTip(botFileLabel, "This will only change the tab name!");
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.Location = new Point(19, 78);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(65, 15);
            outputLabel.TabIndex = 4;
            outputLabel.Text = "Output log";
            // 
            // botOutputTextBox
            // 
            botOutputTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            botOutputTextBox.BackColor = SystemColors.InfoText;
            botOutputTextBox.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            botOutputTextBox.ForeColor = SystemColors.Menu;
            botOutputTextBox.Location = new Point(19, 96);
            botOutputTextBox.Name = "botOutputTextBox";
            botOutputTextBox.ReadOnly = true;
            botOutputTextBox.Size = new Size(731, 230);
            botOutputTextBox.TabIndex = 3;
            botOutputTextBox.Text = "Process not running!";
            botOutputTextBox.TextChanged += botOutputTextBox_TextChanged;
            // 
            // deleteProcessBtn
            // 
            deleteProcessBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            deleteProcessBtn.Enabled = false;
            deleteProcessBtn.Location = new Point(644, 376);
            deleteProcessBtn.Name = "deleteProcessBtn";
            deleteProcessBtn.Size = new Size(106, 23);
            deleteProcessBtn.TabIndex = 2;
            deleteProcessBtn.Text = "Delete Process";
            deleteProcessBtn.UseVisualStyleBackColor = true;
            // 
            // botNameTextBox
            // 
            botNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            botNameTextBox.Location = new Point(88, 14);
            botNameTextBox.Name = "botNameTextBox";
            botNameTextBox.PlaceholderText = "New Process";
            botNameTextBox.Size = new Size(382, 23);
            botNameTextBox.TabIndex = 1;
            botNameTextBox.TextChanged += botNameTextBox_TextChanged;
            // 
            // botNameLabel
            // 
            botNameLabel.AutoSize = true;
            botNameLabel.Cursor = Cursors.Help;
            botNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            botNameLabel.Location = new Point(19, 17);
            botNameLabel.Name = "botNameLabel";
            botNameLabel.Size = new Size(63, 15);
            botNameLabel.TabIndex = 0;
            botNameLabel.Text = "Tab Name:";
            toolTip.SetToolTip(botNameLabel, "This will only change the tab name!");
            // 
            // newTab
            // 
            newTab.Controls.Add(deleteProcessBtn1);
            newTab.Controls.Add(durkaDork);
            newTab.Location = new Point(4, 24);
            newTab.Name = "newTab";
            newTab.Padding = new Padding(3);
            newTab.Size = new Size(768, 414);
            newTab.TabIndex = 1;
            newTab.Text = "+";
            newTab.UseVisualStyleBackColor = true;
            // 
            // deleteProcessBtn1
            // 
            deleteProcessBtn1.Location = new Point(19, 48);
            deleteProcessBtn1.Name = "deleteProcessBtn1";
            deleteProcessBtn1.Size = new Size(106, 23);
            deleteProcessBtn1.TabIndex = 1;
            deleteProcessBtn1.Text = "Delete Process";
            deleteProcessBtn1.UseVisualStyleBackColor = true;
            deleteProcessBtn1.Click += deleteProcessBtn1_Click;
            // 
            // durkaDork
            // 
            durkaDork.AutoSize = true;
            durkaDork.Location = new Point(19, 17);
            durkaDork.Margin = new Padding(3);
            durkaDork.Name = "durkaDork";
            durkaDork.Size = new Size(214, 15);
            durkaDork.TabIndex = 0;
            durkaDork.Text = "Multiple process support coming soon!";
            // 
            // toolTip
            // 
            toolTip.AutomaticDelay = 0;
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 0;
            toolTip.ReshowDelay = 0;
            toolTip.UseFading = false;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showToolStripMenuItem, processesToolStripMenuItem, exitToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(134, 70);
            // 
            // showToolStripMenuItem
            // 
            showToolStripMenuItem.Name = "showToolStripMenuItem";
            showToolStripMenuItem.Size = new Size(133, 22);
            showToolStripMenuItem.Text = "Show";
            showToolStripMenuItem.Click += showToolStripMenuItem_Click;
            // 
            // processesToolStripMenuItem
            // 
            processesToolStripMenuItem.Enabled = false;
            processesToolStripMenuItem.Name = "processesToolStripMenuItem";
            processesToolStripMenuItem.Size = new Size(133, 22);
            processesToolStripMenuItem.Text = "Kill Process";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(133, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipText = "BALLOONTIPTEXT";
            notifyIcon1.BalloonTipTitle = "BALLOONTIPTITLE";
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "Console App Logger";
            notifyIcon1.Visible = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, test2ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem1 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(37, 20);
            toolStripMenuItem1.Text = "File";
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(93, 22);
            exitToolStripMenuItem1.Text = "Exit";
            exitToolStripMenuItem1.Click += exitToolStripMenuItem_Click;
            // 
            // test2ToolStripMenuItem
            // 
            test2ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutConsoleAppLoggerToolStripMenuItem });
            test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
            test2ToolStripMenuItem.Size = new Size(52, 20);
            test2ToolStripMenuItem.Text = "About";
            // 
            // aboutConsoleAppLoggerToolStripMenuItem
            // 
            aboutConsoleAppLoggerToolStripMenuItem.Name = "aboutConsoleAppLoggerToolStripMenuItem";
            aboutConsoleAppLoggerToolStripMenuItem.Size = new Size(218, 22);
            aboutConsoleAppLoggerToolStripMenuItem.Text = "About Console App Logger";
            aboutConsoleAppLoggerToolStripMenuItem.Click += aboutConsoleAppLoggerToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 481);
            Controls.Add(menuStrip1);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(760, 400);
            Name = "Form1";
            Text = "Console App Logger";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            newTab.ResumeLayout(false);
            newTab.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage newTab;
        private Label botNameLabel;
        private ToolTip toolTip;
        private TextBox botNameTextBox;
        private Button openFileButton;
        private TextBox botFileTextBox;
        private Label botFileLabel;
        private Label outputLabel;
        private RichTextBox botOutputTextBox;
        private Button deleteProcessBtn;
        private OpenFileDialog openFileDialog;
        private CheckBox dumpLogCheckBox;
        private Button startProcessBtn;
        private Button stopProcessBtn;
        private SaveFileDialog saveFileDialog;
        private CheckBox timestampCheckBox;
        private Label durkaDork;
        private Button deleteProcessBtn1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showToolStripMenuItem;
        private ToolStripMenuItem processesToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private NotifyIcon notifyIcon1;
        private CheckBox minimizeToTrayCheckBox;
        private Label minimizeToTrayLabel;
        private Button copyLogToClipboardBtn;
        private Button saveLogToFileBtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem test2ToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private ToolStripMenuItem aboutConsoleAppLoggerToolStripMenuItem;
        private TextBox commandLineTxtBox;
        private Label label1;
    }
}