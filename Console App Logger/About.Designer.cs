namespace Console_App_Logger
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.consoleAppLogger2;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(151, 12);
            label1.Name = "label1";
            label1.Size = new Size(277, 37);
            label1.TabIndex = 1;
            label1.Text = "Console App Logger";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 96);
            label2.Name = "label2";
            label2.Size = new Size(214, 180);
            label2.TabIndex = 2;
            label2.Text = "\r\n\r\nDeveloped by AntAptive\r\n\r\nConsole App Logger logo by AntAptive\r\n\r\nSpecial thanks to\r\nAntWaifu\r\nMr. Yeast\r\nJimi\r\nThe Stack Overflow community\r\nAnd you for downloading!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(229, 49);
            label3.Name = "label3";
            label3.Size = new Size(127, 25);
            label3.TabIndex = 3;
            label3.Text = "Version 1.0.3";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(162, 96);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(101, 15);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "© AntAptive 2023";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.Location = new Point(333, 316);
            button1.Name = "button1";
            button1.Size = new Size(88, 23);
            button1.TabIndex = 5;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // About
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 351);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "About";
            Text = "About";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel1;
        private Button button1;
    }
}