namespace Console_App_Logger
{
    partial class DumpLogPopup
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
            okButton = new Button();
            infoIcon = new PictureBox();
            dontShowAgain = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)infoIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // okButton
            // 
            okButton.Location = new Point(325, 100);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 0;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // infoIcon
            // 
            infoIcon.Image = Properties.Resources.Security_And_Maintenance_Alert_Windows_10_version_21H2;
            infoIcon.Location = new Point(22, 25);
            infoIcon.Name = "infoIcon";
            infoIcon.Size = new Size(45, 33);
            infoIcon.SizeMode = PictureBoxSizeMode.Zoom;
            infoIcon.TabIndex = 1;
            infoIcon.TabStop = false;
            // 
            // dontShowAgain
            // 
            dontShowAgain.Location = new Point(165, 100);
            dontShowAgain.Name = "dontShowAgain";
            dontShowAgain.Size = new Size(131, 23);
            dontShowAgain.TabIndex = 2;
            dontShowAgain.Text = "Don't show this again";
            dontShowAgain.UseVisualStyleBackColor = true;
            dontShowAgain.Click += dontShowAgain_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(73, 25);
            label1.Name = "label1";
            label1.Size = new Size(326, 39);
            label1.TabIndex = 3;
            label1.Text = "When you stop the process, you'll be asked to save the log to\r\na .txt file. The log will not save if this program is closed before\r\nthe process is stopped!";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonFace;
            pictureBox1.Location = new Point(-6, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(443, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // DumpLogPopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(419, 135);
            Controls.Add(label1);
            Controls.Add(dontShowAgain);
            Controls.Add(infoIcon);
            Controls.Add(okButton);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DumpLogPopup";
            ShowIcon = false;
            Text = "Console App Logger";
            ((System.ComponentModel.ISupportInitialize)infoIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button okButton;
        private PictureBox infoIcon;
        private Button dontShowAgain;
        private Label label1;
        private PictureBox pictureBox1;
    }
}