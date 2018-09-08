using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.NetworkInformation; // 
namespace Backup_GK
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    class MakingBackupCopy
    {
        public

        void copyRecipies(string Source_path, string Destination_path)
        {
            if (!Directory.Exists(Destination_path))
            {
                Directory.CreateDirectory(Destination_path);
            }

            DirectoryInfo dirInfo = new DirectoryInfo(Source_path);
            FileInfo[] files = dirInfo.GetFiles();
            foreach (FileInfo tempfile in files)
            {
                tempfile.CopyTo(Path.Combine(Destination_path, tempfile.Name));
            }

            DirectoryInfo[] directories = dirInfo.GetDirectories();
            foreach (DirectoryInfo tempdir in directories)
            {
                copyRecipies(Path.Combine(Source_path, tempdir.Name), Path.Combine(Destination_path, tempdir.Name));
            }

        }
    }

    class PingHMI
    {
        public

        bool PingAdres(string ipadress)
        {
            Ping pingSender = new Ping();
            PingReply reply = pingSender.Send(ipadress);

            if (reply.Status == IPStatus.Success)
            {
                MessageBox.Show("HMI ip:" + '\t' + ipadress +'\n'+ "Ping"+ "\t" + reply.RoundtripTime + " ms" );

                return (true);
            }
            else
            {
                MessageBox.Show(" "+ reply.Status + '\n'+"HMI "+ ipadress+ " jest nieosiągalny!");
               
                return (false);
            }

        }

    }

}