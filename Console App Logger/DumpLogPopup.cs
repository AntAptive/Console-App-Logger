using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Console_App_Logger
{
    public partial class DumpLogPopup : Form
    {
        public bool dontAskAgain = false;

        public DumpLogPopup()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private Form getForm(string name)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == name)
                {
                    return form;
                }
            }
            return null;
        }

        private void dontShowAgain_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Note this will show again when the program is restarted.");
            this.Close();
            dontAskAgain = true;
            Form1 form1 = (Form1)getForm("Form1");
            form1.dumpLogDontAskAgain = true;
        }

        public void ShowPopup()
        {
            if (!dontAskAgain)
            {
                this.Show();
                SystemSounds.Exclamation.Play();
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
