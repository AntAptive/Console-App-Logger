using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection.PortableExecutable;
using System.Windows.Forms;
using System.Media;
using System.Threading;
using System.Security.Cryptography;
using Microsoft.Toolkit.Uwp.Notifications;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic;

namespace Console_App_Logger
{
    public partial class Form1 : Form
    {
        //----------------------------------------------------------------
        //           This entire script needs to be optimized.
        //----------------------------------------------------------------

        private string BotFilePath;
        private bool includeTimestampsInLog;

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        private const int TCM_SETMINTABWIDTH = 0x1300 + 49;


        public Form1()
        {
            InitializeComponent();
            Start();
        }


        private void Start()
        {
            SendMessage(this.tabControl1.Handle, TCM_SETMINTABWIDTH, IntPtr.Zero, (IntPtr)16);
            //Shorten the width of the "+" tab
        }

        private TabPage MakeNewTab(string name) //Runs every time the user clicks the "+" tab.
        {
            TabPage newTab = new TabPage(name);

            newTab.BackColor = Color.White;

            //For every control type in the new tab, check what it is, and copy its properties
            foreach (Control control in tabControl1.TabPages[name = "newTab"].Controls)
            {
                Control ctrl2 = new Control();

                if (control.GetType() == typeof(Label))
                {
                    ctrl2 = new Label();
                }
                else if (control.GetType() == typeof(Button))
                {
                    ctrl2 = new Button();
                    ctrl2.Click += deleteProcessBtn1_Click;
                    ctrl2.BackColor = control.BackColor;
                    ctrl2.ForeColor = control.ForeColor;
                }
                ctrl2.Text = control.Text;
                ctrl2.Size = control.Size;
                ctrl2.Location = control.Location;
                ctrl2.Anchor = control.Anchor;

                newTab.Controls.Add(ctrl2);
            }

            //Return the new tab
            return newTab;
        }

        private string GetTimestamp(DateTime value)
        {
            //Checks if the user has included timestamps. If so, return the timestamp string.
            //If not, return blank.
            if (includeTimestampsInLog) return $"[{value.ToString("MM/dd/yyyy HH:mm:ss")}] ";
            else return "";

        }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e) //If the user selects the last tab which will always be the "+" tab, open a new tab
        {
            var lastIndex = this.tabControl1.TabCount - 1;
            if (this.tabControl1.GetTabRect(lastIndex).Contains(e.Location))
            {
                if (this.tabControl1.TabCount == 10)
                {
                    MessageBox.Show("It is not recommended to run more than 10 processes simultaneously unless you know what you're doing. Please proceed with caution.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.tabControl1.TabPages.Insert(lastIndex, MakeNewTab("New Process"));
                this.tabControl1.SelectedIndex = lastIndex;
            }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e) //Not sure what this does. Maybe prevents a bug?
        {
            if (e.TabPageIndex == this.tabControl1.TabCount - 1)
            {
                e.Cancel = true;
            }

        }

        private void OpenOFD()
        {
            OpenFileDialog ofd = openFileDialog;


            ofd.Title = "Select File";
            ofd.RestoreDirectory = true;
            ofd.Filter = "Console App File (*.exe)|*.exe";
            ofd.FilterIndex = 1;

            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                botFileTextBox.Text = ofd.FileName;
            }
            else if (result == DialogResult.Cancel)
            {
                botFileTextBox.Text = "Process File Not Loaded!";
                BotFilePath = null;
                return;
            }
            else
            {
                botFileTextBox.Text = "Process File Not Loaded!";
                BotFilePath = null;
                return;
            }

            //If is an .exe file, check if is
            if (ofd.FileName.EndsWith(".exe"))
            {
                bool isConsoleApp = GetExeType(ofd.FileName, out bool isDll) == Subsystem.WindowsCui;

                if (!isConsoleApp)
                {
                    Console.WriteLine("The selected executable is a console application.");
                    ofd.FileName = null;
                    botFileTextBox.Text = "Process File Not Loaded!";
                    BotFilePath = null;
                    MessageBox.Show("Selected application is not a compatible console app", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    BotFilePath = ofd.FileName;
                }
            }

        }

        private void openFile_Click(object sender, EventArgs e)
        {
            OpenOFD();
        }

        public Subsystem GetExeType(string imagePath, out bool isDll)
        {
            using var stream = File.Open(imagePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            using var reader = new PEReader(stream);
            isDll = reader.PEHeaders.IsDll;
            return reader?.PEHeaders?.PEHeader != null ? reader.PEHeaders.PEHeader.Subsystem : Subsystem.Unknown;
        }

        public bool dumpLogDontAskAgain = false;
        private void dumpLogCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (dumpLogCheckBox.Checked == true && !dumpLogDontAskAgain)
            {
                DumpLogPopup dlp = new DumpLogPopup();
                dlp.ShowPopup();
            }
        }

        private void botNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(botNameTextBox.Text))
            {
                tabControl1.SelectedTab.Text = "New Process";
            }
            else
            {
                tabControl1.SelectedTab.Text = botNameTextBox.Text;
            }
        }


