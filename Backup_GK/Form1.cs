using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Backup_GK
{
    public partial class Form1 : Form
    {
        string save_Path ;
        string hmi_path ;
        string hmi_ipAdress ;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Choose_Folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                save_Path = fbd.SelectedPath;
                save_Path = save_Path.Replace('\\', '/'); // korekcja poprawnego zapisu sciezki
                Path_Desplay.Text = save_Path;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
          
        }

        private void button_Backup_Click(object sender, EventArgs e)
        {
            // EXAMPLE hmi_path = "//HMI3500/aaa/bbb/ccc"
          if (Selected_HMI_1.Checked || Selected_HMI_2.Checked || Selected_HMI_3.Checked || Selected_HMI_4.Checked == true)
          {    
            if (!string.IsNullOrEmpty(save_Path)) // zabezpieczenie przed pusta sciezka zapisu
            {
                if (Directory.Exists(hmi_path))
                {
                    MakingBackupCopy bckupHMI = new MakingBackupCopy();
                    progressBar1.Value = 30;
                    bckupHMI.copyRecipies(hmi_path, save_Path);

                    progressBar1.Value = 100;
                    MessageBox.Show("Koniec kopiowania");
                    progressBar1.Value = 0;

                } else { MessageBox.Show("Nie można skopiować z tej ścieżki!" + '\n' + hmi_path); }
            } else { MessageBox.Show("Brak ścieżki zapisu!"); }
          } else { MessageBox.Show ("Wybierz jakiś panel!"); }
            
        }

        private void Text_info_2_Click(object sender, EventArgs e)
        {

        }

        private void Path_Desplay_TextChanged(object sender, EventArgs e)
        {
              
        }

        private void button_Ping_Click(object sender, EventArgs e)
        {
  

            if ((Selected_HMI_1.Checked  ||  Selected_HMI_2.Checked || Selected_HMI_3.Checked || Selected_HMI_4.Checked) == false )
            {
                MessageBox.Show("Proszę wybrać panel do pingowania");
            }
    
            if((Selected_HMI_1.Checked || Selected_HMI_2.Checked || Selected_HMI_3.Checked || Selected_HMI_4.Checked) == true)
            {
                this.UseWaitCursor = true;
                Application.DoEvents();                

                PingHMI pingSelectedHMI = new PingHMI();
                pingSelectedHMI.PingAdres(hmi_ipAdress);

                this.UseWaitCursor = false;
            }
         
        }

        private void Selected_HMI_1_CheckedChanged(object sender, EventArgs e)
        {
            if (Selected_HMI_1.Checked)
            {
                Selected_HMI_2.Checked = false; Selected_HMI_3.Checked = false; Selected_HMI_4.Checked = false;
                hmi_path = "C:\\Users\\AspireV\\Desktop\\Source_\\Receptury"; // sciezka do folderu kopiowanego
                hmi_ipAdress = "119.24.0.127";

                PanelInfoBox.Clear();
                PanelInfoBox.Text = (hmi_path + System.Environment.NewLine + hmi_ipAdress );
            }
            if (!Selected_HMI_1.Checked)
            {
                hmi_path = null;
                hmi_ipAdress = null;
                PanelInfoBox.Clear();
            }
        }

        private void Selected_HMI_2_CheckedChanged(object sender, EventArgs e)
        {
            if (Selected_HMI_2.Checked)
            {
                Selected_HMI_1.Checked = false; Selected_HMI_3.Checked = false; Selected_HMI_4.Checked = false;
                hmi_path = "Path HMI 2";
                hmi_ipAdress = "192.168.1.4";

                PanelInfoBox.Clear();
                PanelInfoBox.Text = (hmi_path + System.Environment.NewLine + hmi_ipAdress);
            }

            if (!Selected_HMI_2.Checked)
            {
                hmi_path = null;
                hmi_ipAdress = null;
                PanelInfoBox.Clear();
            }
        }

        private void Selected_HMI_3_CheckedChanged(object sender, EventArgs e)
        {
           if (Selected_HMI_3.Checked)
           {
                Selected_HMI_1.Checked = false; Selected_HMI_2.Checked = false; Selected_HMI_4.Checked = false;
                hmi_path = "Path HMI 3";
                hmi_ipAdress = "192.0.1.9";

                PanelInfoBox.Clear();
                PanelInfoBox.Text = (hmi_path + System.Environment.NewLine + hmi_ipAdress);
           }

            if (!Selected_HMI_3.Checked)
            {
                hmi_path = null;
                hmi_ipAdress = null;
                PanelInfoBox.Clear();
            }
        }

        private void Selected_HMI_4_CheckedChanged(object sender, EventArgs e)
        {
            if (Selected_HMI_4.Checked)
            {
                Selected_HMI_1.Checked = false; Selected_HMI_3.Checked = false; Selected_HMI_2.Checked = false;
                hmi_path = "Path HMI 4";
                hmi_ipAdress = "192.168.23.1";

                PanelInfoBox.Clear();
                PanelInfoBox.Text = (hmi_path + System.Environment.NewLine + hmi_ipAdress);
            }

            if (!Selected_HMI_4.Checked)
            {
                hmi_path = null;
                hmi_ipAdress = null;
                PanelInfoBox.Clear();
            }
        }

        private void PanelInfoBox_TextChanged(object sender, EventArgs e)
        {
        }

    }
}