        Process bot;

        bool dontShowDumpWarningAgain = false;

        private async void startBotButton_Click(object sender, EventArgs e)
        {
            startProcessBtn.Enabled = false;

            bot = new Process();
            bot.StartInfo.UseShellExecute = false;
            bot.StartInfo.RedirectStandardOutput = true;
            bot.StartInfo.RedirectStandardInput = true;
            bot.StartInfo.CreateNoWindow = true;
            if (BotFilePath != null)
            {
                if (!dumpLogCheckBox.Checked && !dontShowDumpWarningAgain)
                {
                    DialogResult dialog = MessageBox.Show("You currently have \"Dump log to file\" disabled. Would you like to enable it?", "", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        dumpLogCheckBox.Checked = true;
                    }
                    else if (dialog == DialogResult.No)
                    {
                        DialogResult dialog2 = MessageBox.Show("Show this message again next time if \"Dump log to file\" is disabled?", "", MessageBoxButtons.YesNo);
                        if (dialog2 == DialogResult.No)
                        {
                            dontShowDumpWarningAgain = true;
                        }
                    }
                }

                //Disable the checkboxes
                dumpLogCheckBox.Enabled = false;
                timestampCheckBox.Enabled = false;

                bot.StartInfo.FileName = BotFilePath;
                bot.Start();
                bot.Exited += Bot_Exited;
                botOutputTextBox.Text = $"{GetTimestamp(DateTime.Now)}Starting process: {tabControl1.SelectedTab.Text}\n{GetTimestamp(DateTime.Now)}({BotFilePath})\n";
                new Thread(async () =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    await ReadBotLine(bot);
                }).Start();
                stopProcessBtn.Enabled = true;
                await bot.WaitForExitAsync();
            }
            else
            {
                botOutputTextBox.Text += $"\n{GetTimestamp(DateTime.Now)}Process failed to start: Process file not found!";
                MessageBox.Show("Please select a process to run!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OpenOFD();
                startProcessBtn.Enabled = true;
                botOutputTextBox.Text = "Process not running!";
            }


        }

        private async Task<bool> ReadBotLine(Process bot)
        {
            try
            {
                while (!bot.StandardOutput.EndOfStream)
                {
                    string line = bot.StandardOutput.ReadLine();

                    if (botOutputTextBox.InvokeRequired)
                    {
                        botOutputTextBox.Invoke(new MethodInvoker(delegate { botOutputTextBox.Text += $"\n{GetTimestamp(DateTime.Now)}{line}"; }));
                    }
                    else
                    {
                        botOutputTextBox.Text += $"\n{GetTimestamp(DateTime.Now)}{line}";
                    }
                    Debug.WriteLine($"{GetTimestamp(DateTime.Now)}{line}");
                }
            }
            catch
            {
                return true;
            }
            return true;
        }

        private void Bot_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            botOutputTextBox.Text += "\n" + e.ToString();
            Debug.WriteLine(e.ToString());
        }

        private void ExitBot()
        {
            if (botOutputTextBox.InvokeRequired)
            {
                botOutputTextBox.Invoke(new MethodInvoker(delegate { botOutputTextBox.Text += $"\n{GetTimestamp(DateTime.Now)}Process stopped!"; }));
            }
            else
            {
                botOutputTextBox.Text += $"\n{GetTimestamp(DateTime.Now)}Process stopped!";
            }

            if (dumpLogCheckBox.Checked)
            {

                Thread thread = new Thread((ThreadStart)(() =>
                {
                    SaveFileDialog sfd = saveFileDialog;

                    sfd.Filter = "Text File (*.txt)|*.txt|Log File (*.log)|*.log";
                    sfd.RestoreDirectory = true;

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        botOutputTextBox.Invoke(new MethodInvoker(delegate
                        {

                            File.WriteAllText(sfd.FileName, botOutputTextBox.Text);
                        }));
                    }
                }));
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }

            //Reset the UI
            botOutputTextBox.Invoke(new MethodInvoker(delegate { botOutputTextBox.Text = "Process not running!"; }));
            startProcessBtn.Invoke(new MethodInvoker(delegate { startProcessBtn.Enabled = true; }));
            dumpLogCheckBox.Invoke(new MethodInvoker(delegate { dumpLogCheckBox.Enabled = true; }));
            timestampCheckBox.Invoke(new MethodInvoker(delegate { timestampCheckBox.Enabled = true; }));
            stopProcessBtn.Invoke(new MethodInvoker(delegate { stopProcessBtn.Enabled = false; }));

            bot = null;
        }

        private void Bot_Exited(object? sender, EventArgs e)
        {
            ExitBot();
        }

        private void timestampCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            includeTimestampsInLog = timestampCheckBox.Checked;
        }

        private void deleteProcessBtn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (minimizeToTrayCheckBox.Checked)
                {
                    notifyIcon1.BalloonTipTitle = "Console App Logger";
                    notifyIcon1.BalloonTipText = "Console App Logger is still open! Access your system tray to re-open or close the software.";
                    notifyIcon1.ShowBalloonTip(100);

                    notifyIcon1.Visible = true;
                    this.Hide();
                    e.Cancel = true;
                }
                else
                {
                    SystemSounds.Exclamation.Play();
                    DialogResult dialog = MessageBox.Show("Close Console App Logger?\nAny running processes will be killed without logging!", "", MessageBoxButtons.YesNo);

                    if (dialog == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                    else if (dialog == DialogResult.Yes)
                    {
                        if (bot != null)
                        {
                            try
                            {
                                bot.Kill();
                            }
                            catch (Exception ex)
                            {
                                Debug.WriteLine(ex);
                            }
                        }
                        Application.Exit();
                    }
                }
            }
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play();
            DialogResult dialog = MessageBox.Show("Close Console App Logger?\nAny running processes will be killed without logging!", "", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                if (bot != null)
                {
                    bot.Kill();
                }
                Application.Exit();
            }

        }

        private void minimizeToTrayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            minimizeToTrayLabel.Visible = minimizeToTrayCheckBox.Checked;
        }

        private void copyLogToClipboardBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(botOutputTextBox.Text);
            notifyIcon1.BalloonTipTitle = "Console App Logger";
            notifyIcon1.BalloonTipText = "Copied current log to clipboard!";
            notifyIcon1.ShowBalloonTip(100);
        }

        private void saveLogToFileBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = saveFileDialog;

            sfd.Filter = "Text File (*.txt)|*.txt|Log File (*.log)|*.log";
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, botOutputTextBox.Text);
            }
        }

        private void stopProcessBtn_MouseClick(object sender, MouseEventArgs e)
        {
            bot.Kill();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutConsoleAppLoggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void botOutputTextBox_TextChanged(object sender, EventArgs e)
        {
            botOutputTextBox.ScrollToCaret();
        }

        private void commandLineTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                StreamWriter streamWriter = bot.StandardInput;

                streamWriter.WriteLine(commandLineTxtBox.Text);

                commandLineTxtBox.Text = "";
            }
        }
    }
}